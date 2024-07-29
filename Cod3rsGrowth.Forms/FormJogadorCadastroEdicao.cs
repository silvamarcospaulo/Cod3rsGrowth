using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;

namespace Cod3rsGrowth.Forms
{
    public partial class FormJogadorCadastroEdicao : Form
    {
        private CartaServico _cartaServico;
        private BaralhoServico _baralhoServico;
        private JogadorServico _jogadorServico;
        private Jogador _jogador;
        private Thread threadFormsJogador;
        private Thread threadFormsJogadorEntrar;
        private DialogResult resposta;

        public FormJogadorCadastroEdicao(CartaServico cartaServico, BaralhoServico baralhoServico, JogadorServico jogadorServico, Jogador jogador)
        {
            _cartaServico = cartaServico;
            _baralhoServico = baralhoServico;
            _jogadorServico = jogadorServico;
            _jogador = jogador;

            InitializeComponent();
        }

        private void CarregarFormJogadorCadastroEdicao(object sender, EventArgs e)
        {
            if (_jogador?.Id > decimal.Zero) CarregarEdicao();
        }

        private void CarregarEdicao()
        {
            Width = 391;
            Height = 642;
            Text = "MTG DeckBuilder - Edição";
            labelCadastro.Text = "Editar perfil";
            textBoxNome.Enabled = false;
            textBoxNome.Text = _jogador.NomeJogador;
            textBoxSobrenome.Enabled = false;
            textBoxSobrenome.Text = _jogador.SobrenomeJogador;
            dateTimePickerDataDeNascimento.Enabled = false;
            dateTimePickerDataDeNascimento.Value = _jogador.DataNascimentoJogador;
            buttonApagarPerfil.Visible = true;
            buttonApagarPerfil.Enabled = true;
            buttonEditar.Visible = true;
            buttonEditar.Enabled = true;
            labelAlertaEncerrarConta.Visible = true;
            linkLabelJaPossuoConta.Visible = true;
            linkLabelJaPossuoConta.Enabled = true;
            buttonCadastrar.Visible = false;
            buttonCadastrar.Enabled = false;
            buttonCancelar.Visible = false;
            buttonCancelar.Enabled = false;
        }

        private void AoClicarCadastrarNovoUsuario(object sender, EventArgs e)
        {
            var data = Convert.ToDateTime(dateTimePickerDataDeNascimento.Text);

            var jogadorAutenticar = new Jogador()
            {
                NomeJogador = textBoxNome.Text,
                SobrenomeJogador = textBoxSobrenome.Text,
                UsuarioJogador = textBoxUsuario.Text,
                UsuarioConfirmacaoJogador = textBoxConfirmarUsuario.Text,
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
                threadFormsJogador = new Thread(CarregarJogadorEmNovaJanela);
                threadFormsJogador.SetApartmentState(ApartmentState.STA);
                threadFormsJogador.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao criar conta.");
            }
        }

        private void CarregarJogadorEmNovaJanela(Object obj)
        {
            Application.Run(new FormListaBaralhosDoJogador(_cartaServico, _baralhoServico, _jogadorServico, _jogador));
        }

        private void AoClicarLinkVoltarParaTelaDeListaDeBaralho(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _jogador = _jogadorServico.ObterPorId(_jogador.Id);

            this.Close();
            threadFormsJogador = new Thread(CarregaFormJogadorEmNovaJanela);
            threadFormsJogador.SetApartmentState(ApartmentState.STA);
            threadFormsJogador.Start();
        }

        private void CarregaFormJogadorEmNovaJanela(object obj)
        {
            Application.Run(new FormListaBaralhosDoJogador(_cartaServico, _baralhoServico, _jogadorServico, _jogador));
        }

        private void CarregarJogadorEntrarEmNovaJanela(Object obj)
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

        private void AoClicarVoltarParaTelaDeLogin(object sender, EventArgs e)
        {
            this.Close();
            threadFormsJogador = new Thread(CarregarJogadorEntrarEmNovaJanela);
            threadFormsJogador.SetApartmentState(ApartmentState.STA);
            threadFormsJogador.Start();
        }

        private void AoClicarEnviaAlteracoesDePerfil(object sender, EventArgs e)
        {
            var valorNulo = 0;

            _jogador.UsuarioJogador = textBoxUsuario.Text.Length > valorNulo ? textBoxUsuario.Text : null;
            _jogador.UsuarioConfirmacaoJogador = textBoxConfirmarUsuario.Text.Length > valorNulo ? textBoxConfirmarUsuario.Text : null;

            _jogador.SenhaHashJogador = textBoxSenha.Text.Length > valorNulo ? textBoxSenha.Text : null;
            _jogador.SenhaHashConfirmacaoJogador = textBoxConfirmarSenha.Text.Length > valorNulo ? textBoxConfirmarSenha.Text : null;

            try
            {
                _jogadorServico.Atualizar(_jogador);

                this.Close();
                threadFormsJogadorEntrar = new Thread(CarregarJanelaDeLoginEmNovaJanela);
                threadFormsJogadorEntrar.SetApartmentState(ApartmentState.STA);
                threadFormsJogadorEntrar.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarJanelaDeLoginEmNovaJanela(object obj)
        {
            Application.Run(new FormJogadorEntrar(_cartaServico, _baralhoServico, _jogadorServico));
        }

        private void AoClicarApagaPerfil(object sender, EventArgs e)
        {
            try
            {
                resposta = MessageBox.Show($"{_jogador.NomeJogador}, lamentamos que esteja saindo.\nTem certeza que deseja encerrar sua conta? Você perderá seus dados e baralhos.\r\n\r\nContinuar?", "Confirmação", MessageBoxButtons.YesNo);

                if (resposta == DialogResult.Yes)
                {
                    _jogadorServico.Excluir(_jogador.Id);
                    MessageBox.Show("Conta encerrada!");

                    this.Close();
                    threadFormsJogadorEntrar = new Thread(CarregarJanelaDeLoginEmNovaJanela);
                    threadFormsJogadorEntrar.SetApartmentState(ApartmentState.STA);
                    threadFormsJogadorEntrar.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível encerrar sua conta no momento, tente novamente mais tarde!\n{ex.Message}", "Erro ao encerrar conta");
            }
        }
    }
}