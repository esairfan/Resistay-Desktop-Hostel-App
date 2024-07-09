namespace Resistay.UI
{
    partial class UpdatePassword
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
            Guna.UI2.WinForms.Guna2Button BackToMenu;
            this.Profile = new System.Windows.Forms.Label();
            this.NewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.CurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.Updatepasswordbtn = new Guna.UI2.WinForms.Guna2Button();
            BackToMenu = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // BackToMenu
            // 
            BackToMenu.BorderRadius = 20;
            BackToMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            BackToMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            BackToMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            BackToMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            BackToMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            BackToMenu.ForeColor = System.Drawing.Color.Black;
            BackToMenu.Location = new System.Drawing.Point(277, 319);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new System.Drawing.Size(110, 23);
            BackToMenu.TabIndex = 61;
            BackToMenu.Text = "Back To Menu";
            BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // Profile
            // 
            this.Profile.AutoSize = true;
            this.Profile.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile.Location = new System.Drawing.Point(40, 36);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(229, 26);
            this.Profile.TabIndex = 2;
            this.Profile.Text = "Update Password";
            // 
            // NewPassword
            // 
            this.NewPassword.BorderRadius = 22;
            this.NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewPassword.DefaultText = "";
            this.NewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPassword.Location = new System.Drawing.Point(99, 190);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.PasswordChar = '\0';
            this.NewPassword.PlaceholderForeColor = System.Drawing.Color.Black;
            this.NewPassword.PlaceholderText = "New Password";
            this.NewPassword.SelectedText = "";
            this.NewPassword.Size = new System.Drawing.Size(200, 36);
            this.NewPassword.TabIndex = 33;
            // 
            // CurrentPassword
            // 
            this.CurrentPassword.BorderRadius = 22;
            this.CurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CurrentPassword.DefaultText = "";
            this.CurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CurrentPassword.Location = new System.Drawing.Point(99, 129);
            this.CurrentPassword.Name = "CurrentPassword";
            this.CurrentPassword.PasswordChar = '\0';
            this.CurrentPassword.PlaceholderForeColor = System.Drawing.Color.Black;
            this.CurrentPassword.PlaceholderText = "Current Password";
            this.CurrentPassword.SelectedText = "";
            this.CurrentPassword.Size = new System.Drawing.Size(200, 36);
            this.CurrentPassword.TabIndex = 32;
            // 
            // Updatepasswordbtn
            // 
            this.Updatepasswordbtn.BorderRadius = 26;
            this.Updatepasswordbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Updatepasswordbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Updatepasswordbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Updatepasswordbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Updatepasswordbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Updatepasswordbtn.ForeColor = System.Drawing.Color.White;
            this.Updatepasswordbtn.Location = new System.Drawing.Point(152, 242);
            this.Updatepasswordbtn.Name = "Updatepasswordbtn";
            this.Updatepasswordbtn.Size = new System.Drawing.Size(80, 45);
            this.Updatepasswordbtn.TabIndex = 48;
            this.Updatepasswordbtn.Text = "Update";
            this.Updatepasswordbtn.Click += new System.EventHandler(this.Updatepasswordbtn_Click);
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 354);
            this.Controls.Add(BackToMenu);
            this.Controls.Add(this.Updatepasswordbtn);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.CurrentPassword);
            this.Controls.Add(this.Profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePassword";
            this.Load += new System.EventHandler(this.UpdatePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Profile;
        private Guna.UI2.WinForms.Guna2TextBox NewPassword;
        private Guna.UI2.WinForms.Guna2TextBox CurrentPassword;
        private Guna.UI2.WinForms.Guna2Button Updatepasswordbtn;
    }
}