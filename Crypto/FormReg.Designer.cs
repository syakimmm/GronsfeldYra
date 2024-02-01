namespace Crypto
{
    partial class FormReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReg));
            this.tPassReg2 = new System.Windows.Forms.TextBox();
            this.labelRegistrPassword2 = new System.Windows.Forms.Label();
            this.bReg = new System.Windows.Forms.Button();
            this.tPassReg1 = new System.Windows.Forms.TextBox();
            this.labelRegistrPassword = new System.Windows.Forms.Label();
            this.tLoginReg = new System.Windows.Forms.TextBox();
            this.labelRegistrLogin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tPassReg2
            // 
            this.tPassReg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tPassReg2.Location = new System.Drawing.Point(139, 235);
            this.tPassReg2.Margin = new System.Windows.Forms.Padding(4);
            this.tPassReg2.Name = "tPassReg2";
            this.tPassReg2.PasswordChar = '*';
            this.tPassReg2.Size = new System.Drawing.Size(218, 30);
            this.tPassReg2.TabIndex = 22;
            this.tPassReg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRegistrPassword2
            // 
            this.labelRegistrPassword2.BackColor = System.Drawing.Color.IndianRed;
            this.labelRegistrPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRegistrPassword2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRegistrPassword2.Location = new System.Drawing.Point(25, 229);
            this.labelRegistrPassword2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegistrPassword2.Name = "labelRegistrPassword2";
            this.labelRegistrPassword2.Size = new System.Drawing.Size(94, 48);
            this.labelRegistrPassword2.TabIndex = 21;
            this.labelRegistrPassword2.Text = "ПРОВЕРКА";
            this.labelRegistrPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bReg
            // 
            this.bReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bReg.Location = new System.Drawing.Point(37, 314);
            this.bReg.Margin = new System.Windows.Forms.Padding(4);
            this.bReg.Name = "bReg";
            this.bReg.Size = new System.Drawing.Size(305, 56);
            this.bReg.TabIndex = 20;
            this.bReg.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            this.bReg.UseVisualStyleBackColor = true;
            this.bReg.Click += new System.EventHandler(this.bReg_Click);
            // 
            // tPassReg1
            // 
            this.tPassReg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tPassReg1.Location = new System.Drawing.Point(139, 175);
            this.tPassReg1.Margin = new System.Windows.Forms.Padding(4);
            this.tPassReg1.Name = "tPassReg1";
            this.tPassReg1.PasswordChar = '*';
            this.tPassReg1.Size = new System.Drawing.Size(218, 30);
            this.tPassReg1.TabIndex = 19;
            this.tPassReg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRegistrPassword
            // 
            this.labelRegistrPassword.BackColor = System.Drawing.Color.IndianRed;
            this.labelRegistrPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRegistrPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRegistrPassword.Location = new System.Drawing.Point(25, 171);
            this.labelRegistrPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegistrPassword.Name = "labelRegistrPassword";
            this.labelRegistrPassword.Size = new System.Drawing.Size(94, 45);
            this.labelRegistrPassword.TabIndex = 18;
            this.labelRegistrPassword.Text = "ПАРОЛЬ";
            this.labelRegistrPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tLoginReg
            // 
            this.tLoginReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tLoginReg.Location = new System.Drawing.Point(139, 108);
            this.tLoginReg.Margin = new System.Windows.Forms.Padding(4);
            this.tLoginReg.Name = "tLoginReg";
            this.tLoginReg.Size = new System.Drawing.Size(219, 30);
            this.tLoginReg.TabIndex = 17;
            this.tLoginReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRegistrLogin
            // 
            this.labelRegistrLogin.BackColor = System.Drawing.Color.IndianRed;
            this.labelRegistrLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRegistrLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRegistrLogin.Location = new System.Drawing.Point(25, 104);
            this.labelRegistrLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegistrLogin.Name = "labelRegistrLogin";
            this.labelRegistrLogin.Size = new System.Drawing.Size(94, 45);
            this.labelRegistrLogin.TabIndex = 16;
            this.labelRegistrLogin.Text = "ЛОГИН";
            this.labelRegistrLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(13, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 42);
            this.label6.TabIndex = 15;
            this.label6.Text = "Укажите данные для регистрации\r\nнового пользователя";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(392, 406);
            this.Controls.Add(this.tPassReg2);
            this.Controls.Add(this.labelRegistrPassword2);
            this.Controls.Add(this.bReg);
            this.Controls.Add(this.tPassReg1);
            this.Controls.Add(this.labelRegistrPassword);
            this.Controls.Add(this.tLoginReg);
            this.Controls.Add(this.labelRegistrLogin);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.FormReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tPassReg2;
        private System.Windows.Forms.Label labelRegistrPassword2;
        private System.Windows.Forms.Button bReg;
        private System.Windows.Forms.TextBox tPassReg1;
        private System.Windows.Forms.Label labelRegistrPassword;
        private System.Windows.Forms.TextBox tLoginReg;
        private System.Windows.Forms.Label labelRegistrLogin;
        private System.Windows.Forms.Label label6;
    }
}