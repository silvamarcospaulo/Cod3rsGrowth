namespace Cod3rsGrowth.Forms
{
    partial class FormsEditarPerfil
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
            textBoxConfirmarNovaSenha = new TextBox();
            labelConfirmarNovaSenha = new Label();
            textBoxNovaSenha = new TextBox();
            textBoxConfirmarNovoUsuario = new TextBox();
            linkLabelCancelar = new LinkLabel();
            buttonEnviarAlteracoes = new Button();
            textBoxNovoUsuario = new TextBox();
            labelNovaSenha = new Label();
            labelNovoUsuario = new Label();
            labelConfirmarNovoUsuario = new Label();
            labelNome = new Label();
            labelEditarPerfil = new Label();
            label1 = new Label();
            labelSobrenome = new Label();
            labelUsuario = new Label();
            labelDataDeNascimento = new Label();
            labelNomeJogador = new Label();
            labelSobrenomeJogador = new Label();
            labelUsuarioJogador = new Label();
            labelDataDeNascimentoJogador = new Label();
            SuspendLayout();
            // 
            // textBoxConfirmarNovaSenha
            // 
            textBoxConfirmarNovaSenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConfirmarNovaSenha.Location = new Point(12, 447);
            textBoxConfirmarNovaSenha.Name = "textBoxConfirmarNovaSenha";
            textBoxConfirmarNovaSenha.Size = new Size(351, 23);
            textBoxConfirmarNovaSenha.TabIndex = 21;
            // 
            // labelConfirmarNovaSenha
            // 
            labelConfirmarNovaSenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelConfirmarNovaSenha.AutoSize = true;
            labelConfirmarNovaSenha.FlatStyle = FlatStyle.System;
            labelConfirmarNovaSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelConfirmarNovaSenha.Location = new Point(12, 417);
            labelConfirmarNovaSenha.Name = "labelConfirmarNovaSenha";
            labelConfirmarNovaSenha.Size = new Size(167, 21);
            labelConfirmarNovaSenha.TabIndex = 26;
            labelConfirmarNovaSenha.Text = "Confirmar nova senha:";
            // 
            // textBoxNovaSenha
            // 
            textBoxNovaSenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNovaSenha.Cursor = Cursors.Hand;
            textBoxNovaSenha.Location = new Point(12, 385);
            textBoxNovaSenha.Name = "textBoxNovaSenha";
            textBoxNovaSenha.Size = new Size(351, 23);
            textBoxNovaSenha.TabIndex = 20;
            textBoxNovaSenha.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmarNovoUsuario
            // 
            textBoxConfirmarNovoUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConfirmarNovoUsuario.Cursor = Cursors.Hand;
            textBoxConfirmarNovoUsuario.Location = new Point(12, 323);
            textBoxConfirmarNovoUsuario.Name = "textBoxConfirmarNovoUsuario";
            textBoxConfirmarNovoUsuario.Size = new Size(351, 23);
            textBoxConfirmarNovoUsuario.TabIndex = 17;
            // 
            // linkLabelCancelar
            // 
            linkLabelCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabelCancelar.AutoSize = true;
            linkLabelCancelar.Cursor = Cursors.Hand;
            linkLabelCancelar.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelCancelar.Location = new Point(161, 524);
            linkLabelCancelar.Name = "linkLabelCancelar";
            linkLabelCancelar.Size = new Size(53, 15);
            linkLabelCancelar.TabIndex = 24;
            linkLabelCancelar.TabStop = true;
            linkLabelCancelar.Text = "Cancelar";
            linkLabelCancelar.TextAlign = ContentAlignment.MiddleCenter;
            linkLabelCancelar.LinkClicked += linkLabelCancelar_LinkClicked;
            // 
            // buttonEnviarAlteracoes
            // 
            buttonEnviarAlteracoes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEnviarAlteracoes.Cursor = Cursors.Hand;
            buttonEnviarAlteracoes.Location = new Point(12, 479);
            buttonEnviarAlteracoes.Name = "buttonEnviarAlteracoes";
            buttonEnviarAlteracoes.Size = new Size(351, 36);
            buttonEnviarAlteracoes.TabIndex = 22;
            buttonEnviarAlteracoes.Text = "Enviar alterações";
            buttonEnviarAlteracoes.UseVisualStyleBackColor = true;
            buttonEnviarAlteracoes.Click += buttonEnviarAlteracoes_Click;
            // 
            // textBoxNovoUsuario
            // 
            textBoxNovoUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNovoUsuario.Cursor = Cursors.Hand;
            textBoxNovoUsuario.Location = new Point(12, 261);
            textBoxNovoUsuario.Name = "textBoxNovoUsuario";
            textBoxNovoUsuario.Size = new Size(351, 23);
            textBoxNovoUsuario.TabIndex = 16;
            // 
            // labelNovaSenha
            // 
            labelNovaSenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNovaSenha.AutoSize = true;
            labelNovaSenha.FlatStyle = FlatStyle.System;
            labelNovaSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNovaSenha.Location = new Point(12, 355);
            labelNovaSenha.Name = "labelNovaSenha";
            labelNovaSenha.Size = new Size(95, 21);
            labelNovaSenha.TabIndex = 11;
            labelNovaSenha.Text = "Nova senha:";
            // 
            // labelNovoUsuario
            // 
            labelNovoUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNovoUsuario.AutoSize = true;
            labelNovoUsuario.FlatStyle = FlatStyle.System;
            labelNovoUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNovoUsuario.Location = new Point(12, 231);
            labelNovoUsuario.Name = "labelNovoUsuario";
            labelNovoUsuario.Size = new Size(107, 21);
            labelNovoUsuario.TabIndex = 13;
            labelNovoUsuario.Text = "Novo usuário:";
            // 
            // labelConfirmarNovoUsuario
            // 
            labelConfirmarNovoUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelConfirmarNovoUsuario.AutoSize = true;
            labelConfirmarNovoUsuario.FlatStyle = FlatStyle.System;
            labelConfirmarNovoUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelConfirmarNovoUsuario.Location = new Point(12, 293);
            labelConfirmarNovoUsuario.Name = "labelConfirmarNovoUsuario";
            labelConfirmarNovoUsuario.Size = new Size(179, 21);
            labelConfirmarNovoUsuario.TabIndex = 14;
            labelConfirmarNovoUsuario.Text = "Confirmar novo usuario:";
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNome.AutoSize = true;
            labelNome.FlatStyle = FlatStyle.System;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(12, 72);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(56, 21);
            labelNome.TabIndex = 27;
            labelNome.Text = "Nome:";
            // 
            // labelEditarPerfil
            // 
            labelEditarPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEditarPerfil.AutoSize = true;
            labelEditarPerfil.FlatStyle = FlatStyle.System;
            labelEditarPerfil.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditarPerfil.Location = new Point(12, 9);
            labelEditarPerfil.Name = "labelEditarPerfil";
            labelEditarPerfil.Size = new Size(154, 37);
            labelEditarPerfil.TabIndex = 28;
            labelEditarPerfil.Text = "Editar perfil";
            labelEditarPerfil.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 29;
            label1.Text = "Edite Usuário e Senha.";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSobrenome
            // 
            labelSobrenome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelSobrenome.AutoSize = true;
            labelSobrenome.FlatStyle = FlatStyle.System;
            labelSobrenome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSobrenome.Location = new Point(12, 106);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(94, 21);
            labelSobrenome.TabIndex = 30;
            labelSobrenome.Text = "Sobrenome:";
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelUsuario.AutoSize = true;
            labelUsuario.FlatStyle = FlatStyle.System;
            labelUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsuario.Location = new Point(12, 140);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(67, 21);
            labelUsuario.TabIndex = 31;
            labelUsuario.Text = "Usuário:";
            // 
            // labelDataDeNascimento
            // 
            labelDataDeNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDataDeNascimento.AutoSize = true;
            labelDataDeNascimento.FlatStyle = FlatStyle.System;
            labelDataDeNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataDeNascimento.Location = new Point(12, 174);
            labelDataDeNascimento.Name = "labelDataDeNascimento";
            labelDataDeNascimento.Size = new Size(153, 21);
            labelDataDeNascimento.TabIndex = 32;
            labelDataDeNascimento.Text = "Data de Nascimento:";
            // 
            // labelNomeJogador
            // 
            labelNomeJogador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNomeJogador.AutoSize = true;
            labelNomeJogador.FlatStyle = FlatStyle.System;
            labelNomeJogador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomeJogador.ForeColor = SystemColors.ControlDarkDark;
            labelNomeJogador.Location = new Point(74, 72);
            labelNomeJogador.Name = "labelNomeJogador";
            labelNomeJogador.Size = new Size(43, 21);
            labelNomeJogador.TabIndex = 33;
            labelNomeJogador.Text = "label";
            // 
            // labelSobrenomeJogador
            // 
            labelSobrenomeJogador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelSobrenomeJogador.AutoSize = true;
            labelSobrenomeJogador.FlatStyle = FlatStyle.System;
            labelSobrenomeJogador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSobrenomeJogador.ForeColor = SystemColors.ControlDarkDark;
            labelSobrenomeJogador.Location = new Point(112, 106);
            labelSobrenomeJogador.Name = "labelSobrenomeJogador";
            labelSobrenomeJogador.Size = new Size(43, 21);
            labelSobrenomeJogador.TabIndex = 34;
            labelSobrenomeJogador.Text = "label";
            // 
            // labelUsuarioJogador
            // 
            labelUsuarioJogador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelUsuarioJogador.AutoSize = true;
            labelUsuarioJogador.FlatStyle = FlatStyle.System;
            labelUsuarioJogador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsuarioJogador.ForeColor = SystemColors.ControlDarkDark;
            labelUsuarioJogador.Location = new Point(85, 140);
            labelUsuarioJogador.Name = "labelUsuarioJogador";
            labelUsuarioJogador.Size = new Size(43, 21);
            labelUsuarioJogador.TabIndex = 35;
            labelUsuarioJogador.Text = "label";
            // 
            // labelDataDeNascimentoJogador
            // 
            labelDataDeNascimentoJogador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDataDeNascimentoJogador.AutoSize = true;
            labelDataDeNascimentoJogador.FlatStyle = FlatStyle.System;
            labelDataDeNascimentoJogador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataDeNascimentoJogador.ForeColor = SystemColors.ControlDarkDark;
            labelDataDeNascimentoJogador.Location = new Point(171, 174);
            labelDataDeNascimentoJogador.Name = "labelDataDeNascimentoJogador";
            labelDataDeNascimentoJogador.Size = new Size(43, 21);
            labelDataDeNascimentoJogador.TabIndex = 36;
            labelDataDeNascimentoJogador.Text = "label";
            // 
            // FormsEditarPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 552);
            Controls.Add(labelDataDeNascimentoJogador);
            Controls.Add(labelUsuarioJogador);
            Controls.Add(labelSobrenomeJogador);
            Controls.Add(labelNomeJogador);
            Controls.Add(labelDataDeNascimento);
            Controls.Add(labelUsuario);
            Controls.Add(labelSobrenome);
            Controls.Add(label1);
            Controls.Add(labelEditarPerfil);
            Controls.Add(labelNome);
            Controls.Add(textBoxConfirmarNovaSenha);
            Controls.Add(labelConfirmarNovaSenha);
            Controls.Add(textBoxNovaSenha);
            Controls.Add(textBoxConfirmarNovoUsuario);
            Controls.Add(linkLabelCancelar);
            Controls.Add(buttonEnviarAlteracoes);
            Controls.Add(textBoxNovoUsuario);
            Controls.Add(labelNovaSenha);
            Controls.Add(labelNovoUsuario);
            Controls.Add(labelConfirmarNovoUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormsEditarPerfil";
            Text = "MTG DeckBuilder - Editar Perfil";
            TopMost = true;
            Load += FormsEditarPerfil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxConfirmarNovaSenha;
        private Label labelConfirmarNovaSenha;
        private TextBox textBoxNovaSenha;
        private Label labelCadastro;
        private TextBox textBoxConfirmarNovoUsuario;
        private LinkLabel linkLabelCancelar;
        private Button buttonEnviarAlteracoes;
        private TextBox textBoxNovoUsuario;
        private Label labelNovaSenha;
        private Label labelNovoUsuario;
        private Label labelConfirmarNovoUsuario;
        private Label labelNome;
        private Label labelEditarPerfil;
        private Label label1;
        private Label labelSobrenome;
        private Label labelUsuario;
        private Label labelDataDeNascimento;
        private Label labelNomeJogador;
        private Label labelSobrenomeJogador;
        private Label labelUsuarioJogador;
        private Label labelDataDeNascimentoJogador;
    }
}