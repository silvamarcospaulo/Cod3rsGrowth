using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Migrador;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Cod3rsGrowth.Web.Controllers;
using System.Threading;

namespace Cod3rsGrowth.Forms
{
    public partial class FormsJogador : Form
    {
        private Jogador jogador;
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private JwtServico tokenServico;
        private ConexaoDados conexaoDados;
        private LoginController loginController;
        private Thread threadFormsEntrar;
        private Thread threadFormsEditarPerfil;
        private Thread threadFormsNovoBaralho;

        public FormsJogador(CartaServico _cartaServico, BaralhoServico _baralhoServico, JogadorServico _jogadorServico,
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

        public void FormJogador_Load(object sender, EventArgs e)
        {
            labelNomeJogador.Text = jogador.NomeJogador + " " + jogador.SobrenomeJogador;
            labelUsuarioJogador.Text = jogador.UsuarioJogador;
            labelQuantidadeDeBaralhosJogador.Text = jogador.QuantidadeDeBaralhosJogador.ToString();
            labelPrecoCartasTotalJogador.Text = jogador.PrecoDasCartasJogador.ToString();
            var listaDeBaralho = baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = jogador.Id });
            dataGridViewBaralhoDoJogador.DataSource = listaDeBaralho;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
            threadFormsEntrar = new Thread(AoClicarCarregarJogadorEntrarEmNovaJanela);
            threadFormsEntrar.SetApartmentState(ApartmentState.STA);
            threadFormsEntrar.Start();
        }

        private void AoClicarCarregarJogadorEntrarEmNovaJanela(object obj)
        {
            Application.Run(new FormsJogadorEntrar(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController));
        }

        private void buttonEditarPerfil_Click(object sender, EventArgs e)
        {

        }
    }
}