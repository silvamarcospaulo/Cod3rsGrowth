using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Infra;
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
        private JogadorServico jogadorServico;
        private ConexaoDados conexaoDados;

        public FormJogador(JogadorServico _jogadorServico, ConexaoDados _conexaoDados)
        {
            jogadorServico = _jogadorServico;
            conexaoDados = _conexaoDados;
            InitializeComponent();
        }

        public void FormJogador_Load(object sender, EventArgs e)
        {
            var listaDeJogadores = jogadorServico.ObterTodos(new JogadorFiltro());

            dataGridViewJogador.DataSource = listaDeJogadores;

            dataGridViewJogador.Columns.Add(new DataGridViewTextBoxColumn());
        }

        private void dataGridViewJogador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
