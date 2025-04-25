namespace ControleDeAcessoForm
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bntCadastrar = new Button();
            bntEntrar = new Button();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // bntCadastrar
            // 
            bntCadastrar.Location = new Point(111, 155);
            bntCadastrar.Name = "bntCadastrar";
            bntCadastrar.Size = new Size(97, 23);
            bntCadastrar.TabIndex = 0;
            bntCadastrar.Text = "cadastrar-se";
            bntCadastrar.UseVisualStyleBackColor = true;
            bntCadastrar.Click += bntCadastrar_Click;
            // 
            // bntEntrar
            // 
            bntEntrar.Location = new Point(213, 155);
            bntEntrar.Name = "bntEntrar";
            bntEntrar.Size = new Size(75, 23);
            bntEntrar.TabIndex = 1;
            bntEntrar.Text = "Entrar";
            bntEntrar.UseVisualStyleBackColor = true;
            bntEntrar.Click += bntEntrar_Click;
            // 
            // txtEmail
            // 
            txtEmail.AcceptsReturn = true;
            txtEmail.Location = new Point(108, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(111, 118);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(178, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 75);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 121);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(304, 118);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(42, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "ver";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(417, 251);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(bntEntrar);
            Controls.Add(bntCadastrar);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntCadastrar;
        private Button bntEntrar;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
    }
}
