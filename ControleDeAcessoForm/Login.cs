namespace ControleDeAcessoForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void Login_Load_1(object sender, EventArgs e)
        {}
        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.Show();
            this.Hide();
        }


    }
}
