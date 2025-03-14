namespace Exercicio02DPL
{
    partial class NewACC
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtConfsenha = new TextBox();
            ShowPW = new CheckBox();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 50);
            label1.Name = "label1";
            label1.Size = new Size(279, 40);
            label1.TabIndex = 0;
            label1.Text = "NEW ACCOUNT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(118, 144);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(144, 173);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "E-mail:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(89, 202);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 3;
            label4.Text = "New Password:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(65, 231);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 4;
            label5.Text = "Confirm Password:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(207, 141);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(146, 23);
            txtUsername.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(207, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(146, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(207, 199);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(146, 23);
            txtSenha.TabIndex = 7;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtConfsenha
            // 
            txtConfsenha.Location = new Point(207, 228);
            txtConfsenha.Name = "txtConfsenha";
            txtConfsenha.Size = new Size(146, 23);
            txtConfsenha.TabIndex = 8;
            txtConfsenha.UseSystemPasswordChar = true;
            // 
            // ShowPW
            // 
            ShowPW.AutoSize = true;
            ShowPW.Location = new Point(226, 257);
            ShowPW.Name = "ShowPW";
            ShowPW.Size = new Size(108, 19);
            ShowPW.TabIndex = 9;
            ShowPW.Text = "Show Password";
            ShowPW.UseVisualStyleBackColor = true;
            ShowPW.CheckedChanged += ShowPW_CheckedChanged;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(183, 303);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(181, 43);
            CreateButton.TabIndex = 10;
            CreateButton.Text = "Create Account";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += button1_Click;
            // 
            // NewACC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(535, 423);
            Controls.Add(CreateButton);
            Controls.Add(ShowPW);
            Controls.Add(txtConfsenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "NewACC";
            ShowIcon = false;
            Text = "NewACC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtConfsenha;
        private CheckBox ShowPW;
        private Button CreateButton;
    }
}