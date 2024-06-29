namespace Cod3rsGrowth.Forms
{
    partial class Main
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
            cartaBindingSource = new BindingSource(components);
            dataGridViewCarta = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            custoDeManaConvertidoCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDeCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            raridadeCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            corCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Nome = new Label();
            buttonJogador = new Button();
            ((System.ComponentModel.ISupportInitialize)cartaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarta).BeginInit();
            SuspendLayout();
            // 
            // cartaBindingSource
            // 
            cartaBindingSource.DataSource = typeof(Dominio.Modelos.Carta);
            // 
            // dataGridViewCarta
            // 
            dataGridViewCarta.AllowUserToAddRows = false;
            dataGridViewCarta.AllowUserToDeleteRows = false;
            dataGridViewCarta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCarta.AutoGenerateColumns = false;
            dataGridViewCarta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCarta.BorderStyle = BorderStyle.None;
            dataGridViewCarta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarta.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeCartaDataGridViewTextBoxColumn, custoDeManaConvertidoCartaDataGridViewTextBoxColumn, tipoDeCartaDataGridViewTextBoxColumn, raridadeCartaDataGridViewTextBoxColumn, precoCartaDataGridViewTextBoxColumn, corCartaDataGridViewTextBoxColumn });
            dataGridViewCarta.DataSource = cartaBindingSource;
            dataGridViewCarta.GridColor = SystemColors.InactiveCaption;
            dataGridViewCarta.ImeMode = ImeMode.NoControl;
            dataGridViewCarta.Location = new Point(12, 119);
            dataGridViewCarta.Name = "dataGridViewCarta";
            dataGridViewCarta.RowTemplate.Height = 25;
            dataGridViewCarta.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewCarta.Size = new Size(1428, 627);
            dataGridViewCarta.TabIndex = 0;
            dataGridViewCarta.UseWaitCursor = true;
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
            // Nome
            // 
            Nome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Nome.AutoEllipsis = true;
            Nome.AutoSize = true;
            Nome.Font = new Font("Impact", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Nome.Location = new Point(259, 42);
            Nome.Name = "Nome";
            Nome.Size = new Size(312, 48);
            Nome.TabIndex = 1;
            Nome.Text = "MTG DeckBuilder";
            Nome.UseWaitCursor = true;
            // 
            // buttonJogador
            // 
            buttonJogador.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonJogador.Cursor = Cursors.Hand;
            buttonJogador.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            buttonJogador.FlatStyle = FlatStyle.System;
            buttonJogador.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            buttonJogador.Location = new Point(650, 42);
            buttonJogador.Name = "buttonJogador";
            buttonJogador.Size = new Size(138, 48);
            buttonJogador.TabIndex = 2;
            buttonJogador.Text = "Jogadores";
            buttonJogador.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonJogador.UseCompatibleTextRendering = true;
            buttonJogador.UseVisualStyleBackColor = true;
            buttonJogador.UseWaitCursor = true;
            buttonJogador.Click += buttonJogador_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 758);
            Controls.Add(buttonJogador);
            Controls.Add(Nome);
            Controls.Add(dataGridViewCarta);
            Name = "Main";
            Text = "DeckBuilder";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)cartaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource cartaBindingSource;
        private DataGridView dataGridViewCarta;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn custoDeManaConvertidoCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDeCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn raridadeCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn corCartaDataGridViewTextBoxColumn;
        private Label Nome;
        private Button buttonJogador;
    }
}
