using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;

namespace Cod3rsGrowth.Forms
{
    public partial class FormsJogadorCadastro : Form
    {
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private ConexaoDados conexaoDados;

        public FormsJogadorCadastro(CartaServico _cartaServico, BaralhoServico _baralhoServico,
            JogadorServico _jogadorServico, ConexaoDados _conexaoDados)
        {
            cartaServico = _cartaServico;
            baralhoServico = _baralhoServico;
            jogadorServico = _jogadorServico;
            conexaoDados = _conexaoDados;
            InitializeComponent();
        }

        private void FormsJogadorCadastro_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var jogadorCriar = new Jogador()
                {
                    NomeJogador = textBoxNome.Text,
                    UsuarioJogador = textBoxUsername.Text,
                    SenhaJogador = textBoxSenha.Text,
                    DataNascimentoJogador = Convert.ToDateTime(dateTimePickerDataDeNascimento.Text)
                };
                var idJogador = jogadorServico.Criar(jogadorCriar);
                var jogador = jogadorServico.ObterPorId(idJogador);
                AoClicarCarregarJogadorEmNovaJanela(jogador);
            }
            catch (Exception ex)
            {

            }
        }

        private void AoClicarCarregarJogadorEmNovaJanela(Jogador jogador)
        {
            this.Hide();
            new FormsJogador(cartaServico, baralhoServico, jogadorServico, conexaoDados, jogador).Show();
        }

        private void linkLabelJaPossuoConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormsJogadorEntrar(cartaServico, baralhoServico, jogadorServico, conexaoDados).Show();
        }
    }
}
