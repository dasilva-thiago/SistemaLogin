using MySqlConnector;
using SistemaLogin.Services;
using SistenaLogin.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistenaLogin
{
    public partial class F_Cadastro : Form
    {
        public F_Cadastro()
        {
            InitializeComponent();
        }

        private void F_Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string username = txtCadastrarUsuario.Text;
            string password = txtCadastrarSenha.Text;
            string email = txtCadastrarEmail.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Preencha todos os campos para cadastrar", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hashSeguro = PasswordHasher.HashPassword(password);

            using (var conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string sql = "INSERT INTO usuarios (username, password_hash, email) VALUES (@username, @password_hash, @email)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password_hash", hashSeguro);
                        cmd.Parameters.AddWithValue("@email", email);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Usuário cadastrado com sucesso! Agora você pode fazer login.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtCadastrarUsuario.Clear();
                        txtCadastrarSenha.Clear();
                        Close();
                    }
                }

                catch (MySqlException ex)
                {
                    // O código 1062 
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("Este usuário já existe. Tente outro nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar no banco de dados" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
