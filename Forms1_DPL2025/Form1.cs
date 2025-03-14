namespace Forms1_DPL2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void verSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (verSenha.Checked == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(user) ||  string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void newaccButton_Click(object sender, EventArgs e)
        {
            criarAcc homeForm = new criarAcc();
            homeForm.Show();
            this.Hide();
        }
    }
}
