using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using System.Windows.Forms;

namespace Cod3rsGrowth.Forms
{
    public partial class FormNovoBaralho : Form
    {
        private CartaServico _cartaServico;
        private BaralhoServico _baralhoServico;
        private JogadorServico _jogadorServico;
        private Jogador _jogador;
        private Baralho _baralhoParcial;
        private Carta _cartaSelecionada;
        private Thread threadFormListaBaralhoJogador;
        private Thread threadListaDeCartaDoBaralho;
        private int PRECO_PADRAO = 0;
        private int QUANTIDADE_MINIMA = 0;
        private string STRING_VAZIA = string.Empty;

        public FormNovoBaralho(CartaServico cartaServico, BaralhoServico baralhoServico, JogadorServico jogadorServico, Jogador jogador, Baralho? baralhoParcial)
        {
            _jogador = jogador;
            _cartaServico = cartaServico;
            _baralhoServico = baralhoServico;
            _jogadorServico = jogadorServico;
            _baralhoParcial = baralhoParcial;
            InitializeComponent();
        }

        private void CarregarFormNovoBaralho(object sender, EventArgs e)
        {
            CarregarItensDoComboBoxFormatoDoBaralho();
            VerficarSeBaralhoExiste();
            dataGridViewCartas.DataSource = _cartaServico.ObterTodos(null);
            _baralhoParcial.IdJogador = _jogador.Id;
        }

        private void AtualizarDadosBaralhoNaTela()
        {
            const int casasDecimais = 2;

            if (_baralhoParcial is null)
            {
                labelQuantidadeParcial.Text = STRING_VAZIA;
                labelCustoParcial.Text = STRING_VAZIA;
                labelPrecoParcial.Text = STRING_VAZIA;
                labelCorParcial.Text = STRING_VAZIA;
            }
            else
            {
                labelQuantidadeParcial.Text = _baralhoParcial.QuantidadeDeCartasNoBaralho.ToString();
                labelCustoParcial.Text = _baralhoParcial.CustoDeManaConvertidoDoBaralho.ToString();
                labelPrecoParcial.Text = $"R${Math.Round(_baralhoParcial.PrecoDoBaralho, casasDecimais)}";
                labelCorParcial.Text = _baralhoParcial.CorBaralho;
            }
            numericUpDownQuantidadeDeCopiasDeCarta.Value = Convert.ToDecimal(QUANTIDADE_MINIMA);
        }

        private void VerficarSeBaralhoExiste()
        {
            if (_baralhoParcial is null)
            {
                _baralhoParcial = _baralhoParcial = new Baralho();
                _baralhoParcial.CartasDoBaralho = new List<CopiaDeCartasNoBaralho>();
            }
            else
            {
                AtualizarDadosBaralho();
                AtualizarDadosBaralhoNaTela();
                textBoxNomeBaralho.Text = _baralhoParcial.NomeBaralho;
            }
        }

        private void AoClicarLimpaSelecaoDeFiltros(object sender, EventArgs e)
        {
            LimparFiltro();
            dataGridViewCartas.DataSource = _cartaServico.ObterTodos(null);

        }

        private void AoClicarAplicaSelecaoDeFiltros(object sender, EventArgs e)
        {
            dataGridViewCartas.DataSource = _cartaServico.ObterTodos(GerarFiltro(sender, e));
        }

        private void AoClicarCancelaCriacaoDeNovoBaralho(object sender, EventArgs e)
        {
            const string mensagem = "Tem certeza que deseja cancelar a criação de baralho?\nSeu progresso será perdido!";
            const string tituloMessageBox = "Cancelar criação de baralho";
            var resultado = MessageBox.Show(mensagem, tituloMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                threadFormListaBaralhoJogador = new Thread(CarregarFormListaBaralhoJogadorEmNovaJanelaEmNovaJanela);
                threadFormListaBaralhoJogador.SetApartmentState(ApartmentState.STA);
                threadFormListaBaralhoJogador.Start();
            }
        }

        private void AoClicarSelecionaCarta(object sender, DataGridViewCellEventArgs e)
        {
            var carta = dataGridViewCartas.Rows[e.RowIndex];
            _cartaSelecionada = (Carta)carta.DataBoundItem;
            labelNomeCartaSelecionada.Text = _cartaSelecionada?.NomeCarta ?? "";
        }

        private void AoClicarAdicionaCartaAoBaralho(object sender, EventArgs e)
        {
            if (numericUpDownQuantidadeDeCopiasDeCarta.Value > QUANTIDADE_MINIMA && _cartaSelecionada is not null)
            {
                var quantidade = Convert.ToInt32(numericUpDownQuantidadeDeCopiasDeCarta.Value);
                var copiaExistente = _baralhoParcial?.CartasDoBaralho?.FirstOrDefault(copia => copia?.Carta?.Id == _cartaSelecionada?.Id);

                if (copiaExistente is not null)
                {
                    copiaExistente.QuantidadeCopiasDaCartaNoBaralho = quantidade;
                }
                else
                {
                    _baralhoParcial?.CartasDoBaralho?.Add(new CopiaDeCartasNoBaralho()
                    {
                        NomeCarta = _cartaSelecionada?.NomeCarta,
                        Carta = _cartaSelecionada,
                        IdCarta = _cartaSelecionada.Id,
                        QuantidadeCopiasDaCartaNoBaralho = quantidade
                    });
                }
                AtualizarDadosBaralho();
                AtualizarDadosBaralhoNaTela();
            }
        }

