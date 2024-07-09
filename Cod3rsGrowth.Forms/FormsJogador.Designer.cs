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
            baralhoBindingSource = new BindingSource(components);
            labelDadosJogador = new Label();
            buttonSair = new Button();
            labelFiltroNome = new Label();
            textBoxFiltrarNome = new TextBox();
            panel1 = new Panel();
            labelMonteSeuBaralho = new Label();
            panel2 = new Panel();
            dateTimePickerDataMaxima = new DateTimePicker();
            dateTimePickerDataMinima = new DateTimePicker();
            labelDataDeCriacao = new Label();
            label2 = new Label();
            label3 = new Label();
            labelPrecoBaralho = new Label();
            labelMax = new Label();
            buttonLimparFiltro = new Button();
            buttonEditarPerfil = new Button();
            labelFiltros = new Label();
            buttonAplicarFiltro = new Button();
            numericUpDownMax = new NumericUpDown();
            labelFormatoDeJogo = new Label();
            labelPrecoMax = new Label();
            checkBoxBranco = new CheckBox();
            checkBoxAzul = new CheckBox();
            checkBoxPreto = new CheckBox();
            checkBoxFormatoPauper = new CheckBox();
            labelMin = new Label();
            labelPrecoMin = new Label();
            checkBoxVerde = new CheckBox();
            checkBoxFormatoStandard = new CheckBox();
            checkBoxFormatoCommander = new CheckBox();
            labelCor = new Label();
            checkBoxIncolor = new CheckBox();
            numericUpDownMin = new NumericUpDown();
            checkBoxVermelho = new CheckBox();
            panel3 = new Panel();
            dataGridViewBaralhos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            baralhoBindingSource1 = new BindingSource(components);
            buttonNovoBaralho = new Button();
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaralhos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // Nome
            // 
            resources.ApplyResources(Nome, "Nome");
            Nome.AutoEllipsis = true;
            Nome.FlatStyle = FlatStyle.System;
            Nome.Name = "Nome";
            // 
            // labelDadosJogador
            // 
            resources.ApplyResources(labelDadosJogador, "labelDadosJogador");
            labelDadosJogador.FlatStyle = FlatStyle.System;
            labelDadosJogador.ForeColor = SystemColors.ControlDarkDark;
            labelDadosJogador.Name = "labelDadosJogador";
            // 
            // buttonSair
            // 
            resources.ApplyResources(buttonSair, "buttonSair");
            buttonSair.Name = "buttonSair";
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
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
            textBoxFiltrarNome.TextChanged += textBoxFiltrarNome_TextChanged;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(labelMonteSeuBaralho);
            panel1.Controls.Add(labelDadosJogador);
            panel1.Controls.Add(Nome);
            panel1.Name = "panel1";
            // 
            // labelMonteSeuBaralho
            // 
            resources.ApplyResources(labelMonteSeuBaralho, "labelMonteSeuBaralho");
            labelMonteSeuBaralho.FlatStyle = FlatStyle.System;
            labelMonteSeuBaralho.ForeColor = SystemColors.ControlDarkDark;
            labelMonteSeuBaralho.Name = "labelMonteSeuBaralho";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(dateTimePickerDataMaxima);
            panel2.Controls.Add(dateTimePickerDataMinima);
            panel2.Controls.Add(labelDataDeCriacao);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(labelPrecoBaralho);
            panel2.Controls.Add(labelMax);
            panel2.Controls.Add(buttonLimparFiltro);
            panel2.Controls.Add(buttonEditarPerfil);
            panel2.Controls.Add(labelFiltros);
            panel2.Controls.Add(buttonAplicarFiltro);
            panel2.Controls.Add(numericUpDownMax);
            panel2.Controls.Add(labelFormatoDeJogo);
            panel2.Controls.Add(labelPrecoMax);
            panel2.Controls.Add(checkBoxBranco);
            panel2.Controls.Add(checkBoxAzul);
            panel2.Controls.Add(buttonSair);
            panel2.Controls.Add(checkBoxPreto);
            panel2.Controls.Add(checkBoxFormatoPauper);
            panel2.Controls.Add(labelMin);
            panel2.Controls.Add(labelPrecoMin);
            panel2.Controls.Add(checkBoxVerde);
            panel2.Controls.Add(checkBoxFormatoStandard);
            panel2.Controls.Add(checkBoxFormatoCommander);
            panel2.Controls.Add(labelCor);
            panel2.Controls.Add(checkBoxIncolor);
            panel2.Controls.Add(numericUpDownMin);
            panel2.Controls.Add(checkBoxVermelho);
            panel2.Name = "panel2";
            // 
            // dateTimePickerDataMaxima
            // 
            resources.ApplyResources(dateTimePickerDataMaxima, "dateTimePickerDataMaxima");
            dateTimePickerDataMaxima.Format = DateTimePickerFormat.Short;
            dateTimePickerDataMaxima.Name = "dateTimePickerDataMaxima";
            dateTimePickerDataMaxima.Value = new DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerDataMinima
            // 
            resources.ApplyResources(dateTimePickerDataMinima, "dateTimePickerDataMinima");
            dateTimePickerDataMinima.Format = DateTimePickerFormat.Short;
            dateTimePickerDataMinima.Name = "dateTimePickerDataMinima";
            dateTimePickerDataMinima.Value = new DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // labelDataDeCriacao
            // 
            resources.ApplyResources(labelDataDeCriacao, "labelDataDeCriacao");
            labelDataDeCriacao.FlatStyle = FlatStyle.System;
            labelDataDeCriacao.Name = "labelDataDeCriacao";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.FlatStyle = FlatStyle.System;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.FlatStyle = FlatStyle.System;
            label3.Name = "label3";
            // 
            // labelPrecoBaralho
            // 
            resources.ApplyResources(labelPrecoBaralho, "labelPrecoBaralho");
            labelPrecoBaralho.FlatStyle = FlatStyle.System;
            labelPrecoBaralho.Name = "labelPrecoBaralho";
            // 
            // labelMax
            // 
            resources.ApplyResources(labelMax, "labelMax");
            labelMax.FlatStyle = FlatStyle.System;
            labelMax.Name = "labelMax";
            // 
            // buttonLimparFiltro
            // 
            resources.ApplyResources(buttonLimparFiltro, "buttonLimparFiltro");
            buttonLimparFiltro.Name = "buttonLimparFiltro";
            buttonLimparFiltro.UseVisualStyleBackColor = true;
            buttonLimparFiltro.Click += buttonLimparFiltro_Click;
            // 
            // buttonEditarPerfil
            // 
            resources.ApplyResources(buttonEditarPerfil, "buttonEditarPerfil");
            buttonEditarPerfil.Name = "buttonEditarPerfil";
            buttonEditarPerfil.UseVisualStyleBackColor = true;
            buttonEditarPerfil.Click += buttonEditarPerfil_Click;
            // 
            // labelFiltros
            // 
            resources.ApplyResources(labelFiltros, "labelFiltros");
            labelFiltros.FlatStyle = FlatStyle.System;
            labelFiltros.Name = "labelFiltros";
            // 
            // buttonAplicarFiltro
            // 
            resources.ApplyResources(buttonAplicarFiltro, "buttonAplicarFiltro");
            buttonAplicarFiltro.Name = "buttonAplicarFiltro";
            buttonAplicarFiltro.UseVisualStyleBackColor = true;
            buttonAplicarFiltro.Click += buttonAplicarFiltro_Click;
            // 
            // numericUpDownMax
            // 
            resources.ApplyResources(numericUpDownMax, "numericUpDownMax");
            numericUpDownMax.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownMax.Name = "numericUpDownMax";
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
            // labelMin
            // 
            resources.ApplyResources(labelMin, "labelMin");
            labelMin.FlatStyle = FlatStyle.System;
            labelMin.Name = "labelMin";
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
            panel3.Controls.Add(dataGridViewBaralhos);
            panel3.Controls.Add(buttonNovoBaralho);
            panel3.Controls.Add(textBoxFiltrarNome);
            panel3.Controls.Add(labelFiltroNome);
            panel3.Name = "panel3";
            // 
            // dataGridViewBaralhos
            // 
            resources.ApplyResources(dataGridViewBaralhos, "dataGridViewBaralhos");
            dataGridViewBaralhos.AutoGenerateColumns = false;
            dataGridViewBaralhos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBaralhos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBaralhos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dataGridViewBaralhos.DataSource = baralhoBindingSource1;
            dataGridViewBaralhos.Name = "dataGridViewBaralhos";
            dataGridViewBaralhos.RowTemplate.Height = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "NomeBaralho";
            resources.ApplyResources(dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "DataDeCriacaoBaralho";
            resources.ApplyResources(dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "FormatoDeJogoBaralho";
            resources.ApplyResources(dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "QuantidadeDeCartasNoBaralho";
            resources.ApplyResources(dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "PrecoDoBaralho";
            resources.ApplyResources(dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "CustoDeManaConvertidoDoBaralho";
            resources.ApplyResources(dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "CorBaralho";
            resources.ApplyResources(dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // baralhoBindingSource1
            // 
            baralhoBindingSource1.DataSource = typeof(Dominio.Modelos.Baralho);
            // 
            // buttonNovoBaralho
            // 
            resources.ApplyResources(buttonNovoBaralho, "buttonNovoBaralho");
            buttonNovoBaralho.Name = "buttonNovoBaralho";
            buttonNovoBaralho.UseVisualStyleBackColor = true;
            buttonNovoBaralho.Click += buttonNovoBaralho_Click;
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(notifyIcon1, "notifyIcon1");
            // 
            // FormsJogador
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "FormsJogador";
            Load += FormJogador_Load;
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaralhos).EndInit();
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label Nome;
        private BindingSource baralhoBindingSource;
        private Label labelDadosJogador;
        private Button buttonSair;
        private Label labelFiltroNome;
        private TextBox textBoxFiltrarNome;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label labelPrecoMax;
        private Button buttonEditarPerfil;
        private Label labelFiltros;
        private Label labelFormatoDeJogo;
        private CheckBox checkBoxFormatoCommander;
        private CheckBox checkBoxFormatoPauper;
        private CheckBox checkBoxFormatoStandard;
        private Label labelCor;
        private CheckBox checkBoxAzul;
        private CheckBox checkBoxBranco;
        private CheckBox checkBoxIncolor;
        private CheckBox checkBoxPreto;
        private CheckBox checkBoxVerde;
        private CheckBox checkBoxVermelho;
        private Label labelPrecoBaralho;
        private Label labelPrecoMin;
        private Label labelMin;
        private Label labelMax;
        private NumericUpDown numericUpDownMin;
        private NumericUpDown numericUpDownMax;
        private Button buttonAplicarFiltro;
        private Button buttonLimparFiltro;
        private Label labelMonteSeuBaralho;
        private Button buttonNovoBaralho;
        private DataGridView dataGridViewBaralhos;
        private BindingSource baralhoBindingSource1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Label labelDataDeCriacao;
        private Label label2;
        private Label label3;
        private NotifyIcon notifyIcon1;
        private DateTimePicker dateTimePickerDataMinima;
        private DateTimePicker dateTimePickerDataMaxima;
    }
}