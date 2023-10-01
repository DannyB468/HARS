using System;

namespace Home_Appliance_Rental_System
{
    partial class UserMenu
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
            this.LblSearch = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblSort = new System.Windows.Forms.Label();
            this.CmbSort = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.ForeColor = System.Drawing.Color.White;
            this.LblSearch.Location = new System.Drawing.Point(481, 146);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(50, 16);
            this.LblSearch.TabIndex = 0;
            this.LblSearch.Text = "Search";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(595, 142);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(100, 20);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // LblSort
            // 
            this.LblSort.AutoSize = true;
            this.LblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSort.ForeColor = System.Drawing.SystemColors.Control;
            this.LblSort.Location = new System.Drawing.Point(740, 146);
            this.LblSort.Name = "LblSort";
            this.LblSort.Size = new System.Drawing.Size(31, 16);
            this.LblSort.TabIndex = 2;
            this.LblSort.Text = "Sort";
            // 
            // CmbSort
            // 
            this.CmbSort.FormattingEnabled = true;
            this.CmbSort.Items.AddRange(new object[] {
            "Energy Consumption",
            "Weekly Cost"});
            this.CmbSort.Location = new System.Drawing.Point(789, 142);
            this.CmbSort.Name = "CmbSort";
            this.CmbSort.Size = new System.Drawing.Size(121, 21);
            this.CmbSort.TabIndex = 3;
            this.CmbSort.SelectedIndexChanged += new System.EventHandler(this.CmbSort_SelectedIndexChanged);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(937, 400);
            this.Controls.Add(this.CmbSort);
            this.Controls.Add(this.LblSort);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LblSearch);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.Load += new System.EventHandler(this.UserMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblSort;
        private System.Windows.Forms.ComboBox CmbSort;
    }
}