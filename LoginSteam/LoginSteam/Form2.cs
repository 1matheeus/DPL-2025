using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoginSteam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void createaccbutton_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string confsenha = txtconfSenha.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(confsenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (senha != confsenha)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, verifique.", "Erro de senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filePath = Path.Combine(@"C:\DPL-2025\LoginSteam\LoginSteam", "dadosConta.txt");
            string conteudo = $"Usuário: {user}\nEmail: {email}\nSenha: {senha}";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(conteudo);
                    writer.WriteLine("--------------------");
                }

                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (verSenha.Checked == true)
            {
                txtSenha.UseSystemPasswordChar = false;
                txtconfSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                txtconfSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
