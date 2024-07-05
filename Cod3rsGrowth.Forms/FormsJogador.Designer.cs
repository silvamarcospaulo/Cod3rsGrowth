﻿namespace Cod3rsGrowth.Forms
{
    partial class FormsJogador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsJogador));
            Nome = new Label();
            dataGridViewBaralhoDoJogador = new DataGridView();
            baralhoBindingSource = new BindingSource(components);
            labelNome = new Label();
            labelUsername = new Label();
            labelQuantidadeDeBaralhos = new Label();
            labelPrecoTotalDeCartas = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaralhoDoJogador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Nome
            // 
            resources.ApplyResources(Nome, "Nome");
            Nome.AutoEllipsis = true;
            Nome.Name = "Nome";
            Nome.Click += Nome_Click;
            // 
            // dataGridViewBaralhoDoJogador
            // 
            resources.ApplyResources(dataGridViewBaralhoDoJogador, "dataGridViewBaralhoDoJogador");
            dataGridViewBaralhoDoJogador.AllowUserToAddRows = false;
            dataGridViewBaralhoDoJogador.AllowUserToDeleteRows = false;
            dataGridViewBaralhoDoJogador.AutoGenerateColumns = false;
            dataGridViewBaralhoDoJogador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBaralhoDoJogador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBaralhoDoJogador.DataSource = baralhoBindingSource;
            dataGridViewBaralhoDoJogador.Name = "dataGridViewBaralhoDoJogador";
            dataGridViewBaralhoDoJogador.ReadOnly = true;
            dataGridViewBaralhoDoJogador.RowTemplate.Height = 25;
            dataGridViewBaralhoDoJogador.CellContentClick += dataGridViewBaralhoDoJogador_CellContentClick;
            // 
            // baralhoBindingSource
            // 
            baralhoBindingSource.CurrentChanged += baralhoBindingSource_CurrentChanged;
            // 
            // labelNome
            // 
            resources.ApplyResources(labelNome, "labelNome");
            labelNome.Name = "labelNome";
            // 
            // labelUsername
            // 
            resources.ApplyResources(labelUsername, "labelUsername");
            labelUsername.Name = "labelUsername";
            // 
            // labelQuantidadeDeBaralhos
            // 
            resources.ApplyResources(labelQuantidadeDeBaralhos, "labelQuantidadeDeBaralhos");
            labelQuantidadeDeBaralhos.Name = "labelQuantidadeDeBaralhos";
            // 
            // labelPrecoTotalDeCartas
            // 
            resources.ApplyResources(labelPrecoTotalDeCartas, "labelPrecoTotalDeCartas");
            labelPrecoTotalDeCartas.Name = "labelPrecoTotalDeCartas";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.BindingContextChanged += FormJogador_Load;
            label1.TextChanged += FormJogador_Load;
            label1.DataContextChanged += FormJogador_Load;
            // 
            // FormsJogador
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(labelPrecoTotalDeCartas);
            Controls.Add(labelQuantidadeDeBaralhos);
            Controls.Add(labelUsername);
            Controls.Add(labelNome);
            Controls.Add(dataGridViewBaralhoDoJogador);
            Controls.Add(Nome);
            Name = "FormsJogador";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormsJogador_FormClosing;
            Load += FormJogador_Load;
            Leave += FormsJogador_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaralhoDoJogador).EndInit();
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Nome;
        private BindingSource baralhoBindingSource;
        private Label labelNome;
        private DataGridView dataGridViewBaralhoDoJogador;
        private DataGridViewTextBoxColumn nomeBaralhoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formatoDeJogoBaralhoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn corBaralhoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoDoBaralhoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn custoDeManaConvertidoDoBaralhoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDeCartasNoBaralhoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeCriacaoBaralhoDataGridViewTextBoxColumn;
        private Label labelUsername;
        private Label labelQuantidadeDeBaralhos;
        private Label labelPrecoTotalDeCartas;
        private Label label1;
    }
}