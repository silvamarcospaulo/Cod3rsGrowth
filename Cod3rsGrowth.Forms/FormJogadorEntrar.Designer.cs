﻿namespace Cod3rsGrowth.Forms
{
    partial class FormJogadorEntrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogadorEntrar));
            labelNome = new Label();
            textBoxSenha = new TextBox();
            textBoxUsuario = new TextBox();
            labelSenha = new Label();
            buttonEntrar = new Button();
            linkLabelEsqueciSenha = new LinkLabel();
            linkLabelCadastrar = new LinkLabel();
            labelMtgDeckBuilder = new Label();
            labelUsuarioMensagemDeErro = new Label();
            labelSenhaMensagemDeErro = new Label();
            SuspendLayout();
            // 
            // labelNome
            // 
            resources.ApplyResources(labelNome, "labelNome");
            labelNome.FlatStyle = FlatStyle.System;
            labelNome.Name = "labelNome";
            // 
            // textBoxSenha
            // 
            resources.ApplyResources(textBoxSenha, "textBoxSenha");
            textBoxSenha.Cursor = Cursors.Hand;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // textBoxUsuario
            // 
            resources.ApplyResources(textBoxUsuario, "textBoxUsuario");
            textBoxUsuario.Cursor = Cursors.Hand;
            textBoxUsuario.Name = "textBoxUsuario";
            // 
            // labelSenha
            // 
            resources.ApplyResources(labelSenha, "labelSenha");
            labelSenha.FlatStyle = FlatStyle.System;
            labelSenha.Name = "labelSenha";
            // 
            // buttonEntrar
            // 
            resources.ApplyResources(buttonEntrar, "buttonEntrar");
            buttonEntrar.Cursor = Cursors.Hand;
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += AoClicarAutenticaUsuarioSenha;
            // 
            // linkLabelEsqueciSenha
            // 
            resources.ApplyResources(linkLabelEsqueciSenha, "linkLabelEsqueciSenha");
            linkLabelEsqueciSenha.Cursor = Cursors.Hand;
            linkLabelEsqueciSenha.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelEsqueciSenha.Name = "linkLabelEsqueciSenha";
            linkLabelEsqueciSenha.TabStop = true;
            linkLabelEsqueciSenha.LinkClicked += AoClicarAbreTelaDeRestauracaoDeSenha;
            // 
            // linkLabelCadastrar
            // 
            resources.ApplyResources(linkLabelCadastrar, "linkLabelCadastrar");
            linkLabelCadastrar.Cursor = Cursors.Hand;
            linkLabelCadastrar.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelCadastrar.Name = "linkLabelCadastrar";
            linkLabelCadastrar.TabStop = true;
            linkLabelCadastrar.LinkClicked += AoClicarAbreTelaDeCadastroDeConta;
            // 
            // labelMtgDeckBuilder
            // 
            resources.ApplyResources(labelMtgDeckBuilder, "labelMtgDeckBuilder");
            labelMtgDeckBuilder.Name = "labelMtgDeckBuilder";
            // 
            // labelUsuarioMensagemDeErro
            // 
            resources.ApplyResources(labelUsuarioMensagemDeErro, "labelUsuarioMensagemDeErro");
            labelUsuarioMensagemDeErro.ForeColor = Color.Red;
            labelUsuarioMensagemDeErro.Name = "labelUsuarioMensagemDeErro";
            // 
            // labelSenhaMensagemDeErro
            // 
            resources.ApplyResources(labelSenhaMensagemDeErro, "labelSenhaMensagemDeErro");
            labelSenhaMensagemDeErro.ForeColor = Color.Red;
            labelSenhaMensagemDeErro.Name = "labelSenhaMensagemDeErro";
            // 
            // FormJogadorEntrar
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelSenhaMensagemDeErro);
            Controls.Add(labelUsuarioMensagemDeErro);
            Controls.Add(labelMtgDeckBuilder);
            Controls.Add(linkLabelCadastrar);
            Controls.Add(linkLabelEsqueciSenha);
            Controls.Add(labelNome);
            Controls.Add(textBoxSenha);
            Controls.Add(buttonEntrar);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelSenha);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormJogadorEntrar";
            ShowIcon = false;
            ShowInTaskbar = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonEntrar;
        private Label labelSenha;
        private Label labelNome;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private LinkLabel linkLabelEsqueciSenha;
        private LinkLabel linkLabelCadastrar;
        private Label labelMtgDeckBuilder;
        private Label labelUsuarioMensagemDeErro;
        private Label labelSenhaMensagemDeErro;
    }
}