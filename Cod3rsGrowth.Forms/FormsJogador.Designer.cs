namespace Cod3rsGrowth.Forms
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
            labelNomeJogador = new Label();
            buttonSair = new Button();
            labelUsuarioJogador = new Label();
            labelQuantidadeDeBaralhosJogador = new Label();
            labelPrecoCartasTotalJogador = new Label();
            labelFiltroNome = new Label();
            textBoxFiltrarNome = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonEditarPerfil = new Button();
            buttonNovoBaralho = new Button();
            labelFiltros = new Label();
            numericUpDownMax = new NumericUpDown();
            labelFormatoDeJogo = new Label();
            labelPrecoMax = new Label();
            checkBoxBranco = new CheckBox();
            checkBoxAzul = new CheckBox();
            buttonAplicarFiltro = new Button();
            checkBoxPreto = new CheckBox();
            checkBoxFormatoPauper = new CheckBox();
            labelPrecoMin = new Label();
            checkBoxVerde = new CheckBox();
            checkBoxFormatoStandard = new CheckBox();
            labelPrecoBaralho = new Label();
            checkBoxFormatoCommander = new CheckBox();
            labelCor = new Label();
            checkBoxIncolor = new CheckBox();
            numericUpDownMin = new NumericUpDown();
            checkBoxVermelho = new CheckBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaralhoDoJogador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Nome
            // 
            resources.ApplyResources(Nome, "Nome");
            Nome.AutoEllipsis = true;
            Nome.FlatStyle = FlatStyle.System;
            Nome.Name = "Nome";
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
            // 
            // labelNome
            // 
            resources.ApplyResources(labelNome, "labelNome");
            labelNome.FlatStyle = FlatStyle.System;
            labelNome.Name = "labelNome";
            // 
            // labelUsername
            // 
            resources.ApplyResources(labelUsername, "labelUsername");
            labelUsername.FlatStyle = FlatStyle.System;
            labelUsername.Name = "labelUsername";
            // 
            // labelQuantidadeDeBaralhos
            // 
            resources.ApplyResources(labelQuantidadeDeBaralhos, "labelQuantidadeDeBaralhos");
            labelQuantidadeDeBaralhos.FlatStyle = FlatStyle.System;
            labelQuantidadeDeBaralhos.Name = "labelQuantidadeDeBaralhos";
            // 
            // labelPrecoTotalDeCartas
            // 
            resources.ApplyResources(labelPrecoTotalDeCartas, "labelPrecoTotalDeCartas");
            labelPrecoTotalDeCartas.FlatStyle = FlatStyle.System;
            labelPrecoTotalDeCartas.Name = "labelPrecoTotalDeCartas";
            // 
            // labelNomeJogador
            // 
            resources.ApplyResources(labelNomeJogador, "labelNomeJogador");
            labelNomeJogador.FlatStyle = FlatStyle.System;
            labelNomeJogador.Name = "labelNomeJogador";
            labelNomeJogador.BindingContextChanged += FormJogador_Load;
            labelNomeJogador.TextChanged += FormJogador_Load;
            labelNomeJogador.DataContextChanged += FormJogador_Load;
            // 
            // buttonSair
            // 
            resources.ApplyResources(buttonSair, "buttonSair");
            buttonSair.Name = "buttonSair";
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
            // 
            // labelUsuarioJogador
            // 
            resources.ApplyResources(labelUsuarioJogador, "labelUsuarioJogador");
            labelUsuarioJogador.FlatStyle = FlatStyle.System;
            labelUsuarioJogador.Name = "labelUsuarioJogador";
            // 
            // labelQuantidadeDeBaralhosJogador
            // 
            resources.ApplyResources(labelQuantidadeDeBaralhosJogador, "labelQuantidadeDeBaralhosJogador");
            labelQuantidadeDeBaralhosJogador.FlatStyle = FlatStyle.System;
            labelQuantidadeDeBaralhosJogador.Name = "labelQuantidadeDeBaralhosJogador";
            // 
            // labelPrecoCartasTotalJogador
            // 
            resources.ApplyResources(labelPrecoCartasTotalJogador, "labelPrecoCartasTotalJogador");
            labelPrecoCartasTotalJogador.FlatStyle = FlatStyle.System;
            labelPrecoCartasTotalJogador.Name = "labelPrecoCartasTotalJogador";
            // 
            // labelFiltroNome
            // 
            resources.ApplyResources(labelFiltroNome, "labelFiltroNome");
            labelFiltroNome.FlatStyle = FlatStyle.System;
            labelFiltroNome.Name = "labelFiltroNome";
            // 
            // textBoxFiltrarNome
            // 
            resources.ApplyResources(textBoxFiltrarNome, "textBoxFiltrarNome");
            textBoxFiltrarNome.Cursor = Cursors.Hand;
            textBoxFiltrarNome.Name = "textBoxFiltrarNome";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(labelNome);
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(labelPrecoCartasTotalJogador);
            panel1.Controls.Add(labelQuantidadeDeBaralhosJogador);
            panel1.Controls.Add(labelPrecoTotalDeCartas);
            panel1.Controls.Add(labelUsuarioJogador);
            panel1.Controls.Add(labelNomeJogador);
            panel1.Controls.Add(Nome);
            panel1.Controls.Add(labelQuantidadeDeBaralhos);
            panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(buttonEditarPerfil);
            panel2.Controls.Add(buttonNovoBaralho);
            panel2.Controls.Add(labelFiltros);
            panel2.Controls.Add(numericUpDownMax);
            panel2.Controls.Add(labelFormatoDeJogo);
            panel2.Controls.Add(labelPrecoMax);
            panel2.Controls.Add(checkBoxBranco);
            panel2.Controls.Add(checkBoxAzul);
            panel2.Controls.Add(buttonSair);
            panel2.Controls.Add(buttonAplicarFiltro);
            panel2.Controls.Add(checkBoxPreto);
            panel2.Controls.Add(checkBoxFormatoPauper);
            panel2.Controls.Add(labelPrecoMin);
            panel2.Controls.Add(checkBoxVerde);
            panel2.Controls.Add(checkBoxFormatoStandard);
            panel2.Controls.Add(labelPrecoBaralho);
            panel2.Controls.Add(checkBoxFormatoCommander);
            panel2.Controls.Add(labelCor);
            panel2.Controls.Add(checkBoxIncolor);
            panel2.Controls.Add(numericUpDownMin);
            panel2.Controls.Add(checkBoxVermelho);
            panel2.Name = "panel2";
            // 
            // buttonEditarPerfil
            // 
            resources.ApplyResources(buttonEditarPerfil, "buttonEditarPerfil");
            buttonEditarPerfil.Name = "buttonEditarPerfil";
            buttonEditarPerfil.UseVisualStyleBackColor = true;
            buttonEditarPerfil.Click += buttonEditarPerfil_Click;
            // 
            // buttonNovoBaralho
            // 
            resources.ApplyResources(buttonNovoBaralho, "buttonNovoBaralho");
            buttonNovoBaralho.Name = "buttonNovoBaralho";
            buttonNovoBaralho.UseVisualStyleBackColor = true;
            // 
            // labelFiltros
            // 
            resources.ApplyResources(labelFiltros, "labelFiltros");
            labelFiltros.FlatStyle = FlatStyle.System;
            labelFiltros.Name = "labelFiltros";
            // 
            // numericUpDownMax
            // 
            resources.ApplyResources(numericUpDownMax, "numericUpDownMax");
            numericUpDownMax.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownMax.Name = "numericUpDownMax";
            numericUpDownMax.Value = new decimal(new int[] { 99999999, 0, 0, 0 });
            // 
            // labelFormatoDeJogo
            // 
            resources.ApplyResources(labelFormatoDeJogo, "labelFormatoDeJogo");
            labelFormatoDeJogo.FlatStyle = FlatStyle.System;
            labelFormatoDeJogo.Name = "labelFormatoDeJogo";
            // 
            // labelPrecoMax
            // 
            resources.ApplyResources(labelPrecoMax, "labelPrecoMax");
            labelPrecoMax.FlatStyle = FlatStyle.System;
            labelPrecoMax.Name = "labelPrecoMax";
            // 
            // checkBoxBranco
            // 
            resources.ApplyResources(checkBoxBranco, "checkBoxBranco");
            checkBoxBranco.Name = "checkBoxBranco";
            checkBoxBranco.UseVisualStyleBackColor = true;
            // 
            // checkBoxAzul
            // 
            resources.ApplyResources(checkBoxAzul, "checkBoxAzul");
            checkBoxAzul.Name = "checkBoxAzul";
            checkBoxAzul.UseVisualStyleBackColor = true;
            // 
            // buttonAplicarFiltro
            // 
            resources.ApplyResources(buttonAplicarFiltro, "buttonAplicarFiltro");
            buttonAplicarFiltro.Name = "buttonAplicarFiltro";
            buttonAplicarFiltro.UseVisualStyleBackColor = true;
            // 
            // checkBoxPreto
            // 
            resources.ApplyResources(checkBoxPreto, "checkBoxPreto");
            checkBoxPreto.Name = "checkBoxPreto";
            checkBoxPreto.UseVisualStyleBackColor = true;
            // 
            // checkBoxFormatoPauper
            // 
            resources.ApplyResources(checkBoxFormatoPauper, "checkBoxFormatoPauper");
            checkBoxFormatoPauper.Name = "checkBoxFormatoPauper";
            checkBoxFormatoPauper.UseVisualStyleBackColor = true;
            // 
            // labelPrecoMin
            // 
            resources.ApplyResources(labelPrecoMin, "labelPrecoMin");
            labelPrecoMin.FlatStyle = FlatStyle.System;
            labelPrecoMin.Name = "labelPrecoMin";
            // 
            // checkBoxVerde
            // 
            resources.ApplyResources(checkBoxVerde, "checkBoxVerde");
            checkBoxVerde.Name = "checkBoxVerde";
            checkBoxVerde.UseVisualStyleBackColor = true;
            // 
            // checkBoxFormatoStandard
            // 
            resources.ApplyResources(checkBoxFormatoStandard, "checkBoxFormatoStandard");
            checkBoxFormatoStandard.Name = "checkBoxFormatoStandard";
            checkBoxFormatoStandard.UseVisualStyleBackColor = true;
            // 
            // labelPrecoBaralho
            // 
            resources.ApplyResources(labelPrecoBaralho, "labelPrecoBaralho");
            labelPrecoBaralho.FlatStyle = FlatStyle.System;
            labelPrecoBaralho.Name = "labelPrecoBaralho";
            // 
            // checkBoxFormatoCommander
            // 
            resources.ApplyResources(checkBoxFormatoCommander, "checkBoxFormatoCommander");
            checkBoxFormatoCommander.Name = "checkBoxFormatoCommander";
            checkBoxFormatoCommander.UseVisualStyleBackColor = true;
            // 
            // labelCor
            // 
            resources.ApplyResources(labelCor, "labelCor");
            labelCor.FlatStyle = FlatStyle.System;
            labelCor.Name = "labelCor";
            // 
            // checkBoxIncolor
            // 
            resources.ApplyResources(checkBoxIncolor, "checkBoxIncolor");
            checkBoxIncolor.Name = "checkBoxIncolor";
            checkBoxIncolor.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMin
            // 
            resources.ApplyResources(numericUpDownMin, "numericUpDownMin");
            numericUpDownMin.Cursor = Cursors.Hand;
            numericUpDownMin.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownMin.Name = "numericUpDownMin";
            // 
            // checkBoxVermelho
            // 
            resources.ApplyResources(checkBoxVermelho, "checkBoxVermelho");
            checkBoxVermelho.Name = "checkBoxVermelho";
            checkBoxVermelho.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.Controls.Add(textBoxFiltrarNome);
            panel3.Controls.Add(labelFiltroNome);
            panel3.Controls.Add(dataGridViewBaralhoDoJogador);
            panel3.Name = "panel3";
            // 
            // FormsJogador
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormsJogador";
            WindowState = FormWindowState.Maximized;
            Load += FormJogador_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaralhoDoJogador).EndInit();
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private Label labelNomeJogador;
        private Button buttonSair;
        private Label labelUsuarioJogador;
        private Label labelQuantidadeDeBaralhosJogador;
        private Label labelPrecoCartasTotalJogador;
        private Label labelFiltroNome;
        private TextBox textBoxFiltrarNome;
        private Panel panel1;
        private Panel panel2;
        private NumericUpDown numericUpDownMax;
        private Label labelFormatoDeJogo;
        private Label labelPrecoMax;
        private CheckBox checkBoxBranco;
        private CheckBox checkBoxAzul;
        private Button buttonAplicarFiltro;
        private CheckBox checkBoxPreto;
        private CheckBox checkBoxFormatoPauper;
        private Label labelPrecoMin;
        private CheckBox checkBoxVerde;
        private CheckBox checkBoxFormatoStandard;
        private Label labelPrecoBaralho;
        private CheckBox checkBoxFormatoCommander;
        private Label labelCor;
        private CheckBox checkBoxIncolor;
        private NumericUpDown numericUpDownMin;
        private CheckBox checkBoxVermelho;
        private Label labelFiltros;
        private Panel panel3;
        private Button buttonNovoBaralho;
        private Button buttonEditarPerfil;
    }
}