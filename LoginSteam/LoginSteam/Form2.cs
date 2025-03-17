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
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LoginSteam
{

    public partial class Form2 : Form
    {
        private string usuario;
        private string senha;
        public Form2(string user,string pass)
        {
            InitializeComponent();
            this.usuario = user;
            this.senha = pass;
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
            string conteudo = $"{user};{senha}";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(conteudo);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
