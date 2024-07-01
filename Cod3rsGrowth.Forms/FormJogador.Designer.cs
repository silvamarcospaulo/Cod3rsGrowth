namespace Cod3rsGrowth.Forms
{
    partial class FormJogador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogador));
            Nome = new Label();
            baralhoBindingSource = new BindingSource(components);
            dataGridViewBaralho = new DataGridView();
            nomeBaralhoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DataDeCriacaoBaralho = new DataGridViewTextBoxColumn();
            QuantidadeDeCartasNoBaralho = new DataGridViewTextBoxColumn();
            PrecoDoBaralho = new DataGridViewTextBoxColumn();
            CustoDeManaConvertidoDoBaralho = new DataGridViewTextBoxColumn();
            formatoDeJogoBaralhoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            corBaralhoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaralho).BeginInit();
            SuspendLayout();
            // 
            // Nome
            // 
            resources.ApplyResources(Nome, "Nome");
            Nome.AutoEllipsis = true;
            Nome.Name = "Nome";
            // 
            // baralhoBindingSource
            // 
            baralhoBindingSource.DataSource = typeof(Dominio.Modelos.Baralho);
            // 
            // dataGridViewBaralho
            // 
            resources.ApplyResources(dataGridViewBaralho, "dataGridViewBaralho");
            dataGridViewBaralho.AllowUserToAddRows = false;
            dataGridViewBaralho.AllowUserToDeleteRows = false;
            dataGridViewBaralho.AutoGenerateColumns = false;
            dataGridViewBaralho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBaralho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBaralho.Columns.AddRange(new DataGridViewColumn[] { nomeBaralhoDataGridViewTextBoxColumn, DataDeCriacaoBaralho, QuantidadeDeCartasNoBaralho, PrecoDoBaralho, CustoDeManaConvertidoDoBaralho, formatoDeJogoBaralhoDataGridViewTextBoxColumn, corBaralhoDataGridViewTextBoxColumn });
            dataGridViewBaralho.DataSource = baralhoBindingSource;
            dataGridViewBaralho.Name = "dataGridViewBaralho";
            dataGridViewBaralho.ReadOnly = true;
            dataGridViewBaralho.RowTemplate.Height = 25;
            dataGridViewBaralho.CellContentClick += dataGridViewBaralho_CellContentClick;
            // 
            // nomeBaralhoDataGridViewTextBoxColumn
            // 
            nomeBaralhoDataGridViewTextBoxColumn.DataPropertyName = "NomeBaralho";
            resources.ApplyResources(nomeBaralhoDataGridViewTextBoxColumn, "nomeBaralhoDataGridViewTextBoxColumn");
            nomeBaralhoDataGridViewTextBoxColumn.Name = "nomeBaralhoDataGridViewTextBoxColumn";
            nomeBaralhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DataDeCriacaoBaralho
            // 
            DataDeCriacaoBaralho.DataPropertyName = "DataDeCriacaoBaralho";
            resources.ApplyResources(DataDeCriacaoBaralho, "DataDeCriacaoBaralho");
            DataDeCriacaoBaralho.Name = "DataDeCriacaoBaralho";
            DataDeCriacaoBaralho.ReadOnly = true;
            // 
            // QuantidadeDeCartasNoBaralho
            // 
            QuantidadeDeCartasNoBaralho.DataPropertyName = "QuantidadeDeCartasNoBaralho";
            resources.ApplyResources(QuantidadeDeCartasNoBaralho, "QuantidadeDeCartasNoBaralho");
            QuantidadeDeCartasNoBaralho.Name = "QuantidadeDeCartasNoBaralho";
            QuantidadeDeCartasNoBaralho.ReadOnly = true;
            // 
            // PrecoDoBaralho
            // 
            PrecoDoBaralho.DataPropertyName = "PrecoDoBaralho";
            resources.ApplyResources(PrecoDoBaralho, "PrecoDoBaralho");
            PrecoDoBaralho.Name = "PrecoDoBaralho";
            PrecoDoBaralho.ReadOnly = true;
            // 
            // CustoDeManaConvertidoDoBaralho
            // 
            CustoDeManaConvertidoDoBaralho.DataPropertyName = "CustoDeManaConvertidoDoBaralho";
            resources.ApplyResources(CustoDeManaConvertidoDoBaralho, "CustoDeManaConvertidoDoBaralho");
            CustoDeManaConvertidoDoBaralho.Name = "CustoDeManaConvertidoDoBaralho";
            CustoDeManaConvertidoDoBaralho.ReadOnly = true;
            // 
            // formatoDeJogoBaralhoDataGridViewTextBoxColumn
            // 
            formatoDeJogoBaralhoDataGridViewTextBoxColumn.DataPropertyName = "FormatoDeJogoBaralho";
            resources.ApplyResources(formatoDeJogoBaralhoDataGridViewTextBoxColumn, "formatoDeJogoBaralhoDataGridViewTextBoxColumn");
            formatoDeJogoBaralhoDataGridViewTextBoxColumn.Name = "formatoDeJogoBaralhoDataGridViewTextBoxColumn";
            formatoDeJogoBaralhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corBaralhoDataGridViewTextBoxColumn
            // 
            corBaralhoDataGridViewTextBoxColumn.DataPropertyName = "CorBaralho";
            resources.ApplyResources(corBaralhoDataGridViewTextBoxColumn, "corBaralhoDataGridViewTextBoxColumn");
            corBaralhoDataGridViewTextBoxColumn.Name = "corBaralhoDataGridViewTextBoxColumn";
            corBaralhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormJogador
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewBaralho);
            Controls.Add(Nome);
            Name = "FormJogador";
            WindowState = FormWindowState.Maximized;
            Load += FormJogador_Load;
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaralho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Nome;
        private BindingSource baralhoBindingSource;
        private DataGridView dataGridViewBaralho;
        private DataGridViewTextBoxColumn nomeBaralhoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DataDeCriacaoBaralho;
        private DataGridViewTextBoxColumn QuantidadeDeCartasNoBaralho;
        private DataGridViewTextBoxColumn PrecoDoBaralho;
        private DataGridViewTextBoxColumn CustoDeManaConvertidoDoBaralho;
        private DataGridViewTextBoxColumn formatoDeJogoBaralhoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn corBaralhoDataGridViewTextBoxColumn;
    }
}