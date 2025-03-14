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

namespace Exercicio02DPL
{
    public partial class NewACC : Form
    {
        public NewACC()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = txtUsername.Text;
            string Email = txtEmail.Text;
            string Senha = txtSenha.Text;
            string ConfSenha = txtConfsenha.Text;

            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Senha) || string.IsNullOrWhiteSpace(ConfSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter("dados.txt", true))
                {
                    writer.WriteLine("Username: " + UserName);
                    writer.WriteLine("Email: " + Email);
                    writer.WriteLine("Senha: " + Senha);
                    writer.WriteLine("Confirmação de Senha: " + ConfSenha);
                    writer.WriteLine("-------------------------------");
                }
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPW.Checked == true)
            {
                txtSenha.UseSystemPasswordChar = false;
                txtConfsenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                txtConfsenha.UseSystemPasswordChar = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NewACC_Load(object sender, EventArgs e)
        {

        }
    }
}
