namespace ControleDeAcessoForm
{
    partial class RegistroDeAcesso
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
            dgvUsuarios = new DataGridView();
            clnNome = new DataGridViewTextBoxColumn();
            clnEntrada = new DataGridViewTextBoxColumn();
            clnSaida = new DataGridViewTextBoxColumn();
            label1 = new Label();
            bntBuscar = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnNome, clnEntrada, clnSaida });
            dgvUsuarios.Location = new Point(248, 177);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.Size = new Size(343, 242);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            // 
            // clnEntrada
            // 
            clnEntrada.HeaderText = "Entrada";
            clnEntrada.Name = "clnEntrada";
            clnEntrada.ReadOnly = true;
            // 
            // clnSaida
            // 
            clnSaida.HeaderText = "Saida";
            clnSaida.Name = "clnSaida";
            clnSaida.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 47);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "Registro de Acesso";
            label1.Click += label1_Click;
            // 
            // bntBuscar
            // 
            bntBuscar.Location = new Point(363, 148);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(75, 23);
            bntBuscar.TabIndex = 2;
            bntBuscar.Text = "Buscar";
            bntBuscar.UseVisualStyleBackColor = true;
            bntBuscar.Click += bntBuscar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // RegistroDeAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(bntBuscar);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Name = "RegistroDeAcesso";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Label label1;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEntrada;
        private DataGridViewTextBoxColumn clnSaida;
        private Button bntBuscar;
        private TextBox textBox1;
    }
}