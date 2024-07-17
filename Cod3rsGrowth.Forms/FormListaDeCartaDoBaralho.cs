using Cod3rsGrowth.Dominio.Modelos;
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
    public partial class FormListaDeCartaDoBaralho : Form
    {
        private List<CopiaDeCartasNoBaralho> _copiaParcialDeCartas;
        private Jogador _jogador;

        public FormListaDeCartaDoBaralho(List<CopiaDeCartasNoBaralho> copiaParcialDeCartas, Jogador jogador)
        {
            _jogador = jogador;
            _copiaParcialDeCartas = copiaParcialDeCartas;
            InitializeComponent();
        }

        private void CarregarFormListaDeCartasDoBaralho(object sender, EventArgs e)
        {
            dataGridViewListaDeCartasDoBaralho.DataSource = _copiaParcialDeCartas;

        }
    }
}