        private void AoClicarVisualizaListaDeCartasDoBaralho(object sender, EventArgs e)
        {
            if (_baralhoParcial.CartasDoBaralho.Any<CopiaDeCartasNoBaralho>())
            {
                _baralhoParcial.IdJogador = _jogador.Id;
                _baralhoParcial.NomeBaralho = textBoxNomeBaralho.Text;
                _baralhoParcial.FormatoDeJogoBaralho = (FormatoDeJogoEnum)comboBoxFormato.SelectedValue;

                this.Close();
                threadListaDeCartaDoBaralho = new Thread(CarregarFormListaDeCartaDoBaralhoEmNovaJanelaEmNovaJanela);
                threadListaDeCartaDoBaralho.SetApartmentState(ApartmentState.STA);
                threadListaDeCartaDoBaralho.Start();
            }
            else
            {
                var resultado = MessageBox.Show("A lista de baralho não possui nenguma carta", "Erro ao visualizar lista de carta do baralho");
            }
        }

        private void CarregarFormListaDeCartaDoBaralhoEmNovaJanelaEmNovaJanela(object obj)
        {
            Application.Run(new FormNovoBaralhoListaDeCarta(_cartaServico, _baralhoServico, _jogadorServico, _jogador, _baralhoParcial));
        }

        private void AoClicarComumDesselecionaOutrasCheckBoxRaridade(object sender, EventArgs e)
        {
            checkBoxRaridadeIncomum.Checked = false;
            checkBoxRaridadeRaro.Checked = false;
            checkBoxRaridadeMitico.Checked = false;
        }

        private void AoClicarIncomumDesselecionaOutrasCheckBoxRaridade(object sender, EventArgs e)
        {
            checkBoxRaridadeComum.Checked = false;
            checkBoxRaridadeRaro.Checked = false;
            checkBoxRaridadeMitico.Checked = false;
        }

        private void AoClicarRaroDesselecionaOutrasCheckBoxRaridade(object sender, EventArgs e)
        {
            checkBoxRaridadeIncomum.Checked = false;
            checkBoxRaridadeComum.Checked = false;
            checkBoxRaridadeMitico.Checked = false;
        }

        private void AoClicarMiticoDesselecionaOutrasCheckBoxRaridade(object sender, EventArgs e)
        {
            checkBoxRaridadeIncomum.Checked = false;
            checkBoxRaridadeRaro.Checked = false;
            checkBoxRaridadeComum.Checked = false;
        }

        private void AtualizarDadosBaralho()
        {
            _baralhoParcial.QuantidadeDeCartasNoBaralho = BaralhoServico.SomarQuantidadeDeCartasDoBaralho(_baralhoParcial.CartasDoBaralho);
            _baralhoParcial.CustoDeManaConvertidoDoBaralho = BaralhoServico.SomarCustoDeManaConvertidoDoBaralho(_baralhoParcial.CartasDoBaralho);
            _baralhoParcial.PrecoDoBaralho = BaralhoServico.SomarPrecoDoBaralho(_baralhoParcial.CartasDoBaralho);
            _baralhoParcial.CorBaralho = BaralhoServico.ConferirCoresDoBaralho(_baralhoParcial.CartasDoBaralho);
            numericUpDownQuantidadeDeCopiasDeCarta.Value = Convert.ToDecimal(QUANTIDADE_MINIMA);
        }

        private void LimparFiltro()
        {
            checkBoxAzul.Checked = false;
            checkBoxBranco.Checked = false;
            checkBoxIncolor.Checked = false;
            checkBoxVerde.Checked = false;
            checkBoxVermelho.Checked = false;
            checkBoxPreto.Checked = false;
            checkBoxTipoDeCartaCriatura.Checked = false;
            checkBoxTipoDeCartaTerrenoBasico.Checked = false;
            checkBoxTipoDeCartaTerreno.Checked = false;
            checkBoxTipoDeCartaFeitico.Checked = false;
            checkBoxTipoDeCartaEncantamento.Checked = false;
            numericUpDownMin.Value = Convert.ToDecimal(null);
            numericUpDownMax.Value = Convert.ToDecimal(null);
            numericUpDownCmc.Value = Convert.ToDecimal(null);
            textBoxFiltrarNome.Text = string.Empty;
        }

        private void CarregarFormListaBaralhoJogadorEmNovaJanelaEmNovaJanela(object obj)
        {
            Application.Run(new FormListaBaralhosDoJogador(_cartaServico, _baralhoServico, _jogadorServico, _jogador));
        }

