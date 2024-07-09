using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Cod3rsGrowth.Web.Controllers;
using Microsoft.Extensions.Options;

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
            labelDadosJogador.Text = "Nome jogador: " + jogador.NomeJogador + " " + jogador.SobrenomeJogador + "   |   Usuário: " + jogador.UsuarioJogador +
            "   |   Quantidade de baralho: " + jogador.QuantidadeDeBaralhosJogador.ToString() + "   |   Preco total das cartas: " + jogador.PrecoDasCartasJogador.ToString();
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

        private void AoClicarAbrirTelaDeEdicaoDePerfil(object sender, EventArgs e)
        {
            this.Close();
            threadFormsEditarPerfil = new Thread(IniciarFormsEditarPerfil);
            threadFormsEditarPerfil.SetApartmentState(ApartmentState.STA);
            threadFormsEditarPerfil.Start();
        }

        private void IniciarFormsEditarPerfil(object obj)
        {
            Application.Run(new FormsEditarPerfil(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController, jogador));
        }

        private void AoClicarAplicarSelecaoDeFiltros(object sender, EventArgs e)
        {
            const string corAzul = "Azul";
            const string corBranco = "Branco";
            const string corIncolor = "Incolor";
            const string corVerde = "Verde";
            const string corVermelho = "Vermelho";
            const string corPreto = "Preto";
            const int precoPadrao = 0;
            var dataPadrao = Convert.ToDateTime("01/01/2001");

            var filtro = new BaralhoFiltro();
            var corBaralho = new List<string>();
            var listaFormatoDeJogo = new List<FormatoDeJogoEnum>();

            if (checkBoxFormatoCommander.Checked is true) listaFormatoDeJogo.Add(FormatoDeJogoEnum.Commander);
            if (checkBoxFormatoPauper.Checked is true) listaFormatoDeJogo.Add(FormatoDeJogoEnum.Pauper);
            if (checkBoxFormatoStandard.Checked is true) listaFormatoDeJogo.Add(FormatoDeJogoEnum.Standard);

            if (listaFormatoDeJogo.Count > precoPadrao) filtro.FormatoDeJogoBaralho = listaFormatoDeJogo;

            if (checkBoxAzul.Checked is true) corBaralho.Add(corAzul);
            if (checkBoxBranco.Checked is true) corBaralho.Add(corBranco);
            if (checkBoxIncolor.Checked is true) corBaralho.Add(corIncolor);
            if (checkBoxVerde.Checked is true) corBaralho.Add(corVerde);
            if (checkBoxVermelho.Checked is true) corBaralho.Add(corVermelho);
            if (checkBoxPreto.Checked is true) corBaralho.Add(corPreto);

            if (corBaralho.Count > precoPadrao) filtro.CorBaralho = corBaralho;

            if (numericUpDownMin.Value != precoPadrao) filtro.PrecoDoBaralhoMinimo = Convert.ToDecimal(numericUpDownMin.Text);
            if (numericUpDownMax.Value != precoPadrao) filtro.PrecoDoBaralhoMaximo = Convert.ToDecimal(numericUpDownMax.Text);

            var datinha = dateTimePickerDataMinima.Value;

            if (dateTimePickerDataMinima.Value != dataPadrao) filtro.DataCriacaoMinimo = new DateTime(
                day: dateTimePickerDataMinima.Value.Day, month: dateTimePickerDataMinima.Value.Month, year: dateTimePickerDataMinima.Value.Year);

            if (dateTimePickerDataMaxima.Value != dataPadrao) filtro.DataCriacaoMaximo = new DateTime(
                day: dateTimePickerDataMaxima.Value.Day, month: dateTimePickerDataMaxima.Value.Month, year: dateTimePickerDataMaxima.Value.Year);

            if (textBoxFiltrarNome.Text.Length > 0) filtro.Nome = textBoxFiltrarNome.Text;

            filtro.IdJogador = jogador.Id;

            dataGridViewBaralhos.DataSource = baralhoServico.ObterTodos(filtro);
        }

        private void AoClicarLimparSelecaoDeFiltros(object sender, EventArgs e)
        {
            const int precoPadrao = 0;

            var dataPadrao = Convert.ToDateTime("01/01/2001");
            checkBoxAzul.Checked = false;
            checkBoxBranco.Checked = false;
            checkBoxIncolor.Checked = false;
            checkBoxVerde.Checked = false;
            checkBoxVermelho.Checked = false;
            checkBoxPreto.Checked = false;
            checkBoxFormatoCommander.Checked = false;
            checkBoxFormatoStandard.Checked = false;
            checkBoxFormatoPauper.Checked = false;
            numericUpDownMin.Value = Convert.ToDecimal(precoPadrao);
            numericUpDownMax.Value = Convert.ToDecimal(precoPadrao);
            dateTimePickerDataMinima.Value = dataPadrao;
            dateTimePickerDataMaxima.Value = dataPadrao;
            textBoxFiltrarNome.Text = "";
            
            dataGridViewBaralhos.DataSource = baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = jogador.Id });
        }

        private void AoClicarAbrirJanelaDeCriacaoDeBaralho(object sender, EventArgs e)
        {

        }
    }
}