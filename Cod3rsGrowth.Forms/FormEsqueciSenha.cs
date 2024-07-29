using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;

namespace Cod3rsGrowth.Forms
{
    public partial class FormEsqueciSenha : Form
    {
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private Thread threadFormsEntrar;

        public FormEsqueciSenha(CartaServico _cartaServico, BaralhoServico _baralhoServico, JogadorServico _jogadorServico)
        {
            cartaServico = _cartaServico;
            baralhoServico = _baralhoServico;
            jogadorServico = _jogadorServico;
            InitializeComponent();
        }

        private void AoClicarRestauraSenhaDoJogador(object sender, EventArgs e)
        {
            var data = Convert.ToDateTime(dateTimePickerDataDeNascimento.Text);
            var jogadorRestaurarSenha = new Jogador()
            {
                NomeJogador = textBoxNome.Text,
                SobrenomeJogador = textBoxSobrenome.Text,
                UsuarioJogador = textBoxUsuario.Text,
                SenhaHashJogador = textBoxNovasenha.Text,
                SenhaHashConfirmacaoJogador = textBoxConfirmarNovaSenha.Text,
                DataNascimentoJogador = new DateTime(day: data.Day, month: data.Month, year: data.Year)
            };

            try
            {
                jogadorServico.AlterarSenha(jogadorRestaurarSenha);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao recuperar conta");
            }

            this.Close();
            threadFormsEntrar = new Thread(CarregarJanelaJogadorEntrarEmNovaJanela);
            threadFormsEntrar.SetApartmentState(ApartmentState.STA);
            threadFormsEntrar.Start();
        }

        private void AoClicarCancelaRestauracaoDeSenha(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            threadFormsEntrar = new Thread(CarregarJanelaJogadorEntrarEmNovaJanela);
            threadFormsEntrar.SetApartmentState(ApartmentState.STA);
            threadFormsEntrar.Start();
        }

        private void CarregarJanelaJogadorEntrarEmNovaJanela(object obj)
        {
            Application.Run(new FormJogadorEntrar(cartaServico, baralhoServico, jogadorServico));
        }

        private void AoClicarVisualizaSenha(object sender, EventArgs e)
        {
            textBoxNovasenha.UseSystemPasswordChar = !textBoxNovasenha.UseSystemPasswordChar;
        }

        private void AoClicarVisualizaConfirmacaoDeSenha(object sender, EventArgs e)
        {
            textBoxConfirmarNovaSenha.UseSystemPasswordChar = !textBoxConfirmarNovaSenha.UseSystemPasswordChar;
        }
    }
}