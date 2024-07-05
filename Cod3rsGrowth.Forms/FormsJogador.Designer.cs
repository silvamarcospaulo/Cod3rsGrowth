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
            groupFiltrar = new GroupBox();
            numericUpDownMax = new NumericUpDown();
            labelPrecoMax = new Label();
            buttonAplicarFiltro = new Button();
            labelPrecoMin = new Label();
            labelPrecoBaralho = new Label();
            checkBoxIncolor = new CheckBox();
            checkBoxVermelho = new CheckBox();
            labelCor = new Label();
            labelFormatoDeJogo = new Label();
            checkBoxVerde = new CheckBox();
            checkBoxPreto = new CheckBox();
            checkBoxBranco = new CheckBox();
            checkBoxAzul = new CheckBox();
            checkBoxFormatoPauper = new CheckBox();
            checkBoxFormatoStandard = new CheckBox();
            checkBoxFormatoCommander = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            labelFiltroNome = new Label();
            textBoxFiltrarNome = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaralhoDoJogador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource).BeginInit();
            groupFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Nome
            // 
            resources.ApplyResources(Nome, "Nome");
            Nome.AutoEllipsis = true;
            Nome.FlatStyle = FlatStyle.System;
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
            labelQuantidadeDeBaralhos.Name = "labelQuantidadeDeBaralhos";
            // 
            // labelPrecoTotalDeCartas
            // 
            resources.ApplyResources(labelPrecoTotalDeCartas, "labelPrecoTotalDeCartas");
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
            labelQuantidadeDeBaralhosJogador.Click += labelQuantidadeDeBaralhosJogador_Click;
            // 
            // labelPrecoCartasTotalJogador
            // 
            resources.ApplyResources(labelPrecoCartasTotalJogador, "labelPrecoCartasTotalJogador");
            labelPrecoCartasTotalJogador.FlatStyle = FlatStyle.System;
            labelPrecoCartasTotalJogador.Name = "labelPrecoCartasTotalJogador";
            // 
            // groupFiltrar
            // 
            resources.ApplyResources(groupFiltrar, "groupFiltrar");
            groupFiltrar.Controls.Add(numericUpDownMax);
            groupFiltrar.Controls.Add(labelPrecoMax);
            groupFiltrar.Controls.Add(buttonAplicarFiltro);
            groupFiltrar.Controls.Add(labelPrecoMin);
            groupFiltrar.Controls.Add(labelPrecoBaralho);
            groupFiltrar.Controls.Add(checkBoxIncolor);
            groupFiltrar.Controls.Add(checkBoxVermelho);
            groupFiltrar.Controls.Add(labelCor);
            groupFiltrar.Controls.Add(labelFormatoDeJogo);
            groupFiltrar.Controls.Add(checkBoxVerde);
            groupFiltrar.Controls.Add(checkBoxPreto);
            groupFiltrar.Controls.Add(checkBoxBranco);
            groupFiltrar.Controls.Add(checkBoxAzul);
            groupFiltrar.Controls.Add(checkBoxFormatoPauper);
            groupFiltrar.Controls.Add(checkBoxFormatoStandard);
            groupFiltrar.Controls.Add(checkBoxFormatoCommander);
            groupFiltrar.Controls.Add(numericUpDown1);
            groupFiltrar.FlatStyle = FlatStyle.System;
            groupFiltrar.ForeColor = SystemColors.ControlDarkDark;
            groupFiltrar.Name = "groupFiltrar";
            groupFiltrar.TabStop = false;
            // 
            // numericUpDownMax
            // 
            resources.ApplyResources(numericUpDownMax, "numericUpDownMax");
            numericUpDownMax.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownMax.Name = "numericUpDownMax";
            // 
            // labelPrecoMax
            // 
            resources.ApplyResources(labelPrecoMax, "labelPrecoMax");
            labelPrecoMax.Name = "labelPrecoMax";
            // 
            // buttonAplicarFiltro
            // 
            resources.ApplyResources(buttonAplicarFiltro, "buttonAplicarFiltro");
            buttonAplicarFiltro.Name = "buttonAplicarFiltro";
            buttonAplicarFiltro.UseVisualStyleBackColor = true;
            // 
            // labelPrecoMin
            // 
            resources.ApplyResources(labelPrecoMin, "labelPrecoMin");
            labelPrecoMin.FlatStyle = FlatStyle.System;
            labelPrecoMin.Name = "labelPrecoMin";
            // 
            // labelPrecoBaralho
            // 
            resources.ApplyResources(labelPrecoBaralho, "labelPrecoBaralho");
            labelPrecoBaralho.FlatStyle = FlatStyle.System;
            labelPrecoBaralho.Name = "labelPrecoBaralho";
            // 
            // checkBoxIncolor
            // 
            resources.ApplyResources(checkBoxIncolor, "checkBoxIncolor");
            checkBoxIncolor.Name = "checkBoxIncolor";
            checkBoxIncolor.UseVisualStyleBackColor = true;
            // 
            // checkBoxVermelho
            // 
            resources.ApplyResources(checkBoxVermelho, "checkBoxVermelho");
            checkBoxVermelho.Name = "checkBoxVermelho";
            checkBoxVermelho.UseVisualStyleBackColor = true;
            // 
            // labelCor
            // 
            resources.ApplyResources(labelCor, "labelCor");
            labelCor.FlatStyle = FlatStyle.System;
            labelCor.Name = "labelCor";
            // 
            // labelFormatoDeJogo
            // 
            resources.ApplyResources(labelFormatoDeJogo, "labelFormatoDeJogo");
            labelFormatoDeJogo.FlatStyle = FlatStyle.System;
            labelFormatoDeJogo.Name = "labelFormatoDeJogo";
            labelFormatoDeJogo.Click += labelFormatoDeJogo_Click;
            // 
            // checkBoxVerde
            // 
            resources.ApplyResources(checkBoxVerde, "checkBoxVerde");
            checkBoxVerde.Name = "checkBoxVerde";
            checkBoxVerde.UseVisualStyleBackColor = true;
            // 
            // checkBoxPreto
            // 
            resources.ApplyResources(checkBoxPreto, "checkBoxPreto");
            checkBoxPreto.Name = "checkBoxPreto";
            checkBoxPreto.UseVisualStyleBackColor = true;
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
            // checkBoxFormatoPauper
            // 
            resources.ApplyResources(checkBoxFormatoPauper, "checkBoxFormatoPauper");
            checkBoxFormatoPauper.Name = "checkBoxFormatoPauper";
            checkBoxFormatoPauper.UseVisualStyleBackColor = true;
            checkBoxFormatoPauper.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBoxFormatoStandard
            // 
            resources.ApplyResources(checkBoxFormatoStandard, "checkBoxFormatoStandard");
            checkBoxFormatoStandard.Name = "checkBoxFormatoStandard";
            checkBoxFormatoStandard.UseVisualStyleBackColor = true;
            // 
            // checkBoxFormatoCommander
            // 
            resources.ApplyResources(checkBoxFormatoCommander, "checkBoxFormatoCommander");
            checkBoxFormatoCommander.Name = "checkBoxFormatoCommander";
            checkBoxFormatoCommander.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(numericUpDown1, "numericUpDown1");
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.Cursor = Cursors.Hand;
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
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
            panel1.Controls.Add(Nome);
            panel1.Controls.Add(labelNome);
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(labelPrecoCartasTotalJogador);
            panel1.Controls.Add(labelQuantidadeDeBaralhos);
            panel1.Controls.Add(labelQuantidadeDeBaralhosJogador);
            panel1.Controls.Add(labelPrecoTotalDeCartas);
            panel1.Controls.Add(labelUsuarioJogador);
            panel1.Controls.Add(labelNomeJogador);
            panel1.Controls.Add(buttonSair);
            panel1.Name = "panel1";
            // 
            // FormsJogador
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxFiltrarNome);
            Controls.Add(labelFiltroNome);
            Controls.Add(groupFiltrar);
            Controls.Add(dataGridViewBaralhoDoJogador);
            Controls.Add(panel1);
            Name = "FormsJogador";
            WindowState = FormWindowState.Maximized;
            Load += FormJogador_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaralhoDoJogador).EndInit();
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource).EndInit();
            groupFiltrar.ResumeLayout(false);
            groupFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label labelNomeJogador;
        private Button buttonSair;
        private Label labelUsuarioJogador;
        private Label labelQuantidadeDeBaralhosJogador;
        private Label labelPrecoCartasTotalJogador;
        private GroupBox groupFiltrar;
        private CheckBox checkBoxVerde;
        private CheckBox checkBoxPreto;
        private CheckBox checkBoxBranco;
        private CheckBox checkBoxAzul;
        private CheckBox checkBoxFormatoPauper;
        private CheckBox checkBoxFormatoStandard;
        private CheckBox checkBoxFormatoCommander;
        private Label labelFormatoDeJogo;
        private Label labelCor;
        private CheckBox checkBoxIncolor;
        private CheckBox checkBoxVermelho;
        private Label labelPrecoBaralho;
        private Label labelPrecoMin;
        private Button buttonAplicarFiltro;
        private NumericUpDown numericUpDown1;
        private Label labelPrecoMax;
        private NumericUpDown numericUpDownMax;
        private Label labelFiltroNome;
        private TextBox textBoxFiltrarNome;
        private Panel panel1;
    }
}