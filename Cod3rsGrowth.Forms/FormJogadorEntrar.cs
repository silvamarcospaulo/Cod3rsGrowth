using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.CartasJson;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Cod3rsGrowth.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading;

namespace Cod3rsGrowth.Forms
{
    public partial class FormJogadorEntrar : Form
    {
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private JwtServico tokenServico;
        private ConexaoDados conexaoDados;
        private LoginController loginController;
        private Jogador jogador;
        private Thread threadFormsJogador;
        private Thread threadFormsCadastro;
        private Thread threadFormsEsqueciSenha;

        public FormJogadorEntrar(CartaServico _cartaServico, BaralhoServico _baralhoServico,
            JogadorServico _jogadorServico, JwtServico _tokenServico, ConexaoDados _conexaoDados, LoginController _loginController)
        {
            cartaServico = _cartaServico;
            baralhoServico = _baralhoServico;
            jogadorServico = _jogadorServico;
            tokenServico = _tokenServico;
            conexaoDados = _conexaoDados;
            loginController = _loginController;
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                var jogadorAutenticar = new Jogador()
                {
                    UsuarioJogador = textBoxUsuario.Text,
                    SenhaHashJogador = textBoxSenha.Text
                };

                jogador = jogadorServico.AutenticaLogin(jogadorAutenticar);

                this.Close();
                threadFormsJogador = new Thread(AoClicarCarregarJogadorEmNovaJanela);
                threadFormsJogador.SetApartmentState(ApartmentState.STA);
                threadFormsJogador.Start();
            }
            catch (Exception ex)
            {

            }
        }

        private void AoClicarCarregarJogadorEmNovaJanela(object obj)
        {
            Application.Run(new FormListaBaralhosDoJogador(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController, jogador));
        }

        private void linkLabelCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            threadFormsCadastro = new Thread(AoClicarAbrirTelaDeCadastroEmNovaJanela);
            threadFormsCadastro.SetApartmentState(ApartmentState.STA);
            threadFormsCadastro.Start();
        }

        private void AoClicarAbrirTelaDeCadastroEmNovaJanela(object obj)
        {
            Application.Run(new FormJogadorCadastro(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController));
        }

        private void linkLabelEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            threadFormsEsqueciSenha = new Thread(AoClicarAbrirTelaDeEsqueciSenhaEmNovaJanela);
            threadFormsEsqueciSenha.SetApartmentState(ApartmentState.STA);
            threadFormsEsqueciSenha.Start();
        }

        private void AoClicarAbrirTelaDeEsqueciSenhaEmNovaJanela(object obj)
        {
            Application.Run(new FormEsqueciSenha(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController));
        }
    }
}