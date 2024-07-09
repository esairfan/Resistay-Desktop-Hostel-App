namespace Resistay.UI
{
    partial class FeesAllotement
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
            this.AllotStudentCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AllotStudentLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AllotementFees = new System.Windows.Forms.Label();
            this.StudentFees = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Date = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.StudentFee = new Guna.UI2.WinForms.Guna2TextBox();
            this.AllotfeesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FeesChallan = new Guna.UI2.WinForms.Guna2TextBox();
            this.ChallanLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            BackToMenu.Location = new System.Drawing.Point(356, 392);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new System.Drawing.Size(110, 23);
            BackToMenu.TabIndex = 59;
            BackToMenu.Text = "Back To Menu";
            BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // AllotStudentCombo
            // 
            this.AllotStudentCombo.BackColor = System.Drawing.Color.Transparent;
            this.AllotStudentCombo.BorderRadius = 22;
            this.AllotStudentCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AllotStudentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AllotStudentCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllotStudentCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllotStudentCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AllotStudentCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AllotStudentCombo.ItemHeight = 30;
            this.AllotStudentCombo.Items.AddRange(new object[] {
            "Boys",
            "Girls"});
            this.AllotStudentCombo.Location = new System.Drawing.Point(209, 94);
            this.AllotStudentCombo.Name = "AllotStudentCombo";
            this.AllotStudentCombo.Size = new System.Drawing.Size(140, 36);
            this.AllotStudentCombo.TabIndex = 60;
            this.AllotStudentCombo.SelectedIndexChanged += new System.EventHandler(this.AllotStudentCombo_SelectedIndexChanged);
            // 
            // AllotStudentLabel
            // 
            this.AllotStudentLabel.BackColor = System.Drawing.Color.Transparent;
            this.AllotStudentLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllotStudentLabel.Location = new System.Drawing.Point(28, 108);
            this.AllotStudentLabel.Name = "AllotStudentLabel";
            this.AllotStudentLabel.Size = new System.Drawing.Size(107, 22);
            this.AllotStudentLabel.TabIndex = 54;
            this.AllotStudentLabel.Text = "Select Student";
            // 
            // AllotementFees
            // 
            this.AllotementFees.AutoSize = true;
            this.AllotementFees.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllotementFees.Location = new System.Drawing.Point(12, 24);
            this.AllotementFees.Name = "AllotementFees";
            this.AllotementFees.Size = new System.Drawing.Size(378, 52);
            this.AllotementFees.TabIndex = 52;
            this.AllotementFees.Text = "Allot Hostel Fees to Student\r\n ";
            // 
            // StudentFees
            // 
            this.StudentFees.BackColor = System.Drawing.Color.Transparent;
            this.StudentFees.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentFees.Location = new System.Drawing.Point(28, 165);
            this.StudentFees.Name = "StudentFees";
            this.StudentFees.Size = new System.Drawing.Size(77, 22);
            this.StudentFees.TabIndex = 62;
            this.StudentFees.Text = "Enter Fees";
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(28, 251);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(113, 22);
            this.Date.TabIndex = 63;
            this.Date.Text = "Enter due Date\r\n";
            // 
            // StudentFee
            // 
            this.StudentFee.AutoRoundedCorners = true;
            this.StudentFee.BorderRadius = 17;
            this.StudentFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StudentFee.DefaultText = "";
            this.StudentFee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StudentFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StudentFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StudentFee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StudentFee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentFee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StudentFee.ForeColor = System.Drawing.Color.Black;
            this.StudentFee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentFee.Location = new System.Drawing.Point(213, 151);
            this.StudentFee.Name = "StudentFee";
            this.StudentFee.PasswordChar = '\0';
            this.StudentFee.PlaceholderText = "";
            this.StudentFee.SelectedText = "";
            this.StudentFee.Size = new System.Drawing.Size(136, 36);
            this.StudentFee.TabIndex = 65;
            this.StudentFee.TextChanged += new System.EventHandler(this.Fee_TextChanged);
            // 
            // AllotfeesBtn
            // 
            this.AllotfeesBtn.BorderRadius = 26;
            this.AllotfeesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AllotfeesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AllotfeesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AllotfeesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AllotfeesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AllotfeesBtn.ForeColor = System.Drawing.Color.White;
            this.AllotfeesBtn.Location = new System.Drawing.Point(155, 303);
            this.AllotfeesBtn.Name = "AllotfeesBtn";
            this.AllotfeesBtn.Size = new System.Drawing.Size(80, 45);
            this.AllotfeesBtn.TabIndex = 66;
            this.AllotfeesBtn.Text = "Allot";
            this.AllotfeesBtn.Click += new System.EventHandler(this.AllotfeesBtn_Click);
            // 
            // DueDate
            // 
            this.DueDate.Checked = true;
            this.DueDate.FillColor = System.Drawing.Color.White;
            this.DueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DueDate.Location = new System.Drawing.Point(186, 251);
            this.DueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(182, 22);
            this.DueDate.TabIndex = 67;
            this.DueDate.Value = new System.DateTime(2024, 4, 27, 0, 40, 12, 694);
            // 
            // FeesChallan
            // 
            this.FeesChallan.AutoRoundedCorners = true;
            this.FeesChallan.BorderRadius = 17;
            this.FeesChallan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FeesChallan.DefaultText = "";
            this.FeesChallan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FeesChallan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FeesChallan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FeesChallan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FeesChallan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FeesChallan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FeesChallan.ForeColor = System.Drawing.Color.Black;
            this.FeesChallan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FeesChallan.Location = new System.Drawing.Point(213, 209);
            this.FeesChallan.Name = "FeesChallan";
            this.FeesChallan.PasswordChar = '\0';
            this.FeesChallan.PlaceholderText = "";
            this.FeesChallan.SelectedText = "";
            this.FeesChallan.Size = new System.Drawing.Size(136, 36);
            this.FeesChallan.TabIndex = 68;
            // 
            // ChallanLabel
            // 
            this.ChallanLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChallanLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChallanLabel.Location = new System.Drawing.Point(28, 213);
            this.ChallanLabel.Name = "ChallanLabel";
            this.ChallanLabel.Size = new System.Drawing.Size(158, 22);
            this.ChallanLabel.TabIndex = 69;
            this.ChallanLabel.Text = "Enter ChallanNumber";
            // 
            // FeesAllotement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 445);
            this.Controls.Add(this.ChallanLabel);
            this.Controls.Add(this.FeesChallan);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.AllotfeesBtn);
            this.Controls.Add(this.StudentFee);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.StudentFees);
            this.Controls.Add(this.AllotStudentCombo);
            this.Controls.Add(BackToMenu);
            this.Controls.Add(this.AllotStudentLabel);
            this.Controls.Add(this.AllotementFees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FeesAllotement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeesAllotement";
            this.Load += new System.EventHandler(this.FeesAllotement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox AllotStudentCombo;
        private Guna.UI2.WinForms.Guna2HtmlLabel AllotStudentLabel;
        private System.Windows.Forms.Label AllotementFees;
        private Guna.UI2.WinForms.Guna2HtmlLabel StudentFees;
        private Guna.UI2.WinForms.Guna2HtmlLabel Date;
        private Guna.UI2.WinForms.Guna2TextBox StudentFee;
        private Guna.UI2.WinForms.Guna2Button AllotfeesBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker DueDate;
        private Guna.UI2.WinForms.Guna2TextBox FeesChallan;
        private Guna.UI2.WinForms.Guna2HtmlLabel ChallanLabel;
    }
}