using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.CartasJson;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Cod3rsGrowth.Forms
{
    public partial class FormsJogadorEntrar : Form
    {
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private ConexaoDados conexaoDados;
        private LoginController loginController;

        public FormsJogadorEntrar(CartaServico _cartaServico, BaralhoServico _baralhoServico,
            JogadorServico _jogadorServico, ConexaoDados _conexaoDados, LoginController _loginController)
        {
            cartaServico = _cartaServico;
            baralhoServico = _baralhoServico;
            jogadorServico = _jogadorServico;
            conexaoDados = _conexaoDados;
            loginController = _loginController;
            InitializeComponent();
        }

        private void FormsJogadorCadastroLogin_Load(object sender, EventArgs e)
        {
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                var jogadorAutenticar = new Jogador() { NomeJogador = textBoxNome.Text, SenhaHashJogador = textBoxSenha.Text };
                var jogadorAutenticado = loginController.Autenticacao(jogadorAutenticar) as OkObjectResult;
                Jogador jogadorEntrar = (Jogador)jogadorAutenticado.Value;
                AoClicarCarregarJogadorEmNovaJanela(jogadorServico.ObterPorId(jogadorEntrar.Id));
            }
            catch (Exception ex)
            {

            }
        }

        private void AoClicarCarregarJogadorEmNovaJanela(Jogador jogador)
        {
            this.Hide();
            new FormsJogador(cartaServico, baralhoServico, jogadorServico, conexaoDados, jogador).Show();
        }

        private void linkLabelCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormsJogadorCadastro(cartaServico, baralhoServico, jogadorServico, conexaoDados, loginController).Show();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}