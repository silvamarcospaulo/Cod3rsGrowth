using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using System.ComponentModel;

namespace Cod3rsGrowth.Forms
{
    public partial class FormListaBaralhosDoJogador : Form
    {
        private Jogador _jogador;
        private CartaServico _cartaServico;
        private BaralhoServico _baralhoServico;
        private JogadorServico _jogadorServico;
        private Thread threadFormEntrar;
        private Thread threadFormEditarPerfil;
        private Thread threadFormNovoBaralho;
        private Thread threadFromsListaBaralhosDoJogador;
        private const int QUANTIDADE_MINIMA = 0;
        private const int PRECO_PADRAO = 0;
        private DateTime DATA_PADRAO = Convert.ToDateTime("01/01/2001");
        private DialogResult resposta;
        private Baralho baralhoSelecionado;


        public FormListaBaralhosDoJogador(CartaServico cartaServico, BaralhoServico baralhoServico, JogadorServico jogadorServico, Jogador jogador)
        {
            _cartaServico = cartaServico;
            _baralhoServico = baralhoServico;
            _jogadorServico = jogadorServico;
            _jogador = jogador;

            InitializeComponent();
        }

        public void CarregarFormListaBaralhosDoJogador(object sender, EventArgs e)
        {
            CarregarLabelJogador();
            var listaDeBaralho = new BindingList<Baralho>(_baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = _jogador.Id }));
            dataGridViewBaralhos.DataSource = listaDeBaralho;
        }

        private void CarregarLabelJogador()
        {
            const int casasDecimais = 2;

            Text = $"MTG DeckBuilder - Home | {_jogador.NomeJogador} {_jogador.SobrenomeJogador}";

            labelDadosJogador.Text = $"Nome _jogador: {_jogador.NomeJogador} {_jogador.SobrenomeJogador}" +
                $"   |   Usuário: {_jogador.UsuarioJogador}" +
                $"   |   Quantidade de baralho: {_jogador.QuantidadeDeBaralhosJogador}" +
                $"   |   Preco total das cartas: R${Math.Round(_jogador.PrecoDasCartasJogador, casasDecimais)}";
        }

        private void AoClicarFinalizaASessao(object sender, EventArgs e)
        {
            this.Close();
            threadFormEntrar = new Thread(CarregarFormJogadorEntrarEmNovaJanela);
            threadFormEntrar.SetApartmentState(ApartmentState.STA);
            threadFormEntrar.Start();
        }

        private void CarregarFormJogadorEntrarEmNovaJanela(object obj)
        {
            Application.Run(new FormJogadorEntrar(_cartaServico, _baralhoServico, _jogadorServico));
        }

        private void AoClicarAbrirTelaDeEdicaoDePerfil(object sender, EventArgs e)
        {
            this.Close();
            threadFormEditarPerfil = new Thread(CarregarFormJogadorEditarPerfilEmNovaJanela);
            threadFormEditarPerfil.SetApartmentState(ApartmentState.STA);
            threadFormEditarPerfil.Start();
        }

        private void CarregarFormJogadorEditarPerfilEmNovaJanela(object obj)
        {
            Application.Run(new FormJogadorEditarPerfil(_cartaServico, _baralhoServico, _jogadorServico, _jogador));
        }

        private void AoClicarAplicaSelecaoDeFiltros(object sender, EventArgs e)
        {
            dataGridViewBaralhos.DataSource = _baralhoServico.ObterTodos(GerarFiltro(sender, e));
        }

        private BaralhoFiltro GerarFiltro(object sender, EventArgs e)
        {
            var filtro = new BaralhoFiltro()
            {
                IdJogador = _jogador.Id
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
            dataGridViewBaralhos.DataSource = _baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = _jogador.Id });

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

        private void AoClicarAbreTelaDeCriacaoDeBaralho(object sender, EventArgs e)
        {
            this.Close();
            threadFormNovoBaralho = new Thread(CarregarFormNovoBaralhoEmNovaJanela);
            threadFormNovoBaralho.SetApartmentState(ApartmentState.STA);
            threadFormNovoBaralho.Start();
        }

        private void CarregarFormNovoBaralhoEmNovaJanela(object obj)
        {
            Application.Run(new FormNovoBaralho(_cartaServico, _baralhoServico, _jogadorServico, _jogador, null));
        }

        private void AoClicarCarregaDadosDoBaralho(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selecao = dataGridViewBaralhos.Rows[e.RowIndex];
                var baralhoGrid = (Baralho)selecao.DataBoundItem;
                baralhoSelecionado = baralhoGrid;

                AoClicarApagaBaralho(sender, e);
            }
        }

        private void AoClicarApagaBaralho(object sender, EventArgs e)
        {
            try
            {
                resposta = MessageBox.Show("Apagar baralho?", "Confirmação", MessageBoxButtons.YesNo);

                if (resposta == DialogResult.Yes)
                {
                    _baralhoServico.Excluir(baralhoSelecionado.Id);
                    MessageBox.Show("Baralho excluído!");

                    CarregarFormListaBaralhosDoJogador(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível apagar o baralho selecionado no momento, tente novamente mais tarde!\n{ex.Message}", "Erro ao apagar baralho");
            }
        }
    }
}