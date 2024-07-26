using Cod3rsGrowth.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Cod3rsGrowth.Forms
{
    partial class FormEditarBaralho
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            numericUpDownMax = new NumericUpDown();
            numericUpDownMin = new NumericUpDown();
            checkBoxRaridadeMitico = new CheckBox();
            checkBoxRaridadeRaro = new CheckBox();
            buttonCancelar = new Button();
            checkBoxRaridadeIncomum = new CheckBox();
            checkBoxRaridadeComum = new CheckBox();
            labelRaridade = new Label();
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
            checkBoxVermelho = new CheckBox();
            panel2 = new Panel();
            dataGridViewCartas = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            custoDeManaConvertidoCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDeCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            raridadeCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            corCartaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cartaBindingSource = new BindingSource(components);
            textBoxFiltrarNome = new TextBox();
            labelFiltroNome = new Label();
            panel3 = new Panel();
            labelNomeBaralho = new Label();
            labelFormatoBaralho = new Label();
            labelNomeCartaSelecionada = new Label();
            label3 = new Label();
            buttonAdicionarCarta = new Button();
            numericUpDownQuantidadeDeCopiasDeCarta = new NumericUpDown();
            label1 = new Label();
            labelCorParcial = new Label();
            labelPrecoParcial = new Label();
            buttonVisualizarBaralho = new Button();
            labelCustoParcial = new Label();
            labelQuantidadeParcial = new Label();
            labelNome = new Label();
            labelFormato = new Label();
            labelCorBaralho = new Label();
            labelQuantidadeDeCartas = new Label();
            labelPreco = new Label();
            labelCmc = new Label();
            baralhoBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCmc).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCartas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartaBindingSource).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidadeDeCopiasDeCarta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDownMax);
            panel1.Controls.Add(numericUpDownMin);
            panel1.Controls.Add(checkBoxRaridadeMitico);
            panel1.Controls.Add(checkBoxRaridadeRaro);
            panel1.Controls.Add(buttonCancelar);
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
            panel1.Controls.Add(checkBoxVermelho);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(808, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 601);
            panel1.TabIndex = 0;
            // 
            // numericUpDownMax
            // 
            numericUpDownMax.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDownMax.Location = new Point(48, 460);
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
            numericUpDownMin.Location = new Point(48, 434);
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
            checkBoxRaridadeMitico.Location = new Point(94, 393);
            checkBoxRaridadeMitico.Name = "checkBoxRaridadeMitico";
            checkBoxRaridadeMitico.Size = new Size(60, 24);
            checkBoxRaridadeMitico.TabIndex = 2255;
            checkBoxRaridadeMitico.Tag = "Mítico";
            checkBoxRaridadeMitico.Text = "Mítico";
            checkBoxRaridadeMitico.UseVisualStyleBackColor = true;
            checkBoxRaridadeMitico.CheckedChanged += AoClicarMiticoDesselecionaOutrasCheckBoxRaridade;
            // 
            // checkBoxRaridadeRaro
            // 
            checkBoxRaridadeRaro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxRaridadeRaro.FlatStyle = FlatStyle.System;
            checkBoxRaridadeRaro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxRaridadeRaro.ImeMode = ImeMode.NoControl;
            checkBoxRaridadeRaro.Location = new Point(8, 393);
            checkBoxRaridadeRaro.Name = "checkBoxRaridadeRaro";
            checkBoxRaridadeRaro.Size = new Size(60, 24);
            checkBoxRaridadeRaro.TabIndex = 2254;
            checkBoxRaridadeRaro.Tag = "Raro";
            checkBoxRaridadeRaro.Text = "Raro";
            checkBoxRaridadeRaro.UseVisualStyleBackColor = true;
            checkBoxRaridadeRaro.CheckedChanged += AoClicarRaroDesselecionaOutrasCheckBoxRaridade;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCancelar.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.ImeMode = ImeMode.NoControl;
            buttonCancelar.Location = new Point(8, 13);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(185, 25);
            buttonCancelar.TabIndex = 19;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += AoClicarCancelaCriacaoDeNovoBaralho;
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
            checkBoxRaridadeIncomum.CheckedChanged += AoClicarIncomumDesselecionaOutrasCheckBoxRaridade;
            // 
            // checkBoxRaridadeComum
            // 
            checkBoxRaridadeComum.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxRaridadeComum.FlatStyle = FlatStyle.System;
            checkBoxRaridadeComum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxRaridadeComum.ImeMode = ImeMode.NoControl;
            checkBoxRaridadeComum.Location = new Point(8, 365);
            checkBoxRaridadeComum.Name = "checkBoxRaridadeComum";
            checkBoxRaridadeComum.Size = new Size(76, 24);
            checkBoxRaridadeComum.TabIndex = 2252;
            checkBoxRaridadeComum.Tag = "Comum";
            checkBoxRaridadeComum.Text = "Comum";
            checkBoxRaridadeComum.UseVisualStyleBackColor = true;
            checkBoxRaridadeComum.CheckedChanged += AoClicarComumDesselecionaOutrasCheckBoxRaridade;
            // 
            // labelRaridade
            // 
            labelRaridade.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelRaridade.FlatStyle = FlatStyle.System;
            labelRaridade.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRaridade.ImeMode = ImeMode.NoControl;
            labelRaridade.Location = new Point(8, 342);
            labelRaridade.Name = "labelRaridade";
            labelRaridade.Size = new Size(69, 19);
            labelRaridade.TabIndex = 2251;
            labelRaridade.Text = "Raridade:";
            labelRaridade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDownCmc
            // 
            numericUpDownCmc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDownCmc.Location = new Point(8, 505);
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
            checkBoxTipoDeCartaEncantamento.Location = new Point(8, 207);
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
            checkBoxTipoDeCartaMagicaInstantanea.Location = new Point(8, 179);
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
            checkBoxTipoDeCartaFeitico.Location = new Point(8, 151);
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
            labelDataDeCriacao.Location = new Point(8, 482);
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
            labelPrecoCarta.Location = new Point(8, 421);
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
            labelMax.Location = new Point(8, 463);
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
            buttonLimparFiltro.Location = new Point(8, 564);
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
            buttonAplicarFiltro.Location = new Point(8, 537);
            buttonAplicarFiltro.Name = "buttonAplicarFiltro";
            buttonAplicarFiltro.Size = new Size(185, 25);
            buttonAplicarFiltro.TabIndex = 17;
            buttonAplicarFiltro.Text = "Aplicar filtro";
            buttonAplicarFiltro.UseVisualStyleBackColor = true;
            buttonAplicarFiltro.Click += AoClicarAplicaSelecaoDeFiltros;
            // 
            // labelTipoDeCarta
            // 
            labelTipoDeCarta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTipoDeCarta.FlatStyle = FlatStyle.System;
            labelTipoDeCarta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoDeCarta.ImeMode = ImeMode.NoControl;
            labelTipoDeCarta.Location = new Point(8, 44);
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
            checkBoxAzul.Location = new Point(8, 258);
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
            checkBoxTipoDeCartaTerrenoBasico.Location = new Point(8, 95);
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
            labelMin.Location = new Point(8, 444);
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
            checkBoxVerde.Location = new Point(8, 314);
            checkBoxVerde.Name = "checkBoxVerde";
            checkBoxVerde.Size = new Size(69, 24);
            checkBoxVerde.TabIndex = 12;
            checkBoxVerde.Text = "Verde";
            checkBoxVerde.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoDeCartaTerreno
            // 
            checkBoxTipoDeCartaTerreno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxTipoDeCartaTerreno.FlatStyle = FlatStyle.System;
            checkBoxTipoDeCartaTerreno.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTipoDeCartaTerreno.ImeMode = ImeMode.NoControl;
            checkBoxTipoDeCartaTerreno.Location = new Point(8, 123);
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
            checkBoxTipoDeCartaCriatura.Location = new Point(8, 67);
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
            labelCor.Location = new Point(8, 235);
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
            checkBoxIncolor.Location = new Point(8, 286);
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
            dataGridViewCartas.AutoGenerateColumns = false;
            dataGridViewCartas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCartas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCartas.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeCartaDataGridViewTextBoxColumn, custoDeManaConvertidoCartaDataGridViewTextBoxColumn, tipoDeCartaDataGridViewTextBoxColumn, raridadeCartaDataGridViewTextBoxColumn, precoCartaDataGridViewTextBoxColumn, corCartaDataGridViewTextBoxColumn });
            dataGridViewCartas.DataSource = cartaBindingSource;
            dataGridViewCartas.Location = new Point(3, 48);
            dataGridViewCartas.Name = "dataGridViewCartas";
            dataGridViewCartas.ReadOnly = true;
            dataGridViewCartas.RowTemplate.Height = 25;
            dataGridViewCartas.Size = new Size(602, 541);
            dataGridViewCartas.TabIndex = 4;
            dataGridViewCartas.CellClick += AoClicarSelecionaCarta;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeCartaDataGridViewTextBoxColumn
            // 
            nomeCartaDataGridViewTextBoxColumn.DataPropertyName = "NomeCarta";
            nomeCartaDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeCartaDataGridViewTextBoxColumn.Name = "nomeCartaDataGridViewTextBoxColumn";
            nomeCartaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custoDeManaConvertidoCartaDataGridViewTextBoxColumn
            // 
            custoDeManaConvertidoCartaDataGridViewTextBoxColumn.DataPropertyName = "CustoDeManaConvertidoCarta";
            custoDeManaConvertidoCartaDataGridViewTextBoxColumn.HeaderText = "CMC";
            custoDeManaConvertidoCartaDataGridViewTextBoxColumn.Name = "custoDeManaConvertidoCartaDataGridViewTextBoxColumn";
            custoDeManaConvertidoCartaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDeCartaDataGridViewTextBoxColumn
            // 
            tipoDeCartaDataGridViewTextBoxColumn.DataPropertyName = "TipoDeCarta";
            tipoDeCartaDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDeCartaDataGridViewTextBoxColumn.Name = "tipoDeCartaDataGridViewTextBoxColumn";
            tipoDeCartaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // raridadeCartaDataGridViewTextBoxColumn
            // 
            raridadeCartaDataGridViewTextBoxColumn.DataPropertyName = "RaridadeCarta";
            raridadeCartaDataGridViewTextBoxColumn.HeaderText = "Raridade";
            raridadeCartaDataGridViewTextBoxColumn.Name = "raridadeCartaDataGridViewTextBoxColumn";
            raridadeCartaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoCartaDataGridViewTextBoxColumn
            // 
            precoCartaDataGridViewTextBoxColumn.DataPropertyName = "PrecoCarta";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            precoCartaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            precoCartaDataGridViewTextBoxColumn.HeaderText = "Preco";
            precoCartaDataGridViewTextBoxColumn.Name = "precoCartaDataGridViewTextBoxColumn";
            precoCartaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corCartaDataGridViewTextBoxColumn
            // 
            corCartaDataGridViewTextBoxColumn.DataPropertyName = "CorCarta";
            corCartaDataGridViewTextBoxColumn.HeaderText = "Cor";
            corCartaDataGridViewTextBoxColumn.Name = "corCartaDataGridViewTextBoxColumn";
            corCartaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cartaBindingSource
            // 
            cartaBindingSource.DataSource = typeof(Dominio.Modelos.Carta);
            // 
            // textBoxFiltrarNome
            // 
            textBoxFiltrarNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFiltrarNome.Cursor = Cursors.Hand;
            textBoxFiltrarNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFiltrarNome.Location = new Point(100, 13);
            textBoxFiltrarNome.Name = "textBoxFiltrarNome";
            textBoxFiltrarNome.Size = new Size(505, 25);
            textBoxFiltrarNome.TabIndex = 1;
            textBoxFiltrarNome.Enter += AoClicarAplicaSelecaoDeFiltros;
            // 
            // labelFiltroNome
            // 
            labelFiltroNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelFiltroNome.FlatStyle = FlatStyle.System;
            labelFiltroNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelFiltroNome.ImeMode = ImeMode.NoControl;
            labelFiltroNome.Location = new Point(3, 16);
            labelFiltroNome.Name = "labelFiltroNome";
            labelFiltroNome.Size = new Size(119, 19);
            labelFiltroNome.TabIndex = 0;
            labelFiltroNome.Text = "Nome da Carta:";
            labelFiltroNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(labelNomeBaralho);
            panel3.Controls.Add(labelFormatoBaralho);
            panel3.Controls.Add(labelNomeCartaSelecionada);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(buttonAdicionarCarta);
            panel3.Controls.Add(numericUpDownQuantidadeDeCopiasDeCarta);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(labelCorParcial);
            panel3.Controls.Add(labelPrecoParcial);
            panel3.Controls.Add(buttonVisualizarBaralho);
            panel3.Controls.Add(labelCustoParcial);
            panel3.Controls.Add(labelQuantidadeParcial);
            panel3.Controls.Add(labelNome);
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
            // labelNomeBaralho
            // 
            labelNomeBaralho.AutoSize = true;
            labelNomeBaralho.FlatStyle = FlatStyle.System;
            labelNomeBaralho.Location = new Point(8, 38);
            labelNomeBaralho.Name = "labelNomeBaralho";
            labelNomeBaralho.Size = new Size(0, 15);
            labelNomeBaralho.TabIndex = 2259;
            labelNomeBaralho.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelFormatoBaralho
            // 
            labelFormatoBaralho.AutoSize = true;
            labelFormatoBaralho.FlatStyle = FlatStyle.System;
            labelFormatoBaralho.Location = new Point(8, 84);
            labelFormatoBaralho.Name = "labelFormatoBaralho";
            labelFormatoBaralho.Size = new Size(0, 15);
            labelFormatoBaralho.TabIndex = 2260;
            labelFormatoBaralho.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNomeCartaSelecionada
            // 
            labelNomeCartaSelecionada.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelNomeCartaSelecionada.AutoSize = true;
            labelNomeCartaSelecionada.FlatStyle = FlatStyle.System;
            labelNomeCartaSelecionada.Location = new Point(8, 470);
            labelNomeCartaSelecionada.Name = "labelNomeCartaSelecionada";
            labelNomeCartaSelecionada.Size = new Size(0, 15);
            labelNomeCartaSelecionada.TabIndex = 0;
            labelNomeCartaSelecionada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 445);
            label3.Name = "label3";
            label3.Size = new Size(132, 19);
            label3.TabIndex = 0;
            label3.Text = "Carta selecionada:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonAdicionarCarta
            // 
            buttonAdicionarCarta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdicionarCarta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdicionarCarta.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdicionarCarta.ImeMode = ImeMode.NoControl;
            buttonAdicionarCarta.Location = new Point(8, 522);
            buttonAdicionarCarta.Name = "buttonAdicionarCarta";
            buttonAdicionarCarta.Size = new Size(185, 25);
            buttonAdicionarCarta.TabIndex = 2258;
            buttonAdicionarCarta.Text = "Adicionar carta ao baralho";
            buttonAdicionarCarta.UseVisualStyleBackColor = true;
            buttonAdicionarCarta.Click += AoClicarAdicionaCartaAoBaralho;
            // 
            // numericUpDownQuantidadeDeCopiasDeCarta
            // 
            numericUpDownQuantidadeDeCopiasDeCarta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDownQuantidadeDeCopiasDeCarta.Location = new Point(148, 493);
            numericUpDownQuantidadeDeCopiasDeCarta.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownQuantidadeDeCopiasDeCarta.Name = "numericUpDownQuantidadeDeCopiasDeCarta";
            numericUpDownQuantidadeDeCopiasDeCarta.Size = new Size(45, 23);
            numericUpDownQuantidadeDeCopiasDeCarta.TabIndex = 2257;
            numericUpDownQuantidadeDeCopiasDeCarta.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(8, 495);
            label1.Name = "label1";
            label1.Size = new Size(185, 19);
            label1.TabIndex = 2256;
            label1.Text = "Quantidade de cópias";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCorParcial
            // 
            labelCorParcial.AutoSize = true;
            labelCorParcial.FlatStyle = FlatStyle.System;
            labelCorParcial.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorParcial.Location = new Point(8, 268);
            labelCorParcial.Name = "labelCorParcial";
            labelCorParcial.Size = new Size(0, 15);
            labelCorParcial.TabIndex = 24;
            labelCorParcial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPrecoParcial
            // 
            labelPrecoParcial.AutoSize = true;
            labelPrecoParcial.FlatStyle = FlatStyle.System;
            labelPrecoParcial.Location = new Point(8, 222);
            labelPrecoParcial.Name = "labelPrecoParcial";
            labelPrecoParcial.Size = new Size(0, 15);
            labelPrecoParcial.TabIndex = 23;
            labelPrecoParcial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonVisualizarBaralho
            // 
            buttonVisualizarBaralho.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonVisualizarBaralho.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonVisualizarBaralho.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVisualizarBaralho.ImeMode = ImeMode.NoControl;
            buttonVisualizarBaralho.Location = new Point(8, 564);
            buttonVisualizarBaralho.Name = "buttonVisualizarBaralho";
            buttonVisualizarBaralho.Size = new Size(185, 25);
            buttonVisualizarBaralho.TabIndex = 20;
            buttonVisualizarBaralho.Text = "Visualizar lista de cartas";
            buttonVisualizarBaralho.UseVisualStyleBackColor = true;
            buttonVisualizarBaralho.Click += AoClicarVisualizaListaDeCartasDoBaralho;
            // 
            // labelCustoParcial
            // 
            labelCustoParcial.AutoSize = true;
            labelCustoParcial.FlatStyle = FlatStyle.System;
            labelCustoParcial.Location = new Point(8, 176);
            labelCustoParcial.Name = "labelCustoParcial";
            labelCustoParcial.Size = new Size(0, 15);
            labelCustoParcial.TabIndex = 22;
            labelCustoParcial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelQuantidadeParcial
            // 
            labelQuantidadeParcial.AutoSize = true;
            labelQuantidadeParcial.FlatStyle = FlatStyle.System;
            labelQuantidadeParcial.Location = new Point(8, 130);
            labelQuantidadeParcial.Name = "labelQuantidadeParcial";
            labelQuantidadeParcial.Size = new Size(0, 15);
            labelQuantidadeParcial.TabIndex = 21;
            labelQuantidadeParcial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.FlatStyle = FlatStyle.System;
            labelNome.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(8, 13);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(132, 19);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome do baralho:";
            labelNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelFormato
            // 
            labelFormato.AutoSize = true;
            labelFormato.FlatStyle = FlatStyle.System;
            labelFormato.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelFormato.Location = new Point(8, 59);
            labelFormato.Name = "labelFormato";
            labelFormato.Size = new Size(148, 19);
            labelFormato.TabIndex = 1;
            labelFormato.Text = "Formato do baralho:";
            labelFormato.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCorBaralho
            // 
            labelCorBaralho.AutoSize = true;
            labelCorBaralho.FlatStyle = FlatStyle.System;
            labelCorBaralho.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCorBaralho.Location = new Point(8, 243);
            labelCorBaralho.Name = "labelCorBaralho";
            labelCorBaralho.Size = new Size(38, 19);
            labelCorBaralho.TabIndex = 5;
            labelCorBaralho.Text = "Cor:";
            labelCorBaralho.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelQuantidadeDeCartas
            // 
            labelQuantidadeDeCartas.AutoSize = true;
            labelQuantidadeDeCartas.FlatStyle = FlatStyle.System;
            labelQuantidadeDeCartas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuantidadeDeCartas.Location = new Point(8, 105);
            labelQuantidadeDeCartas.Name = "labelQuantidadeDeCartas";
            labelQuantidadeDeCartas.Size = new Size(156, 19);
            labelQuantidadeDeCartas.TabIndex = 2;
            labelQuantidadeDeCartas.Text = "Quantidade de cartas:";
            labelQuantidadeDeCartas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPreco
            // 
            labelPreco.AutoSize = true;
            labelPreco.FlatStyle = FlatStyle.System;
            labelPreco.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelPreco.Location = new Point(8, 197);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(52, 19);
            labelPreco.TabIndex = 4;
            labelPreco.Text = "Preço:";
            labelPreco.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCmc
            // 
            labelCmc.AutoSize = true;
            labelCmc.FlatStyle = FlatStyle.System;
            labelCmc.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCmc.Location = new Point(8, 151);
            labelCmc.Name = "labelCmc";
            labelCmc.Size = new Size(189, 19);
            labelCmc.TabIndex = 3;
            labelCmc.Text = "Custo de mana convertido:";
            labelCmc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // baralhoBindingSource
            // 
            baralhoBindingSource.DataSource = typeof(Dominio.Modelos.Baralho);
            // 
            // FormEditarBaralho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 601);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1024, 640);
            Name = "FormEditarBaralho";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            Text = "MTG DeckBuilder - Criação de baralho";
            WindowState = FormWindowState.Maximized;
            Load += CarregarFromEditarBaralho;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCmc).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCartas).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartaBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidadeDeCopiasDeCarta).EndInit();
            ((System.ComponentModel.ISupportInitialize)baralhoBindingSource).EndInit();
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
        private Button buttonCancelar;
        private Button buttonVisualizarBaralho;
        private Label labelCorBaralho;
        private Label labelPreco;
        private Label labelCmc;
        private Label labelQuantidadeDeCartas;
        private Label labelQuantidadeParcial;
        private Label labelCustoParcial;
        private Label labelPrecoParcial;
        private Label labelCorParcial;
        private Label labelRaridade;
        private CheckBox checkBoxRaridadeIncomum;
        private CheckBox checkBoxRaridadeComum;
        private CheckBox checkBoxRaridadeRaro;
        private CheckBox checkBoxRaridadeMitico;
        private NumericUpDown numericUpDownQuantidadeDeCopiasDeCarta;
        private Label label1;
        private Button buttonAdicionarCarta;
        private BindingSource cartaBindingSource;
        private BindingSource baralhoBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn custoDeManaConvertidoCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDeCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn raridadeCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn corCartaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imagemDataGridViewTextBoxColumn;
        private Label labelNomeCartaSelecionada;
        private Label label3;
        private Label labelNomeBaralho;
        private Label labelFormatoBaralho;
        private Label labelNome;
        private Label labelFormato;
    }
}