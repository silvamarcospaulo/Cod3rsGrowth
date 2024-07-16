namespace Cod3rsGrowth.Forms
{
    partial class FormNovoBaralho
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
            panel1 = new Panel();
            numericUpDownCmc = new NumericUpDown();
            checkBoxTipoDeCartaEncantamento = new CheckBox();
            checkBoxTipoDeCartaMagicaInstantanea = new CheckBox();
            checkBoxTipoDeCartaFeitico = new CheckBox();
            labelDataDeCriacao = new Label();
            labelPrecoCarta = new Label();
            labelMax = new Label();
            buttonLimparFiltro = new Button();
            labelFiltros = new Label();
            buttonAplicarFiltro = new Button();
            numericUpDownMax = new NumericUpDown();
            labelTipoDeCarta = new Label();
            checkBoxBranco = new CheckBox();
            checkBoxAzul = new CheckBox();
            checkBoxPreto = new CheckBox();
            checkBoxTipoDeCartaTerrenoBasico = new CheckBox();
            labelMin = new Label();
            checkBoxVerde = new CheckBox();
            checkBoxTipoDeCartaTerreno = new CheckBox();
            checkBoxTipoDeCartaCriatura = new CheckBox();
            labelCor = new Label();
            checkBoxIncolor = new CheckBox();
            numericUpDownMin = new NumericUpDown();
            checkBoxVermelho = new CheckBox();
            panel2 = new Panel();
            dataGridViewCartas = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            AdicionarAoBaralho = new DataGridViewTextBoxColumn();
            textBoxFiltrarNome = new TextBox();
            labelFiltroNome = new Label();
            cartaBindingSource = new BindingSource(components);
            panel3 = new Panel();
            labelCorParcial = new Label();
            buttonCandelar = new Button();
            labelPrecoParcial = new Label();
            buttonCriarBaralho = new Button();
            labelCustoParcial = new Label();
            labelQuantidadeParcial = new Label();
            pictureBox1 = new PictureBox();
            comboBoxFormato = new ComboBox();
            baralhoBindingSource = new BindingSource(components);
            labelNome = new Label();
            textBoxNomeBaralho = new TextBox();
            labelFormato = new Label();
            labelCorBaralho = new Label();
            labelQuantidadeDeCartas = new Label();
            labelPreco = new Label();
            labelCmc = new Label();
            cartaBindingSource1 = new BindingSource(components);
            labelRaridade = new Label();
            checkBoxRaridadeComum = new CheckBox();
            checkBoxRaridadeIncomum = new CheckBox();
            checkBoxRaridadeRara = new CheckBox();
            checkBoxRaridadeMitica = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCmc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCartas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartaBindingSource).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartaBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxRaridadeMitica);
            panel1.Controls.Add(checkBoxRaridadeRara);
            panel1.Controls.Add(checkBoxRaridadeIncomum);
            panel1.Controls.Add(checkBoxRaridadeComum);
            panel1.Controls.Add(labelRaridade);
            panel1.Controls.Add(numericUpDownCmc);
            panel1.Controls.Add(checkBoxTipoDeCartaEncantamento);
            panel1.Controls.Add(checkBoxTipoDeCartaMagicaInstantanea);
            panel1.Controls.Add(checkBoxTipoDeCartaFeitico);
            panel1.Controls.Add(labelDataDeCriacao);
            panel1.Controls.Add(labelPrecoCarta);
            panel1.Controls.Add(labelMax);
            panel1.Controls.Add(buttonLimparFiltro);
            panel1.Controls.Add(labelFiltros);
            panel1.Controls.Add(buttonAplicarFiltro);
            panel1.Controls.Add(numericUpDownMax);
            panel1.Controls.Add(labelTipoDeCarta);
            panel1.Controls.Add(checkBoxBranco);
            panel1.Controls.Add(checkBoxAzul);
            panel1.Controls.Add(checkBoxPreto);
            panel1.Controls.Add(checkBoxTipoDeCartaTerrenoBasico);
            panel1.Controls.Add(labelMin);
            panel1.Controls.Add(checkBoxVerde);
            panel1.Controls.Add(checkBoxTipoDeCartaTerreno);
            panel1.Controls.Add(checkBoxTipoDeCartaCriatura);
            panel1.Controls.Add(labelCor);
            panel1.Controls.Add(checkBoxIncolor);
            panel1.Controls.Add(numericUpDownMin);
            panel1.Controls.Add(checkBoxVermelho);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(808, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 601);
            panel1.TabIndex = 0;
            // 
            // numericUpDownCmc
            // 
            numericUpDownCmc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDownCmc.Location = new Point(7, 505);
            numericUpDownCmc.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownCmc.Name = "numericUpDownCmc";
            numericUpDownCmc.Size = new Size(185, 23);
            numericUpDownCmc.TabIndex = 16;
            numericUpDownCmc.TextAlign = HorizontalAlignment.Right;
            // 
            // checkBoxTipoDeCartaEncantamento
            // 
            checkBoxTipoDeCartaEncantamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxTipoDeCartaEncantamento.FlatStyle = FlatStyle.System;
            checkBoxTipoDeCartaEncantamento.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTipoDeCartaEncantamento.ImeMode = ImeMode.NoControl;
            checkBoxTipoDeCartaEncantamento.Location = new Point(7, 207);
            checkBoxTipoDeCartaEncantamento.Name = "checkBoxTipoDeCartaEncantamento";
            checkBoxTipoDeCartaEncantamento.Size = new Size(101, 24);
            checkBoxTipoDeCartaEncantamento.TabIndex = 7;
            checkBoxTipoDeCartaEncantamento.Tag = "";
            checkBoxTipoDeCartaEncantamento.Text = "Encantamento";
            checkBoxTipoDeCartaEncantamento.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoDeCartaMagicaInstantanea
            // 
            checkBoxTipoDeCartaMagicaInstantanea.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxTipoDeCartaMagicaInstantanea.FlatStyle = FlatStyle.System;
            checkBoxTipoDeCartaMagicaInstantanea.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTipoDeCartaMagicaInstantanea.ImeMode = ImeMode.NoControl;
            checkBoxTipoDeCartaMagicaInstantanea.Location = new Point(7, 179);
            checkBoxTipoDeCartaMagicaInstantanea.Name = "checkBoxTipoDeCartaMagicaInstantanea";
            checkBoxTipoDeCartaMagicaInstantanea.Size = new Size(131, 24);
            checkBoxTipoDeCartaMagicaInstantanea.TabIndex = 6;
            checkBoxTipoDeCartaMagicaInstantanea.Tag = "";
            checkBoxTipoDeCartaMagicaInstantanea.Text = "Magica Instantânea";
            checkBoxTipoDeCartaMagicaInstantanea.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoDeCartaFeitico
            // 
            checkBoxTipoDeCartaFeitico.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxTipoDeCartaFeitico.FlatStyle = FlatStyle.System;
            checkBoxTipoDeCartaFeitico.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTipoDeCartaFeitico.ImeMode = ImeMode.NoControl;
            checkBoxTipoDeCartaFeitico.Location = new Point(7, 151);
            checkBoxTipoDeCartaFeitico.Name = "checkBoxTipoDeCartaFeitico";
            checkBoxTipoDeCartaFeitico.Size = new Size(89, 24);
            checkBoxTipoDeCartaFeitico.TabIndex = 5;
            checkBoxTipoDeCartaFeitico.Tag = "";
            checkBoxTipoDeCartaFeitico.Text = "Feitiço";
            checkBoxTipoDeCartaFeitico.UseVisualStyleBackColor = true;
            // 
            // labelDataDeCriacao
            // 
            labelDataDeCriacao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelDataDeCriacao.FlatStyle = FlatStyle.System;
            labelDataDeCriacao.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelDataDeCriacao.ImeMode = ImeMode.NoControl;
            labelDataDeCriacao.Location = new Point(7, 482);
            labelDataDeCriacao.Name = "labelDataDeCriacao";
            labelDataDeCriacao.Size = new Size(179, 19);
            labelDataDeCriacao.TabIndex = 0;
            labelDataDeCriacao.Text = "Custo de mana convetido:";
            labelDataDeCriacao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPrecoCarta
            // 
            labelPrecoCarta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelPrecoCarta.FlatStyle = FlatStyle.System;
            labelPrecoCarta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrecoCarta.ImeMode = ImeMode.NoControl;
            labelPrecoCarta.Location = new Point(7, 421);
            labelPrecoCarta.Name = "labelPrecoCarta";
            labelPrecoCarta.Size = new Size(130, 19);
            labelPrecoCarta.TabIndex = 0;
            labelPrecoCarta.Text = "Preço:";
            labelPrecoCarta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelMax
            // 
            labelMax.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelMax.FlatStyle = FlatStyle.System;
            labelMax.ImeMode = ImeMode.NoControl;
            labelMax.Location = new Point(7, 463);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(30, 15);
            labelMax.TabIndex = 2250;
            labelMax.Text = "Max";
            // 
            // buttonLimparFiltro
            // 
            buttonLimparFiltro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLimparFiltro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonLimparFiltro.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimparFiltro.ImeMode = ImeMode.NoControl;
            buttonLimparFiltro.Location = new Point(7, 564);
            buttonLimparFiltro.Name = "buttonLimparFiltro";
            buttonLimparFiltro.Size = new Size(185, 25);
            buttonLimparFiltro.TabIndex = 18;
            buttonLimparFiltro.Text = "Limpar filtro";
            buttonLimparFiltro.UseVisualStyleBackColor = true;
            buttonLimparFiltro.Click += AoClicarLimpaSelecaoDeFiltros;
            // 
            // labelFiltros
            // 
            labelFiltros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelFiltros.FlatStyle = FlatStyle.System;
            labelFiltros.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelFiltros.ImeMode = ImeMode.NoControl;
            labelFiltros.Location = new Point(69, 10);
            labelFiltros.Name = "labelFiltros";
            labelFiltros.Size = new Size(71, 30);
            labelFiltros.TabIndex = 0;
            labelFiltros.Text = "Filtros";
            labelFiltros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAplicarFiltro
            // 
            buttonAplicarFiltro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAplicarFiltro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAplicarFiltro.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAplicarFiltro.ImeMode = ImeMode.NoControl;
            buttonAplicarFiltro.Location = new Point(7, 537);
            buttonAplicarFiltro.Name = "buttonAplicarFiltro";
            buttonAplicarFiltro.Size = new Size(185, 25);
            buttonAplicarFiltro.TabIndex = 17;
            buttonAplicarFiltro.Text = "Aplicar filtro";
            buttonAplicarFiltro.UseVisualStyleBackColor = true;
            buttonAplicarFiltro.Click += AoClicarAplicaSelecaoDeFiltros;
            // 
            // numericUpDownMax
            // 
            numericUpDownMax.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDownMax.Location = new Point(47, 460);
            numericUpDownMax.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownMax.Name = "numericUpDownMax";
            numericUpDownMax.Size = new Size(145, 23);
            numericUpDownMax.TabIndex = 15;
            numericUpDownMax.TextAlign = HorizontalAlignment.Right;
            // 
            // labelTipoDeCarta
            // 
            labelTipoDeCarta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTipoDeCarta.FlatStyle = FlatStyle.System;
            labelTipoDeCarta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoDeCarta.ImeMode = ImeMode.NoControl;
            labelTipoDeCarta.Location = new Point(7, 44);
            labelTipoDeCarta.Name = "labelTipoDeCarta";
            labelTipoDeCarta.Size = new Size(128, 19);
            labelTipoDeCarta.TabIndex = 0;
            labelTipoDeCarta.Text = "Tipo de carta:";
            labelTipoDeCarta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxBranco
            // 
            checkBoxBranco.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxBranco.FlatStyle = FlatStyle.System;
            checkBoxBranco.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxBranco.ImeMode = ImeMode.NoControl;
            checkBoxBranco.Location = new Point(94, 258);
            checkBoxBranco.Name = "checkBoxBranco";
            checkBoxBranco.Size = new Size(76, 24);
            checkBoxBranco.TabIndex = 9;
            checkBoxBranco.Tag = "Branco";
            checkBoxBranco.Text = "Branco";
            checkBoxBranco.UseVisualStyleBackColor = true;
            // 
            // checkBoxAzul
            // 
            checkBoxAzul.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxAzul.FlatStyle = FlatStyle.System;
            checkBoxAzul.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAzul.ImeMode = ImeMode.NoControl;
            checkBoxAzul.Location = new Point(7, 258);
            checkBoxAzul.Name = "checkBoxAzul";
            checkBoxAzul.Size = new Size(60, 24);
            checkBoxAzul.TabIndex = 8;
            checkBoxAzul.Tag = "Azul";
            checkBoxAzul.Text = "Azul";
            checkBoxAzul.UseVisualStyleBackColor = true;
            // 
            // checkBoxPreto
            // 
            checkBoxPreto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxPreto.FlatStyle = FlatStyle.System;
            checkBoxPreto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxPreto.ImeMode = ImeMode.NoControl;
            checkBoxPreto.Location = new Point(94, 286);
            checkBoxPreto.Name = "checkBoxPreto";
            checkBoxPreto.Size = new Size(67, 24);
            checkBoxPreto.TabIndex = 11;
            checkBoxPreto.Text = "Preto";
            checkBoxPreto.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoDeCartaTerrenoBasico
            // 
            checkBoxTipoDeCartaTerrenoBasico.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxTipoDeCartaTerrenoBasico.FlatStyle = FlatStyle.System;
            checkBoxTipoDeCartaTerrenoBasico.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTipoDeCartaTerrenoBasico.ImeMode = ImeMode.NoControl;
            checkBoxTipoDeCartaTerrenoBasico.Location = new Point(7, 95);
            checkBoxTipoDeCartaTerrenoBasico.Name = "checkBoxTipoDeCartaTerrenoBasico";
            checkBoxTipoDeCartaTerrenoBasico.Size = new Size(118, 24);
            checkBoxTipoDeCartaTerrenoBasico.TabIndex = 3;
            checkBoxTipoDeCartaTerrenoBasico.Tag = "";
            checkBoxTipoDeCartaTerrenoBasico.Text = "Terreno Básico";
            checkBoxTipoDeCartaTerrenoBasico.UseVisualStyleBackColor = true;
            // 
            // labelMin
            // 
            labelMin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelMin.FlatStyle = FlatStyle.System;
            labelMin.ImeMode = ImeMode.NoControl;
            labelMin.Location = new Point(7, 444);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(28, 15);
            labelMin.TabIndex = 2235;
            labelMin.Text = "Min";
            labelMin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxVerde
            // 
            checkBoxVerde.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxVerde.FlatStyle = FlatStyle.System;
            checkBoxVerde.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxVerde.ImeMode = ImeMode.NoControl;
            checkBoxVerde.Location = new Point(7, 314);
            checkBoxVerde.Name = "checkBoxVerde";
            checkBoxVerde.Size = new Size(69, 24);
            checkBoxVerde.TabIndex = 12;
            checkBoxVerde.Text = "Verde";
            checkBoxVerde.UseVisualStyleBackColor = true;
            checkBoxVerde.CheckedChanged += checkBoxVerde_CheckedChanged;
            // 
            // checkBoxTipoDeCartaTerreno
            // 
            checkBoxTipoDeCartaTerreno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxTipoDeCartaTerreno.FlatStyle = FlatStyle.System;
            checkBoxTipoDeCartaTerreno.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTipoDeCartaTerreno.ImeMode = ImeMode.NoControl;
            checkBoxTipoDeCartaTerreno.Location = new Point(7, 123);
            checkBoxTipoDeCartaTerreno.Name = "checkBoxTipoDeCartaTerreno";
            checkBoxTipoDeCartaTerreno.Size = new Size(89, 24);
            checkBoxTipoDeCartaTerreno.TabIndex = 4;
            checkBoxTipoDeCartaTerreno.Tag = "";
            checkBoxTipoDeCartaTerreno.Text = "Terreno";
            checkBoxTipoDeCartaTerreno.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoDeCartaCriatura
            // 
            checkBoxTipoDeCartaCriatura.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxTipoDeCartaCriatura.FlatStyle = FlatStyle.System;
            checkBoxTipoDeCartaCriatura.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTipoDeCartaCriatura.ImeMode = ImeMode.NoControl;
            checkBoxTipoDeCartaCriatura.Location = new Point(7, 67);
            checkBoxTipoDeCartaCriatura.Name = "checkBoxTipoDeCartaCriatura";
            checkBoxTipoDeCartaCriatura.Size = new Size(110, 24);
            checkBoxTipoDeCartaCriatura.TabIndex = 2;
            checkBoxTipoDeCartaCriatura.Tag = "";
            checkBoxTipoDeCartaCriatura.Text = "Criatura";
            checkBoxTipoDeCartaCriatura.UseVisualStyleBackColor = true;
            // 
            // labelCor
            // 
            labelCor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelCor.FlatStyle = FlatStyle.System;
            labelCor.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCor.ImeMode = ImeMode.NoControl;
            labelCor.Location = new Point(7, 235);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(38, 19);
            labelCor.TabIndex = 0;
            labelCor.Text = "Cor:";
            labelCor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxIncolor
            // 
            checkBoxIncolor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxIncolor.FlatStyle = FlatStyle.System;
            checkBoxIncolor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIncolor.ImeMode = ImeMode.NoControl;
            checkBoxIncolor.Location = new Point(7, 286);
            checkBoxIncolor.Name = "checkBoxIncolor";
            checkBoxIncolor.Size = new Size(76, 24);
            checkBoxIncolor.TabIndex = 10;
            checkBoxIncolor.Text = "Incolor";
            checkBoxIncolor.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMin
            // 
            numericUpDownMin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDownMin.Cursor = Cursors.Hand;
            numericUpDownMin.Location = new Point(47, 434);
            numericUpDownMin.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownMin.Name = "numericUpDownMin";
            numericUpDownMin.Size = new Size(145, 23);
            numericUpDownMin.TabIndex = 14;
            numericUpDownMin.TextAlign = HorizontalAlignment.Right;
            // 
            // checkBoxVermelho
            // 
            checkBoxVermelho.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxVermelho.FlatStyle = FlatStyle.System;
            checkBoxVermelho.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxVermelho.ImeMode = ImeMode.NoControl;
            checkBoxVermelho.Location = new Point(94, 314);
            checkBoxVermelho.Name = "checkBoxVermelho";
            checkBoxVermelho.Size = new Size(92, 24);
            checkBoxVermelho.TabIndex = 13;
            checkBoxVermelho.Text = "Vermelho";
            checkBoxVermelho.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewCartas);
            panel2.Controls.Add(textBoxFiltrarNome);
            panel2.Controls.Add(labelFiltroNome);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 601);
            panel2.TabIndex = 1;
            // 
            // dataGridViewCartas
            // 
            dataGridViewCartas.AllowUserToAddRows = false;
            dataGridViewCartas.AllowUserToDeleteRows = false;
            dataGridViewCartas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCartas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCartas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCartas.Columns.AddRange(new DataGridViewColumn[] { Nome, Quantidade, AdicionarAoBaralho });
            dataGridViewCartas.Location = new Point(3, 48);
            dataGridViewCartas.Name = "dataGridViewCartas";
            dataGridViewCartas.RowTemplate.Height = 25;
            dataGridViewCartas.Size = new Size(602, 541);
            dataGridViewCartas.TabIndex = 4;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Resizable = DataGridViewTriState.False;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // AdicionarAoBaralho
            // 
            AdicionarAoBaralho.HeaderText = "Adicionar ao Baralho";
            AdicionarAoBaralho.Name = "AdicionarAoBaralho";
            // 
            // textBoxFiltrarNome
            // 
            textBoxFiltrarNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFiltrarNome.Cursor = Cursors.Hand;
            textBoxFiltrarNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFiltrarNome.Location = new Point(117, 13);
            textBoxFiltrarNome.Name = "textBoxFiltrarNome";
            textBoxFiltrarNome.Size = new Size(488, 25);
            textBoxFiltrarNome.TabIndex = 1;
            // 
            // labelFiltroNome
            // 
            labelFiltroNome.FlatStyle = FlatStyle.System;
            labelFiltroNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelFiltroNome.ImeMode = ImeMode.NoControl;
            labelFiltroNome.Location = new Point(3, 16);
            labelFiltroNome.Name = "labelFiltroNome";
            labelFiltroNome.Size = new Size(119, 19);
            labelFiltroNome.TabIndex = 0;
            labelFiltroNome.Text = "Nome do Baralho:";
            labelFiltroNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cartaBindingSource
            // 
            cartaBindingSource.DataSource = typeof(Dominio.Modelos.Carta);
            // 
            // panel3
            // 
            panel3.Controls.Add(labelCorParcial);
            panel3.Controls.Add(buttonCandelar);
            panel3.Controls.Add(labelPrecoParcial);
            panel3.Controls.Add(buttonCriarBaralho);
            panel3.Controls.Add(labelCustoParcial);
            panel3.Controls.Add(labelQuantidadeParcial);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(comboBoxFormato);
            panel3.Controls.Add(labelNome);
            panel3.Controls.Add(textBoxNomeBaralho);
            panel3.Controls.Add(labelFormato);
            panel3.Controls.Add(labelCorBaralho);
            panel3.Controls.Add(labelQuantidadeDeCartas);
            panel3.Controls.Add(labelPreco);
            panel3.Controls.Add(labelCmc);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 601);
            panel3.TabIndex = 2;
            // 
            // labelCorParcial
            // 
            labelCorParcial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelCorParcial.AutoSize = true;
            labelCorParcial.FlatStyle = FlatStyle.System;
            labelCorParcial.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorParcial.Location = new Point(8, 536);
            labelCorParcial.Name = "labelCorParcial";
            labelCorParcial.Size = new Size(198, 15);
            labelCorParcial.TabIndex = 24;
            labelCorParcial.Text = "Azul, Verde, Branco, Preto, Vermelho";
            labelCorParcial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCandelar
            // 
            buttonCandelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCandelar.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCandelar.ImeMode = ImeMode.NoControl;
            buttonCandelar.Location = new Point(8, 13);
            buttonCandelar.Name = "buttonCandelar";
            buttonCandelar.Size = new Size(185, 25);
            buttonCandelar.TabIndex = 19;
            buttonCandelar.Text = "Cancelar";
            buttonCandelar.UseVisualStyleBackColor = true;
            buttonCandelar.Click += AoClicarCancelaCriacaoDeNovoBaralho;
            // 
            // labelPrecoParcial
            // 
            labelPrecoParcial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelPrecoParcial.AutoSize = true;
            labelPrecoParcial.FlatStyle = FlatStyle.System;
            labelPrecoParcial.Location = new Point(8, 496);
            labelPrecoParcial.Name = "labelPrecoParcial";
            labelPrecoParcial.Size = new Size(38, 15);
            labelPrecoParcial.TabIndex = 23;
            labelPrecoParcial.Text = "label1";
            labelPrecoParcial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCriarBaralho
            // 
            buttonCriarBaralho.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCriarBaralho.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCriarBaralho.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCriarBaralho.ImeMode = ImeMode.NoControl;
            buttonCriarBaralho.Location = new Point(8, 564);
            buttonCriarBaralho.Name = "buttonCriarBaralho";
            buttonCriarBaralho.Size = new Size(185, 25);
            buttonCriarBaralho.TabIndex = 20;
            buttonCriarBaralho.Text = "Criar baralho";
            buttonCriarBaralho.UseVisualStyleBackColor = true;
            // 
            // labelCustoParcial
            // 
            labelCustoParcial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelCustoParcial.AutoSize = true;
            labelCustoParcial.FlatStyle = FlatStyle.System;
            labelCustoParcial.Location = new Point(8, 456);
            labelCustoParcial.Name = "labelCustoParcial";
            labelCustoParcial.Size = new Size(38, 15);
            labelCustoParcial.TabIndex = 22;
            labelCustoParcial.Text = "label1";
            labelCustoParcial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelQuantidadeParcial
            // 
            labelQuantidadeParcial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelQuantidadeParcial.AutoSize = true;
            labelQuantidadeParcial.FlatStyle = FlatStyle.System;
            labelQuantidadeParcial.Location = new Point(8, 416);
            labelQuantidadeParcial.Name = "labelQuantidadeParcial";
            labelQuantidadeParcial.Size = new Size(38, 15);
            labelQuantidadeParcial.TabIndex = 21;
            labelQuantidadeParcial.Text = "label1";
            labelQuantidadeParcial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(8, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 230);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // comboBoxFormato
            // 
            comboBoxFormato.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxFormato.DataSource = baralhoBindingSource;
            comboBoxFormato.FormattingEnabled = true;
            comboBoxFormato.Location = new Point(8, 368);
            comboBoxFormato.Name = "comboBoxFormato";
            comboBoxFormato.Size = new Size(185, 23);
            comboBoxFormato.TabIndex = 7;
            // 
            // baralhoBindingSource
            // 
            baralhoBindingSource.DataSource = typeof(Dominio.Modelos.Baralho);
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelNome.AutoSize = true;
            labelNome.FlatStyle = FlatStyle.System;
            labelNome.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(8, 296);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(54, 19);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            labelNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxNomeBaralho
            // 
            textBoxNomeBaralho.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxNomeBaralho.Cursor = Cursors.Hand;
            textBoxNomeBaralho.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNomeBaralho.Location = new Point(8, 318);
            textBoxNomeBaralho.Name = "textBoxNomeBaralho";
            textBoxNomeBaralho.Size = new Size(185, 25);
            textBoxNomeBaralho.TabIndex = 6;
            // 
            // labelFormato
            // 
            labelFormato.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelFormato.AutoSize = true;
            labelFormato.FlatStyle = FlatStyle.System;
            labelFormato.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelFormato.Location = new Point(8, 346);
            labelFormato.Name = "labelFormato";
            labelFormato.Size = new Size(70, 19);
            labelFormato.TabIndex = 1;
            labelFormato.Text = "Formato:";
            labelFormato.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCorBaralho
            // 
            labelCorBaralho.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelCorBaralho.AutoSize = true;
            labelCorBaralho.FlatStyle = FlatStyle.System;
            labelCorBaralho.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCorBaralho.Location = new Point(8, 514);
            labelCorBaralho.Name = "labelCorBaralho";
            labelCorBaralho.Size = new Size(38, 19);
            labelCorBaralho.TabIndex = 5;
            labelCorBaralho.Text = "Cor:";
            labelCorBaralho.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelQuantidadeDeCartas
            // 
            labelQuantidadeDeCartas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelQuantidadeDeCartas.AutoSize = true;
            labelQuantidadeDeCartas.FlatStyle = FlatStyle.System;
            labelQuantidadeDeCartas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuantidadeDeCartas.Location = new Point(8, 394);
            labelQuantidadeDeCartas.Name = "labelQuantidadeDeCartas";
            labelQuantidadeDeCartas.Size = new Size(156, 19);
            labelQuantidadeDeCartas.TabIndex = 2;
            labelQuantidadeDeCartas.Text = "Quantidade de cartas:";
            labelQuantidadeDeCartas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPreco
            // 
            labelPreco.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelPreco.AutoSize = true;
            labelPreco.FlatStyle = FlatStyle.System;
            labelPreco.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelPreco.Location = new Point(8, 474);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(52, 19);
            labelPreco.TabIndex = 4;
            labelPreco.Text = "Preço:";
            labelPreco.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCmc
            // 
            labelCmc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelCmc.AutoSize = true;
            labelCmc.FlatStyle = FlatStyle.System;
            labelCmc.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCmc.Location = new Point(8, 434);
            labelCmc.Name = "labelCmc";
            labelCmc.Size = new Size(189, 19);
            labelCmc.TabIndex = 3;
            labelCmc.Text = "Custo de mana convertido:";
            labelCmc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cartaBindingSource1
            // 
            cartaBindingSource1.DataSource = typeof(Dominio.Modelos.Carta);
            // 
            // labelRaridade
            // 
            labelRaridade.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelRaridade.FlatStyle = FlatStyle.System;
            labelRaridade.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRaridade.ImeMode = ImeMode.NoControl;
            labelRaridade.Location = new Point(7, 342);
            labelRaridade.Name = "labelRaridade";
            labelRaridade.Size = new Size(69, 19);
            labelRaridade.TabIndex = 2251;
            labelRaridade.Text = "Raridade:";
            labelRaridade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxRaridadeComum
            // 
            checkBoxRaridadeComum.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxRaridadeComum.FlatStyle = FlatStyle.System;
            checkBoxRaridadeComum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxRaridadeComum.ImeMode = ImeMode.NoControl;
            checkBoxRaridadeComum.Location = new Point(7, 365);
            checkBoxRaridadeComum.Name = "checkBoxRaridadeComum";
            checkBoxRaridadeComum.Size = new Size(76, 24);
            checkBoxRaridadeComum.TabIndex = 2252;
            checkBoxRaridadeComum.Tag = "Comum";
            checkBoxRaridadeComum.Text = "Comum";
            checkBoxRaridadeComum.UseVisualStyleBackColor = true;
            // 
            // checkBoxRaridadeIncomum
            // 
            checkBoxRaridadeIncomum.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxRaridadeIncomum.FlatStyle = FlatStyle.System;
            checkBoxRaridadeIncomum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxRaridadeIncomum.ImeMode = ImeMode.NoControl;
            checkBoxRaridadeIncomum.Location = new Point(94, 365);
            checkBoxRaridadeIncomum.Name = "checkBoxRaridadeIncomum";
            checkBoxRaridadeIncomum.Size = new Size(92, 24);
            checkBoxRaridadeIncomum.TabIndex = 2253;
            checkBoxRaridadeIncomum.Tag = "Incomum";
            checkBoxRaridadeIncomum.Text = "Incomum";
            checkBoxRaridadeIncomum.UseVisualStyleBackColor = true;
            // 
            // checkBoxRaridadeRara
            // 
            checkBoxRaridadeRara.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxRaridadeRara.FlatStyle = FlatStyle.System;
            checkBoxRaridadeRara.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxRaridadeRara.ImeMode = ImeMode.NoControl;
            checkBoxRaridadeRara.Location = new Point(7, 393);
            checkBoxRaridadeRara.Name = "checkBoxRaridadeRara";
            checkBoxRaridadeRara.Size = new Size(60, 24);
            checkBoxRaridadeRara.TabIndex = 2254;
            checkBoxRaridadeRara.Tag = "Rara";
            checkBoxRaridadeRara.Text = "Rara";
            checkBoxRaridadeRara.UseVisualStyleBackColor = true;
            // 
            // checkBoxRaridadeMitica
            // 
            checkBoxRaridadeMitica.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxRaridadeMitica.FlatStyle = FlatStyle.System;
            checkBoxRaridadeMitica.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxRaridadeMitica.ImeMode = ImeMode.NoControl;
            checkBoxRaridadeMitica.Location = new Point(94, 393);
            checkBoxRaridadeMitica.Name = "checkBoxRaridadeMitica";
            checkBoxRaridadeMitica.Size = new Size(60, 24);
            checkBoxRaridadeMitica.TabIndex = 2255;
            checkBoxRaridadeMitica.Tag = "Mítica";
            checkBoxRaridadeMitica.Text = "Mítica";
            checkBoxRaridadeMitica.UseVisualStyleBackColor = true;
            // 
            // FormNovoBaralho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 601);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            MinimumSize = new Size(1024, 640);
            Name = "FormNovoBaralho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MTG -DeckBuilder - Criação de baralho";
            WindowState = FormWindowState.Maximized;
            Load += CarregarFormNovoBaralho;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownCmc).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCartas).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartaBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartaBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label labelDataDeCriacao;
        private Label labelPrecoCarta;
        private Label labelMax;
        private Button buttonLimparFiltro;
        private Label labelFiltros;
        private Button buttonAplicarFiltro;
        private NumericUpDown numericUpDownMax;
        private Label labelTipoDeCarta;
        private CheckBox checkBoxBranco;
        private CheckBox checkBoxAzul;
        private CheckBox checkBoxPreto;
        private CheckBox checkBoxTipoDeCartaTerrenoBasico;
        private Label labelMin;
        private CheckBox checkBoxVerde;
        private CheckBox checkBoxTipoDeCartaTerreno;
        private CheckBox checkBoxTipoDeCartaCriatura;
        private Label labelCor;
        private CheckBox checkBoxIncolor;
        private NumericUpDown numericUpDownMin;
        private CheckBox checkBoxVermelho;
        private TextBox textBoxFiltrarNome;
        private Label labelFiltroNome;
        private DataGridView dataGridViewCartas;
        private CheckBox checkBoxTipoDeCartaFeitico;
        private CheckBox checkBoxTipoDeCartaEncantamento;
        private CheckBox checkBoxTipoDeCartaMagicaInstantanea;
        private NumericUpDown numericUpDownCmc;
        private BindingSource cartaBindingSource;
        private PictureBox pictureBox1;
        private Button buttonCandelar;
        private Button buttonCriarBaralho;
        private ComboBox comboBoxFormato;
        private TextBox textBoxNomeBaralho;
        private Label labelCorBaralho;
        private Label labelPreco;
        private Label labelCmc;
        private Label labelQuantidadeDeCartas;
        private Label labelFormato;
        private Label labelNome;
        private Label labelQuantidadeParcial;
        private Label labelCustoParcial;
        private Label labelPrecoParcial;
        private Label labelCorParcial;
        private BindingSource cartaBindingSource1;
        private BindingSource baralhoBindingSource;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn AdicionarAoBaralho;
        private Label labelRaridade;
        private CheckBox checkBoxRaridadeIncomum;
        private CheckBox checkBoxRaridadeComum;
        private CheckBox checkBoxRaridadeRara;
        private CheckBox checkBoxRaridadeMitica;
    }
}