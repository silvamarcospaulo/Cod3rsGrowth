using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Cod3rsGrowth.Web.Controllers;

namespace Cod3rsGrowth.Forms
{
    public partial class FormJogadorCadastro : Form
    {
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private JwtServico tokenServico;
        private ConexaoDados conexaoDados;
        private LoginController loginController;
        private Jogador jogador;
        private Thread threadFormsJogador;

        public FormJogadorCadastro(CartaServico _cartaServico, BaralhoServico _baralhoServico, JogadorServico _jogadorServico,
            JwtServico _tokenServico, ConexaoDados _conexaoDados, LoginController _loginController)
        {
            cartaServico = _cartaServico;
            baralhoServico = _baralhoServico;
            jogadorServico = _jogadorServico;
            tokenServico = _tokenServico;
            conexaoDados = _conexaoDados;
            loginController = _loginController;
            InitializeComponent();
        }

        private void AoClicarCadastrarNovoUsuario(object sender, EventArgs e)
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

            try
            {
                var idJogador = jogadorServico.Criar(jogadorAutenticar);
                jogador = jogadorServico.ObterPorId(idJogador);

                this.Close();
                threadFormsJogador = new Thread(AoClicarCarregarJogadorEmNovaJanela);
                threadFormsJogador.SetApartmentState(ApartmentState.STA);
                threadFormsJogador.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarCarregarJogadorEmNovaJanela(Object obj)
        {
            Application.Run(new FormListaBaralhosDoJogador(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController, jogador));
        }

        private void AoClicarVoltarParaTelaDeLogin(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            threadFormsJogador = new Thread(AoClicarCarregarJogadorEntrarEmNovaJanela);
            threadFormsJogador.SetApartmentState(ApartmentState.STA);
            threadFormsJogador.Start();
        }

        private void AoClicarCarregarJogadorEntrarEmNovaJanela(Object obj)
        {
            Application.Run(new FormJogadorEntrar(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController));
        }
    }
}
