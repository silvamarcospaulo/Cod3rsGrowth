namespace Cod3rsGrowth.Forms
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
            textBoxNome = new TextBox();
            labelSenha = new Label();
            buttonEntrar = new Button();
            linkLabelEsqueciSenha = new LinkLabel();
            linkLabelCadastrar = new LinkLabel();
            SuspendLayout();
            // 
            // labelNome
            // 
            resources.ApplyResources(labelNome, "labelNome");
            labelNome.Name = "labelNome";
            // 
            // textBoxSenha
            // 
            resources.ApplyResources(textBoxSenha, "textBoxSenha");
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // textBoxNome
            // 
            resources.ApplyResources(textBoxNome, "textBoxNome");
            textBoxNome.Name = "textBoxNome";
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // labelSenha
            // 
            resources.ApplyResources(labelSenha, "labelSenha");
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
            linkLabelEsqueciSenha.Name = "linkLabelEsqueciSenha";
            linkLabelEsqueciSenha.TabStop = true;
            // 
            // linkLabelCadastrar
            // 
            resources.ApplyResources(linkLabelCadastrar, "linkLabelCadastrar");
            linkLabelCadastrar.Name = "linkLabelCadastrar";
            linkLabelCadastrar.TabStop = true;
            linkLabelCadastrar.LinkClicked += linkLabelCadastrar_LinkClicked;
            // 
            // FormsJogadorLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(linkLabelCadastrar);
            Controls.Add(linkLabelEsqueciSenha);
            Controls.Add(labelNome);
            Controls.Add(textBoxSenha);
            Controls.Add(buttonEntrar);
            Controls.Add(textBoxNome);
            Controls.Add(labelSenha);
            Name = "FormsJogadorLogin";
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
        private TextBox textBoxNome;
        private TextBox textBoxSenha;
        private LinkLabel linkLabelEsqueciSenha;
        private LinkLabel linkLabelCadastrar;
    }
}