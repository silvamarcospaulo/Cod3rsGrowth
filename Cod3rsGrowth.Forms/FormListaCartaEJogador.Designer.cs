namespace Cod3rsGrowth.Forms
{
    partial class FormListaCartaEJogador
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewCarta = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            custoDeManaConvertidoCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDeCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            raridadeCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            corCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cartaBindingSource = new BindingSource(components);
            tabPage2 = new TabPage();
            dataGridViewJogador = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nomeJogadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataNascimentoJogadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoDasCartasJogadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDeBaralhosJogadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contaAtivaJogadorDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            jogadorBindingSource1 = new BindingSource(components);
            jogadorBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartaBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJogador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jogadorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jogadorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewCarta);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cartas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCarta
            // 
            dataGridViewCarta.AllowUserToAddRows = false;
            dataGridViewCarta.AllowUserToDeleteRows = false;
            dataGridViewCarta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCarta.AutoGenerateColumns = false;
            dataGridViewCarta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCarta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarta.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeCartaDataGridViewTextBoxColumn, custoDeManaConvertidoCartaDataGridViewTextBoxColumn, tipoDeCartaDataGridViewTextBoxColumn, raridadeCartaDataGridViewTextBoxColumn, precoCartaDataGridViewTextBoxColumn, corCartaDataGridViewTextBoxColumn });
            dataGridViewCarta.DataSource = cartaBindingSource;
            dataGridViewCarta.GridColor = SystemColors.InactiveCaption;
            dataGridViewCarta.ImeMode = ImeMode.NoControl;
            dataGridViewCarta.Location = new Point(6, 6);
            dataGridViewCarta.Name = "dataGridViewCarta";
            dataGridViewCarta.RowTemplate.Height = 25;
            dataGridViewCarta.Size = new Size(756, 386);
            dataGridViewCarta.TabIndex = 0;
            dataGridViewCarta.CellContentClick += dataGridViewCarta_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeCartaDataGridViewTextBoxColumn
            // 
            nomeCartaDataGridViewTextBoxColumn.DataPropertyName = "NomeCarta";
            nomeCartaDataGridViewTextBoxColumn.HeaderText = "NomeCarta";
            nomeCartaDataGridViewTextBoxColumn.Name = "nomeCartaDataGridViewTextBoxColumn";
            // 
            // custoDeManaConvertidoCartaDataGridViewTextBoxColumn
            // 
            custoDeManaConvertidoCartaDataGridViewTextBoxColumn.DataPropertyName = "CustoDeManaConvertidoCarta";
            custoDeManaConvertidoCartaDataGridViewTextBoxColumn.HeaderText = "CustoDeManaConvertidoCarta";
            custoDeManaConvertidoCartaDataGridViewTextBoxColumn.Name = "custoDeManaConvertidoCartaDataGridViewTextBoxColumn";
            // 
            // tipoDeCartaDataGridViewTextBoxColumn
            // 
            tipoDeCartaDataGridViewTextBoxColumn.DataPropertyName = "TipoDeCarta";
            tipoDeCartaDataGridViewTextBoxColumn.HeaderText = "TipoDeCarta";
            tipoDeCartaDataGridViewTextBoxColumn.Name = "tipoDeCartaDataGridViewTextBoxColumn";
            // 
            // raridadeCartaDataGridViewTextBoxColumn
            // 
            raridadeCartaDataGridViewTextBoxColumn.DataPropertyName = "RaridadeCarta";
            raridadeCartaDataGridViewTextBoxColumn.HeaderText = "RaridadeCarta";
            raridadeCartaDataGridViewTextBoxColumn.Name = "raridadeCartaDataGridViewTextBoxColumn";
            // 
            // precoCartaDataGridViewTextBoxColumn
            // 
            precoCartaDataGridViewTextBoxColumn.DataPropertyName = "PrecoCarta";
            precoCartaDataGridViewTextBoxColumn.HeaderText = "PrecoCarta";
            precoCartaDataGridViewTextBoxColumn.Name = "precoCartaDataGridViewTextBoxColumn";
            // 
            // corCartaDataGridViewTextBoxColumn
            // 
            corCartaDataGridViewTextBoxColumn.DataPropertyName = "CorCarta";
            corCartaDataGridViewTextBoxColumn.HeaderText = "CorCarta";
            corCartaDataGridViewTextBoxColumn.Name = "corCartaDataGridViewTextBoxColumn";
            // 
            // cartaBindingSource
            // 
            cartaBindingSource.DataSource = typeof(Dominio.Modelos.Carta);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewJogador);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Jogadores";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewJogador
            // 
            dataGridViewJogador.AllowUserToAddRows = false;
            dataGridViewJogador.AllowUserToDeleteRows = false;
            dataGridViewJogador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewJogador.AutoGenerateColumns = false;
            dataGridViewJogador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewJogador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJogador.ColumnHeadersVisible = false;
            dataGridViewJogador.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nomeJogadorDataGridViewTextBoxColumn, dataNascimentoJogadorDataGridViewTextBoxColumn, precoDasCartasJogadorDataGridViewTextBoxColumn, quantidadeDeBaralhosJogadorDataGridViewTextBoxColumn, contaAtivaJogadorDataGridViewCheckBoxColumn });
            dataGridViewJogador.DataSource = jogadorBindingSource1;
            dataGridViewJogador.Location = new Point(6, 6);
            dataGridViewJogador.Name = "dataGridViewJogador";
            dataGridViewJogador.ReadOnly = true;
            dataGridViewJogador.RowTemplate.Height = 25;
            dataGridViewJogador.Size = new Size(756, 386);
            dataGridViewJogador.TabIndex = 0;
            dataGridViewJogador.CellContentClick += dataGridViewJogador_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeJogadorDataGridViewTextBoxColumn
            // 
            nomeJogadorDataGridViewTextBoxColumn.DataPropertyName = "NomeJogador";
            nomeJogadorDataGridViewTextBoxColumn.HeaderText = "NomeJogador";
            nomeJogadorDataGridViewTextBoxColumn.Name = "nomeJogadorDataGridViewTextBoxColumn";
            nomeJogadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascimentoJogadorDataGridViewTextBoxColumn
            // 
            dataNascimentoJogadorDataGridViewTextBoxColumn.DataPropertyName = "DataNascimentoJogador";
            dataNascimentoJogadorDataGridViewTextBoxColumn.HeaderText = "DataNascimentoJogador";
            dataNascimentoJogadorDataGridViewTextBoxColumn.Name = "dataNascimentoJogadorDataGridViewTextBoxColumn";
            dataNascimentoJogadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDasCartasJogadorDataGridViewTextBoxColumn
            // 
            precoDasCartasJogadorDataGridViewTextBoxColumn.DataPropertyName = "PrecoDasCartasJogador";
            precoDasCartasJogadorDataGridViewTextBoxColumn.HeaderText = "PrecoDasCartasJogador";
            precoDasCartasJogadorDataGridViewTextBoxColumn.Name = "precoDasCartasJogadorDataGridViewTextBoxColumn";
            precoDasCartasJogadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDeBaralhosJogadorDataGridViewTextBoxColumn
            // 
            quantidadeDeBaralhosJogadorDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeDeBaralhosJogador";
            quantidadeDeBaralhosJogadorDataGridViewTextBoxColumn.HeaderText = "QuantidadeDeBaralhosJogador";
            quantidadeDeBaralhosJogadorDataGridViewTextBoxColumn.Name = "quantidadeDeBaralhosJogadorDataGridViewTextBoxColumn";
            quantidadeDeBaralhosJogadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contaAtivaJogadorDataGridViewCheckBoxColumn
            // 
            contaAtivaJogadorDataGridViewCheckBoxColumn.DataPropertyName = "ContaAtivaJogador";
            contaAtivaJogadorDataGridViewCheckBoxColumn.HeaderText = "ContaAtivaJogador";
            contaAtivaJogadorDataGridViewCheckBoxColumn.Name = "contaAtivaJogadorDataGridViewCheckBoxColumn";
            contaAtivaJogadorDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // jogadorBindingSource1
            // 
            jogadorBindingSource1.DataSource = typeof(Dominio.Modelos.Jogador);
            // 
            // jogadorBindingSource
            // 
            jogadorBindingSource.DataSource = typeof(Dominio.Modelos.Jogador);
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Dominio.Modelos.Carta);
            // 
            // FormListaCartaEJogador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormListaCartaEJogador";
            Text = "Form1";
            Load += Form1_Load_1;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarta).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartaBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewJogador).EndInit();
            ((System.ComponentModel.ISupportInitialize)jogadorBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)jogadorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private BindingSource jogadorBindingSource;
        private BindingSource bindingSource1;
        private DataGridView dataGridViewCarta;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn custoDeManaConvertidoCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDeCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn raridadeCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn corCartaDataGridViewTextBoxColumn;
        private BindingSource cartaBindingSource;
        private DataGridView dataGridViewJogador;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nomeJogadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataNascimentoJogadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoDasCartasJogadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDeBaralhosJogadorDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn contaAtivaJogadorDataGridViewCheckBoxColumn;
        private BindingSource jogadorBindingSource1;
    }
}
