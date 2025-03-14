namespace Exercicio02DPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPW.Checked == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Usuario = txtUser.Text;
            string Password = txtSenha.Text;
            if (Usuario == "" || Password == "")
            {

            }
        }

        private void NewAcc_Click(object sender, EventArgs e)
        {
            NewACC newACC = new NewACC();
            newACC.Show();
            this.Hide();
            
        }
    }
}
