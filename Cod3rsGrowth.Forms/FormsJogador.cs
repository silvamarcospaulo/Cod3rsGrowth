using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Cod3rsGrowth.Web.Controllers;

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
            dataGridViewBaralhos.DataSource = listaDeBaralho;
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
            this.Close();
            threadFormsEditarPerfil = new Thread(AoClicarCarregarEditarPerfilEmNovaJanela);
            threadFormsEditarPerfil.SetApartmentState(ApartmentState.STA);
            threadFormsEditarPerfil.Start();
        }

        private void AoClicarCarregarEditarPerfilEmNovaJanela(object obj)
        {
            Application.Run(new FormsEditarPerfil(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController, jogador));
        }

        private void buttonAplicarFiltro_Click(object sender, EventArgs e)
        {
            const string corAzul = "U";
            const string corBranco = "W";
            const string corIncolor = "C";
            const string corVerde = "G";
            const string corVermelho = "R";
            const string corPreto = "B";
            const int tamanhoInvalidoMin = 0;
            const int tamanhoInvalidoMax = 99999999;

            var filtro = new BaralhoFiltro();
            var corBaralho = new List<string>();
            var listaFormatoDeJogo = new List<FormatoDeJogoEnum>();

            if (checkBoxFormatoCommander.Checked is true) listaFormatoDeJogo.Add(FormatoDeJogoEnum.Commander);
            if (checkBoxFormatoPauper.Checked is true) listaFormatoDeJogo.Add(FormatoDeJogoEnum.Pauper);
            if (checkBoxFormatoStandard.Checked is true) listaFormatoDeJogo.Add(FormatoDeJogoEnum.Standard);

            if (listaFormatoDeJogo.Count > tamanhoInvalidoMin) filtro.FormatoDeJogoBaralho = listaFormatoDeJogo;

            if (checkBoxAzul.Checked is true) corBaralho.Add(corAzul);
            if (checkBoxBranco.Checked is true) corBaralho.Add(corBranco);
            if (checkBoxIncolor.Checked is true) corBaralho.Add(corIncolor);
            if (checkBoxVerde.Checked is true) corBaralho.Add(corVerde);
            if (checkBoxVermelho.Checked is true) corBaralho.Add(corVermelho);
            if (checkBoxPreto.Checked is true) corBaralho.Add(corPreto);

            if (corBaralho.Count > tamanhoInvalidoMin) filtro.CorBaralho = corBaralho;

            if (numericUpDownMin.Value > tamanhoInvalidoMin) filtro.PrecoDoBaralhoMinimo = Convert.ToDecimal(numericUpDownMin.Text);
            if (numericUpDownMax.Value < tamanhoInvalidoMax) filtro.PrecoDoBaralhoMaximo = Convert.ToDecimal(numericUpDownMax.Text);

            filtro.IdJogador = jogador.Id;

            dataGridViewBaralhos.DataSource = baralhoServico.ObterTodos(filtro);
        }

        private void buttonLimparFiltro_Click(object sender, EventArgs e)
        {
            const int tamanhoInvalidoMin = 0;
            const int tamanhoInvalidoMax = 99999999;

            dataGridViewBaralhos.DataSource = baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = jogador.Id });
            checkBoxAzul.Checked = false;
            checkBoxBranco.Checked = false;
            checkBoxIncolor.Checked = false;
            checkBoxVerde.Checked = false;
            checkBoxVermelho.Checked = false;
            checkBoxPreto.Checked = false;

            checkBoxFormatoCommander.Checked = false;
            checkBoxFormatoStandard.Checked = false;
            checkBoxFormatoPauper.Checked = false;

            numericUpDownMin.Value = Convert.ToDecimal(tamanhoInvalidoMin);
            numericUpDownMax.Value = Convert.ToDecimal(tamanhoInvalidoMax);
        }

        private void buttonNovoBaralho_Click(object sender, EventArgs e)
        {

        }
    }
}