namespace Cod3rsGrowth.Forms
{
    partial class FormsJogadorCadastroLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsJogadorCadastroLogin));
            splitCadastroEntrar = new SplitContainer();
            groupBoxEntrar = new GroupBox();
            labelEntrarNome = new Label();
            textBoxEntrarSenha = new TextBox();
            textBoxEntrarNome = new TextBox();
            labelEntrarSenha = new Label();
            buttonEntrar = new Button();
            groupBoxCadastrar = new GroupBox();
            dateTimePickerCadastro = new DateTimePicker();
            textBoxCadastroSenha = new TextBox();
            labelCadastroSenha = new Label();
            labelCadastroDataDeNascimento = new Label();
            labelCadastroNome = new Label();
            buttonCadastro = new Button();
            button1 = new Button();
            textBoxCadastroNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitCadastroEntrar).BeginInit();
            splitCadastroEntrar.Panel1.SuspendLayout();
            splitCadastroEntrar.Panel2.SuspendLayout();
            splitCadastroEntrar.SuspendLayout();
            groupBoxEntrar.SuspendLayout();
            groupBoxCadastrar.SuspendLayout();
            SuspendLayout();
            // 
            // splitCadastroEntrar
            // 
            resources.ApplyResources(splitCadastroEntrar, "splitCadastroEntrar");
            splitCadastroEntrar.Name = "splitCadastroEntrar";
            // 
            // splitCadastroEntrar.Panel1
            // 
            resources.ApplyResources(splitCadastroEntrar.Panel1, "splitCadastroEntrar.Panel1");
            splitCadastroEntrar.Panel1.Controls.Add(groupBoxEntrar);
            // 
            // splitCadastroEntrar.Panel2
            // 
            resources.ApplyResources(splitCadastroEntrar.Panel2, "splitCadastroEntrar.Panel2");
            splitCadastroEntrar.Panel2.Controls.Add(groupBoxCadastrar);
            // 
            // groupBoxEntrar
            // 
            resources.ApplyResources(groupBoxEntrar, "groupBoxEntrar");
            groupBoxEntrar.Controls.Add(labelEntrarNome);
            groupBoxEntrar.Controls.Add(textBoxEntrarSenha);
            groupBoxEntrar.Controls.Add(textBoxEntrarNome);
            groupBoxEntrar.Controls.Add(labelEntrarSenha);
            groupBoxEntrar.Controls.Add(buttonEntrar);
            groupBoxEntrar.Name = "groupBoxEntrar";
            groupBoxEntrar.TabStop = false;
            groupBoxEntrar.Enter += groupBoxEntrar_Enter;
            // 
            // labelEntrarNome
            // 
            resources.ApplyResources(labelEntrarNome, "labelEntrarNome");
            labelEntrarNome.Name = "labelEntrarNome";
            labelEntrarNome.Click += labelEntrarNome_Click;
            // 
            // textBoxEntrarSenha
            // 
            resources.ApplyResources(textBoxEntrarSenha, "textBoxEntrarSenha");
            textBoxEntrarSenha.Name = "textBoxEntrarSenha";
            textBoxEntrarSenha.UseSystemPasswordChar = true;
            // 
            // textBoxEntrarNome
            // 
            resources.ApplyResources(textBoxEntrarNome, "textBoxEntrarNome");
            textBoxEntrarNome.Name = "textBoxEntrarNome";
            textBoxEntrarNome.TextChanged += textBoxEntrarNome_TextChanged;
            // 
            // labelEntrarSenha
            // 
            resources.ApplyResources(labelEntrarSenha, "labelEntrarSenha");
            labelEntrarSenha.Name = "labelEntrarSenha";
            labelEntrarSenha.Click += labelEntrarSenha_Click;
            // 
            // buttonEntrar
            // 
            resources.ApplyResources(buttonEntrar, "buttonEntrar");
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // groupBoxCadastrar
            // 
            resources.ApplyResources(groupBoxCadastrar, "groupBoxCadastrar");
            groupBoxCadastrar.Controls.Add(textBoxCadastroNome);
            groupBoxCadastrar.Controls.Add(dateTimePickerCadastro);
            groupBoxCadastrar.Controls.Add(textBoxCadastroSenha);
            groupBoxCadastrar.Controls.Add(labelCadastroSenha);
            groupBoxCadastrar.Controls.Add(labelCadastroDataDeNascimento);
            groupBoxCadastrar.Controls.Add(labelCadastroNome);
            groupBoxCadastrar.Controls.Add(buttonCadastro);
            groupBoxCadastrar.Controls.Add(button1);
            groupBoxCadastrar.Name = "groupBoxCadastrar";
            groupBoxCadastrar.TabStop = false;
            groupBoxCadastrar.Enter += groupBoxCadastro;
            // 
            // dateTimePickerCadastro
            // 
            resources.ApplyResources(dateTimePickerCadastro, "dateTimePickerCadastro");
            dateTimePickerCadastro.Format = DateTimePickerFormat.Short;
            dateTimePickerCadastro.Name = "dateTimePickerCadastro";
            // 
            // textBoxCadastroSenha
            // 
            resources.ApplyResources(textBoxCadastroSenha, "textBoxCadastroSenha");
            textBoxCadastroSenha.Name = "textBoxCadastroSenha";
            textBoxCadastroSenha.UseSystemPasswordChar = true;
            // 
            // labelCadastroSenha
            // 
            resources.ApplyResources(labelCadastroSenha, "labelCadastroSenha");
            labelCadastroSenha.Name = "labelCadastroSenha";
            labelCadastroSenha.Click += labelCadastroSenha_Click;
            // 
            // labelCadastroDataDeNascimento
            // 
            resources.ApplyResources(labelCadastroDataDeNascimento, "labelCadastroDataDeNascimento");
            labelCadastroDataDeNascimento.Name = "labelCadastroDataDeNascimento";
            labelCadastroDataDeNascimento.Click += labelCadastroDataDeNascimento_Click;
            // 
            // labelCadastroNome
            // 
            resources.ApplyResources(labelCadastroNome, "labelCadastroNome");
            labelCadastroNome.Name = "labelCadastroNome";
            labelCadastroNome.Click += labelCadastroNome_Click;
            // 
            // buttonCadastro
            // 
            resources.ApplyResources(buttonCadastro, "buttonCadastro");
            buttonCadastro.Name = "buttonCadastro";
            buttonCadastro.UseVisualStyleBackColor = true;
            buttonCadastro.Click += buttonCadastro_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxCadastroNome
            // 
            resources.ApplyResources(textBoxCadastroNome, "textBoxCadastroNome");
            textBoxCadastroNome.Name = "textBoxCadastroNome";
            textBoxCadastroNome.TextChanged += textBoxCadastroNome_TextChanged;
            // 
            // FormsJogadorCadastroLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitCadastroEntrar);
            Name = "FormsJogadorCadastroLogin";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += FormsJogadorCadastroLogin_Load;
            splitCadastroEntrar.Panel1.ResumeLayout(false);
            splitCadastroEntrar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitCadastroEntrar).EndInit();
            splitCadastroEntrar.ResumeLayout(false);
            groupBoxEntrar.ResumeLayout(false);
            groupBoxEntrar.PerformLayout();
            groupBoxCadastrar.ResumeLayout(false);
            groupBoxCadastrar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitCadastroEntrar;
        private GroupBox groupBoxEntrar;
        private Button buttonEntrar;
        private Button buttonCadastro;
        private GroupBox groupBoxCadastrar;
        private Button button1;
        private Label labelCadastroNome;
        private Label labelCadastroDataDeNascimento;
        private Label labelCadastroSenha;
        private TextBox textBoxCadastroSenha;
        private DateTimePicker dateTimePickerCadastro;
        private Label labelEntrarSenha;
        private Label labelEntrarNome;
        private TextBox textBoxEntrarNome;
        private TextBox textBoxEntrarSenha;
        private TextBox textBoxCadastroNome;
    }
}