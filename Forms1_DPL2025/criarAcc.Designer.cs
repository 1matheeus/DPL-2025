namespace Forms1_DPL2025
{
    partial class criarAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(criarAcc));
            label5 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtconfSenha = new TextBox();
            verSenha = new CheckBox();
            createAccButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold);
            label5.Location = new Point(500, 139);
            label5.Name = "label5";
            label5.Size = new Size(154, 19);
            label5.TabIndex = 12;
            label5.Text = "Welcome to Stüssy®.";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(364, 1);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(403, 157);
            label1.TabIndex = 11;
            label1.Text = "CREATE NEW ACCOUNT";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-82, -97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 704);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold);
            label2.Location = new Point(410, 194);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 14;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold);
            label3.Location = new Point(436, 233);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 15;
            label3.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold);
            label4.Location = new Point(352, 312);
            label4.Name = "label4";
            label4.Size = new Size(142, 19);
            label4.TabIndex = 16;
            label4.Text = "Confirm Password:";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold);
            label6.Location = new Point(414, 273);
            label6.Name = "label6";
            label6.Size = new Size(80, 19);
            label6.TabIndex = 17;
            label6.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.DarkGray;
            txtUsername.Location = new Point(500, 194);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(229, 23);
            txtUsername.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.DarkGray;
            txtEmail.Location = new Point(500, 233);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 23);
            txtEmail.TabIndex = 19;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.DarkGray;
            txtSenha.Location = new Point(500, 273);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(229, 23);
            txtSenha.TabIndex = 20;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtconfSenha
            // 
            txtconfSenha.BackColor = Color.DarkGray;
            txtconfSenha.Location = new Point(500, 312);
            txtconfSenha.Name = "txtconfSenha";
            txtconfSenha.Size = new Size(229, 23);
            txtconfSenha.TabIndex = 21;
            txtconfSenha.UseSystemPasswordChar = true;
            // 
            // verSenha
            // 
            verSenha.AutoSize = true;
            verSenha.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold);
            verSenha.Location = new Point(540, 341);
            verSenha.Name = "verSenha";
            verSenha.Size = new Size(138, 23);
            verSenha.TabIndex = 22;
            verSenha.Text = "Show Password";
            verSenha.UseVisualStyleBackColor = true;
            verSenha.CheckedChanged += verSenha_CheckedChanged;
            // 
            // createAccButton
            // 
            createAccButton.BackColor = Color.DarkGray;
            createAccButton.Location = new Point(463, 395);
            createAccButton.Name = "createAccButton";
            createAccButton.Size = new Size(242, 51);
            createAccButton.TabIndex = 23;
            createAccButton.Text = "Sign In";
            createAccButton.UseVisualStyleBackColor = false;
            createAccButton.Click += createAccButton_Click;
            // 
            // criarAcc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 500);
            Controls.Add(createAccButton);
            Controls.Add(verSenha);
            Controls.Add(txtconfSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "criarAcc";
            Text = "criarAcc";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtconfSenha;
        private CheckBox verSenha;
        private Button createAccButton;
    }
}