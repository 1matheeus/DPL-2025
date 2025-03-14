namespace Exercicio02DPL
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ShowPW = new CheckBox();
            txtUser = new TextBox();
            txtSenha = new TextBox();
            LoginButton = new Button();
            button1 = new Button();
            NewAcc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(121, 29);
            label1.Name = "label1";
            label1.Size = new Size(129, 47);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 107);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 137);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Pass Word:";
            // 
            // ShowPW
            // 
            ShowPW.AutoSize = true;
            ShowPW.Location = new Point(267, 135);
            ShowPW.Name = "ShowPW";
            ShowPW.Size = new Size(55, 19);
            ShowPW.TabIndex = 3;
            ShowPW.Text = "Show";
            ShowPW.UseVisualStyleBackColor = true;
            ShowPW.CheckedChanged += ShowPW_CheckedChanged;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(121, 104);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(140, 23);
            txtUser.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(121, 133);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(140, 23);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(106, 207);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(173, 42);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Sign In";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(36, 271);
            button1.Name = "button1";
            button1.Size = new Size(157, 25);
            button1.TabIndex = 7;
            button1.Text = "Forgot Password";
            button1.UseVisualStyleBackColor = true;
            // 
            // NewAcc
            // 
            NewAcc.Location = new Point(199, 271);
            NewAcc.Name = "NewAcc";
            NewAcc.Size = new Size(157, 25);
            NewAcc.TabIndex = 8;
            NewAcc.Text = "Create New Account";
            NewAcc.UseVisualStyleBackColor = true;
            NewAcc.Click += NewAcc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(387, 326);
            Controls.Add(NewAcc);
            Controls.Add(button1);
            Controls.Add(LoginButton);
            Controls.Add(txtSenha);
            Controls.Add(txtUser);
            Controls.Add(ShowPW);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox ShowPW;
        private TextBox txtUser;
        private TextBox txtSenha;
        private Button LoginButton;
        private Button button1;
        private Button NewAcc;
    }
}
