using SistenaLogin.Services;

namespace SistenaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text.Trim();
            string password = txtSenha.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Preencha todos os campos!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var authService = new AuthService();
            bool isValid = authService.AuthenticateUser(username, password);
            if (isValid)
            {
                MessageBox.Show("Login Realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCadastre_Click(object sender, EventArgs e)
        {
            F_Cadastro f_Cadastro = new F_Cadastro();
            f_Cadastro.ShowDialog();

        }
    }
}
