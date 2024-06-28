using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Infra.Repository;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;

namespace Cod3rsGrowth.Forms
{
    public partial class FormListaCartaEJogador : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView songsDataGridView = new DataGridView();
        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();

        private CartaServico servicoCarta;
        private BaralhoServico servicoBaralho;
        private JogadorServico servicoJogador;

        public FormListaCartaEJogador(CartaServico _servicoCarta, BaralhoServico _servicoBaralho,
            JogadorServico _servicoJogador)
        {
            servicoCarta = _servicoCarta;
            servicoBaralho = _servicoBaralho;
            servicoJogador = _servicoJogador;
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var listaDeCartas = servicoCarta.ObterTodos(new CartaFiltro());

            dataGridViewCarta.DataSource = listaDeCartas;

            dataGridViewCarta.Columns.Add(new DataGridViewTextBoxColumn());


            var listaDeJogadores = servicoJogador.ObterTodos(new JogadorFiltro());

            dataGridViewJogador.DataSource = listaDeJogadores;

            dataGridViewJogador.Columns.Add(new DataGridViewTextBoxColumn());
        }

        private void dataGridViewJogador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCarta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}