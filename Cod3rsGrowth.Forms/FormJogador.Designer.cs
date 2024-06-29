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
            resources.ApplyResources(dataGridViewJogador, "dataGridViewJogador");
            dataGridViewJogador.AllowUserToAddRows = false;
            dataGridViewJogador.AllowUserToDeleteRows = false;
            dataGridViewJogador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewJogador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJogador.DataBindings.Add(new Binding("DataContext", jogadorBindingSource1, "Id", true));
            dataGridViewJogador.Name = "dataGridViewJogador";
            dataGridViewJogador.ReadOnly = true;
            dataGridViewJogador.RowTemplate.Height = 25;
            dataGridViewJogador.CellContentClick += dataGridViewJogador_CellContentClick;
            // 
            // jogadorBindingSource1
            // 
            jogadorBindingSource1.DataSource = typeof(Dominio.Modelos.Jogador);
            // 
            // Nome
            // 
            resources.ApplyResources(Nome, "Nome");
            Nome.AutoEllipsis = true;
            Nome.Name = "Nome";
            // 
            // jogadorBindingSource
            // 
            jogadorBindingSource.DataSource = typeof(Dominio.Modelos.Jogador);
            // 
            // FormJogador
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Nome);
            Controls.Add(dataGridViewJogador);
            Name = "FormJogador";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormJogador_FormClosed;
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