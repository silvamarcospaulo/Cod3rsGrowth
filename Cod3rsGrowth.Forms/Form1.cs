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


            //dataGridView1.Columns["Nome"].HeaderText = "Nome";
            //dataGridView1.Columns["Id"].HeaderText = "Id";
            //dataGridView1.Columns["TipoDeCarta"].HeaderText = "TipoDeCarta";
            //dataGridView1.Columns["Cor"].HeaderText = "Cor";
            //dataGridView1.Columns["CustoDeManaConvertido"].HeaderText = "CustoDeManaConvertido";
            //dataGridView1.Columns["Raridade"].HeaderText = "Raridade";
            //dataGridView1.Columns["Preco"].HeaderText = "Preco";

            var listaDeCartas = servicoCarta.ObterTodos(null);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = listaDeCartas;

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}