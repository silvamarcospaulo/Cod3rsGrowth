using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;

namespace Cod3rsGrowth.Forms
{
    public partial class FormJogadorEntrar : Form
    {
        private CartaServico _cartaServico;
        private BaralhoServico _baralhoServico;
        private JogadorServico _jogadorServico;
        private Jogador _jogador;
        private Thread threadFormsJogador;
        private Thread threadFormsCadastro;
        private Thread threadFormsEsqueciSenha;

        public FormJogadorEntrar(CartaServico cartaServico, BaralhoServico baralhoServico, JogadorServico jogadorServico)
        {
            _cartaServico = cartaServico;
            _baralhoServico = baralhoServico;
            _jogadorServico = jogadorServico;
            InitializeComponent();
        }

        private void AoClicarAutenticaUsuarioSenha(object sender, EventArgs e)
        {
            labelUsuarioMensagemDeErro.Text = "";
            labelSenhaMensagemDeErro.Text = "";

            try
            {
                var jogadorAutenticar = new Jogador()
                {
                    UsuarioJogador = textBoxUsuario.Text,
                    SenhaHashJogador = textBoxSenha.Text
                };

                var resultado = JwtServico.AutenticarJogador(jogadorAutenticar, _jogadorServico);

                _jogador = _jogadorServico.ObterPorId(resultado.Id);

                this.Close();
                threadFormsJogador = new Thread(CarregaFormJogadorEmNovaJanela);
                threadFormsJogador.SetApartmentState(ApartmentState.STA);
                threadFormsJogador.Start();
            }
            catch (NullReferenceException)
            {
                labelSenhaMensagemDeErro.Text = "A senha que você inseriu está incorreta.";
            }
            catch (InvalidOperationException)
            {
                labelUsuarioMensagemDeErro.Text = "O usuário que você inseriu não está conectado a uma conta.";
            }
        }

        private void CarregaFormJogadorEmNovaJanela(object obj)
        {
            Application.Run(new FormListaBaralhosDoJogador(_cartaServico, _baralhoServico, _jogadorServico, _jogador));
        }

        private void AoClicarAbreTelaDeCadastroDeConta(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            threadFormsCadastro = new Thread(CarregaFormCadastroEmNovaJanela);
            threadFormsCadastro.SetApartmentState(ApartmentState.STA);
            threadFormsCadastro.Start();
        }

        private void CarregaFormCadastroEmNovaJanela(object obj)
        {
            Application.Run(new FormJogadorCadastroEdicao(_cartaServico, _baralhoServico, _jogadorServico, null));
        }

        private void AoClicarAbreTelaDeRestauracaoDeSenha(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            threadFormsEsqueciSenha = new Thread(CarregaFormEsqueciSenhaEmNovaJanela);
            threadFormsEsqueciSenha.SetApartmentState(ApartmentState.STA);
            threadFormsEsqueciSenha.Start();
        }

        private void CarregaFormEsqueciSenhaEmNovaJanela(object obj)
        {
            Application.Run(new FormEsqueciSenha(_cartaServico, _baralhoServico, _jogadorServico));
        }

        private void AoClicarVisualizaSenha(object sender, EventArgs e)
        {
            textBoxSenha.UseSystemPasswordChar = !textBoxSenha.UseSystemPasswordChar;
        }
    }
}