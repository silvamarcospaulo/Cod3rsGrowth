using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Cod3rsGrowth.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Cod3rsGrowth.Forms
{
    public partial class FormsJogadorCadastro : Form
    {
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private JwtServico tokenServico;
        private ConexaoDados conexaoDados;
        private LoginController loginController;

        public FormsJogadorCadastro(CartaServico _cartaServico, BaralhoServico _baralhoServico,
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

        private void FormsJogadorCadastro_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var data = Convert.ToDateTime(dateTimePickerDataDeNascimento.Text);

                var jogadorAutenticar = new Jogador()
                {
                    NomeJogador = textBoxNome.Text,
                    SobrenomeJogador = textBoxSobrenome.Text,
                    UsuarioJogador = textBoxUsuario.Text,
                    SenhaHashJogador = textBoxSenha.Text,
                    SenhaHashConfirmacaoJogador = textBoxConfirmarSenha.Text,
                    DataNascimentoJogador = new DateTime(day: data.Day, month: data.Month, year: data.Year),
                    DataDeCriacaoContaJogador = DateTime.Now
                };

                var idJogador = jogadorServico.Criar(jogadorAutenticar);
                var jogador = jogadorServico.ObterPorId(idJogador);
                AoClicarCarregarJogadorEmNovaJanela(jogador);
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

        private void linkLabelJaPossuoConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormsJogadorEntrar(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController).Show();
        }

        private void labelDataDeNascimento_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDataDeNascimento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
