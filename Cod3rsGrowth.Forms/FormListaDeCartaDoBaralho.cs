using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using System.ComponentModel;

namespace Cod3rsGrowth.Forms
{
    public partial class FormListaDeCartaDoBaralho : Form
    {
        private Jogador _jogador;
        private CartaServico _cartaServico;
        private BaralhoServico _baralhoServico;
        private JogadorServico _jogadorServico;
        private Baralho _baralho;
        private Carta cartaSelecionada;
        private Thread threadFormListaBaralhoJogador;
        private Thread threadFormNovoBaralho;
        private const int QUANTIDADE_MINIMA = 0;
        private string STRING_VAZIA = string.Empty;

        public FormListaDeCartaDoBaralho(CartaServico cartaServico, BaralhoServico baralhoServico, JogadorServico jogadorServico, Jogador jogador, Baralho baralho)
        {
            _cartaServico = cartaServico;
            _baralhoServico = baralhoServico;
            _jogadorServico = jogadorServico;
            _jogador = jogador;
            _baralho = baralho;
            InitializeComponent();
        }

        private void CarregarFormListaDeCartasDoBaralho(object sender, EventArgs e)
        {
            CarregarListaDeCopiaDeCartasNoBaralho();
            LimparDadosDaCarta();
        }

        private void AtualizarDadosBaralhoNaTela()
        {
            const int casasDecimais = 2;

            labelNomeParcial.Text = _baralho.NomeBaralho;
            labelFormatoParcial.Text = _baralho.FormatoDeJogoBaralho.ToString();
            labelQuantidadeParcial.Text = _baralho.QuantidadeDeCartasNoBaralho.ToString();
            labelCustoParcial.Text = _baralho.CustoDeManaConvertidoDoBaralho.ToString();
            labelPrecoParcial.Text = $"R${Math.Round(_baralho.PrecoDoBaralho, casasDecimais)}";
            labelCorParcial.Text = _baralho.CorBaralho;
        }

        private void AtualizarDadosBaralho()
        {
            _baralho.QuantidadeDeCartasNoBaralho = BaralhoServico.SomarQuantidadeDeCartasDoBaralho(_baralho.CartasDoBaralho);
            _baralho.CustoDeManaConvertidoDoBaralho = BaralhoServico.SomarCustoDeManaConvertidoDoBaralho(_baralho.CartasDoBaralho);
            _baralho.PrecoDoBaralho = BaralhoServico.SomarPrecoDoBaralho(_baralho.CartasDoBaralho);
            _baralho.CorBaralho = BaralhoServico.ConferirCoresDoBaralho(_baralho.CartasDoBaralho);
        }

        private void CarregarListaDeCopiaDeCartasNoBaralho()
        {
            var cartasDoJogador = new BindingList<CopiaDeCartasNoBaralho>(_baralho.CartasDoBaralho);
            dataGridViewListaDeCartasDoBaralho.DataSource = cartasDoJogador;
            AtualizarDadosBaralho();
            AtualizarDadosBaralhoNaTela();
        }

        private void AoClicarCarregaDadosDaCarta(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selecao = dataGridViewListaDeCartasDoBaralho.Rows[e.RowIndex];
                var copia = (CopiaDeCartasNoBaralho)selecao.DataBoundItem;
                cartaSelecionada = copia?.Carta;
                CarregarDadosDaCarta();
            }
        }

        private void LimparDadosDaCarta()
        {
            labelNomeCartaSelecionada.Text = STRING_VAZIA;
            labelTipoCartaSelecionada.Text = STRING_VAZIA;
            labelCustoManaCartaSelecionada.Text = STRING_VAZIA;
            labelPrecoCartaSelecionada.Text = STRING_VAZIA;
            labelRariadeCartaSelecionada.Text = STRING_VAZIA;
            labelCorCartaSelecionada.Text = STRING_VAZIA;
        }

        private void CarregarDadosDaCarta()
        {
            const int casasDecimais = 2;
            labelNomeCartaSelecionada.Text = cartaSelecionada.NomeCarta;
            labelTipoCartaSelecionada.Text = cartaSelecionada.TipoDeCarta;
            labelCustoManaCartaSelecionada.Text = cartaSelecionada.CustoDeManaConvertidoCarta.ToString();
            labelPrecoCartaSelecionada.Text = $"R${Math.Round(cartaSelecionada.PrecoCarta, casasDecimais)}";
            labelRariadeCartaSelecionada.Text = cartaSelecionada.RaridadeCarta.ToString();
            labelCorCartaSelecionada.Text = cartaSelecionada.CorCarta;
        }

        private void AoClicarCriaBaralho(object sender, EventArgs e)
        {
            try
            {
                _baralhoServico.Criar(_baralho);
                this.Close();
                threadFormListaBaralhoJogador = new Thread(CarregarFormListaBaralhoJogadorEmNovaJanela);
                threadFormListaBaralhoJogador.SetApartmentState(ApartmentState.STA);
                threadFormListaBaralhoJogador.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao criar novo baralho");
            }
        }

        private void CarregarFormListaBaralhoJogadorEmNovaJanela(object obj)
        {
            Application.Run(new FormListaBaralhosDoJogador(_cartaServico, _baralhoServico, _jogadorServico, _jogador));
        }

        private void AoClicarVoltaParaTelaDeNovoBaralho(object sender, EventArgs e)
        {
            this.Close();
            threadFormNovoBaralho = new Thread(CarregarFormNovoBaralhoEmNovaJanela);
            threadFormNovoBaralho.SetApartmentState(ApartmentState.STA);
            threadFormNovoBaralho.Start();
        }

        private void CarregarFormNovoBaralhoEmNovaJanela(object obj)
        {
            Application.Run(new FormNovoBaralho(_cartaServico, _baralhoServico, _jogadorServico, _jogador, _baralho));
        }

        private void AoClicarRemoveCartaDaListaDeCartasDoBaralho(object sender, EventArgs e)
        {
            try
            {
                if (cartaSelecionada is null)
                    MessageBox.Show("Nenhuma carta foi selecionada!", "Erro ao remover carta");

                var cartaParaRemover = _baralho?.CartasDoBaralho?.FirstOrDefault(copia => copia.IdCarta == cartaSelecionada?.Id) ?? null;

                var resposta = new DialogResult();

                resposta = cartaParaRemover is not null
                    ? MessageBox.Show($"Remover {cartaParaRemover.NomeCarta} da lista de carta do baralho?", "Confirmação", MessageBoxButtons.YesNo)
                    : MessageBox.Show("Não existe uma carta correspondente na lista!", "Erro ao remover carta");

                if (resposta == DialogResult.Yes)
                {
                    _baralho.CartasDoBaralho.Remove(cartaParaRemover);
                    MessageBox.Show($"A carta {cartaParaRemover.NomeCarta} foi removida da lista com sucesso!", "Carta removida com sucesso!");
                    CarregarListaDeCopiaDeCartasNoBaralho();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover {cartaSelecionada.NomeCarta} da lista de cartas!\n{ex.Message}", "Erro ao remover carta");
            }
        }
    }
}