using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Infra.Repository;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Threading;

namespace Cod3rsGrowth.Forms
{
    public partial class Main : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView songsDataGridView = new DataGridView();
        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();
        private FormJogador formJogador;
        private Thread threadMain;

        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private ConexaoDados conexaoDados;

        public Main(CartaServico _cartaServico, BaralhoServico _baralhoServico,
            JogadorServico _jogadorServico, ConexaoDados _conexaoDados)
        {
            cartaServico = _cartaServico;
            baralhoServico = _baralhoServico;
            jogadorServico = _jogadorServico;
            conexaoDados = _conexaoDados;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CarregarPaginaInicial();
        }

        private void dataGridViewCarta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonJogador_Click(object sender, EventArgs e)
        {
            this.Close();
            threadMain = new Thread(AoClicarListarJogadoresEmNovaJanela);
            threadMain.SetApartmentState(ApartmentState.STA);
            threadMain.Start();
        }

        private void AoClicarListarJogadoresEmNovaJanela(object obj)
        {
            Application.Run(new FormJogador(cartaServico, baralhoServico, jogadorServico, conexaoDados));
        }

        public void CarregarPaginaInicial()
        {
            var listaDeCartas = cartaServico.ObterTodos(new CartaFiltro());

            dataGridViewCarta.DataSource = listaDeCartas;

            dataGridViewCarta.Columns.Add(new DataGridViewTextBoxColumn());
        }
    }
}