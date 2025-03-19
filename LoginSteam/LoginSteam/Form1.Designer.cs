  using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LoginSteam
{
    public class GradientButton : Button
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
            txtUserBG = new TextBox();
            txtPasswordBG = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            qrcode = new PictureBox();
            label3 = new Label();
            helplink = new LinkLabel();
            logbutton = new GradientButton();
            CreateACC = new LinkLabel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)qrcode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUserBG
            // 
            txtUserBG.BackColor = Color.FromArgb(51, 53, 59);
            txtUserBG.BorderStyle = BorderStyle.None;
            txtUserBG.Enabled = false;
            txtUserBG.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserBG.Location = new Point(31, 95);
            txtUserBG.Name = "txtUserBG";
            txtUserBG.Size = new Size(355, 36);
            txtUserBG.TabIndex = 0;
            txtUserBG.TextChanged += txtUser_TextChanged;
            // 
            // txtPasswordBG
            // 
            txtPasswordBG.BackColor = Color.FromArgb(51, 53, 59);
            txtPasswordBG.BorderStyle = BorderStyle.None;
            txtPasswordBG.Enabled = false;
            txtPasswordBG.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasswordBG.Location = new Point(31, 157);
            txtPasswordBG.Name = "txtPasswordBG";
            txtPasswordBG.Size = new Size(355, 36);
            txtPasswordBG.TabIndex = 1;
            txtPasswordBG.UseSystemPasswordChar = true;
            txtPasswordBG.TextChanged += txtPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(57, 117, 187);
            label1.Location = new Point(27, 81);
            label1.Name = "label1";
            label1.Size = new Size(172, 13);
            label1.TabIndex = 2;
            label1.Text = "SIGN IN WITH ACCOUNT NAME";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(122, 122, 122);
            label2.Location = new Point(28, 140);
            label2.Name = "label2";
            label2.Size = new Size(67, 13);
            label2.TabIndex = 3;
            label2.Text = "PASSWORD";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(122, 122, 122);
            checkBox1.Location = new Point(31, 200);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(113, 21);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // qrcode
            // 
            qrcode.Image = Properties.Resources.qrcode_log;
            qrcode.Location = new Point(436, 95);
            qrcode.Name = "qrcode";
            qrcode.Size = new Size(163, 161);
            qrcode.TabIndex = 5;
            qrcode.TabStop = false;
            qrcode.Paint += qrcode_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(56, 109, 172);
            label3.Location = new Point(436, 81);
            label3.Name = "label3";
            label3.Size = new Size(115, 13);
            label3.TabIndex = 6;
            label3.Text = "OR SIGN IN WITH QR";
            // 
            // helplink
            // 
            helplink.ActiveLinkColor = Color.FromArgb(122, 122, 122);
            helplink.AutoSize = true;
            helplink.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            helplink.LinkColor = Color.FromArgb(122, 122, 122);
            helplink.Location = new Point(31, 334);
            helplink.Name = "helplink";
            helplink.Size = new Size(106, 13);
            helplink.TabIndex = 7;
            helplink.TabStop = true;
            helplink.Text = "Help, I can't sign in";
            helplink.VisitedLinkColor = Color.FromArgb(122, 122, 122);
            helplink.LinkClicked += helplink_LinkClicked;
            // 
            // logbutton
            // 
            logbutton.BackColor = Color.FromArgb(73, 155, 248);
            logbutton.FlatStyle = FlatStyle.Popup;
            logbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logbutton.ForeColor = Color.White;
            logbutton.Location = new Point(91, 228);
            logbutton.Margin = new Padding(0);
            logbutton.Name = "logbutton";
            logbutton.Size = new Size(254, 41);
            logbutton.TabIndex = 8;
            logbutton.Text = "Sign In";
            logbutton.UseVisualStyleBackColor = false;
            logbutton.Click += logbutton_Click;
            // 
            // CreateACC
            // 
            CreateACC.ActiveLinkColor = Color.FromArgb(122, 122, 122);
            CreateACC.AutoSize = true;
            CreateACC.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateACC.LinkColor = Color.FromArgb(122, 122, 122);
            CreateACC.Location = new Point(531, 334);
            CreateACC.Name = "CreateACC";
            CreateACC.Size = new Size(119, 13);
            CreateACC.TabIndex = 9;
            CreateACC.TabStop = true;
            CreateACC.Text = "Create a Free Account";
            CreateACC.VisitedLinkColor = Color.FromArgb(122, 122, 122);
            CreateACC.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(122, 122, 122);
            label4.Location = new Point(380, 334);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(155, 13);
            label4.TabIndex = 10;
            label4.Text = "Don't have a Steam account?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, -27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 105);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(51, 53, 59);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(38, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 18);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(51, 53, 59);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(38, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(344, 18);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 35, 40);
            ClientSize = new Size(671, 372);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(CreateACC);
            Controls.Add(label4);
            Controls.Add(logbutton);
            Controls.Add(helplink);
            Controls.Add(label3);
            Controls.Add(qrcode);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPasswordBG);
            Controls.Add(txtUserBG);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)qrcode).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserBG;
        private TextBox txtPasswordBG;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private PictureBox qrcode;
        private Label label3;
        private LinkLabel helplink;
        private GradientButton logbutton;
        private LinkLabel CreateACC;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
