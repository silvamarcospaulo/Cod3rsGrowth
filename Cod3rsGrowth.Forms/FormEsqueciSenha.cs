using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Cod3rsGrowth.Web.Controllers;
using FluentValidation;

namespace Cod3rsGrowth.Forms
{
    public partial class FormEsqueciSenha : Form
    {
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private JwtServico tokenServico;
        private ConexaoDados conexaoDados;
        private LoginController loginController;
        private Thread threadFormsEntrar;

        public FormEsqueciSenha(CartaServico _cartaServico, BaralhoServico _baralhoServico,
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

        private void AoClicarRestauraSenhaDoJogador(object sender, EventArgs e)
        {
            var data = Convert.ToDateTime(dateTimePickerDataDeNascimento.Text);
            var jogadorRestaurarSenha = new Jogador()
            {
                NomeJogador = textBoxNome.Text,
                SobrenomeJogador = textBoxSobrenome.Text,
                UsuarioJogador = textBoxUsuario.Text,
                SenhaHashJogador = textBoxNovasenha.Text,
                SenhaHashConfirmacaoJogador = textBoxConfirmarNovaSenha.Text,
                DataNascimentoJogador = new DateTime(day: data.Day, month: data.Month, year: data.Year)
            };

            try
            {
                jogadorServico.AlterarSenha(jogadorRestaurarSenha);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
            threadFormsEntrar = new Thread(CarregarJanelaJogadorEntrar);
            threadFormsEntrar.SetApartmentState(ApartmentState.STA);
            threadFormsEntrar.Start();
        }

        private void AoClicarCancelaRestauracaoDeSenha(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            threadFormsEntrar = new Thread(CarregarJanelaJogadorEntrar);
            threadFormsEntrar.SetApartmentState(ApartmentState.STA);
            threadFormsEntrar.Start();
        }

        private void CarregarJanelaJogadorEntrar(object obj)
        {
            Application.Run(new FormJogadorEntrar(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController));
        }
    }
}