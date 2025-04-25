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
            components = new System.ComponentModel.Container();
            dgvUsuarios = new DataGridView();
            cmdId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEntrada = new DataGridViewTextBoxColumn();
            clnSaida = new DataGridViewTextBoxColumn();
            label1 = new Label();
            bntBuscar = new Button();
            txtNome = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            txtEntrada = new TextBox();
            txtSaida = new TextBox();
            Nome = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { cmdId, clnNome, clnEntrada, clnSaida });
            dgvUsuarios.Location = new Point(125, 174);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.Size = new Size(544, 242);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmdId
            // 
            cmdId.HeaderText = "Id";
            cmdId.Name = "cmdId";
            cmdId.ReadOnly = true;
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
            clnEntrada.Width = 150;
            // 
            // clnSaida
            // 
            clnSaida.HeaderText = "Saida";
            clnSaida.Name = "clnSaida";
            clnSaida.ReadOnly = true;
            clnSaida.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 19);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "Registro de Acesso";
            label1.Click += label1_Click;
            // 
            // bntBuscar
            // 
            bntBuscar.Location = new Point(326, 112);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(75, 23);
            bntBuscar.TabIndex = 2;
            bntBuscar.Text = "Buscar";
            bntBuscar.UseVisualStyleBackColor = true;
            bntBuscar.Click += bntBuscar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(182, 84);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(182, 113);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(128, 23);
            txtEntrada.TabIndex = 6;
            // 
            // txtSaida
            // 
            txtSaida.Location = new Point(182, 145);
            txtSaida.Name = "txtSaida";
            txtSaida.Size = new Size(128, 23);
            txtSaida.TabIndex = 7;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(125, 92);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 8;
            Nome.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 121);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "Entrada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 153);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 10;
            label3.Text = "Saida";
            // 
            // RegistroDeAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nome);
            Controls.Add(txtSaida);
            Controls.Add(txtEntrada);
            Controls.Add(txtNome);
            Controls.Add(bntBuscar);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Name = "RegistroDeAcesso";
            Text = "Form1";
            Load += RegistroDeAcesso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Label label1;
        private Button bntBuscar;
        private TextBox txtNome;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtEntrada;
        private TextBox txtSaida;
        private Label Nome;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn cmdId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEntrada;
        private DataGridViewTextBoxColumn clnSaida;
    }
}