using ControleDeAcessoClass;
using System.Diagnostics.Eventing.Reader;

namespace ControleDeAcessoForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void Login_Load_1(object sender, EventArgs e)
        { }
        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.Show();
            this.Hide();
        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {

            var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if (usuario != null && usuario.Ativo)
            {
                usuario.RegistrarEntrada();
                

                if (usuario.Id > 0)
                {
                    if (usuario.Ativo)
                    {

                        FrmInicial frmInicial = new();
                        frmInicial.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sua conta está inativa.\nProcure o administrador.", "Conta inativa");
                    }
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos ou inexistentes!", "Erro de Login");
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)


                txtSenha.UseSystemPasswordChar = true;
            else
                txtSenha.UseSystemPasswordChar = false;

        }

        private void bntConsultar_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}