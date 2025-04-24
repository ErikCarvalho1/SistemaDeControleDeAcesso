using ControleDeAcessoClass;
using Org.BouncyCastle.Pqc.Crypto.Frodo;
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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void bntVoltar_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Show();

        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new(txtNome.Text, txtEmail.Text, txtCpf.Text, cmbTipo.SelectedIndex + 1, txtSenha.Text);
            usuario.Inserir();
            txtId.Text = usuario.Id.ToString();
            MessageBox.Show($"Usuário {usuario.Nome} gravado com sucesso com o ID {usuario.Id}");
            FormCadastro_Load(sender, e);



        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
