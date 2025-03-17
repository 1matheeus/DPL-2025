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
using Microsoft.VisualBasic.ApplicationServices;

namespace LoginSteam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void qrcode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void helplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://help.steampowered.com/",
                UseShellExecute = true
            });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void logbutton_Click(object sender, EventArgs e)
        {
            //string user = txtUser.Text;
            //string senha = txtPassword.Text;
            string arquivo = @"C:\DPL-2025\LoginSteam\LoginSteam\dadosConta.txt";

            //if (Login(user,))
            //{
            //  Form3 form3 = new Form3();
            //form3.Show();
            //sthis.Hide();
            //}
            Form2 form2 = new Form2(usuario, senha);
            form2.Show();
            this.Hide();
        }
        private bool Login(string user, string senha, string arquivo)
        {
            foreach (string linha in File.ReadAllLines(arquivo))
            {
                string[] partes = linha.Split(";");
                if (partes[0] == user && partes[1] == senha)
                {
                    return true;
                }
            }

            return false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
