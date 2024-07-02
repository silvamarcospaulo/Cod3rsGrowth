﻿using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;

namespace Cod3rsGrowth.Forms
{
    public partial class FormsJogadorEntrar : Form
    {
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private ConexaoDados conexaoDados;

        public FormsJogadorEntrar(CartaServico _cartaServico, BaralhoServico _baralhoServico,
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

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                var jogadorAutenticar = new Jogador() { NomeJogador = textBoxNome.Text, SenhaJogador = textBoxSenha.Text };
                var jogadorEntrar = new Jogador();
                AoClicarCarregarJogadorEmNovaJanela(jogadorEntrar);
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

        private void linkLabelCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormsJogadorCadastro(cartaServico, baralhoServico, jogadorServico, conexaoDados).Show();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}