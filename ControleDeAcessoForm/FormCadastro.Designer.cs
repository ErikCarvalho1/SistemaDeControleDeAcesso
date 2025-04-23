namespace ControleDeAcessoForm
{
    partial class FormCadastro
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            bntVoltar = new Button();
            bntCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(211, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // bntVoltar
            // 
            bntVoltar.Location = new Point(209, 210);
            bntVoltar.Name = "bntVoltar";
            bntVoltar.Size = new Size(75, 23);
            bntVoltar.TabIndex = 3;
            bntVoltar.Text = "Voltar";
            bntVoltar.UseVisualStyleBackColor = true;
            bntVoltar.Click += bntVoltar_Click;
            // 
            // bntCadastrar
            // 
            bntCadastrar.Location = new Point(309, 210);
            bntCadastrar.Name = "bntCadastrar";
            bntCadastrar.Size = new Size(75, 23);
            bntCadastrar.TabIndex = 4;
            bntCadastrar.Text = "Cadastrar";
            bntCadastrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 64);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 91);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 126);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 7;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 170);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Senha";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(317, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(318, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 64);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bntCadastrar);
            Controls.Add(bntVoltar);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormCadastro";
            Text = "FormCadastro";
            Load += FormCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button bntVoltar;
        private Button bntCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
    }
}