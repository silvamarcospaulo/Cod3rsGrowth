namespace Cod3rsGrowth.Forms
{
    partial class FormsEsqueciSenha
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
            buttonAtualizarSenha = new Button();
            textBoxNome = new TextBox();
            textBoxSobrenome = new TextBox();
            textBoxNovasenha = new TextBox();
            textBoxUsuario = new TextBox();
            SuspendLayout();
            // 
            // dateTimePickerDataDeNascimento
            // 
            dateTimePickerDataDeNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerDataDeNascimento.Format = DateTimePickerFormat.Short;
            dateTimePickerDataDeNascimento.Location = new Point(38, 333);
            dateTimePickerDataDeNascimento.Name = "dateTimePickerDataDeNascimento";
            dateTimePickerDataDeNascimento.Size = new Size(111, 23);
            dateTimePickerDataDeNascimento.TabIndex = 5;
            dateTimePickerDataDeNascimento.ValueChanged += dateTimePickerDataDeNascimento_ValueChanged;
            // 
            // labelDataDeNascimento
            // 
            labelDataDeNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDataDeNascimento.AutoSize = true;
            labelDataDeNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataDeNascimento.Location = new Point(38, 309);
            labelDataDeNascimento.Name = "labelDataDeNascimento";
            labelDataDeNascimento.Size = new Size(153, 21);
            labelDataDeNascimento.TabIndex = 0;
            labelDataDeNascimento.Text = "Data de Nascimento:";
            // 
            // labelNovaSenha
            // 
            labelNovaSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNovaSenha.AutoSize = true;
            labelNovaSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNovaSenha.Location = new Point(38, 247);
            labelNovaSenha.Name = "labelNovaSenha";
            labelNovaSenha.Size = new Size(95, 21);
            labelNovaSenha.TabIndex = 0;
            labelNovaSenha.Text = "Nova senha:";
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(38, 189);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(67, 21);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Usuario:";
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(38, 73);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(56, 21);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            // 
            // labelSobrenome
            // 
            labelSobrenome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSobrenome.AutoSize = true;
            labelSobrenome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSobrenome.Location = new Point(38, 127);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(94, 21);
            labelSobrenome.TabIndex = 0;
            labelSobrenome.Text = "Sobrenome:";
            // 
            // buttonAtualizarSenha
            // 
            buttonAtualizarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAtualizarSenha.Location = new Point(12, 377);
            buttonAtualizarSenha.Name = "buttonAtualizarSenha";
            buttonAtualizarSenha.Size = new Size(351, 36);
            buttonAtualizarSenha.TabIndex = 6;
            buttonAtualizarSenha.Text = "Atualizar Senha";
            buttonAtualizarSenha.UseVisualStyleBackColor = true;
            buttonAtualizarSenha.Click += buttonAtualizarSenha_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNome.Location = new Point(38, 98);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(290, 23);
            textBoxNome.TabIndex = 1;
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSobrenome.Location = new Point(38, 153);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(290, 23);
            textBoxSobrenome.TabIndex = 2;
            // 
            // textBoxNovasenha
            // 
            textBoxNovasenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNovasenha.Location = new Point(38, 273);
            textBoxNovasenha.Name = "textBoxNovasenha";
            textBoxNovasenha.Size = new Size(290, 23);
            textBoxNovasenha.TabIndex = 4;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsuario.Location = new Point(38, 213);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(290, 23);
            textBoxUsuario.TabIndex = 3;
            // 
            // FormsEsqueciSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 450);
            Controls.Add(textBoxUsuario);
            Controls.Add(textBoxNovasenha);
            Controls.Add(textBoxSobrenome);
            Controls.Add(textBoxNome);
            Controls.Add(buttonAtualizarSenha);
            Controls.Add(dateTimePickerDataDeNascimento);
            Controls.Add(labelDataDeNascimento);
            Controls.Add(labelNovaSenha);
            Controls.Add(labelUsername);
            Controls.Add(labelNome);
            Controls.Add(labelSobrenome);
            Name = "FormsEsqueciSenha";
            Text = "MTG DeckBuilder - Esqueci Senha";
            Load += FormsEsqueciSenha_Load;
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
        private Button buttonAtualizarSenha;
        private TextBox textBoxNome;
        private TextBox textBoxSobrenome;
        private TextBox textBoxNovasenha;
        private TextBox textBoxUsuario;
    }
}