namespace Cod3rsGrowth.Forms
{
    partial class FormsJogadorCadastro
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
            textBoxUsername = new TextBox();
            textBoxSenha = new TextBox();
            textBoxNome = new TextBox();
            dateTimePickerDataDeNascimento = new DateTimePicker();
            buttonCadastrar = new Button();
            linkLabelJaPossuoConta = new LinkLabel();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(38, 124);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(56, 21);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(38, 189);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(84, 21);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username:";
            // 
            // labelSenha
            // 
            labelSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSenha.Location = new Point(38, 256);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(56, 21);
            labelSenha.TabIndex = 2;
            labelSenha.Text = "Senha:";
            // 
            // labelDataDeNascimento
            // 
            labelDataDeNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDataDeNascimento.AutoSize = true;
            labelDataDeNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataDeNascimento.Location = new Point(38, 317);
            labelDataDeNascimento.Name = "labelDataDeNascimento";
            labelDataDeNascimento.Size = new Size(153, 21);
            labelDataDeNascimento.TabIndex = 3;
            labelDataDeNascimento.Text = "Data de Nascimento:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.Location = new Point(38, 213);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(290, 23);
            textBoxUsername.TabIndex = 4;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSenha.Location = new Point(38, 282);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(290, 23);
            textBoxSenha.TabIndex = 5;
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // textBoxNome
            // 
            textBoxNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNome.Location = new Point(38, 153);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(290, 23);
            textBoxNome.TabIndex = 6;
            // 
            // dateTimePickerDataDeNascimento
            // 
            dateTimePickerDataDeNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerDataDeNascimento.Format = DateTimePickerFormat.Short;
            dateTimePickerDataDeNascimento.Location = new Point(38, 348);
            dateTimePickerDataDeNascimento.Name = "dateTimePickerDataDeNascimento";
            dateTimePickerDataDeNascimento.Size = new Size(111, 23);
            dateTimePickerDataDeNascimento.TabIndex = 7;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCadastrar.Location = new Point(12, 377);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(351, 36);
            buttonCadastrar.TabIndex = 8;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // linkLabelJaPossuoConta
            // 
            linkLabelJaPossuoConta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabelJaPossuoConta.AutoSize = true;
            linkLabelJaPossuoConta.Location = new Point(142, 426);
            linkLabelJaPossuoConta.Name = "linkLabelJaPossuoConta";
            linkLabelJaPossuoConta.Size = new Size(91, 15);
            linkLabelJaPossuoConta.TabIndex = 9;
            linkLabelJaPossuoConta.TabStop = true;
            linkLabelJaPossuoConta.Text = "Já possuo conta";
            linkLabelJaPossuoConta.TextAlign = ContentAlignment.MiddleCenter;
            linkLabelJaPossuoConta.LinkClicked += linkLabelJaPossuoConta_LinkClicked;
            // 
            // FormsJogadorCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 450);
            Controls.Add(linkLabelJaPossuoConta);
            Controls.Add(buttonCadastrar);
            Controls.Add(dateTimePickerDataDeNascimento);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsername);
            Controls.Add(labelDataDeNascimento);
            Controls.Add(labelSenha);
            Controls.Add(labelUsername);
            Controls.Add(labelNome);
            Name = "FormsJogadorCadastro";
            Text = "MTG DeckBuilder - Cadastro";
            Load += FormsJogadorCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelUsername;
        private Label labelSenha;
        private Label labelDataDeNascimento;
        private TextBox textBoxUsername;
        private TextBox textBoxSenha;
        private TextBox textBoxNome;
        private DateTimePicker dateTimePickerDataDeNascimento;
        private Button buttonCadastrar;
        private LinkLabel linkLabelJaPossuoConta;
    }
}