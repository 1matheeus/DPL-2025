namespace Forms1_DPL2025
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            logButton = new Button();
            newaccButton = new Button();
            label5 = new Label();
            verSenha = new CheckBox();
            txtSenha = new TextBox();
            txtUsername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(381, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 71);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -3);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 498);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(418, 471);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 2;
            label2.Text = "Worldwide since 1980.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold);
            label3.Location = new Point(312, 191);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold);
            label4.Location = new Point(316, 243);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 19);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // logButton
            // 
            logButton.BackColor = Color.DarkGray;
            logButton.Location = new Point(381, 327);
            logButton.Name = "logButton";
            logButton.Size = new Size(224, 46);
            logButton.TabIndex = 8;
            logButton.Text = "Login";
            logButton.UseVisualStyleBackColor = false;
            logButton.Click += logButton_Click;
            // 
            // newaccButton
            // 
            newaccButton.BackColor = Color.DarkGray;
            newaccButton.Location = new Point(381, 391);
            newaccButton.Name = "newaccButton";
            newaccButton.Size = new Size(226, 46);
            newaccButton.TabIndex = 9;
            newaccButton.Text = "Create New Account";
            newaccButton.UseVisualStyleBackColor = false;
            newaccButton.Click += newaccButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 88);
            label5.Name = "label5";
            label5.Size = new Size(154, 19);
            label5.TabIndex = 10;
            label5.Text = "Welcome to Stüssy®.";
            // 
            // verSenha
            // 
            verSenha.AutoSize = true;
            verSenha.Location = new Point(467, 268);
            verSenha.Name = "verSenha";
            verSenha.Size = new Size(138, 23);
            verSenha.TabIndex = 11;
            verSenha.Text = "Show Password";
            verSenha.UseVisualStyleBackColor = true;
            verSenha.CheckedChanged += verSenha_CheckedChanged;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.DarkGray;
            txtSenha.Font = new Font("Segoe UI", 9F);
            txtSenha.Location = new Point(403, 236);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(250, 23);
            txtSenha.TabIndex = 12;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.DarkGray;
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.Location = new Point(403, 191);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 23);
            txtUsername.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(748, 495);
            Controls.Add(txtUsername);
            Controls.Add(txtSenha);
            Controls.Add(verSenha);
            Controls.Add(label5);
            Controls.Add(newaccButton);
            Controls.Add(logButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Stüssy®app";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button logButton;
        private Button newaccButton;
        private Label label5;
        private CheckBox verSenha;
        private TextBox txtSenha;
        private TextBox txtUsername;
    }
}
