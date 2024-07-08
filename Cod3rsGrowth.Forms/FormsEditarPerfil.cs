using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Web.Controllers;

namespace Cod3rsGrowth.Forms
{
    public partial class FormsEditarPerfil : Form
    {
        private Jogador jogador;
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private JwtServico tokenServico;
        private ConexaoDados conexaoDados;
        private LoginController loginController;
        private Thread threadFormsJogador;

        public FormsEditarPerfil(CartaServico _cartaServico, BaralhoServico _baralhoServico, JogadorServico _jogadorServico,
            JwtServico _tokenServico, ConexaoDados _conexaoDados, LoginController _loginController, Jogador _jogador)
        {
            jogador = _jogador;
            cartaServico = _cartaServico;
            baralhoServico = _baralhoServico;
            jogadorServico = _jogadorServico;
            tokenServico = _tokenServico;
            conexaoDados = _conexaoDados;
            loginController = _loginController;
            InitializeComponent();
        }

        private void FormsEditarPerfil_Load(object sender, EventArgs e)
        {
            labelNomeJogador.Text = jogador.NomeJogador;
            labelSobrenomeJogador.Text = jogador.SobrenomeJogador;
            labelUsuarioJogador.Text = jogador.UsuarioJogador;
            labelDataDeNascimentoJogador.Text = jogador.DataNascimentoJogador.ToShortDateString();
        }

        private void linkLabelCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            threadFormsJogador = new Thread(AoClicarCarregarJogadorEntrarEmNovaJanela);
            threadFormsJogador.SetApartmentState(ApartmentState.STA);
            threadFormsJogador.Start();
        }

        private void buttonEnviarAlteracoes_Click(object sender, EventArgs e)
        {
            jogador.UsuarioJogador = textBoxNovoUsuario.Text;
            jogador.UsuarioConfirmacaoJogador = textBoxConfirmarNovoUsuario.Text;
            jogador.SenhaHashJogador = textBoxNovaSenha.Text;
            jogador.SenhaHashConfirmacaoJogador = textBoxConfirmarNovaSenha.Text;

            jogadorServico.Atualizar(jogador);

            this.Close();
            threadFormsJogador = new Thread(AoClicarCarregarJogadorEntrarEmNovaJanela);
            threadFormsJogador.SetApartmentState(ApartmentState.STA);
            threadFormsJogador.Start();
        }

        private void AoClicarCarregarJogadorEntrarEmNovaJanela(object obj)
        {
            Application.Run(new FormsJogadorEntrar(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController));
        }
    }
}
