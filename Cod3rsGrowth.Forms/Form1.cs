using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Infra.Repository;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;

namespace Cod3rsGrowth.Forms
{
    public partial class Form1 : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView songsDataGridView = new DataGridView();
        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();

        private CartaServico servicoCarta;
        private BaralhoServico servicoBaralho;
        private JogadorServico servicoJogador;

        public Form1(CartaServico _servicoCarta, BaralhoServico _servicoBaralho,
            JogadorServico _servicoJogador)
        {
            servicoCarta = _servicoCarta;
            servicoBaralho = _servicoBaralho;
            servicoJogador = _servicoJogador;
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var listaDeCartas = servicoCarta.ObterTodos(null);

            dataGridCartas.AutoGenerateColumns = true;
            dataGridCartas.DataSource = listaDeCartas;

            dataGridCartas.Columns.Add(new DataGridViewTextBoxColumn());


            var listaDeJogadores = servicoJogador.ObterTodos(null);

            dataGridJogador.AutoGenerateColumns = true;
            dataGridJogador.DataSource = listaDeJogadores;

            dataGridJogador.Columns.Add(new DataGridViewTextBoxColumn());
        }

        private void dataGridCartas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridJogador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}