namespace LoginSteam
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtconfSenha = new TextBox();
            criarConta = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            verSenha = new CheckBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 130);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(74, 74, 74);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(82, 127);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(355, 36);
            txtUser.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(74, 74, 74);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(82, 197);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(355, 36);
            txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(74, 74, 74);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(82, 267);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(355, 36);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtconfSenha
            // 
            txtconfSenha.BackColor = Color.FromArgb(74, 74, 74);
            txtconfSenha.BorderStyle = BorderStyle.None;
            txtconfSenha.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtconfSenha.Location = new Point(82, 337);
            txtconfSenha.Name = "txtconfSenha";
            txtconfSenha.Size = new Size(355, 36);
            txtconfSenha.TabIndex = 4;
            txtconfSenha.UseSystemPasswordChar = true;
            // 
            // criarConta
            // 
            criarConta.BackColor = SystemColors.Highlight;
            criarConta.FlatStyle = FlatStyle.Popup;
            criarConta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            criarConta.ForeColor = Color.White;
            criarConta.Location = new Point(129, 421);
            criarConta.Margin = new Padding(0);
            criarConta.Name = "criarConta";
            criarConta.Size = new Size(254, 41);
            criarConta.TabIndex = 9;
            criarConta.Text = "Sign Up";
            criarConta.UseVisualStyleBackColor = false;
            criarConta.Click += createaccbutton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(122, 122, 122);
            label2.Location = new Point(82, 111);
            label2.Name = "label2";
            label2.Size = new Size(68, 13);
            label2.TabIndex = 10;
            label2.Text = "USERNAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(122, 122, 122);
            label1.Location = new Point(82, 181);
            label1.Name = "label1";
            label1.Size = new Size(41, 13);
            label1.TabIndex = 11;
            label1.Text = "EMAIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(122, 122, 122);
            label3.Location = new Point(82, 251);
            label3.Name = "label3";
            label3.Size = new Size(67, 13);
            label3.TabIndex = 12;
            label3.Text = "PASSWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(122, 122, 122);
            label4.Location = new Point(82, 321);
            label4.Name = "label4";
            label4.Size = new Size(121, 13);
            label4.TabIndex = 13;
            label4.Text = "CONFIRM PASSWORD";
            // 
            // verSenha
            // 
            verSenha.AutoSize = true;
            verSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verSenha.ForeColor = Color.FromArgb(122, 122, 122);
            verSenha.Location = new Point(90, 379);
            verSenha.Name = "verSenha";
            verSenha.Size = new Size(58, 21);
            verSenha.TabIndex = 15;
            verSenha.Text = "Show";
            verSenha.UseVisualStyleBackColor = true;
            verSenha.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(484, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(241, 385);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 41, 41);
            ClientSize = new Size(768, 514);
            Controls.Add(pictureBox2);
            Controls.Add(verSenha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(criarConta);
            Controls.Add(txtconfSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form2";
            ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUser;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtconfSenha;
        private Button criarConta;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private CheckBox verSenha;
        private PictureBox pictureBox2;
    }
}