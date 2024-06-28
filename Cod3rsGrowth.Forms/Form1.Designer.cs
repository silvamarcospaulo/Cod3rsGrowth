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
            dataGridCartas = new DataGridView();
            cartaServicoBindingSource = new BindingSource(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridJogador = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridCartas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartaServicoBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridJogador).BeginInit();
            SuspendLayout();
            // 
            // dataGridCartas
            // 
            dataGridCartas.AllowUserToAddRows = false;
            dataGridCartas.AllowUserToDeleteRows = false;
            dataGridCartas.AutoGenerateColumns = false;
            dataGridCartas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCartas.DataSource = cartaServicoBindingSource;
            dataGridCartas.Location = new Point(6, 6);
            dataGridCartas.Name = "dataGridCartas";
            dataGridCartas.ReadOnly = true;
            dataGridCartas.RowTemplate.Height = 25;
            dataGridCartas.Size = new Size(756, 386);
            dataGridCartas.TabIndex = 0;
            dataGridCartas.CellContentClick += dataGridCartas_CellContentClick;
            // 
            // cartaServicoBindingSource
            // 
            cartaServicoBindingSource.DataSource = typeof(Servico.ServicoCarta.CartaServico);
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
            tabPage1.Controls.Add(dataGridCartas);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cartas";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridJogador);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Jogadores";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridJogador
            // 
            dataGridJogador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJogador.Location = new Point(6, 6);
            dataGridJogador.Name = "dataGridJogador";
            dataGridJogador.RowTemplate.Height = 25;
            dataGridJogador.Size = new Size(756, 386);
            dataGridJogador.TabIndex = 0;
            dataGridJogador.CellContentClick += dataGridJogador_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridCartas).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartaServicoBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridJogador).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridCartas;
        private BindingSource cartaServicoBindingSource;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridJogador;
    }
}
