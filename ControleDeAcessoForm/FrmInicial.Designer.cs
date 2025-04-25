namespace ControleDeAcessoForm
{
    partial class FrmInicial
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
            bntConsultar = new Button();
            bntSair = new Button();
            SuspendLayout();
            // 
            // bntConsultar
            // 
            bntConsultar.Location = new Point(298, 132);
            bntConsultar.Name = "bntConsultar";
            bntConsultar.Size = new Size(75, 23);
            bntConsultar.TabIndex = 8;
            bntConsultar.Text = "Consultar";
            bntConsultar.UseVisualStyleBackColor = true;
            bntConsultar.Click += bntConsultar_Click;
            // 
            // bntSair
            // 
            bntSair.Location = new Point(298, 177);
            bntSair.Name = "bntSair";
            bntSair.Size = new Size(75, 23);
            bntSair.TabIndex = 9;
            bntSair.Text = "Sair";
            bntSair.UseVisualStyleBackColor = true;
            bntSair.Click += bntSair_Click;
            // 
            // FrmInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntSair);
            Controls.Add(bntConsultar);
            Name = "FrmInicial";
            Text = "Inicialcs";
            Load += FrmInicialcs_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button bntConsultar;
        private Button bntSair;
    }
}