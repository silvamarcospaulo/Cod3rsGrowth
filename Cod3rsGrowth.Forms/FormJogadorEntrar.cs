using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Cod3rsGrowth.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Cod3rsGrowth.Forms
{
    public partial class FormJogadorEntrar : Form
    {
        private CartaServico _cartaServico;
        private BaralhoServico _baralhoServico;
        private JogadorServico _jogadorServico;
        private JwtServico _tokenServico;
        private ConexaoDados _conexaoDados;
        private LoginController _loginController;
        private Jogador _jogador;
        private Thread threadFormsJogador;
        private Thread threadFormsCadastro;
        private Thread threadFormsEsqueciSenha;

        public FormJogadorEntrar(CartaServico cartaServico, BaralhoServico baralhoServico,
            JogadorServico jogadorServico, JwtServico tokenServico, ConexaoDados conexaoDados, LoginController loginController)
        {
            _cartaServico = cartaServico;
            _baralhoServico = baralhoServico;
            _jogadorServico = jogadorServico;
            _tokenServico = tokenServico;
            _conexaoDados = conexaoDados;
            _loginController = loginController;
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

                var resultado = _loginController.Autenticacao(jogadorAutenticar) as OkObjectResult;
                var jogador = (Jogador)resultado?.Value;

                _jogador = _jogadorServico.ObterPorId(jogador.Id);

                this.Close();
                threadFormsJogador = new Thread(CarregaFormJogador);
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

        private void CarregaFormJogador(object obj)
        {
            Application.Run(new FormListaBaralhosDoJogador(_cartaServico, _baralhoServico, _jogadorServico, _tokenServico, _conexaoDados, _loginController, _jogador));
        }

        private void AoClicarAbreTelaDeCadastroDeConta(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            threadFormsCadastro = new Thread(AoClicarAbrirTelaDeCadastroEmNovaJanela);
            threadFormsCadastro.SetApartmentState(ApartmentState.STA);
            threadFormsCadastro.Start();
        }

        private void AoClicarAbrirTelaDeCadastroEmNovaJanela(object obj)
        {
            Application.Run(new FormJogadorCadastro(_cartaServico, _baralhoServico, _jogadorServico, _tokenServico, _conexaoDados, _loginController));
        }

        private void AoClicarAbreTelaDeRestauracaoDeSenha(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            threadFormsEsqueciSenha = new Thread(AoClicarAbrirTelaDeEsqueciSenhaEmNovaJanela);
            threadFormsEsqueciSenha.SetApartmentState(ApartmentState.STA);
            threadFormsEsqueciSenha.Start();
        }

        private void AoClicarAbrirTelaDeEsqueciSenhaEmNovaJanela(object obj)
        {
            Application.Run(new FormEsqueciSenha(_cartaServico, _baralhoServico, _jogadorServico, _tokenServico, _conexaoDados, _loginController));
        }

        private void AoClicarVisualizaSenha(object sender, EventArgs e)
        {
            if (textBoxSenha.UseSystemPasswordChar)
            {
                textBoxSenha.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxSenha.UseSystemPasswordChar = true;
            }
        }
    }
}