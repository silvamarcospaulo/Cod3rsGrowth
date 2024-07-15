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
    public partial class FormListaBaralhosDoJogador : Form
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
        const int QUANTIDADE_MINIMA = 0;
        const int PRECO_PADRAO = 0;
        DateTime DATA_PADRAO = Convert.ToDateTime("01/01/2001");

        public FormListaBaralhosDoJogador(CartaServico _cartaServico, BaralhoServico _baralhoServico, JogadorServico _jogadorServico,
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

        public void CarregarFormListaBaralhosDoJogador(object sender, EventArgs e)
        {
            const int casasDecimais = 2;

            Text = $"MTG DeckBuilder - Home | {jogador.NomeJogador} {jogador.SobrenomeJogador}";

            labelDadosJogador.Text = $"Nome jogador: {jogador.NomeJogador} {jogador.SobrenomeJogador}" +
                $"   |   Usuário: {jogador.UsuarioJogador}" +
                $"   |   Quantidade de baralho: {jogador.QuantidadeDeBaralhosJogador}" +
                $"   |   Preco total das cartas: R${Math.Round(jogador.PrecoDasCartasJogador, casasDecimais)}";

            var listaDeBaralho = baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = jogador.Id });
            dataGridViewBaralhos.DataSource = listaDeBaralho;
        }

        private void AoClicarFinalizaASessao(object sender, EventArgs e)
        {
            this.Close();
            threadFormsEntrar = new Thread(CarregarFormJogadorEntrar);
            threadFormsEntrar.SetApartmentState(ApartmentState.STA);
            threadFormsEntrar.Start();
        }

        private void CarregarFormJogadorEntrar(object obj)
        {
            Application.Run(new FormJogadorEntrar(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController));
        }

        private void AoClicarAbrirTelaDeEdicaoDePerfil(object sender, EventArgs e)
        {
            this.Close();
            threadFormsEditarPerfil = new Thread(CarregarFormJogadorEditarPerfil);
            threadFormsEditarPerfil.SetApartmentState(ApartmentState.STA);
            threadFormsEditarPerfil.Start();
        }

        private void CarregarFormJogadorEditarPerfil(object obj)
        {
            Application.Run(new FormJogadorEditarPerfil(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController, jogador));
        }

        private void AoClicarAplicaSelecaoDeFiltros(object sender, EventArgs e)
        {
            dataGridViewBaralhos.DataSource = baralhoServico.ObterTodos(GerarFiltro(sender, e));
        }

        private BaralhoFiltro GerarFiltro(object sender, EventArgs e)
        {
            var filtro = new BaralhoFiltro()
            {
                IdJogador = jogador.Id
            };

            filtro = VerificarFiltroFormatoDeJogo(filtro);
            filtro = VerificarFiltroPrecoBaralhoMinimo(filtro);
            filtro = VerificarFiltroPrecoBaralhoMaximo(filtro);
            filtro = VerificarFiltroDataCriacaoMinimo(filtro);
            filtro = VerificarFiltroDataCriacaoMaximo(filtro);
            filtro = VerificarFiltroCorBaralho(filtro);
            filtro = VerificarFiltroNome(filtro);

            return filtro;
        }

        public BaralhoFiltro VerificarFiltroNome(BaralhoFiltro filtro)
        {
            const int tamanhoMinimo = 0;

            if (textBoxFiltrarNome.Text.Length > tamanhoMinimo) filtro.Nome = textBoxFiltrarNome.Text;

            return filtro;
        }

        private BaralhoFiltro VerificarFiltroFormatoDeJogo(BaralhoFiltro filtro)
        {
            var listaFormatoDeJogo = new List<FormatoDeJogoEnum>();

            if (checkBoxFormatoCommander.Checked) listaFormatoDeJogo.Add(FormatoDeJogoEnum.Commander);
            if (checkBoxFormatoPauper.Checked) listaFormatoDeJogo.Add(FormatoDeJogoEnum.Pauper);
            if (checkBoxFormatoStandard.Checked) listaFormatoDeJogo.Add(FormatoDeJogoEnum.Standard);

            if (listaFormatoDeJogo.Count > QUANTIDADE_MINIMA) filtro.FormatoDeJogoBaralho = listaFormatoDeJogo;

            return filtro;
        }

        private BaralhoFiltro VerificarFiltroPrecoBaralhoMinimo(BaralhoFiltro filtro)
        {

            if (numericUpDownMin.Value != PRECO_PADRAO) filtro.PrecoDoBaralhoMinimo = Convert.ToDecimal(numericUpDownMin.Text);

            return filtro;
        }

        private BaralhoFiltro VerificarFiltroPrecoBaralhoMaximo(BaralhoFiltro filtro)
        {
            if (numericUpDownMax.Value != PRECO_PADRAO) filtro.PrecoDoBaralhoMaximo = Convert.ToDecimal(numericUpDownMax.Text);

            return filtro;
        }

        private BaralhoFiltro VerificarFiltroDataCriacaoMinimo(BaralhoFiltro filtro)
        {
            if (dateTimePickerDataMinima.Value != DATA_PADRAO) filtro.DataCriacaoMinimo = new DateTime(day: dateTimePickerDataMinima.Value.Day, month: dateTimePickerDataMinima.Value.Month, year: dateTimePickerDataMinima.Value.Year);

            return filtro;
        }

        private BaralhoFiltro VerificarFiltroDataCriacaoMaximo(BaralhoFiltro filtro)
        {
            if (dateTimePickerDataMaxima.Value != DATA_PADRAO) filtro.DataCriacaoMaximo = new DateTime(day: dateTimePickerDataMaxima.Value.Day, month: dateTimePickerDataMaxima.Value.Month, year: dateTimePickerDataMaxima.Value.Year);

            return filtro;
        }

        private BaralhoFiltro VerificarFiltroCorBaralho(BaralhoFiltro filtro)
        {
            var corBaralho = new List<string>();

            if (checkBoxAzul.Checked) corBaralho.Add(checkBoxAzul.Text);
            if (checkBoxBranco.Checked) corBaralho.Add(checkBoxBranco.Text);
            if (checkBoxIncolor.Checked) corBaralho.Add(checkBoxIncolor.Text);
            if (checkBoxVerde.Checked) corBaralho.Add(checkBoxVerde.Text);
            if (checkBoxVermelho.Checked) corBaralho.Add(checkBoxVermelho.Text);
            if (checkBoxPreto.Checked) corBaralho.Add(checkBoxPreto.Text);

            if (corBaralho.Count > QUANTIDADE_MINIMA) filtro.CorBaralho = corBaralho;

            return filtro;
        }

        private void AoClicarLimpaSelecaoDeFiltros(object sender, EventArgs e)
        {
            LimparFiltro();
            dataGridViewBaralhos.DataSource = baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = jogador.Id });

        }

        private void LimparFiltro()
        {
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
            numericUpDownMin.Value = Convert.ToDecimal(PRECO_PADRAO);
            numericUpDownMax.Value = Convert.ToDecimal(PRECO_PADRAO);
            dateTimePickerDataMinima.Value = dataPadrao;
            dateTimePickerDataMaxima.Value = dataPadrao;
            textBoxFiltrarNome.Text = "";
        }
    }
}