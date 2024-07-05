using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;

namespace Cod3rsGrowth.Forms
{
    public partial class FormsJogador : Form
    {
        private Jogador jogador;
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private ConexaoDados conexaoDados;

        public FormsJogador(CartaServico _cartaServico, BaralhoServico _baralhoServico,
            JogadorServico _jogadorServico, ConexaoDados _conexaoDados, Jogador _jogador)
        {
            jogador = _jogador;
            cartaServico = _cartaServico;
            baralhoServico = _baralhoServico;
            jogadorServico = _jogadorServico;
            conexaoDados = _conexaoDados;

            InitializeComponent();
        }

        public void FormJogador_Load(object sender, EventArgs e)
        {
            var listaDeBaralho = baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = jogador.Id });
            dataGridViewBaralhoDoJogador.DataSource = listaDeBaralho;
        }

        private void dataGridViewBaralhoDoJogador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void baralhoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        public void FormsJogador_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormsJogador_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}