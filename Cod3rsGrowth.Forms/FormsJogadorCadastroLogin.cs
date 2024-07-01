using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;

namespace Cod3rsGrowth.Forms
{
    public partial class FormsJogadorCadastroLogin : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView songsDataGridView = new DataGridView();
        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();
        private FormJogador formJogador;
        private Thread threadFormJogador;

        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private ConexaoDados conexaoDados;

        public FormsJogadorCadastroLogin(CartaServico _cartaServico, BaralhoServico _baralhoServico,
                JogadorServico _jogadorServico, ConexaoDados _conexaoDados)
        {
            cartaServico = _cartaServico;
            baralhoServico = _baralhoServico;
            jogadorServico = _jogadorServico;
            conexaoDados = _conexaoDados;
            InitializeComponent();
        }

        private void FormsJogadorCadastroLogin_Load(object sender, EventArgs e)
        {
        }

        private void groupBoxEntrar_Enter(object sender, EventArgs e)
        {

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                var filtro = new JogadorFiltro() { NomeJogador = textBoxEntrarNome.Text, SenhaJogador = textBoxEntrarSenha.Text};
                this.Close();
                jogadorServico.ObterTodos(filtro);
                AoClicarListarJogadorEmNovaJanela(filtro);
            }
            catch (Exception ex)
            {

            }
        }

        private void AoClicarListarJogadorEmNovaJanela(JogadorFiltro filtro)
        {
            Application.Run(new FormJogador(cartaServico, baralhoServico, jogadorServico, conexaoDados, filtro));
        }

        private void labelEntrarNome_Click(object sender, EventArgs e)
        {

        }

        private void labelEntrarSenha_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {

        }

        private void labelCadastroNome_Click(object sender, EventArgs e)
        {

        }

        private void labelCadastroDataDeNascimento_Click(object sender, EventArgs e)
        {

        }

        private void labelCadastroSenha_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxCadastro(object sender, EventArgs e)
        {

        }

        private void textBoxEntrarNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCadastroNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
