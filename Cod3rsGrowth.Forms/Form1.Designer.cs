namespace Cod3rsGrowth.Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            cartaServicoBindingSource = new BindingSource(components);
            Nome = new DataGridViewTextBoxColumn();
            TipoDeCarta = new DataGridViewTextBoxColumn();
            CustoDeManaConvertido = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Raridade = new DataGridViewTextBoxColumn();
            Cor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartaServicoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, TipoDeCarta, CustoDeManaConvertido, Preco, Raridade, Cor });
            dataGridView1.DataSource = cartaServicoBindingSource;
            dataGridView1.Location = new Point(12, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 313);
            dataGridView1.TabIndex = 0;
            // 
            // cartaServicoBindingSource
            // 
            cartaServicoBindingSource.DataSource = typeof(Servico.ServicoCarta.CartaServico);
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // TipoDeCarta
            // 
            TipoDeCarta.HeaderText = "Tipo de Carta";
            TipoDeCarta.Name = "TipoDeCarta";
            TipoDeCarta.ReadOnly = true;
            // 
            // CustoDeManaConvertido
            // 
            CustoDeManaConvertido.HeaderText = "CMC";
            CustoDeManaConvertido.Name = "CustoDeManaConvertido";
            CustoDeManaConvertido.ReadOnly = true;
            // 
            // Preco
            // 
            Preco.HeaderText = "Preco";
            Preco.Name = "Preco";
            Preco.ReadOnly = true;
            // 
            // Raridade
            // 
            Raridade.HeaderText = "Raridade";
            Raridade.Name = "Raridade";
            Raridade.ReadOnly = true;
            // 
            // Cor
            // 
            Cor.HeaderText = "Cor";
            Cor.Name = "Cor";
            Cor.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartaServicoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn TipoDeCarta;
        private DataGridViewTextBoxColumn CustoDeManaConvertido;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Raridade;
        private DataGridViewTextBoxColumn Cor;
        private BindingSource cartaServicoBindingSource;
    }
}
