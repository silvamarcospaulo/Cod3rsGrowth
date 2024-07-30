namespace Cod3rsGrowth.Forms
{
    partial class FormNovoBaralhoListaDeCarta
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
            labelCorParcial = new Label();
            labelPrecoParcial = new Label();
            buttonCriarBaralhoBaralho = new Button();
            labelCustoParcial = new Label();
            labelQuantidadeParcial = new Label();
            labelNome = new Label();
            labelFormato = new Label();
            labelCorBaralho = new Label();
            labelQuantidadeDeCartas = new Label();
            labelPreco = new Label();
            labelCmc = new Label();
            panel1 = new Panel();
            labelNomeParcial = new Label();
            labelFormatoParcial = new Label();
            buttonRemoverCarta = new Button();
            buttonVoltar = new Button();
            labelDadosBaralho = new Label();
            labelCorCartaSelecionada = new Label();
            labelCorCarta = new Label();
            labelRariadeCartaSelecionada = new Label();
            labelRaridadeCarta = new Label();
            labelPrecoCartaSelecionada = new Label();
            labelPrecoDaCarta = new Label();
            labelCustoManaCartaSelecionada = new Label();
            labelCustoMana = new Label();
            labelTipoCartaSelecionada = new Label();
            labelTipoCarta = new Label();
            labelNomeCartaSelecionada = new Label();
            labelNomeCarta = new Label();
            labelDadosCarta = new Label();
            numericUpDownMax = new NumericUpDown();
            numericUpDownMin = new NumericUpDown();
            checkBoxRaridadeMitico = new CheckBox();
            checkBoxRaridadeRaro = new CheckBox();
            checkBoxRaridadeIncomum = new CheckBox();
            checkBoxRaridadeComum = new CheckBox();
            labelRaridade = new Label();
            numericUpDownCmc = new NumericUpDown();
            checkBoxTipoDeCartaEncantamento = new CheckBox();
            checkBoxTipoDeCartaMagicaInstantanea = new CheckBox();
            labelDataDeCriacao = new Label();
            labelPrecoCarta = new Label();
            labelMax = new Label();
            buttonLimparFiltro = new Button();
            buttonAplicarFiltro = new Button();
            checkBoxBranco = new CheckBox();
            checkBoxAzul = new CheckBox();
            checkBoxPreto = new CheckBox();
            labelMin = new Label();
            checkBoxVerde = new CheckBox();
            labelCor = new Label();
            checkBoxIncolor = new CheckBox();
            checkBoxVermelho = new CheckBox();
            panel2 = new Panel();
            dataGridViewListaDeCartasDoBaralho = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            quantidadeCopiasDaCartaNoBaralhoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idBaralhoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            copiaDeCartasNoBaralhoBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCmc).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaDeCartasDoBaralho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)copiaDeCartasNoBaralhoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelCorParcial
            // 
            labelCorParcial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelCorParcial.AutoSize = true;
            labelCorParcial.FlatStyle = FlatStyle.System;
            labelCorParcial.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorParcial.Location = new Point(8, 748);
            labelCorParcial.Name = "labelCorParcial";
            labelCorParcial.Size = new Size(198, 15);
            labelCorParcial.TabIndex = 0;
            labelCorParcial.Text = "Azul, Verde, Branco, Preto, Vermelho";
            labelCorParcial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPrecoParcial
            // 
            labelPrecoParcial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelPrecoParcial.AutoSize = true;
            labelPrecoParcial.FlatStyle = FlatStyle.System;
            labelPrecoParcial.Location = new Point(8, 698);
            labelPrecoParcial.Name = "labelPrecoParcial";
            labelPrecoParcial.Size = new Size(38, 15);
            labelPrecoParcial.TabIndex = 0;
            labelPrecoParcial.Text = "label1";
            labelPrecoParcial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCriarBaralhoBaralho
            // 
            buttonCriarBaralhoBaralho.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCriarBaralhoBaralho.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCriarBaralhoBaralho.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCriarBaralhoBaralho.ImeMode = ImeMode.NoControl;
            buttonCriarBaralhoBaralho.Location = new Point(8, 778);
            buttonCriarBaralhoBaralho.Name = "buttonCriarBaralhoBaralho";
            buttonCriarBaralhoBaralho.Size = new Size(235, 25);
            buttonCriarBaralhoBaralho.TabIndex = 1;
            buttonCriarBaralhoBaralho.Text = "Confirmar lista e criar baralho";
            buttonCriarBaralhoBaralho.UseVisualStyleBackColor = true;
            buttonCriarBaralhoBaralho.Click += AoClicarCriaBaralho;
            // 
            // labelCustoParcial
            // 
            labelCustoParcial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelCustoParcial.AutoSize = true;
            labelCustoParcial.FlatStyle = FlatStyle.System;
            labelCustoParcial.Location = new Point(8, 648);
            labelCustoParcial.Name = "labelCustoParcial";
            labelCustoParcial.Size = new Size(38, 15);
            labelCustoParcial.TabIndex = 0;
            labelCustoParcial.Text = "label1";
            labelCustoParcial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelQuantidadeParcial
            // 
            labelQuantidadeParcial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelQuantidadeParcial.AutoSize = true;
            labelQuantidadeParcial.FlatStyle = FlatStyle.System;
            labelQuantidadeParcial.Location = new Point(8, 598);
            labelQuantidadeParcial.Name = "labelQuantidadeParcial";
            labelQuantidadeParcial.Size = new Size(38, 15);
            labelQuantidadeParcial.TabIndex = 0;
            labelQuantidadeParcial.Text = "label1";
            labelQuantidadeParcial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelNome.AutoSize = true;
            labelNome.FlatStyle = FlatStyle.System;
            labelNome.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(8, 471);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(54, 19);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            labelNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelFormato
            // 
            labelFormato.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelFormato.AutoSize = true;
            labelFormato.FlatStyle = FlatStyle.System;
            labelFormato.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelFormato.Location = new Point(8, 521);
            labelFormato.Name = "labelFormato";
            labelFormato.Size = new Size(70, 19);
            labelFormato.TabIndex = 0;
            labelFormato.Text = "Formato:";
            labelFormato.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCorBaralho
            // 
            labelCorBaralho.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelCorBaralho.AutoSize = true;
            labelCorBaralho.FlatStyle = FlatStyle.System;
            labelCorBaralho.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCorBaralho.Location = new Point(8, 721);
            labelCorBaralho.Name = "labelCorBaralho";
            labelCorBaralho.Size = new Size(38, 19);
            labelCorBaralho.TabIndex = 0;
            labelCorBaralho.Text = "Cor:";
            labelCorBaralho.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelQuantidadeDeCartas
            // 
            labelQuantidadeDeCartas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelQuantidadeDeCartas.AutoSize = true;
            labelQuantidadeDeCartas.FlatStyle = FlatStyle.System;
            labelQuantidadeDeCartas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuantidadeDeCartas.Location = new Point(8, 571);
            labelQuantidadeDeCartas.Name = "labelQuantidadeDeCartas";
            labelQuantidadeDeCartas.Size = new Size(156, 19);
            labelQuantidadeDeCartas.TabIndex = 0;
            labelQuantidadeDeCartas.Text = "Quantidade de cartas:";
            labelQuantidadeDeCartas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPreco
            // 
            labelPreco.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelPreco.AutoSize = true;
            labelPreco.FlatStyle = FlatStyle.System;
            labelPreco.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelPreco.Location = new Point(8, 671);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(52, 19);
            labelPreco.TabIndex = 0;
            labelPreco.Text = "Preço:";
            labelPreco.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCmc
            // 
            labelCmc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelCmc.AutoSize = true;
            labelCmc.FlatStyle = FlatStyle.System;
            labelCmc.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCmc.Location = new Point(8, 621);
            labelCmc.Name = "labelCmc";
            labelCmc.Size = new Size(189, 19);
            labelCmc.TabIndex = 0;
            labelCmc.Text = "Custo de mana convertido:";
            labelCmc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelNomeParcial);
            panel1.Controls.Add(buttonCriarBaralhoBaralho);
            panel1.Controls.Add(labelFormatoParcial);
            panel1.Controls.Add(buttonRemoverCarta);
            panel1.Controls.Add(labelCorParcial);
            panel1.Controls.Add(buttonVoltar);
            panel1.Controls.Add(labelDadosBaralho);
            panel1.Controls.Add(labelPrecoParcial);
            panel1.Controls.Add(labelCorCartaSelecionada);
            panel1.Controls.Add(labelCorCarta);
            panel1.Controls.Add(labelCustoParcial);
            panel1.Controls.Add(labelRariadeCartaSelecionada);
            panel1.Controls.Add(labelRaridadeCarta);
            panel1.Controls.Add(labelQuantidadeParcial);
            panel1.Controls.Add(labelPrecoCartaSelecionada);
            panel1.Controls.Add(labelPrecoDaCarta);
            panel1.Controls.Add(labelNome);
            panel1.Controls.Add(labelCustoManaCartaSelecionada);
            panel1.Controls.Add(labelCustoMana);
            panel1.Controls.Add(labelFormato);
            panel1.Controls.Add(labelTipoCartaSelecionada);
            panel1.Controls.Add(labelCorBaralho);
            panel1.Controls.Add(labelTipoCarta);
            panel1.Controls.Add(labelNomeCartaSelecionada);
            panel1.Controls.Add(labelQuantidadeDeCartas);
            panel1.Controls.Add(labelNomeCarta);
            panel1.Controls.Add(labelDadosCarta);
            panel1.Controls.Add(labelPreco);
            panel1.Controls.Add(numericUpDownMax);
            panel1.Controls.Add(numericUpDownMin);
            panel1.Controls.Add(labelCmc);
            panel1.Controls.Add(checkBoxRaridadeMitico);
            panel1.Controls.Add(checkBoxRaridadeRaro);
            panel1.Controls.Add(checkBoxRaridadeIncomum);
            panel1.Controls.Add(checkBoxRaridadeComum);
            panel1.Controls.Add(labelRaridade);
            panel1.Controls.Add(numericUpDownCmc);
            panel1.Controls.Add(checkBoxTipoDeCartaEncantamento);
            panel1.Controls.Add(checkBoxTipoDeCartaMagicaInstantanea);
            panel1.Controls.Add(labelDataDeCriacao);
            panel1.Controls.Add(labelPrecoCarta);
            panel1.Controls.Add(labelMax);
            panel1.Controls.Add(buttonLimparFiltro);
            panel1.Controls.Add(buttonAplicarFiltro);
            panel1.Controls.Add(checkBoxBranco);
            panel1.Controls.Add(checkBoxAzul);
            panel1.Controls.Add(checkBoxPreto);
            panel1.Controls.Add(labelMin);
            panel1.Controls.Add(checkBoxVerde);
            panel1.Controls.Add(labelCor);
            panel1.Controls.Add(checkBoxIncolor);
            panel1.Controls.Add(checkBoxVermelho);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(753, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 816);
            panel1.TabIndex = 2275;
            // 
            // labelNomeParcial
            // 
            labelNomeParcial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelNomeParcial.AutoSize = true;
            labelNomeParcial.FlatStyle = FlatStyle.System;
            labelNomeParcial.Location = new Point(8, 498);
            labelNomeParcial.Name = "labelNomeParcial";
            labelNomeParcial.Size = new Size(38, 15);
            labelNomeParcial.TabIndex = 0;
            labelNomeParcial.Text = "label1";
            labelNomeParcial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelFormatoParcial
            // 
            labelFormatoParcial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelFormatoParcial.AutoSize = true;
            labelFormatoParcial.FlatStyle = FlatStyle.System;
            labelFormatoParcial.Location = new Point(8, 548);
            labelFormatoParcial.Name = "labelFormatoParcial";
            labelFormatoParcial.Size = new Size(38, 15);
            labelFormatoParcial.TabIndex = 0;
            labelFormatoParcial.Text = "label1";
            labelFormatoParcial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonRemoverCarta
            // 
            buttonRemoverCarta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRemoverCarta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonRemoverCarta.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRemoverCarta.ImeMode = ImeMode.NoControl;
            buttonRemoverCarta.Location = new Point(8, 395);
            buttonRemoverCarta.Name = "buttonRemoverCarta";
            buttonRemoverCarta.Size = new Size(235, 25);
            buttonRemoverCarta.TabIndex = 2278;
            buttonRemoverCarta.Text = "Remover carta da lista";
            buttonRemoverCarta.UseVisualStyleBackColor = true;
            buttonRemoverCarta.Click += AoClicarRemoveCartaDaListaDeCartasDoBaralho;
            // 
            // buttonVoltar
            // 
            buttonVoltar.Anchor = AnchorStyles.Top;
            buttonVoltar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonVoltar.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVoltar.ImeMode = ImeMode.NoControl;
            buttonVoltar.Location = new Point(8, 12);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(235, 25);
            buttonVoltar.TabIndex = 2279;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += AoClicarVoltaParaTelaDeNovoBaralho;
            // 
            // labelDadosBaralho
            // 
            labelDadosBaralho.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelDadosBaralho.FlatStyle = FlatStyle.System;
            labelDadosBaralho.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelDadosBaralho.ImeMode = ImeMode.NoControl;
            labelDadosBaralho.Location = new Point(25, 433);
            labelDadosBaralho.Name = "labelDadosBaralho";
            labelDadosBaralho.Size = new Size(200, 30);
            labelDadosBaralho.TabIndex = 0;
            labelDadosBaralho.Text = "Dados baralho";
            labelDadosBaralho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCorCartaSelecionada
            // 
            labelCorCartaSelecionada.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelCorCartaSelecionada.AutoSize = true;
            labelCorCartaSelecionada.FlatStyle = FlatStyle.System;
            labelCorCartaSelecionada.Location = new Point(8, 365);
            labelCorCartaSelecionada.Name = "labelCorCartaSelecionada";
            labelCorCartaSelecionada.Size = new Size(38, 15);
            labelCorCartaSelecionada.TabIndex = 0;
            labelCorCartaSelecionada.Text = "label1";
            labelCorCartaSelecionada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCorCarta
            // 
            labelCorCarta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelCorCarta.AutoSize = true;
            labelCorCarta.FlatStyle = FlatStyle.System;
            labelCorCarta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCorCarta.Location = new Point(8, 338);
            labelCorCarta.Name = "labelCorCarta";
            labelCorCarta.Size = new Size(38, 19);
            labelCorCarta.TabIndex = 0;
            labelCorCarta.Text = "Cor:";
            labelCorCarta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelRariadeCartaSelecionada
            // 
            labelRariadeCartaSelecionada.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelRariadeCartaSelecionada.AutoSize = true;
            labelRariadeCartaSelecionada.FlatStyle = FlatStyle.System;
            labelRariadeCartaSelecionada.Location = new Point(8, 315);
            labelRariadeCartaSelecionada.Name = "labelRariadeCartaSelecionada";
            labelRariadeCartaSelecionada.Size = new Size(44, 15);
            labelRariadeCartaSelecionada.TabIndex = 0;
            labelRariadeCartaSelecionada.Text = "label17";
            labelRariadeCartaSelecionada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelRaridadeCarta
            // 
            labelRaridadeCarta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelRaridadeCarta.AutoSize = true;
            labelRaridadeCarta.FlatStyle = FlatStyle.System;
            labelRaridadeCarta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRaridadeCarta.Location = new Point(8, 288);
            labelRaridadeCarta.Name = "labelRaridadeCarta";
            labelRaridadeCarta.Size = new Size(74, 19);
            labelRaridadeCarta.TabIndex = 0;
            labelRaridadeCarta.Text = "Raridade:";
            labelRaridadeCarta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPrecoCartaSelecionada
            // 
            labelPrecoCartaSelecionada.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelPrecoCartaSelecionada.AutoSize = true;
            labelPrecoCartaSelecionada.FlatStyle = FlatStyle.System;
            labelPrecoCartaSelecionada.Location = new Point(8, 265);
            labelPrecoCartaSelecionada.Name = "labelPrecoCartaSelecionada";
            labelPrecoCartaSelecionada.Size = new Size(38, 15);
            labelPrecoCartaSelecionada.TabIndex = 0;
            labelPrecoCartaSelecionada.Text = "label1";
            labelPrecoCartaSelecionada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPrecoDaCarta
            // 
            labelPrecoDaCarta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelPrecoDaCarta.AutoSize = true;
            labelPrecoDaCarta.FlatStyle = FlatStyle.System;
            labelPrecoDaCarta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrecoDaCarta.Location = new Point(8, 238);
            labelPrecoDaCarta.Name = "labelPrecoDaCarta";
            labelPrecoDaCarta.Size = new Size(52, 19);
            labelPrecoDaCarta.TabIndex = 0;
            labelPrecoDaCarta.Text = "Preço:";
            labelPrecoDaCarta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCustoManaCartaSelecionada
            // 
            labelCustoManaCartaSelecionada.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelCustoManaCartaSelecionada.AutoSize = true;
            labelCustoManaCartaSelecionada.FlatStyle = FlatStyle.System;
            labelCustoManaCartaSelecionada.Location = new Point(8, 215);
            labelCustoManaCartaSelecionada.Name = "labelCustoManaCartaSelecionada";
            labelCustoManaCartaSelecionada.Size = new Size(38, 15);
            labelCustoManaCartaSelecionada.TabIndex = 0;
            labelCustoManaCartaSelecionada.Text = "label1";
            labelCustoManaCartaSelecionada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCustoMana
            // 
            labelCustoMana.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelCustoMana.AutoSize = true;
            labelCustoMana.FlatStyle = FlatStyle.System;
            labelCustoMana.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustoMana.Location = new Point(8, 188);
            labelCustoMana.Name = "labelCustoMana";
            labelCustoMana.Size = new Size(44, 19);
            labelCustoMana.TabIndex = 0;
            labelCustoMana.Text = "CMC:";
            labelCustoMana.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTipoCartaSelecionada
            // 
            labelTipoCartaSelecionada.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTipoCartaSelecionada.AutoSize = true;
            labelTipoCartaSelecionada.FlatStyle = FlatStyle.System;
            labelTipoCartaSelecionada.Location = new Point(8, 165);
            labelTipoCartaSelecionada.Name = "labelTipoCartaSelecionada";
            labelTipoCartaSelecionada.Size = new Size(38, 15);
            labelTipoCartaSelecionada.TabIndex = 0;
            labelTipoCartaSelecionada.Text = "label1";
            labelTipoCartaSelecionada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTipoCarta
            // 
            labelTipoCarta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTipoCarta.AutoSize = true;
            labelTipoCarta.FlatStyle = FlatStyle.System;
            labelTipoCarta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoCarta.Location = new Point(8, 138);
            labelTipoCarta.Name = "labelTipoCarta";
            labelTipoCarta.Size = new Size(43, 19);
            labelTipoCarta.TabIndex = 0;
            labelTipoCarta.Text = "Tipo:";
            labelTipoCarta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNomeCartaSelecionada
            // 
            labelNomeCartaSelecionada.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelNomeCartaSelecionada.AutoSize = true;
            labelNomeCartaSelecionada.FlatStyle = FlatStyle.System;
            labelNomeCartaSelecionada.Location = new Point(8, 115);
            labelNomeCartaSelecionada.Name = "labelNomeCartaSelecionada";
            labelNomeCartaSelecionada.Size = new Size(38, 15);
            labelNomeCartaSelecionada.TabIndex = 0;
            labelNomeCartaSelecionada.Text = "label1";
            labelNomeCartaSelecionada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNomeCarta
            // 
            labelNomeCarta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelNomeCarta.AutoSize = true;
            labelNomeCarta.FlatStyle = FlatStyle.System;
            labelNomeCarta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeCarta.Location = new Point(8, 88);
            labelNomeCarta.Name = "labelNomeCarta";
            labelNomeCarta.Size = new Size(54, 19);
            labelNomeCarta.TabIndex = 0;
            labelNomeCarta.Text = "Nome:";
            labelNomeCarta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDadosCarta
            // 
            labelDadosCarta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelDadosCarta.FlatStyle = FlatStyle.System;
            labelDadosCarta.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelDadosCarta.ImeMode = ImeMode.NoControl;
            labelDadosCarta.Location = new Point(25, 50);
            labelDadosCarta.Name = "labelDadosCarta";
            labelDadosCarta.Size = new Size(200, 30);
            labelDadosCarta.TabIndex = 0;
            labelDadosCarta.Text = "Dados carta";
            labelDadosCarta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownMax
            // 
            numericUpDownMax.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDownMax.Location = new Point(103, 1176);
            numericUpDownMax.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownMax.Name = "numericUpDownMax";
            numericUpDownMax.Size = new Size(145, 23);
            numericUpDownMax.TabIndex = 15;
            numericUpDownMax.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownMin
            // 
            numericUpDownMin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDownMin.Cursor = Cursors.Hand;
            numericUpDownMin.Location = new Point(103, 1150);
            numericUpDownMin.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownMin.Name = "numericUpDownMin";
            numericUpDownMin.Size = new Size(145, 23);
            numericUpDownMin.TabIndex = 14;
            numericUpDownMin.TextAlign = HorizontalAlignment.Right;
            // 
            // checkBoxRaridadeMitico
            // 
            checkBoxRaridadeMitico.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxRaridadeMitico.FlatStyle = FlatStyle.System;
            checkBoxRaridadeMitico.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxRaridadeMitico.ImeMode = ImeMode.NoControl;
            checkBoxRaridadeMitico.Location = new Point(149, 1109);
            checkBoxRaridadeMitico.Name = "checkBoxRaridadeMitico";
            checkBoxRaridadeMitico.Size = new Size(60, 24);
            checkBoxRaridadeMitico.TabIndex = 2255;
            checkBoxRaridadeMitico.Tag = "Mítico";
            checkBoxRaridadeMitico.Text = "Mítico";
            checkBoxRaridadeMitico.UseVisualStyleBackColor = true;
            // 
            // checkBoxRaridadeRaro
            // 
            checkBoxRaridadeRaro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxRaridadeRaro.FlatStyle = FlatStyle.System;
            checkBoxRaridadeRaro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxRaridadeRaro.ImeMode = ImeMode.NoControl;
            checkBoxRaridadeRaro.Location = new Point(63, 1109);
            checkBoxRaridadeRaro.Name = "checkBoxRaridadeRaro";
            checkBoxRaridadeRaro.Size = new Size(60, 24);
            checkBoxRaridadeRaro.TabIndex = 2254;
            checkBoxRaridadeRaro.Tag = "Raro";
            checkBoxRaridadeRaro.Text = "Raro";
            checkBoxRaridadeRaro.UseVisualStyleBackColor = true;
            // 
            // checkBoxRaridadeIncomum
            // 
            checkBoxRaridadeIncomum.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxRaridadeIncomum.FlatStyle = FlatStyle.System;
            checkBoxRaridadeIncomum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxRaridadeIncomum.ImeMode = ImeMode.NoControl;
            checkBoxRaridadeIncomum.Location = new Point(149, 1081);
            checkBoxRaridadeIncomum.Name = "checkBoxRaridadeIncomum";
            checkBoxRaridadeIncomum.Size = new Size(92, 24);
            checkBoxRaridadeIncomum.TabIndex = 2253;
            checkBoxRaridadeIncomum.Tag = "Incomum";
            checkBoxRaridadeIncomum.Text = "Incomum";
            checkBoxRaridadeIncomum.UseVisualStyleBackColor = true;
            // 
            // checkBoxRaridadeComum
            // 
            checkBoxRaridadeComum.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxRaridadeComum.FlatStyle = FlatStyle.System;
            checkBoxRaridadeComum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxRaridadeComum.ImeMode = ImeMode.NoControl;
            checkBoxRaridadeComum.Location = new Point(63, 1081);
            checkBoxRaridadeComum.Name = "checkBoxRaridadeComum";
            checkBoxRaridadeComum.Size = new Size(76, 24);
            checkBoxRaridadeComum.TabIndex = 2252;
            checkBoxRaridadeComum.Tag = "Comum";
            checkBoxRaridadeComum.Text = "Comum";
            checkBoxRaridadeComum.UseVisualStyleBackColor = true;
            // 
            // labelRaridade
            // 
            labelRaridade.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelRaridade.FlatStyle = FlatStyle.System;
            labelRaridade.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRaridade.ImeMode = ImeMode.NoControl;
            labelRaridade.Location = new Point(63, 1058);
            labelRaridade.Name = "labelRaridade";
            labelRaridade.Size = new Size(69, 19);
            labelRaridade.TabIndex = 2251;
            labelRaridade.Text = "Raridade:";
            labelRaridade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDownCmc
            // 
            numericUpDownCmc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDownCmc.Location = new Point(63, 1221);
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
            checkBoxTipoDeCartaEncantamento.Location = new Point(63, 923);
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
            checkBoxTipoDeCartaMagicaInstantanea.Location = new Point(63, 895);
            checkBoxTipoDeCartaMagicaInstantanea.Name = "checkBoxTipoDeCartaMagicaInstantanea";
            checkBoxTipoDeCartaMagicaInstantanea.Size = new Size(131, 24);
            checkBoxTipoDeCartaMagicaInstantanea.TabIndex = 6;
            checkBoxTipoDeCartaMagicaInstantanea.Tag = "";
            checkBoxTipoDeCartaMagicaInstantanea.Text = "Magica Instantânea";
            checkBoxTipoDeCartaMagicaInstantanea.UseVisualStyleBackColor = true;
            // 
            // labelDataDeCriacao
            // 
            labelDataDeCriacao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelDataDeCriacao.FlatStyle = FlatStyle.System;
            labelDataDeCriacao.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelDataDeCriacao.ImeMode = ImeMode.NoControl;
            labelDataDeCriacao.Location = new Point(63, 1198);
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
            labelPrecoCarta.Location = new Point(63, 1137);
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
            labelMax.Location = new Point(63, 1179);
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
            buttonLimparFiltro.Location = new Point(63, 1280);
            buttonLimparFiltro.Name = "buttonLimparFiltro";
            buttonLimparFiltro.Size = new Size(185, 25);
            buttonLimparFiltro.TabIndex = 18;
            buttonLimparFiltro.Text = "Limpar filtro";
            buttonLimparFiltro.UseVisualStyleBackColor = true;
            // 
            // buttonAplicarFiltro
            // 
            buttonAplicarFiltro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAplicarFiltro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAplicarFiltro.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAplicarFiltro.ImeMode = ImeMode.NoControl;
            buttonAplicarFiltro.Location = new Point(63, 1253);
            buttonAplicarFiltro.Name = "buttonAplicarFiltro";
            buttonAplicarFiltro.Size = new Size(185, 25);
            buttonAplicarFiltro.TabIndex = 17;
            buttonAplicarFiltro.Text = "Aplicar filtro";
            buttonAplicarFiltro.UseVisualStyleBackColor = true;
            // 
            // checkBoxBranco
            // 
            checkBoxBranco.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxBranco.FlatStyle = FlatStyle.System;
            checkBoxBranco.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxBranco.ImeMode = ImeMode.NoControl;
            checkBoxBranco.Location = new Point(149, 974);
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
            checkBoxAzul.Location = new Point(63, 974);
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
            checkBoxPreto.Location = new Point(149, 1002);
            checkBoxPreto.Name = "checkBoxPreto";
            checkBoxPreto.Size = new Size(67, 24);
            checkBoxPreto.TabIndex = 11;
            checkBoxPreto.Text = "Preto";
            checkBoxPreto.UseVisualStyleBackColor = true;
            // 
            // labelMin
            // 
            labelMin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelMin.FlatStyle = FlatStyle.System;
            labelMin.ImeMode = ImeMode.NoControl;
            labelMin.Location = new Point(63, 1160);
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
            checkBoxVerde.Location = new Point(63, 1030);
            checkBoxVerde.Name = "checkBoxVerde";
            checkBoxVerde.Size = new Size(69, 24);
            checkBoxVerde.TabIndex = 12;
            checkBoxVerde.Text = "Verde";
            checkBoxVerde.UseVisualStyleBackColor = true;
            // 
            // labelCor
            // 
            labelCor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelCor.FlatStyle = FlatStyle.System;
            labelCor.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCor.ImeMode = ImeMode.NoControl;
            labelCor.Location = new Point(63, 951);
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
            checkBoxIncolor.Location = new Point(63, 1002);
            checkBoxIncolor.Name = "checkBoxIncolor";
            checkBoxIncolor.Size = new Size(76, 24);
            checkBoxIncolor.TabIndex = 10;
            checkBoxIncolor.Text = "Incolor";
            checkBoxIncolor.UseVisualStyleBackColor = true;
            // 
            // checkBoxVermelho
            // 
            checkBoxVermelho.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxVermelho.FlatStyle = FlatStyle.System;
            checkBoxVermelho.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxVermelho.ImeMode = ImeMode.NoControl;
            checkBoxVermelho.Location = new Point(149, 1030);
            checkBoxVermelho.Name = "checkBoxVermelho";
            checkBoxVermelho.Size = new Size(92, 24);
            checkBoxVermelho.TabIndex = 13;
            checkBoxVermelho.Text = "Vermelho";
            checkBoxVermelho.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewListaDeCartasDoBaralho);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(753, 816);
            panel2.TabIndex = 2276;
            // 
            // dataGridViewListaDeCartasDoBaralho
            // 
            dataGridViewListaDeCartasDoBaralho.AllowUserToAddRows = false;
            dataGridViewListaDeCartasDoBaralho.AllowUserToDeleteRows = false;
            dataGridViewListaDeCartasDoBaralho.AutoGenerateColumns = false;
            dataGridViewListaDeCartasDoBaralho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListaDeCartasDoBaralho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaDeCartasDoBaralho.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, quantidadeCopiasDaCartaNoBaralhoDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, idBaralhoDataGridViewTextBoxColumn, idCartaDataGridViewTextBoxColumn, cartaDataGridViewTextBoxColumn });
            dataGridViewListaDeCartasDoBaralho.DataSource = copiaDeCartasNoBaralhoBindingSource;
            dataGridViewListaDeCartasDoBaralho.Dock = DockStyle.Fill;
            dataGridViewListaDeCartasDoBaralho.Location = new Point(0, 0);
            dataGridViewListaDeCartasDoBaralho.Name = "dataGridViewListaDeCartasDoBaralho";
            dataGridViewListaDeCartasDoBaralho.ReadOnly = true;
            dataGridViewListaDeCartasDoBaralho.RowTemplate.Height = 25;
            dataGridViewListaDeCartasDoBaralho.Size = new Size(753, 816);
            dataGridViewListaDeCartasDoBaralho.TabIndex = 0;
            dataGridViewListaDeCartasDoBaralho.CellClick += AoClicarCarregaDadosDaCarta;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "NomeCarta";
            dataGridViewTextBoxColumn1.HeaderText = "Nome";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantidadeCopiasDaCartaNoBaralhoDataGridViewTextBoxColumn
            // 
            quantidadeCopiasDaCartaNoBaralhoDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeCopiasDaCartaNoBaralho";
            quantidadeCopiasDaCartaNoBaralhoDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeCopiasDaCartaNoBaralhoDataGridViewTextBoxColumn.Name = "quantidadeCopiasDaCartaNoBaralhoDataGridViewTextBoxColumn";
            quantidadeCopiasDaCartaNoBaralhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idBaralhoDataGridViewTextBoxColumn
            // 
            idBaralhoDataGridViewTextBoxColumn.DataPropertyName = "IdBaralho";
            idBaralhoDataGridViewTextBoxColumn.HeaderText = "IdBaralho";
            idBaralhoDataGridViewTextBoxColumn.Name = "idBaralhoDataGridViewTextBoxColumn";
            idBaralhoDataGridViewTextBoxColumn.ReadOnly = true;
            idBaralhoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idCartaDataGridViewTextBoxColumn
            // 
            idCartaDataGridViewTextBoxColumn.DataPropertyName = "IdCarta";
            idCartaDataGridViewTextBoxColumn.HeaderText = "IdCarta";
            idCartaDataGridViewTextBoxColumn.Name = "idCartaDataGridViewTextBoxColumn";
            idCartaDataGridViewTextBoxColumn.ReadOnly = true;
            idCartaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cartaDataGridViewTextBoxColumn
            // 
            cartaDataGridViewTextBoxColumn.DataPropertyName = "Carta";
            cartaDataGridViewTextBoxColumn.HeaderText = "Carta";
            cartaDataGridViewTextBoxColumn.Name = "cartaDataGridViewTextBoxColumn";
            cartaDataGridViewTextBoxColumn.ReadOnly = true;
            cartaDataGridViewTextBoxColumn.Visible = false;
            // 
            // copiaDeCartasNoBaralhoBindingSource
            // 
            copiaDeCartasNoBaralhoBindingSource.DataSource = typeof(Dominio.Modelos.CopiaDeCartasNoBaralho);
            // 
            // FormListaDeCartaDoBaralho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 816);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1024, 855);
            Name = "FormListaDeCartaDoBaralho";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            Text = "MTG DeckBuilder - Confirmar lista do baralho";
            WindowState = FormWindowState.Maximized;
            Load += CarregarFormListaDeCartasDoBaralho;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCmc).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaDeCartasDoBaralho).EndInit();
            ((System.ComponentModel.ISupportInitialize)copiaDeCartasNoBaralhoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelCorParcial;
        private Label labelPrecoParcial;
        private Button buttonCriarBaralhoBaralho;
        private Label labelCustoParcial;
        private Label labelQuantidadeParcial;
        private Label labelNome;
        private Label labelFormato;
        private Label labelCorBaralho;
        private Label labelQuantidadeDeCartas;
        private Label labelPreco;
        private Label labelCmc;
        private Panel panel1;
        private NumericUpDown numericUpDownMax;
        private NumericUpDown numericUpDownMin;
        private CheckBox checkBoxRaridadeMitico;
        private CheckBox checkBoxRaridadeRaro;
        private CheckBox checkBoxRaridadeIncomum;
        private CheckBox checkBoxRaridadeComum;
        private Label labelRaridade;
        private NumericUpDown numericUpDownCmc;
        private CheckBox checkBoxTipoDeCartaEncantamento;
        private CheckBox checkBoxTipoDeCartaMagicaInstantanea;
        private Label labelDataDeCriacao;
        private Label labelPrecoCarta;
        private Label labelMax;
        private Button buttonLimparFiltro;
        private Button buttonAplicarFiltro;
        private CheckBox checkBoxBranco;
        private CheckBox checkBoxAzul;
        private CheckBox checkBoxPreto;
        private Label labelMin;
        private CheckBox checkBoxVerde;
        private Label labelCor;
        private CheckBox checkBoxIncolor;
        private CheckBox checkBoxVermelho;
        private Panel panel2;
        private DataGridView dataGridViewListaDeCartasDoBaralho;
        private Label labelDadosCarta;
        private Label labelDadosBaralho;
        private Label labelFormatoParcial;
        private Label labelNomeParcial;
        private DataGridViewTextBoxColumn nomeCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn custoDeManaConvertidoCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDeCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn raridadeCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn corCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imagemDataGridViewTextBoxColumn;
        private BindingSource cartaBindingSource;
        private Label labelNomeCartaSelecionada;
        private Label labelNomeCarta;
        private Label labelCorCartaSelecionada;
        private Label labelCorCarta;
        private Label labelRariadeCartaSelecionada;
        private Label labelRaridadeCarta;
        private Label labelPrecoCartaSelecionada;
        private Label labelPrecoDaCarta;
        private Label labelCustoManaCartaSelecionada;
        private Label labelCustoMana;
        private Label labelTipoCartaSelecionada;
        private Label labelTipoCarta;
        private Button buttonVoltar;
        private Button buttonRemoverCarta;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn quantidadeCopiasDaCartaNoBaralhoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idBaralhoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cartaDataGridViewTextBoxColumn;
        private BindingSource copiaDeCartasNoBaralhoBindingSource;
    }
}