namespace Cod3rsGrowth.Forms
{
    partial class FormJogadorCadastro
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
            linkLabelJaPossuoConta = new LinkLabel();
            labelSobrenome = new Label();
            textBoxSobrenome = new TextBox();
            labelCadastro = new Label();
            label1 = new Label();
            labelConfirmarSenha = new Label();
            textBoxConfirmarSenha = new TextBox();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNome.AutoSize = true;
            labelNome.FlatStyle = FlatStyle.System;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(12, 82);
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
            labelUsername.Location = new Point(12, 196);
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
            labelSenha.Location = new Point(12, 310);
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
            labelDataDeNascimento.Location = new Point(12, 253);
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
            textBoxUsuario.Location = new Point(12, 226);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(351, 23);
            textBoxUsuario.TabIndex = 3;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSenha.Cursor = Cursors.Hand;
            textBoxSenha.Location = new Point(12, 337);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(351, 23);
            textBoxSenha.TabIndex = 5;
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // textBoxNome
            // 
            textBoxNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNome.Cursor = Cursors.Hand;
            textBoxNome.Location = new Point(12, 112);
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
            dateTimePickerDataDeNascimento.Location = new Point(12, 283);
            dateTimePickerDataDeNascimento.MinDate = new DateTime(1924, 1, 1, 0, 0, 0, 0);
            dateTimePickerDataDeNascimento.Name = "dateTimePickerDataDeNascimento";
            dateTimePickerDataDeNascimento.Size = new Size(351, 23);
            dateTimePickerDataDeNascimento.TabIndex = 4;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCadastrar.Cursor = Cursors.Hand;
            buttonCadastrar.Location = new Point(12, 427);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(351, 36);
            buttonCadastrar.TabIndex = 7;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += AoClicarCadastrarNovoUsuario;
            // 
            // linkLabelJaPossuoConta
            // 
            linkLabelJaPossuoConta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabelJaPossuoConta.AutoSize = true;
            linkLabelJaPossuoConta.Cursor = Cursors.Hand;
            linkLabelJaPossuoConta.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelJaPossuoConta.Location = new Point(142, 473);
            linkLabelJaPossuoConta.Name = "linkLabelJaPossuoConta";
            linkLabelJaPossuoConta.Size = new Size(91, 15);
            linkLabelJaPossuoConta.TabIndex = 8;
            linkLabelJaPossuoConta.TabStop = true;
            linkLabelJaPossuoConta.Text = "Já possuo conta";
            linkLabelJaPossuoConta.TextAlign = ContentAlignment.MiddleCenter;
            linkLabelJaPossuoConta.LinkClicked += AoClicarVoltarParaTelaDeLogin;
            // 
            // labelSobrenome
            // 
            labelSobrenome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelSobrenome.AutoSize = true;
            labelSobrenome.FlatStyle = FlatStyle.System;
            labelSobrenome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSobrenome.Location = new Point(12, 139);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(94, 21);
            labelSobrenome.TabIndex = 0;
            labelSobrenome.Text = "Sobrenome:";
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSobrenome.Cursor = Cursors.Hand;
            textBoxSobrenome.Location = new Point(12, 166);
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
            labelCadastro.Location = new Point(12, 9);
            labelCadastro.Name = "labelCadastro";
            labelCadastro.Size = new Size(157, 37);
            labelCadastro.TabIndex = 8;
            labelCadastro.Text = "Cadastre-se";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 9;
            label1.Text = "É rápido e fácil!";
            // 
            // labelConfirmarSenha
            // 
            labelConfirmarSenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelConfirmarSenha.AutoSize = true;
            labelConfirmarSenha.FlatStyle = FlatStyle.System;
            labelConfirmarSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelConfirmarSenha.Location = new Point(12, 364);
            labelConfirmarSenha.Name = "labelConfirmarSenha";
            labelConfirmarSenha.Size = new Size(129, 21);
            labelConfirmarSenha.TabIndex = 10;
            labelConfirmarSenha.Text = "Confirmar senha:";
            // 
            // textBoxConfirmarSenha
            // 
            textBoxConfirmarSenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConfirmarSenha.Location = new Point(12, 391);
            textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            textBoxConfirmarSenha.Size = new Size(351, 23);
            textBoxConfirmarSenha.TabIndex = 6;
            // 
            // FormsJogadorCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 500);
            Controls.Add(textBoxConfirmarSenha);
            Controls.Add(labelConfirmarSenha);
            Controls.Add(textBoxSenha);
            Controls.Add(label1);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormsJogadorCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MTG DeckBuilder - Cadastro";
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
        private LinkLabel linkLabelJaPossuoConta;
        private Label labelSobrenome;
        private TextBox textBoxSobrenome;
        private Label labelCadastro;
        private Label label1;
        private Label labelConfirmarSenha;
        private TextBox textBoxConfirmarSenha;
    }
}