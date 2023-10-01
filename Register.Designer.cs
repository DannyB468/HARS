using System;

namespace Home_Appliance_Rental_System
{
    partial class Register
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
            this.HARS = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.Txtusername = new System.Windows.Forms.TextBox();
            this.Txtpassword = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.LinkLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // HARS
            // 
            this.HARS.AutoSize = true;
            this.HARS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HARS.ForeColor = System.Drawing.Color.White;
            this.HARS.Location = new System.Drawing.Point(248, 9);
            this.HARS.Name = "HARS";
            this.HARS.Size = new System.Drawing.Size(262, 20);
            this.HARS.TabIndex = 0;
            this.HARS.Text = "Home Appliance Rental System";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.Color.White;
            this.LblUsername.Location = new System.Drawing.Point(249, 68);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(70, 16);
            this.LblUsername.TabIndex = 2;
            this.LblUsername.Text = "Username";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.White;
            this.LblPassword.Location = new System.Drawing.Point(249, 107);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(67, 16);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Password";
            // 
            // Txtusername
            // 
            this.Txtusername.Location = new System.Drawing.Point(410, 64);
            this.Txtusername.Name = "Txtusername";
            this.Txtusername.Size = new System.Drawing.Size(100, 20);
            this.Txtusername.TabIndex = 4;
            // 
            // Txtpassword
            // 
            this.Txtpassword.Location = new System.Drawing.Point(410, 103);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Size = new System.Drawing.Size(100, 20);
            this.Txtpassword.TabIndex = 5;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(344, 181);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 23);
            this.BtnRegister.TabIndex = 6;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // LinkLogin
            // 
            this.LinkLogin.AutoSize = true;
            this.LinkLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.LinkLogin.LinkColor = System.Drawing.Color.White;
            this.LinkLogin.Location = new System.Drawing.Point(349, 220);
            this.LinkLogin.Name = "LinkLogin";
            this.LinkLogin.Size = new System.Drawing.Size(70, 16);
            this.LinkLogin.TabIndex = 7;
            this.LinkLogin.TabStop = true;
            this.LinkLogin.Text = "Login here";
            this.LinkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLogin_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LinkLogin);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.Txtusername);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.HARS);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Register_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label HARS;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox Txtusername;
        private System.Windows.Forms.TextBox Txtpassword;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.LinkLabel LinkLogin;
    }
}