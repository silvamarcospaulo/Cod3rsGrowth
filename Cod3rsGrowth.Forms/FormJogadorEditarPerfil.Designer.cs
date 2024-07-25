namespace Cod3rsGrowth.Forms
{
    partial class FormJogadorEditarPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogadorEditarPerfil));
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
            labelInformacoesDoPerfil = new Label();
            labelSobrenome = new Label();
            labelUsuario = new Label();
            labelDataDeNascimento = new Label();
            labelNomeJogador = new Label();
            labelSobrenomeJogador = new Label();
            labelUsuarioJogador = new Label();
            labelDataDeNascimentoJogador = new Label();
            buttonApagarPerfil = new Button();
            label2 = new Label();
            labelEncerrarPerfil = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            buttonVisualizarSenhaConfirmacao = new Button();
            buttonVisualizarSenha = new Button();
            SuspendLayout();
            // 
            // textBoxConfirmarNovaSenha
            // 
            resources.ApplyResources(textBoxConfirmarNovaSenha, "textBoxConfirmarNovaSenha");
            textBoxConfirmarNovaSenha.Name = "textBoxConfirmarNovaSenha";
            // 
            // labelConfirmarNovaSenha
            // 
            resources.ApplyResources(labelConfirmarNovaSenha, "labelConfirmarNovaSenha");
            labelConfirmarNovaSenha.FlatStyle = FlatStyle.System;
            labelConfirmarNovaSenha.Name = "labelConfirmarNovaSenha";
            // 
            // textBoxNovaSenha
            // 
            resources.ApplyResources(textBoxNovaSenha, "textBoxNovaSenha");
            textBoxNovaSenha.Cursor = Cursors.Hand;
            textBoxNovaSenha.Name = "textBoxNovaSenha";
            textBoxNovaSenha.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmarNovoUsuario
            // 
            resources.ApplyResources(textBoxConfirmarNovoUsuario, "textBoxConfirmarNovoUsuario");
            textBoxConfirmarNovoUsuario.Cursor = Cursors.Hand;
            textBoxConfirmarNovoUsuario.Name = "textBoxConfirmarNovoUsuario";
            // 
            // linkLabelCancelar
            // 
            resources.ApplyResources(linkLabelCancelar, "linkLabelCancelar");
            linkLabelCancelar.Cursor = Cursors.Hand;
            linkLabelCancelar.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelCancelar.Name = "linkLabelCancelar";
            linkLabelCancelar.TabStop = true;
            linkLabelCancelar.LinkClicked += AoClicarCancelaEdicaoDePerfil;
            // 
            // buttonEnviarAlteracoes
            // 
            resources.ApplyResources(buttonEnviarAlteracoes, "buttonEnviarAlteracoes");
            buttonEnviarAlteracoes.Cursor = Cursors.Hand;
            buttonEnviarAlteracoes.Name = "buttonEnviarAlteracoes";
            buttonEnviarAlteracoes.UseVisualStyleBackColor = true;
            buttonEnviarAlteracoes.Click += AoClicarEnviaAlteracoesDePerfil;
            // 
            // textBoxNovoUsuario
            // 
            resources.ApplyResources(textBoxNovoUsuario, "textBoxNovoUsuario");
            textBoxNovoUsuario.Cursor = Cursors.Hand;
            textBoxNovoUsuario.Name = "textBoxNovoUsuario";
            // 
            // labelNovaSenha
            // 
            resources.ApplyResources(labelNovaSenha, "labelNovaSenha");
            labelNovaSenha.FlatStyle = FlatStyle.System;
            labelNovaSenha.Name = "labelNovaSenha";
            // 
            // labelNovoUsuario
            // 
            resources.ApplyResources(labelNovoUsuario, "labelNovoUsuario");
            labelNovoUsuario.FlatStyle = FlatStyle.System;
            labelNovoUsuario.Name = "labelNovoUsuario";
            // 
            // labelConfirmarNovoUsuario
            // 
            resources.ApplyResources(labelConfirmarNovoUsuario, "labelConfirmarNovoUsuario");
            labelConfirmarNovoUsuario.FlatStyle = FlatStyle.System;
            labelConfirmarNovoUsuario.Name = "labelConfirmarNovoUsuario";
            // 
            // labelNome
            // 
            resources.ApplyResources(labelNome, "labelNome");
            labelNome.FlatStyle = FlatStyle.System;
            labelNome.Name = "labelNome";
            // 
            // labelInformacoesDoPerfil
            // 
            resources.ApplyResources(labelInformacoesDoPerfil, "labelInformacoesDoPerfil");
            labelInformacoesDoPerfil.FlatStyle = FlatStyle.System;
            labelInformacoesDoPerfil.Name = "labelInformacoesDoPerfil";
            // 
            // labelSobrenome
            // 
            resources.ApplyResources(labelSobrenome, "labelSobrenome");
            labelSobrenome.FlatStyle = FlatStyle.System;
            labelSobrenome.Name = "labelSobrenome";
            // 
            // labelUsuario
            // 
            resources.ApplyResources(labelUsuario, "labelUsuario");
            labelUsuario.FlatStyle = FlatStyle.System;
            labelUsuario.Name = "labelUsuario";
            // 
            // labelDataDeNascimento
            // 
            resources.ApplyResources(labelDataDeNascimento, "labelDataDeNascimento");
            labelDataDeNascimento.FlatStyle = FlatStyle.System;
            labelDataDeNascimento.Name = "labelDataDeNascimento";
            // 
            // labelNomeJogador
            // 
            resources.ApplyResources(labelNomeJogador, "labelNomeJogador");
            labelNomeJogador.FlatStyle = FlatStyle.System;
            labelNomeJogador.ForeColor = SystemColors.ControlDarkDark;
            labelNomeJogador.Name = "labelNomeJogador";
            // 
            // labelSobrenomeJogador
            // 
            resources.ApplyResources(labelSobrenomeJogador, "labelSobrenomeJogador");
            labelSobrenomeJogador.FlatStyle = FlatStyle.System;
            labelSobrenomeJogador.ForeColor = SystemColors.ControlDarkDark;
            labelSobrenomeJogador.Name = "labelSobrenomeJogador";
            // 
            // labelUsuarioJogador
            // 
            resources.ApplyResources(labelUsuarioJogador, "labelUsuarioJogador");
            labelUsuarioJogador.FlatStyle = FlatStyle.System;
            labelUsuarioJogador.ForeColor = SystemColors.ControlDarkDark;
            labelUsuarioJogador.Name = "labelUsuarioJogador";
            // 
            // labelDataDeNascimentoJogador
            // 
            resources.ApplyResources(labelDataDeNascimentoJogador, "labelDataDeNascimentoJogador");
            labelDataDeNascimentoJogador.FlatStyle = FlatStyle.System;
            labelDataDeNascimentoJogador.ForeColor = SystemColors.ControlDarkDark;
            labelDataDeNascimentoJogador.Name = "labelDataDeNascimentoJogador";
            // 
            // buttonApagarPerfil
            // 
            resources.ApplyResources(buttonApagarPerfil, "buttonApagarPerfil");
            buttonApagarPerfil.Cursor = Cursors.Hand;
            buttonApagarPerfil.Name = "buttonApagarPerfil";
            buttonApagarPerfil.UseVisualStyleBackColor = true;
            buttonApagarPerfil.Click += AoClicarApagaPerfil;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.FlatStyle = FlatStyle.System;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Name = "label2";
            // 
            // labelEncerrarPerfil
            // 
            resources.ApplyResources(labelEncerrarPerfil, "labelEncerrarPerfil");
            labelEncerrarPerfil.FlatStyle = FlatStyle.System;
            labelEncerrarPerfil.Name = "labelEncerrarPerfil";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.FlatStyle = FlatStyle.System;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.FlatStyle = FlatStyle.System;
            label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.FlatStyle = FlatStyle.System;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Name = "label1";
            // 
            // buttonVisualizarSenhaConfirmacao
            // 
            resources.ApplyResources(buttonVisualizarSenhaConfirmacao, "buttonVisualizarSenhaConfirmacao");
            buttonVisualizarSenhaConfirmacao.Name = "buttonVisualizarSenhaConfirmacao";
            buttonVisualizarSenhaConfirmacao.UseVisualStyleBackColor = true;
            buttonVisualizarSenhaConfirmacao.Click += AoClicarVisualizaConfirmacaoDeSenha;
            // 
            // buttonVisualizarSenha
            // 
            resources.ApplyResources(buttonVisualizarSenha, "buttonVisualizarSenha");
            buttonVisualizarSenha.Name = "buttonVisualizarSenha";
            buttonVisualizarSenha.UseVisualStyleBackColor = true;
            buttonVisualizarSenha.Click += AoClicarVisualizaSenha;
            // 
            // FormJogadorEditarPerfil
            // 
            AcceptButton = buttonEnviarAlteracoes;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = linkLabelCancelar;
            Controls.Add(buttonVisualizarSenhaConfirmacao);
            Controls.Add(buttonVisualizarSenha);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(labelEncerrarPerfil);
            Controls.Add(buttonApagarPerfil);
            Controls.Add(labelDataDeNascimentoJogador);
            Controls.Add(labelUsuarioJogador);
            Controls.Add(labelSobrenomeJogador);
            Controls.Add(labelNomeJogador);
            Controls.Add(labelDataDeNascimento);
            Controls.Add(labelUsuario);
            Controls.Add(labelSobrenome);
            Controls.Add(label1);
            Controls.Add(labelInformacoesDoPerfil);
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
            Name = "FormJogadorEditarPerfil";
            Load += CarregarJogadorEditarPerfil;
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
        private Label labelInformacoesDoPerfil;
        private Label labelSobrenome;
        private Label labelUsuario;
        private Label labelDataDeNascimento;
        private Label labelNomeJogador;
        private Label labelSobrenomeJogador;
        private Label labelUsuarioJogador;
        private Label labelDataDeNascimentoJogador;
        private Button buttonApagarPerfil;
        private Label label2;
        private Label labelEncerrarPerfil;
        private Label label3;
        private Label label4;
        private Label label1;
        private Button buttonVisualizarSenhaConfirmacao;
        private Button buttonVisualizarSenha;
    }
}