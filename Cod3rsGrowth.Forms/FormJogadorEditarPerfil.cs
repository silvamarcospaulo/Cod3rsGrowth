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
using Microsoft.Extensions.Options;

namespace Cod3rsGrowth.Forms
{
    public partial class FormJogadorEditarPerfil : Form
    {
        private Jogador jogador;
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private JwtServico tokenServico;
        private ConexaoDados conexaoDados;
        private LoginController loginController;
        private Thread threadFormsJogador;

        public FormJogadorEditarPerfil(CartaServico _cartaServico, BaralhoServico _baralhoServico, JogadorServico _jogadorServico,
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

        private void CarregarJogadorEditarPerfil(object sender, EventArgs e)
        {
            labelNomeJogador.Text = jogador.NomeJogador;
            labelSobrenomeJogador.Text = jogador.SobrenomeJogador;
            labelUsuarioJogador.Text = jogador.UsuarioJogador;
            labelDataDeNascimentoJogador.Text = jogador.DataNascimentoJogador.ToShortDateString();
        }

        private void AoClicarCancelaEdicaoDePerfil(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            threadFormsJogador = new Thread(CarregarJanelaJogador);
            threadFormsJogador.SetApartmentState(ApartmentState.STA);
            threadFormsJogador.Start();
        }

        private void AoClicarEnviaAlteracoesDePerfil(object sender, EventArgs e)
        {
            var valorNulo = 0;

            if (textBoxNovoUsuario.Text.Length > valorNulo) jogador.UsuarioJogador = textBoxNovoUsuario.Text;
            if (textBoxConfirmarNovoUsuario.Text.Length > valorNulo) jogador.UsuarioConfirmacaoJogador = textBoxConfirmarNovoUsuario.Text;
            if (textBoxNovaSenha.Text.Length > valorNulo) jogador.SenhaHashJogador = textBoxNovaSenha.Text;
            if (textBoxConfirmarNovaSenha.Text.Length > valorNulo) jogador.SenhaHashConfirmacaoJogador = textBoxConfirmarNovaSenha.Text;

            jogadorServico.Atualizar(jogador);

            this.Close();
            threadFormsJogador = new Thread(CarregarJanelaJogador);
            threadFormsJogador.SetApartmentState(ApartmentState.STA);
            threadFormsJogador.Start();
        }

        private void CarregarJanelaJogador(object obj)
        {
            Application.Run(new FormListaBaralhosDoJogador(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController, jogador));
        }
    }
}
