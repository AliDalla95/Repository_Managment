namespace Salameh
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.formSkin1 = new theme.FormSkin();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flatLabel2 = new theme.FlatLabel();
            this.btn2 = new theme.FlatButton();
            this.flatLabel1 = new theme.FlatLabel();
            this.btn1 = new theme.FlatButton();
            this.flatClose1 = new theme.FlatClose();
            this.flatMini1 = new theme.FlatMini();
            this.flatMax1 = new theme.FlatMax();
            this.formSkin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.Black;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.textBox2);
            this.formSkin1.Controls.Add(this.textBox1);
            this.formSkin1.Controls.Add(this.pictureBox1);
            this.formSkin1.Controls.Add(this.flatLabel2);
            this.formSkin1.Controls.Add(this.btn2);
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Controls.Add(this.btn1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Controls.Add(this.flatMax1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formSkin1.ForeColor = System.Drawing.Color.Lime;
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.formSkin1.Size = new System.Drawing.Size(662, 379);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "تسجيل الدخول";
            this.formSkin1.Click += new System.EventHandler(this.formSkin1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(40, 188);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(237, 29);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(40, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::Salameh.Properties.Resources._538684_lock_512x512;
            this.pictureBox1.Location = new System.Drawing.Point(428, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(321, 195);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(63, 13);
            this.flatLabel2.TabIndex = 6;
            this.flatLabel2.Text = "كلمة المرور:";
            this.flatLabel2.Click += new System.EventHandler(this.flatLabel2_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BaseColor = System.Drawing.Color.Red;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn2.Location = new System.Drawing.Point(40, 261);
            this.btn2.Name = "btn2";
            this.btn2.Rounded = true;
            this.btn2.Size = new System.Drawing.Size(123, 32);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "الخروج";
            this.btn2.TextColor = System.Drawing.Color.White;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(309, 135);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(75, 13);
            this.flatLabel1.TabIndex = 5;
            this.flatLabel1.Text = "أسم المستخدم:";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn1.Location = new System.Drawing.Point(255, 261);
            this.btn1.Name = "btn1";
            this.btn1.Rounded = true;
            this.btn1.Size = new System.Drawing.Size(123, 32);
            this.btn1.TabIndex = 3;
            this.btn1.Text = " الدخول";
            this.btn1.TextColor = System.Drawing.Color.Black;
            this.btn1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(632, 28);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 2;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(566, 28);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 1;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(599, 28);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 0;
            this.flatMax1.Text = "flatMax1";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 379);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private theme.FormSkin formSkin1;
        private theme.FlatLabel flatLabel2;
        private theme.FlatButton btn2;
        private theme.FlatLabel flatLabel1;
        private theme.FlatButton btn1;
        private theme.FlatClose flatClose1;
        private theme.FlatMini flatMini1;
        private theme.FlatMax flatMax1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

