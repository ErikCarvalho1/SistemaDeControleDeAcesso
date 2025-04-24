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
    public partial class RegistroDeAcesso : Form
    {
        public RegistroDeAcesso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvUsuarios.CurrentRow.Index;
            int id = Convert.ToInt32(dgvUsuarios.Rows[linha].Cells[0].Value);
            bool ativo = Convert.ToBoolean(dgvUsuarios.Rows[linha].Cells[3].Value);

        }
    }
}