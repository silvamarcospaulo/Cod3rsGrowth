﻿namespace Cod3rsGrowth.Forms
{
    partial class FormsJogadorEntrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsJogadorEntrar));
            labelNome = new Label();
            textBoxSenha = new TextBox();
            textBoxUsuario = new TextBox();
            labelSenha = new Label();
            buttonEntrar = new Button();
            linkLabelEsqueciSenha = new LinkLabel();
            linkLabelCadastrar = new LinkLabel();
            labelMtgDeckBuilder = new Label();
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
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // textBoxUsuario
            // 
            resources.ApplyResources(textBoxUsuario, "textBoxUsuario");
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.TextChanged += textBoxNome_TextChanged;
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
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // linkLabelEsqueciSenha
            // 
            resources.ApplyResources(linkLabelEsqueciSenha, "linkLabelEsqueciSenha");
            linkLabelEsqueciSenha.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelEsqueciSenha.Name = "linkLabelEsqueciSenha";
            linkLabelEsqueciSenha.TabStop = true;
            linkLabelEsqueciSenha.LinkClicked += linkLabelEsqueciSenha_LinkClicked;
            // 
            // linkLabelCadastrar
            // 
            resources.ApplyResources(linkLabelCadastrar, "linkLabelCadastrar");
            linkLabelCadastrar.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelCadastrar.Name = "linkLabelCadastrar";
            linkLabelCadastrar.TabStop = true;
            linkLabelCadastrar.LinkClicked += linkLabelCadastrar_LinkClicked;
            // 
            // labelMtgDeckBuilder
            // 
            resources.ApplyResources(labelMtgDeckBuilder, "labelMtgDeckBuilder");
            labelMtgDeckBuilder.Name = "labelMtgDeckBuilder";
            labelMtgDeckBuilder.Click += labelMtgDeckBuilder_Click;
            // 
            // FormsJogadorEntrar
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelMtgDeckBuilder);
            Controls.Add(linkLabelCadastrar);
            Controls.Add(linkLabelEsqueciSenha);
            Controls.Add(labelNome);
            Controls.Add(textBoxSenha);
            Controls.Add(buttonEntrar);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelSenha);
            Name = "FormsJogadorEntrar";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += FormsJogadorCadastroLogin_Load;
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
    }
}