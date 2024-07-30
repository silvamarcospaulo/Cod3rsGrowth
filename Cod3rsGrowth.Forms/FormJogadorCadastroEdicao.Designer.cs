namespace Cod3rsGrowth.Forms
{
    partial class FormJogadorCadastroEdicao
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
            labelNome = new Label();
            labelUsername = new Label();
            labelSenha = new Label();
            labelDataDeNascimento = new Label();
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            textBoxNome = new TextBox();
            dateTimePickerDataDeNascimento = new DateTimePicker();
            buttonCadastrar = new Button();
            labelSobrenome = new Label();
            textBoxSobrenome = new TextBox();
            labelCadastro = new Label();
            labelConfirmarSenha = new Label();
            textBoxConfirmarSenha = new TextBox();
            buttonVisualizarSenha = new Button();
            buttonVisualizarSenhaConfirmacao = new Button();
            labelAlertaEncerrarConta = new Label();
            buttonApagarPerfil = new Button();
            textBoxConfirmarUsuario = new TextBox();
            labelConfirmarNovoUsuario = new Label();
            linkLabelJaPossuoConta = new LinkLabel();
            buttonCancelar = new Button();
            buttonEditar = new Button();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNome.AutoSize = true;
            labelNome.FlatStyle = FlatStyle.System;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(12, 66);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(56, 21);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelUsername.AutoSize = true;
            labelUsername.FlatStyle = FlatStyle.System;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(12, 178);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(67, 21);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Usuário:";
            // 
            // labelSenha
            // 
            labelSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelSenha.AutoSize = true;
            labelSenha.FlatStyle = FlatStyle.System;
            labelSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSenha.Location = new Point(12, 346);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(56, 21);
            labelSenha.TabIndex = 0;
            labelSenha.Text = "Senha:";
            // 
            // labelDataDeNascimento
            // 
            labelDataDeNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDataDeNascimento.AutoSize = true;
            labelDataDeNascimento.FlatStyle = FlatStyle.System;
            labelDataDeNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataDeNascimento.Location = new Point(12, 290);
            labelDataDeNascimento.Name = "labelDataDeNascimento";
            labelDataDeNascimento.Size = new Size(153, 21);
            labelDataDeNascimento.TabIndex = 0;
            labelDataDeNascimento.Text = "Data de Nascimento:";
            labelDataDeNascimento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsuario.Cursor = Cursors.Hand;
            textBoxUsuario.Location = new Point(12, 205);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(351, 23);
            textBoxUsuario.TabIndex = 3;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSenha.Cursor = Cursors.Hand;
            textBoxSenha.Location = new Point(12, 373);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(276, 23);
            textBoxSenha.TabIndex = 6;
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // textBoxNome
            // 
            textBoxNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNome.Cursor = Cursors.Hand;
            textBoxNome.Location = new Point(12, 93);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(351, 23);
            textBoxNome.TabIndex = 1;
            // 
            // dateTimePickerDataDeNascimento
            // 
            dateTimePickerDataDeNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerDataDeNascimento.Cursor = Cursors.Hand;
            dateTimePickerDataDeNascimento.DropDownAlign = LeftRightAlignment.Right;
            dateTimePickerDataDeNascimento.Format = DateTimePickerFormat.Short;
            dateTimePickerDataDeNascimento.Location = new Point(12, 317);
            dateTimePickerDataDeNascimento.MinDate = new DateTime(1924, 1, 1, 0, 0, 0, 0);
            dateTimePickerDataDeNascimento.Name = "dateTimePickerDataDeNascimento";
            dateTimePickerDataDeNascimento.Size = new Size(351, 23);
            dateTimePickerDataDeNascimento.TabIndex = 5;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCadastrar.Cursor = Cursors.Hand;
            buttonCadastrar.Location = new Point(12, 458);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(351, 36);
            buttonCadastrar.TabIndex = 10;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += AoClicarCadastrarNovoUsuario;
            // 
            // labelSobrenome
            // 
            labelSobrenome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelSobrenome.AutoSize = true;
            labelSobrenome.FlatStyle = FlatStyle.System;
            labelSobrenome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSobrenome.Location = new Point(12, 122);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(94, 21);
            labelSobrenome.TabIndex = 0;
            labelSobrenome.Text = "Sobrenome:";
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSobrenome.Cursor = Cursors.Hand;
            textBoxSobrenome.Location = new Point(12, 149);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(351, 23);
            textBoxSobrenome.TabIndex = 2;
            // 
            // labelCadastro
            // 
            labelCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCadastro.AutoSize = true;
            labelCadastro.FlatStyle = FlatStyle.System;
            labelCadastro.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastro.Location = new Point(12, 14);
            labelCadastro.Name = "labelCadastro";
            labelCadastro.Size = new Size(157, 37);
            labelCadastro.TabIndex = 8;
            labelCadastro.Text = "Cadastre-se";
            // 
            // labelConfirmarSenha
            // 
            labelConfirmarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelConfirmarSenha.AutoSize = true;
            labelConfirmarSenha.FlatStyle = FlatStyle.System;
            labelConfirmarSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelConfirmarSenha.Location = new Point(12, 402);
            labelConfirmarSenha.Name = "labelConfirmarSenha";
            labelConfirmarSenha.Size = new Size(129, 21);
            labelConfirmarSenha.TabIndex = 10;
            labelConfirmarSenha.Text = "Confirmar senha:";
            // 
            // textBoxConfirmarSenha
            // 
            textBoxConfirmarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConfirmarSenha.Location = new Point(12, 429);
            textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            textBoxConfirmarSenha.Size = new Size(276, 23);
            textBoxConfirmarSenha.TabIndex = 8;
            textBoxConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // buttonVisualizarSenha
            // 
            buttonVisualizarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonVisualizarSenha.Location = new Point(294, 373);
            buttonVisualizarSenha.Name = "buttonVisualizarSenha";
            buttonVisualizarSenha.Size = new Size(69, 23);
            buttonVisualizarSenha.TabIndex = 7;
            buttonVisualizarSenha.Text = "Visualizar";
            buttonVisualizarSenha.UseVisualStyleBackColor = true;
            buttonVisualizarSenha.Click += AoClicarVisualizaSenha;
            // 
            // buttonVisualizarSenhaConfirmacao
            // 
            buttonVisualizarSenhaConfirmacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonVisualizarSenhaConfirmacao.Location = new Point(294, 429);
            buttonVisualizarSenhaConfirmacao.Name = "buttonVisualizarSenhaConfirmacao";
            buttonVisualizarSenhaConfirmacao.Size = new Size(69, 23);
            buttonVisualizarSenhaConfirmacao.TabIndex = 9;
            buttonVisualizarSenhaConfirmacao.Text = "Visualizar";
            buttonVisualizarSenhaConfirmacao.UseVisualStyleBackColor = true;
            buttonVisualizarSenhaConfirmacao.Click += AoClicarVisualizaConfirmacaoDeSenha;
            // 
            // labelAlertaEncerrarConta
            // 
            labelAlertaEncerrarConta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelAlertaEncerrarConta.AutoSize = true;
            labelAlertaEncerrarConta.FlatStyle = FlatStyle.System;
            labelAlertaEncerrarConta.ForeColor = SystemColors.ControlDarkDark;
            labelAlertaEncerrarConta.ImeMode = ImeMode.NoControl;
            labelAlertaEncerrarConta.Location = new Point(13, 542);
            labelAlertaEncerrarConta.Name = "labelAlertaEncerrarConta";
            labelAlertaEncerrarConta.Size = new Size(275, 15);
            labelAlertaEncerrarConta.TabIndex = 41;
            labelAlertaEncerrarConta.Text = "Essa ação excluirá todos seus dados e é irreversível!";
            labelAlertaEncerrarConta.TextAlign = ContentAlignment.MiddleLeft;
            labelAlertaEncerrarConta.Visible = false;
            // 
            // buttonApagarPerfil
            // 
            buttonApagarPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonApagarPerfil.Cursor = Cursors.Hand;
            buttonApagarPerfil.Enabled = false;
            buttonApagarPerfil.ImeMode = ImeMode.NoControl;
            buttonApagarPerfil.Location = new Point(12, 500);
            buttonApagarPerfil.Name = "buttonApagarPerfil";
            buttonApagarPerfil.Size = new Size(351, 36);
            buttonApagarPerfil.TabIndex = 12;
            buttonApagarPerfil.Text = "Encerrar conta";
            buttonApagarPerfil.UseVisualStyleBackColor = true;
            buttonApagarPerfil.Visible = false;
            buttonApagarPerfil.Click += AoClicarApagaPerfil;
            // 
            // textBoxConfirmarUsuario
            // 
            textBoxConfirmarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConfirmarUsuario.Cursor = Cursors.Hand;
            textBoxConfirmarUsuario.Location = new Point(12, 261);
            textBoxConfirmarUsuario.Name = "textBoxConfirmarUsuario";
            textBoxConfirmarUsuario.Size = new Size(351, 23);
            textBoxConfirmarUsuario.TabIndex = 4;
            // 
            // labelConfirmarNovoUsuario
            // 
            labelConfirmarNovoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelConfirmarNovoUsuario.AutoSize = true;
            labelConfirmarNovoUsuario.FlatStyle = FlatStyle.System;
            labelConfirmarNovoUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelConfirmarNovoUsuario.ImeMode = ImeMode.NoControl;
            labelConfirmarNovoUsuario.Location = new Point(12, 234);
            labelConfirmarNovoUsuario.Name = "labelConfirmarNovoUsuario";
            labelConfirmarNovoUsuario.Size = new Size(140, 21);
            labelConfirmarNovoUsuario.TabIndex = 43;
            labelConfirmarNovoUsuario.Text = "Confirmar usuario:";
            // 
            // linkLabelJaPossuoConta
            // 
            linkLabelJaPossuoConta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            linkLabelJaPossuoConta.AutoSize = true;
            linkLabelJaPossuoConta.Cursor = Cursors.Hand;
            linkLabelJaPossuoConta.Enabled = false;
            linkLabelJaPossuoConta.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelJaPossuoConta.Location = new Point(161, 563);
            linkLabelJaPossuoConta.Name = "linkLabelJaPossuoConta";
            linkLabelJaPossuoConta.Size = new Size(53, 15);
            linkLabelJaPossuoConta.TabIndex = 13;
            linkLabelJaPossuoConta.TabStop = true;
            linkLabelJaPossuoConta.Text = "Cancelar";
            linkLabelJaPossuoConta.TextAlign = ContentAlignment.MiddleCenter;
            linkLabelJaPossuoConta.Visible = false;
            linkLabelJaPossuoConta.LinkClicked += AoClicarLinkVoltarParaTelaDeListaDeBaralho;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.ImeMode = ImeMode.NoControl;
            buttonCancelar.Location = new Point(12, 500);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(351, 36);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += AoClicarVoltarParaTelaDeLogin;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonEditar.Cursor = Cursors.Hand;
            buttonEditar.Enabled = false;
            buttonEditar.Location = new Point(12, 458);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(351, 36);
            buttonEditar.TabIndex = 44;
            buttonEditar.Text = "Enviar alterações";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Visible = false;
            buttonEditar.Click += AoClicarEnviaAlteracoesDePerfil;
            // 
            // FormJogadorCadastroEdicao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 564);
            Controls.Add(textBoxConfirmarUsuario);
            Controls.Add(labelConfirmarNovoUsuario);
            Controls.Add(buttonVisualizarSenhaConfirmacao);
            Controls.Add(buttonVisualizarSenha);
            Controls.Add(textBoxConfirmarSenha);
            Controls.Add(labelConfirmarSenha);
            Controls.Add(textBoxSenha);
            Controls.Add(labelCadastro);
            Controls.Add(textBoxSobrenome);
            Controls.Add(linkLabelJaPossuoConta);
            Controls.Add(buttonCadastrar);
            Controls.Add(dateTimePickerDataDeNascimento);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelSenha);
            Controls.Add(labelUsername);
            Controls.Add(labelNome);
            Controls.Add(labelSobrenome);
            Controls.Add(labelDataDeNascimento);
            Controls.Add(labelAlertaEncerrarConta);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonApagarPerfil);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormJogadorCadastroEdicao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MTG DeckBuilder - Cadastro";
            Load += CarregarFormJogadorCadastroEdicao;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelUsername;
        private Label labelSenha;
        private Label labelDataDeNascimento;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private TextBox textBoxNome;
        private DateTimePicker dateTimePickerDataDeNascimento;
        private Button buttonCadastrar;
        private Label labelSobrenome;
        private TextBox textBoxSobrenome;
        private Label labelCadastro;
        private Label labelConfirmarSenha;
        private TextBox textBoxConfirmarSenha;
        private Button buttonVisualizarSenha;
        private Button buttonVisualizarSenhaConfirmacao;
        private Label labelAlertaEncerrarConta;
        private Button buttonApagarPerfil;
        private TextBox textBoxConfirmarUsuario;
        private Label labelConfirmarNovoUsuario;
        private LinkLabel linkLabelJaPossuoConta;
        private Button buttonCancelar;
        private Button buttonEditar;
    }
}