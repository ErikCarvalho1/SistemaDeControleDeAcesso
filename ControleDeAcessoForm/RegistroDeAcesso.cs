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


            var usuario = Usuario.ObterPorNome(txtNome.Text.Trim());

            if (usuario != null)
            {
                txtNome.Text = usuario.Nome;
                txtEntrada.Text = usuario.Entrada.ToString();
                txtSaida.Text = usuario.Saida.ToString();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvUsuarios.CurrentRow.Index;
            int id = Convert.ToInt32(dgvUsuarios.Rows[linha].Cells[0].Value);
            DateTime entrada = Convert.ToDateTime(dgvUsuarios.Rows[linha].Cells[2].Value);
            DateTime saida = Convert.ToDateTime(dgvUsuarios.Rows[linha].Cells[3].Value);

        }

        private void RegistroDeAcesso_Load(object sender, EventArgs e)
        {
            {
                var lista = Usuario.ObterListaComRegistro();
                dgvUsuarios.Rows.Clear();
                foreach (var usuario in lista)
                {
                    dgvUsuarios.Rows.Add(usuario.Id, usuario.Nome, usuario.Entrada, usuario.Saida);
                }
            }
        }

        private void dtEntrada_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}