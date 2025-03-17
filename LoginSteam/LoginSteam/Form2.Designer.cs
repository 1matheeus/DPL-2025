using System.Drawing.Drawing2D;

namespace LoginSteam
{
    public class GradientButton1 : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            Rectangle rect = this.ClientRectangle;
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.FromArgb(84, 183, 249), Color.FromArgb(65, 116, 246), LinearGradientMode.Horizontal))
            {
                g.FillRectangle(brush, rect);
            }
            TextRenderer.DrawText(g, this.Text, this.Font, rect, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }

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
            txtUserBG = new TextBox();
            txtEmailBG = new TextBox();
            txtSenhaBG = new TextBox();
            txtconfSenhaBG = new TextBox();
            criarConta = new GradientButton1();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            verSenha = new CheckBox();
            pictureBox2 = new PictureBox();
            txtconfSenha = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            txtUser = new TextBox();
            BackButton = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 106);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtUserBG
            // 
            txtUserBG.BackColor = Color.FromArgb(51, 53, 59);
            txtUserBG.BorderStyle = BorderStyle.None;
            txtUserBG.Enabled = false;
            txtUserBG.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserBG.Location = new Point(82, 127);
            txtUserBG.Name = "txtUserBG";
            txtUserBG.Size = new Size(355, 36);
            txtUserBG.TabIndex = 1;
            // 
            // txtEmailBG
            // 
            txtEmailBG.BackColor = Color.FromArgb(51, 53, 59);
            txtEmailBG.BorderStyle = BorderStyle.None;
            txtEmailBG.Enabled = false;
            txtEmailBG.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailBG.Location = new Point(82, 197);
            txtEmailBG.Name = "txtEmailBG";
            txtEmailBG.Size = new Size(355, 36);
            txtEmailBG.TabIndex = 2;
            // 
            // txtSenhaBG
            // 
            txtSenhaBG.BackColor = Color.FromArgb(51, 53, 59);
            txtSenhaBG.BorderStyle = BorderStyle.None;
            txtSenhaBG.Enabled = false;
            txtSenhaBG.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenhaBG.Location = new Point(82, 267);
            txtSenhaBG.Name = "txtSenhaBG";
            txtSenhaBG.Size = new Size(355, 36);
            txtSenhaBG.TabIndex = 3;
            txtSenhaBG.UseSystemPasswordChar = true;
            // 
            // txtconfSenhaBG
            // 
            txtconfSenhaBG.BackColor = Color.FromArgb(51, 53, 59);
            txtconfSenhaBG.BorderStyle = BorderStyle.None;
            txtconfSenhaBG.Enabled = false;
            txtconfSenhaBG.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtconfSenhaBG.Location = new Point(82, 337);
            txtconfSenhaBG.Name = "txtconfSenhaBG";
            txtconfSenhaBG.Size = new Size(355, 36);
            txtconfSenhaBG.TabIndex = 4;
            txtconfSenhaBG.UseSystemPasswordChar = true;
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
            pictureBox2.Location = new Point(468, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(257, 384);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // txtconfSenha
            // 
            txtconfSenha.BackColor = Color.FromArgb(51, 53, 59);
            txtconfSenha.BorderStyle = BorderStyle.None;
            txtconfSenha.Font = new Font("Segoe UI", 9.75F);
            txtconfSenha.ForeColor = Color.White;
            txtconfSenha.Location = new Point(87, 347);
            txtconfSenha.Name = "txtconfSenha";
            txtconfSenha.Size = new Size(347, 18);
            txtconfSenha.TabIndex = 17;
            txtconfSenha.UseSystemPasswordChar = true;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(51, 53, 59);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 9.75F);
            txtSenha.ForeColor = Color.White;
            txtSenha.Location = new Point(87, 277);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(347, 18);
            txtSenha.TabIndex = 18;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(51, 53, 59);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 9.75F);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(87, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(347, 18);
            txtEmail.TabIndex = 19;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(51, 53, 59);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 9.75F);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(87, 137);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(347, 18);
            txtUser.TabIndex = 20;
            txtUser.TextChanged += textBox4_TextChanged;
            // 
            // BackButton
            // 
            BackButton.ActiveLinkColor = Color.FromArgb(122, 122, 122);
            BackButton.AutoSize = true;
            BackButton.DisabledLinkColor = Color.FromArgb(122, 122, 122);
            BackButton.ForeColor = Color.FromArgb(122, 122, 122);
            BackButton.LinkColor = Color.FromArgb(122, 122, 122);
            BackButton.Location = new Point(688, 479);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(37, 15);
            BackButton.TabIndex = 21;
            BackButton.TabStop = true;
            BackButton.Text = "Voltar";
            BackButton.VisitedLinkColor = Color.FromArgb(122, 122, 122);
            BackButton.LinkClicked += BackButton_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 35, 40);
            ClientSize = new Size(768, 514);
            Controls.Add(BackButton);
            Controls.Add(txtUser);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtconfSenha);
            Controls.Add(pictureBox2);
            Controls.Add(verSenha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(criarConta);
            Controls.Add(txtconfSenhaBG);
            Controls.Add(txtSenhaBG);
            Controls.Add(txtEmailBG);
            Controls.Add(txtUserBG);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
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
        private TextBox txtUserBG;
        private TextBox txtEmailBG;
        private TextBox txtSenhaBG;
        private TextBox txtconfSenhaBG;
        private GradientButton1 criarConta;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private CheckBox verSenha;
        private PictureBox pictureBox2;
        private TextBox txtconfSenha;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private TextBox txtUser;
        private LinkLabel BackButton;
    }
}