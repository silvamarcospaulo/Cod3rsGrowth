using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Cod3rsGrowth.Web.Controllers;
using FluentValidation;
using System.ComponentModel;

namespace Cod3rsGrowth.Forms
{
    public partial class FormListaDeCartaDoBaralho : Form
    {
        private Jogador _jogador;
        private CartaServico _cartaServico;
        private BaralhoServico _baralhoServico;
        private JogadorServico _jogadorServico;
        private JwtServico _tokenServico;
        private ConexaoDados _conexaoDados;
        private LoginController _loginController;
        private Baralho _baralho;
        private Carta cartaSelecionada;
        private Thread threadFormListaBaralhoJogador;
        private Thread threadFormNovoBaralho;
        const int QUANTIDADE_MINIMA = 0;

        public FormListaDeCartaDoBaralho(CartaServico cartaServico, BaralhoServico baralhoServico, JogadorServico jogadorServico,
            JwtServico tokenServico, ConexaoDados conexaoDados, LoginController loginController, Jogador jogador, Baralho baralho)
        {
            _cartaServico = cartaServico;
            _baralhoServico = baralhoServico;
            _jogadorServico = jogadorServico;
            _tokenServico = tokenServico;
            _conexaoDados = conexaoDados;
            _loginController = loginController;
            _jogador = jogador;
            _baralho = baralho;
            InitializeComponent();
        }

        private void CarregarFormListaDeCartasDoBaralho(object sender, EventArgs e)
        {
            const int casasDecimais = 2;

            CarregarListaDeCopiaDeCartasNoBaralho();
            labelNomeParcial.Text = _baralho.NomeBaralho;
            labelFormatoParcial.Text = _baralho.FormatoDeJogoBaralho.ToString();
            labelQuantidadeParcial.Text = _baralho.QuantidadeDeCartasNoBaralho.ToString();
            labelCustoParcial.Text = _baralho.CustoDeManaConvertidoDoBaralho.ToString();
            labelPrecoParcial.Text = $"R${Math.Round(_baralho.PrecoDoBaralho, casasDecimais)}";
            labelCorParcial.Text = _baralho.CorBaralho;
            LimparDadosDaCarta();
        }

        private void CarregarListaDeCopiaDeCartasNoBaralho()
        {
            var cartasDoJogador = new BindingList<CopiaDeCartasNoBaralho>(_baralho.CartasDoBaralho);
            dataGridViewListaDeCartasDoBaralho.DataSource = cartasDoJogador;
        }

        private void AoClicarCarregaDadosDaCarta(object sender, DataGridViewCellEventArgs e)
        {
            var selecao = dataGridViewListaDeCartasDoBaralho.Rows[e.RowIndex];
            var copia = (CopiaDeCartasNoBaralho)selecao.DataBoundItem;
            cartaSelecionada = copia?.Carta;
            CarregarDadosDaCarta();
        }

        private void LimparDadosDaCarta()
        {
            labelNomeCartaSelecionada.Text = "";
            labelTipoCartaSelecionada.Text = "";
            labelCustoManaCartaSelecionada.Text = "";
            labelPrecoCartaSelecionada.Text = "";
            labelRariadeCartaSelecionada.Text = "";
            labelCorCartaSelecionada.Text = "";
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

        private void buttonCriarBaralhoBaralho_Click(object sender, EventArgs e)
        {
            try
            {
                _baralhoServico.Criar(_baralho);
                this.Close();
                threadFormListaBaralhoJogador = new Thread(CarregarFormListaBaralhoJogador);
                threadFormListaBaralhoJogador.SetApartmentState(ApartmentState.STA);
                threadFormListaBaralhoJogador.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarFormListaBaralhoJogador(object obj)
        {
            Application.Run(new FormListaBaralhosDoJogador(_cartaServico, _baralhoServico, _jogadorServico, _tokenServico, _conexaoDados, _loginController, _jogador));
        }

        private void AoClicarVoltaParaTelaDeNovoBaralho(object sender, EventArgs e)
        {
            this.Close();
            threadFormNovoBaralho = new Thread(CarregarFormNovoBaralho);
            threadFormNovoBaralho.SetApartmentState(ApartmentState.STA);
            threadFormNovoBaralho.Start();
        }

        private void CarregarFormNovoBaralho(object obj)
        {
            Application.Run(new FormNovoBaralho(_cartaServico, _baralhoServico, _jogadorServico, _tokenServico, _conexaoDados, _loginController, _jogador, _baralho));
        }

        private void AoClicarRemoveCartaDaListaDeCartasDoBaralho(object sender, EventArgs e)
        {
            var copiaExcluir = _baralho?.CartasDoBaralho?.Where(copia => copia.IdCarta == cartaSelecionada.Id).First();

            foreach (var copia in _baralho.CartasDoBaralho)
            {
                if(copia?.IdCarta == cartaSelecionada?.Id)
                {
                    _baralho.CartasDoBaralho.Remove(copia);
                    break;
                }
            }
            CarregarListaDeCopiaDeCartasNoBaralho();
        }
    }
}