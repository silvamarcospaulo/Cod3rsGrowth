using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cod3rsGrowth.Forms
{
    public partial class FormJogador : Form
    {
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private ConexaoDados conexaoDados;
        private JogadorFiltro jogadorFiltro;

        public FormJogador(CartaServico _cartaServico, BaralhoServico _baralhoServico,
                JogadorServico _jogadorServico, ConexaoDados _conexaoDados, JogadorFiltro filtro)
        {
            jogadorFiltro = filtro;
            cartaServico = _cartaServico;
            baralhoServico = _baralhoServico;
            jogadorServico = _jogadorServico;
            conexaoDados = _conexaoDados;

            InitializeComponent();
        }

        public void FormJogador_Load(object sender, EventArgs e)
        {
            var listaDeJogadores = jogadorServico.ObterTodos(new JogadorFiltro());

            dataGridViewBaralho.DataSource = listaDeJogadores;

            dataGridViewBaralho.Columns.Add(new DataGridViewTextBoxColumn());
        }

        private void dataGridViewJogador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewBaralho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
