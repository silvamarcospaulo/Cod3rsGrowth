﻿using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Cod3rsGrowth.Web.Controllers;
using FluentValidation;

namespace Cod3rsGrowth.Forms
{
    public partial class FormJogadorEditarPerfil : Form
    {
        private Jogador _jogador;
        private CartaServico _cartaServico;
        private BaralhoServico _baralhoServico;
        private JogadorServico _jogadorServico;
        private JwtServico _tokenServico;
        private LoginController _loginController;
        private Thread threadFormsJogadorEntrar;
        private DialogResult resposta;

        public FormJogadorEditarPerfil(CartaServico cartaServico, BaralhoServico baralhoServico, JogadorServico jogadorServico,
            JwtServico tokenServico, LoginController loginController, Jogador jogador)
        {
            _jogador = jogador;
            _cartaServico = cartaServico;
            _baralhoServico = baralhoServico;
            _jogadorServico = jogadorServico;
            _tokenServico = tokenServico;
            _loginController = loginController;
            InitializeComponent();
        }

        private void CarregarJogadorEditarPerfil(object sender, EventArgs e)
        {
            labelNomeJogador.Text = _jogador.NomeJogador;
            labelSobrenomeJogador.Text = _jogador.SobrenomeJogador;
            labelUsuarioJogador.Text = _jogador.UsuarioJogador;
            labelDataDeNascimentoJogador.Text = _jogador.DataNascimentoJogador.ToShortDateString();
        }

        private void AoClicarCancelaEdicaoDePerfil(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            threadFormsJogadorEntrar = new Thread(CarregarJanelaDeLogin);
            threadFormsJogadorEntrar.SetApartmentState(ApartmentState.STA);
            threadFormsJogadorEntrar.Start();
        }

        private void AoClicarEnviaAlteracoesDePerfil(object sender, EventArgs e)
        {
            var valorNulo = 0;

            _jogador.UsuarioJogador = textBoxNovoUsuario.Text.Length > valorNulo ? textBoxNovoUsuario.Text : null;
            _jogador.UsuarioConfirmacaoJogador = textBoxConfirmarNovoUsuario.Text.Length > valorNulo ? textBoxConfirmarNovoUsuario.Text : null;

            _jogador.SenhaHashJogador = textBoxNovaSenha.Text.Length > valorNulo ? textBoxNovaSenha.Text : null;
            _jogador.SenhaHashConfirmacaoJogador = textBoxConfirmarNovaSenha.Text.Length > valorNulo ? textBoxConfirmarNovaSenha.Text : null;

            try
            {
                _jogadorServico.Atualizar(_jogador);

                this.Close();
                threadFormsJogadorEntrar = new Thread(CarregarJanelaDeLogin);
                threadFormsJogadorEntrar.SetApartmentState(ApartmentState.STA);
                threadFormsJogadorEntrar.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarJanelaDeLogin(object obj)
        {
            Application.Run(new FormJogadorEntrar(_cartaServico, _baralhoServico, _jogadorServico, _tokenServico, _loginController));
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
                    threadFormsJogadorEntrar = new Thread(CarregarJanelaDeLogin);
                    threadFormsJogadorEntrar.SetApartmentState(ApartmentState.STA);
                    threadFormsJogadorEntrar.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível encerrar sua conta no momento, tente novamente mais tarde!\n{ex.Message}", "Erro ao encerrar conta");
            }
        }

        private void AoClicarVisualizaSenha(object sender, EventArgs e)
        {
            if (textBoxNovaSenha.UseSystemPasswordChar)
            {
                textBoxNovaSenha.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxNovaSenha.UseSystemPasswordChar = true;
            }
        }

        private void AoClicarVisualizaConfirmacaoDeSenha(object sender, EventArgs e)
        {
            if (textBoxConfirmarNovaSenha.UseSystemPasswordChar)
            {
                textBoxConfirmarNovaSenha.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxConfirmarNovaSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
