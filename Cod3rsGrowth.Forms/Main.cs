using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Infra.Repository;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Cod3rsGrowth.Forms
{
    public partial class Main : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView songsDataGridView = new DataGridView();
        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();
        private FormJogador formJogador;

        private CartaServico servicoCarta;
        private BaralhoServico servicoBaralho;
        private JogadorServico servicoJogador;
        private ConexaoDados conexaoDados;

        public Main(CartaServico _servicoCarta, BaralhoServico _servicoBaralho,
            JogadorServico _servicoJogador, ConexaoDados _conexaoDados)
        {
            servicoCarta = _servicoCarta;
            servicoBaralho = _servicoBaralho;
            servicoJogador = _servicoJogador;
            conexaoDados = _conexaoDados;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var listaDeCartas = servicoCarta.ObterTodos(new CartaFiltro());

            dataGridViewCarta.DataSource = listaDeCartas;

            dataGridViewCarta.Columns.Add(new DataGridViewTextBoxColumn());
        }

        private void dataGridViewCarta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewJogador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void buttonJogador_Click(object sender, EventArgs e)
        {
            formJogador.ShowDialog();
        }

        private void AoClicarListaJogadores(object sender, EventArgs e)
        {
            var listaJogadores = new FormJogador(servicoJogador, conexaoDados);
            buttonJogador.Click += (sender, e) => AoClicarListaJogadores(sender, e);
            listaJogadores.ShowDialog();
            
        }
    }
}