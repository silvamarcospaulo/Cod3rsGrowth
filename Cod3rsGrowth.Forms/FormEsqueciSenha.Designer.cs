namespace Cod3rsGrowth.Forms
{
    partial class FormEsqueciSenha
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
            dateTimePickerDataDeNascimento = new DateTimePicker();
            labelDataDeNascimento = new Label();
            labelNovaSenha = new Label();
            labelUsername = new Label();
            labelNome = new Label();
            labelSobrenome = new Label();
            textBoxNome = new TextBox();
            textBoxSobrenome = new TextBox();
            textBoxNovasenha = new TextBox();
            textBoxUsuario = new TextBox();
            linkLabelCancelar = new LinkLabel();
            labelEsqueciSenha = new Label();
            label1 = new Label();
            labelConfirmarNovaSenha = new Label();
            textBoxConfirmarNovaSenha = new TextBox();
            buttonAtualizar = new Button();
            buttonVisualizarSenhaConfirmacao = new Button();
            buttonVisualizarSenha = new Button();
            SuspendLayout();
            // 
            // dateTimePickerDataDeNascimento
            // 
            dateTimePickerDataDeNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerDataDeNascimento.Cursor = Cursors.Hand;
            dateTimePickerDataDeNascimento.Format = DateTimePickerFormat.Short;
            dateTimePickerDataDeNascimento.Location = new Point(12, 283);
            dateTimePickerDataDeNascimento.Name = "dateTimePickerDataDeNascimento";
            dateTimePickerDataDeNascimento.Size = new Size(351, 23);
            dateTimePickerDataDeNascimento.TabIndex = 4;
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
            // 
            // labelNovaSenha
            // 
            labelNovaSenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNovaSenha.AutoSize = true;
            labelNovaSenha.FlatStyle = FlatStyle.System;
            labelNovaSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNovaSenha.Location = new Point(12, 310);
            labelNovaSenha.Name = "labelNovaSenha";
            labelNovaSenha.Size = new Size(95, 21);
            labelNovaSenha.TabIndex = 0;
            labelNovaSenha.Text = "Nova senha:";
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
            // textBoxNome
            // 
            textBoxNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNome.Cursor = Cursors.Hand;
            textBoxNome.Location = new Point(12, 112);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(351, 23);
            textBoxNome.TabIndex = 1;
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
            // textBoxNovasenha
            // 
            textBoxNovasenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNovasenha.Cursor = Cursors.Hand;
            textBoxNovasenha.Location = new Point(12, 337);
            textBoxNovasenha.Name = "textBoxNovasenha";
            textBoxNovasenha.Size = new Size(276, 23);
            textBoxNovasenha.TabIndex = 5;
            textBoxNovasenha.UseSystemPasswordChar = true;
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
            // linkLabelCancelar
            // 
            linkLabelCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabelCancelar.AutoSize = true;
            linkLabelCancelar.Cursor = Cursors.Hand;
            linkLabelCancelar.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelCancelar.Location = new Point(161, 473);
            linkLabelCancelar.Name = "linkLabelCancelar";
            linkLabelCancelar.Size = new Size(53, 15);
            linkLabelCancelar.TabIndex = 8;
            linkLabelCancelar.TabStop = true;
            linkLabelCancelar.Text = "Cancelar";
            linkLabelCancelar.LinkClicked += AoClicarCancelaRestauracaoDeSenha;
            // 
            // labelEsqueciSenha
            // 
            labelEsqueciSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEsqueciSenha.AutoSize = true;
            labelEsqueciSenha.FlatStyle = FlatStyle.System;
            labelEsqueciSenha.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelEsqueciSenha.Location = new Point(12, 9);
            labelEsqueciSenha.Name = "labelEsqueciSenha";
            labelEsqueciSenha.Size = new Size(238, 37);
            labelEsqueciSenha.TabIndex = 8;
            labelEsqueciSenha.Text = "Restaure sua conta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 9;
            label1.Text = "Insira seus dados corretamente \r\ne sua nova senha.";
            // 
            // labelConfirmarNovaSenha
            // 
            labelConfirmarNovaSenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelConfirmarNovaSenha.AutoSize = true;
            labelConfirmarNovaSenha.FlatStyle = FlatStyle.System;
            labelConfirmarNovaSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelConfirmarNovaSenha.Location = new Point(12, 363);
            labelConfirmarNovaSenha.Name = "labelConfirmarNovaSenha";
            labelConfirmarNovaSenha.Size = new Size(167, 21);
            labelConfirmarNovaSenha.TabIndex = 10;
            labelConfirmarNovaSenha.Text = "Confirmar nova senha:";
            // 
            // textBoxConfirmarNovaSenha
            // 
            textBoxConfirmarNovaSenha.Location = new Point(12, 391);
            textBoxConfirmarNovaSenha.Name = "textBoxConfirmarNovaSenha";
            textBoxConfirmarNovaSenha.Size = new Size(276, 23);
            textBoxConfirmarNovaSenha.TabIndex = 6;
            textBoxConfirmarNovaSenha.UseSystemPasswordChar = true;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAtualizar.Location = new Point(12, 427);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(351, 36);
            buttonAtualizar.TabIndex = 7;
            buttonAtualizar.Text = "Redefinir senha";
            buttonAtualizar.UseVisualStyleBackColor = true;
            buttonAtualizar.Click += AoClicarRestauraSenhaDoJogador;
            // 
            // buttonVisualizarSenhaConfirmacao
            // 
            buttonVisualizarSenhaConfirmacao.Location = new Point(294, 391);
            buttonVisualizarSenhaConfirmacao.Name = "buttonVisualizarSenhaConfirmacao";
            buttonVisualizarSenhaConfirmacao.Size = new Size(69, 23);
            buttonVisualizarSenhaConfirmacao.TabIndex = 14;
            buttonVisualizarSenhaConfirmacao.Text = "Visualizar";
            buttonVisualizarSenhaConfirmacao.UseVisualStyleBackColor = true;
            buttonVisualizarSenhaConfirmacao.Click += AoClicarVisualizaConfirmacaoDeSenha;
            // 
            // buttonVisualizarSenha
            // 
            buttonVisualizarSenha.Location = new Point(294, 337);
            buttonVisualizarSenha.Name = "buttonVisualizarSenha";
            buttonVisualizarSenha.Size = new Size(69, 23);
            buttonVisualizarSenha.TabIndex = 13;
            buttonVisualizarSenha.Text = "Visualizar";
            buttonVisualizarSenha.UseVisualStyleBackColor = true;
            buttonVisualizarSenha.Click += AoClicarVisualizaSenha;
            // 
            // FormEsqueciSenha
            // 
            AcceptButton = buttonAtualizar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 500);
            Controls.Add(buttonVisualizarSenhaConfirmacao);
            Controls.Add(buttonVisualizarSenha);
            Controls.Add(buttonAtualizar);
            Controls.Add(textBoxConfirmarNovaSenha);
            Controls.Add(labelConfirmarNovaSenha);
            Controls.Add(label1);
            Controls.Add(labelEsqueciSenha);
            Controls.Add(linkLabelCancelar);
            Controls.Add(textBoxUsuario);
            Controls.Add(textBoxNovasenha);
            Controls.Add(textBoxSobrenome);
            Controls.Add(textBoxNome);
            Controls.Add(dateTimePickerDataDeNascimento);
            Controls.Add(labelNovaSenha);
            Controls.Add(labelUsername);
            Controls.Add(labelNome);
            Controls.Add(labelSobrenome);
            Controls.Add(labelDataDeNascimento);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormEsqueciSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MTG DeckBuilder - Esqueci Senha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerDataDeNascimento;
        private Label labelDataDeNascimento;
        private Label labelNovaSenha;
        private Label labelUsername;
        private Label labelNome;
        private Label labelSobrenome;
        private TextBox textBoxNome;
        private TextBox textBoxSobrenome;
        private TextBox textBoxNovasenha;
        private TextBox textBoxUsuario;
        private LinkLabel linkLabelCancelar;
        private Label labelEsqueciSenha;
        private Label label1;
        private Label labelConfirmarNovaSenha;
        private TextBox textBoxConfirmarNovaSenha;
        private Button buttonAtualizar;
        private Button buttonVisualizarSenhaConfirmacao;
        private Button buttonVisualizarSenha;
    }
}