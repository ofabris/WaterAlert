using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WaterAlert.Program;

namespace WaterAlert
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void tbLogin_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Usuário:")
            {
                textBox.Text = String.Empty;
            }
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Senha:")
            {
                textBox.Text = String.Empty;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string senha = tbPassword.Text;

            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Possuem campos não preenchidos no Login!", "Validação de Login", MessageBoxButtons.OK);
            }
            else
            {
                if (ValidaLogin(login, senha))
                {
                    MessageBox.Show("Login realizado com sucesso!", "Validação de Login", MessageBoxButtons.OK);

                    // Fechar a FormHome
                    this.Close();

                    // Abrir a tela Perfil
                    FormPerfil perfilForm = new FormPerfil();
                    perfilForm.Show();
                }
                else
                {
                    MessageBox.Show("Este usuário não está cadastrado!", "Validação de Login", MessageBoxButtons.OK);
                }
            }
        }

    }
}