        private CartaFiltro GerarFiltro(object sender, EventArgs e)
        {
            var filtro = new CartaFiltro();

            filtro = VerificarFiltroTipoDeCarta(filtro);
            filtro = VerificarFiltroPrecoCartaMinimo(filtro);
            filtro = VerificarFiltroPrecoCartaMaximo(filtro);
            filtro = VerificarFiltroCorCarta(filtro);
            filtro = VerificarFiltroNome(filtro);
            filtro = VerificarFiltroCustoDeManaConvertito(filtro);
            filtro = VerificarFiltroRaridade(filtro);

            return filtro;
        }

        public CartaFiltro VerificarFiltroNome(CartaFiltro filtro)
        {
            if (textBoxFiltrarNome.Text.Length > QUANTIDADE_MINIMA) filtro.NomeCarta = textBoxFiltrarNome.Text;

            return filtro;
        }

        private CartaFiltro VerificarFiltroTipoDeCarta(CartaFiltro filtro)
        {
            const string tipoDeCartaCriatura = "Creature";
            const string tipoDeCartaTerrenoBasico = "Basic Land";
            const string tipoDeCartaTerreno = "Land";
            const string tipoDeCartaFeitico = "Sorcery";
            const string tipoDeCartaInstantanea = "Instant";
            const string tipoDeCartaEncantamento = "Enchantment";
            var listaFormatoDeJogo = new List<string>();

            if (checkBoxTipoDeCartaCriatura.Checked) listaFormatoDeJogo.Add(tipoDeCartaCriatura);
            if (checkBoxTipoDeCartaTerrenoBasico.Checked) listaFormatoDeJogo.Add(tipoDeCartaTerrenoBasico);
            if (checkBoxTipoDeCartaTerreno.Checked) listaFormatoDeJogo.Add(tipoDeCartaTerreno);
            if (checkBoxTipoDeCartaFeitico.Checked) listaFormatoDeJogo.Add(tipoDeCartaFeitico);
            if (checkBoxTipoDeCartaMagicaInstantanea.Checked) listaFormatoDeJogo.Add(tipoDeCartaInstantanea);
            if (checkBoxTipoDeCartaEncantamento.Checked) listaFormatoDeJogo.Add(tipoDeCartaEncantamento);

            if (listaFormatoDeJogo.Count > QUANTIDADE_MINIMA) filtro.TipoDeCarta = listaFormatoDeJogo;

            return filtro;
        }

        private CartaFiltro VerificarFiltroPrecoCartaMinimo(CartaFiltro filtro)
        {

            if (numericUpDownMin.Value != PRECO_PADRAO) filtro.PrecoCartaMinimo = Convert.ToDecimal(numericUpDownMin.Text);

            return filtro;
        }

        private CartaFiltro VerificarFiltroPrecoCartaMaximo(CartaFiltro filtro)
        {
            if (numericUpDownMax.Value != PRECO_PADRAO) filtro.PrecoCartaMaximo = Convert.ToDecimal(numericUpDownMax.Text);

            return filtro;
        }

        private CartaFiltro VerificarFiltroCorCarta(CartaFiltro filtro)
        {
            var corCarta = new List<string>();

            if (checkBoxAzul.Checked) corCarta.Add(checkBoxAzul.Text);
            if (checkBoxBranco.Checked) corCarta.Add(checkBoxBranco.Text);
            if (checkBoxIncolor.Checked) corCarta.Add(checkBoxIncolor.Text);
            if (checkBoxVerde.Checked) corCarta.Add(checkBoxVerde.Text);
            if (checkBoxVermelho.Checked) corCarta.Add(checkBoxVermelho.Text);
            if (checkBoxPreto.Checked) corCarta.Add(checkBoxPreto.Text);

            if (corCarta.Count > QUANTIDADE_MINIMA) filtro.CorCarta = corCarta;

            return filtro;
        }

        private CartaFiltro VerificarFiltroRaridade(CartaFiltro filtro)
        {
            var raridade = new List<RaridadeEnum>();

            if (checkBoxRaridadeComum.Checked) raridade.Add(RaridadeEnum.Comum);
            if (checkBoxRaridadeIncomum.Checked) raridade.Add(RaridadeEnum.Incomum);
            if (checkBoxRaridadeRaro.Checked) raridade.Add(RaridadeEnum.Raro);
            if (checkBoxRaridadeMitico.Checked) raridade.Add(RaridadeEnum.Mitico);

            if (raridade.Count > QUANTIDADE_MINIMA) filtro.RaridadeCarta = raridade;

            return filtro;
        }

        private CartaFiltro VerificarFiltroCustoDeManaConvertito(CartaFiltro filtro)
        {
            if (numericUpDownCmc.Value != PRECO_PADRAO) filtro.CustoDeManaConvertidoCarta = Convert.ToInt32(numericUpDownMax.Value);

            return filtro;
        }

        private void CarregarItensDoComboBoxFormatoDoBaralho()
        {
            comboBoxFormato.DataSource = Enum.GetValues(typeof(FormatoDeJogoEnum));
        }
    }
}