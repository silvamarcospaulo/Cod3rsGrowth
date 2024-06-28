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
            dataGridViewJogador = new DataGridView();
            jogadorBindingSource1 = new BindingSource(components);
            Nome = new Label();
            jogadorBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewJogador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jogadorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jogadorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewJogador
            // 
            dataGridViewJogador.AllowUserToAddRows = false;
            dataGridViewJogador.AllowUserToDeleteRows = false;
            dataGridViewJogador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewJogador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewJogador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJogador.DataBindings.Add(new Binding("DataContext", jogadorBindingSource1, "Id", true));
            dataGridViewJogador.Location = new Point(12, 119);
            dataGridViewJogador.Name = "dataGridViewJogador";
            dataGridViewJogador.ReadOnly = true;
            dataGridViewJogador.RowTemplate.Height = 25;
            dataGridViewJogador.Size = new Size(776, 319);
            dataGridViewJogador.TabIndex = 1;
            dataGridViewJogador.CellContentClick += dataGridViewJogador_CellContentClick;
            // 
            // jogadorBindingSource1
            // 
            jogadorBindingSource1.DataSource = typeof(Dominio.Modelos.Jogador);
            // 
            // Nome
            // 
            Nome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Nome.AutoEllipsis = true;
            Nome.AutoSize = true;
            Nome.Font = new Font("Impact", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Nome.Location = new Point(246, 39);
            Nome.Name = "Nome";
            Nome.Size = new Size(312, 48);
            Nome.TabIndex = 2;
            Nome.Text = "MTG DeckBuilder";
            // 
            // jogadorBindingSource
            // 
            jogadorBindingSource.DataSource = typeof(Dominio.Modelos.Jogador);
            // 
            // FormJogador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Nome);
            Controls.Add(dataGridViewJogador);
            Name = "FormJogador";
            Text = "FormJogador";
            Load += FormJogador_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewJogador).EndInit();
            ((System.ComponentModel.ISupportInitialize)jogadorBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)jogadorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewJogador;
        private Label Nome;
        private BindingSource jogadorBindingSource;
        private BindingSource jogadorBindingSource1;
    }
}