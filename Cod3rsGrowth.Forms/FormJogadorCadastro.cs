using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;

namespace Cod3rsGrowth.Forms
{
    public partial class FormJogadorCadastro : Form
    {
        private CartaServico _cartaServico;
        private BaralhoServico _baralhoServico;
        private JogadorServico _jogadorServico;
        private Jogador _jogador;
        private Thread threadFormsJogador;

        public FormJogadorCadastro(CartaServico cartaServico, BaralhoServico baralhoServico, JogadorServico jogadorServico)
        {
            _cartaServico = cartaServico;
            _baralhoServico = baralhoServico;
            _jogadorServico = jogadorServico;
            InitializeComponent();
        }

        private void AoClicarCadastrarNovoUsuario(object sender, EventArgs e)
        {
            var data = Convert.ToDateTime(dateTimePickerDataDeNascimento.Text);

            var jogadorAutenticar = new Jogador()
            {
                NomeJogador = textBoxNome.Text,
                SobrenomeJogador = textBoxSobrenome.Text,
                UsuarioJogador = textBoxUsuario.Text,
                SenhaHashJogador = textBoxSenha.Text,
                SenhaHashConfirmacaoJogador = textBoxConfirmarSenha.Text,
                DataNascimentoJogador = new DateTime(day: data.Day, month: data.Month, year: data.Year),
                DataDeCriacaoContaJogador = DateTime.Now
            };

            try
            {
                var idJogador = _jogadorServico.Criar(jogadorAutenticar);
                _jogador = _jogadorServico.ObterPorId(idJogador);

                this.Close();
                threadFormsJogador = new Thread(AoClicarCarregarJogadorEmNovaJanela);
                threadFormsJogador.SetApartmentState(ApartmentState.STA);
                threadFormsJogador.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao criar conta.");
            }
        }

        private void AoClicarCarregarJogadorEmNovaJanela(Object obj)
        {
            Application.Run(new FormListaBaralhosDoJogador(_cartaServico, _baralhoServico, _jogadorServico, _jogador));
        }

        private void AoClicarVoltarParaTelaDeLogin(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            threadFormsJogador = new Thread(AoClicarCarregarJogadorEntrarEmNovaJanela);
            threadFormsJogador.SetApartmentState(ApartmentState.STA);
            threadFormsJogador.Start();
        }

        private void AoClicarCarregarJogadorEntrarEmNovaJanela(Object obj)
        {
            Application.Run(new FormJogadorEntrar(_cartaServico, _baralhoServico, _jogadorServico));
        }

        private void AoClicarVisualizaSenha(object sender, EventArgs e)
        {
            textBoxSenha.UseSystemPasswordChar = !textBoxSenha.UseSystemPasswordChar;
        }

        private void AoClicarVisualizaConfirmacaoDeSenha(object sender, EventArgs e)
        {
            textBoxConfirmarSenha.UseSystemPasswordChar = !textBoxConfirmarSenha.UseSystemPasswordChar;
        }
    }
}