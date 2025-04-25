using ControleDeAcessoClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControleDeAcessoForm
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void FrmInicialcs_Load(object sender, EventArgs e)
        {

        }

        private void bntConsultar_Click(object sender, EventArgs e)
        {
            RegistroDeAcesso registroDeAcesso = new();
            registroDeAcesso.Show();
            this.Hide();
            
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            
            Application.Exit();

        }
    }
}
