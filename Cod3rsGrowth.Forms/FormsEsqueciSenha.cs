﻿using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Cod3rsGrowth.Web.Controllers;

namespace Cod3rsGrowth.Forms
{
    public partial class FormsEsqueciSenha : Form
    {
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private JwtServico tokenServico;
        private ConexaoDados conexaoDados;
        private LoginController loginController;

        public FormsEsqueciSenha(CartaServico _cartaServico, BaralhoServico _baralhoServico,
            JogadorServico _jogadorServico, JwtServico _tokenServico, ConexaoDados _conexaoDados, LoginController _loginController)
        {
            cartaServico = _cartaServico;
            baralhoServico = _baralhoServico;
            jogadorServico = _jogadorServico;
            tokenServico = _tokenServico;
            conexaoDados = _conexaoDados;
            loginController = _loginController;
            InitializeComponent();
        }

        private void FormsEsqueciSenha_Load(object sender, EventArgs e)
        {

        }

        private void AoClicarCarregarJogadorEntrarEmNovaJanela()
        {
            this.Hide();
            new FormsJogadorEntrar(cartaServico, baralhoServico, jogadorServico, tokenServico, conexaoDados, loginController).Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AoClicarCarregarJogadorEntrarEmNovaJanela();
        }

        private void textBoxConfirmarNovaSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRedefinir_Click(object sender, EventArgs e)
        {

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
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

                var po = jogadorRestaurarSenha;

                jogadorServico.AlterarSenha(jogadorRestaurarSenha);

                AoClicarCarregarJogadorEntrarEmNovaJanela();
            }
            catch (Exception ex)
            {

            }
        }
    }
}