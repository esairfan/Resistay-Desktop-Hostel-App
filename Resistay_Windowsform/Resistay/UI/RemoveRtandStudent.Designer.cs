namespace Resistay.UI
{
    partial class RemoveRtandStudent
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
            Guna.UI2.WinForms.Guna2Button BackToMenubtn;
            this.dltrt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RemoveRtBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RemoveStudentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RtLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.StudentLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.StudentName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.removertLabel = new System.Windows.Forms.Label();
            this.RemoveStudent = new System.Windows.Forms.Label();
            BackToMenubtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // BackToMenubtn
            // 
            BackToMenubtn.BorderRadius = 20;
            BackToMenubtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            BackToMenubtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            BackToMenubtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            BackToMenubtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            BackToMenubtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            BackToMenubtn.ForeColor = System.Drawing.Color.Black;
            BackToMenubtn.Location = new System.Drawing.Point(747, 470);
            BackToMenubtn.Name = "BackToMenubtn";
            BackToMenubtn.Size = new System.Drawing.Size(110, 23);
            BackToMenubtn.TabIndex = 61;
            BackToMenubtn.Text = "Back To Menu";
            BackToMenubtn.Click += new System.EventHandler(this.BackToMenubtn_Click);
            // 
            // dltrt
            // 
            this.dltrt.BackColor = System.Drawing.Color.Transparent;
            this.dltrt.BorderRadius = 22;
            this.dltrt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dltrt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dltrt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dltrt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dltrt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dltrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dltrt.ItemHeight = 30;
            this.dltrt.Items.AddRange(new object[] {
            " "});
            this.dltrt.Location = new System.Drawing.Point(324, 278);
            this.dltrt.Name = "dltrt";
            this.dltrt.Size = new System.Drawing.Size(140, 36);
            this.dltrt.TabIndex = 60;
            this.dltrt.SelectedIndexChanged += new System.EventHandler(this.dltrt_SelectedIndexChanged);
            // 
            // RemoveRtBtn
            // 
            this.RemoveRtBtn.BorderRadius = 26;
            this.RemoveRtBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RemoveRtBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RemoveRtBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveRtBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RemoveRtBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveRtBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveRtBtn.Location = new System.Drawing.Point(497, 334);
            this.RemoveRtBtn.Name = "RemoveRtBtn";
            this.RemoveRtBtn.Size = new System.Drawing.Size(80, 45);
            this.RemoveRtBtn.TabIndex = 59;
            this.RemoveRtBtn.Text = "Remove";
            this.RemoveRtBtn.Click += new System.EventHandler(this.RemoveRtBtn_Click);
            // 
            // RemoveStudentBtn
            // 
            this.RemoveStudentBtn.BorderRadius = 26;
            this.RemoveStudentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RemoveStudentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RemoveStudentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveStudentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RemoveStudentBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveStudentBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveStudentBtn.Location = new System.Drawing.Point(497, 152);
            this.RemoveStudentBtn.Name = "RemoveStudentBtn";
            this.RemoveStudentBtn.Size = new System.Drawing.Size(80, 45);
            this.RemoveStudentBtn.TabIndex = 58;
            this.RemoveStudentBtn.Text = "Remove";
            this.RemoveStudentBtn.Click += new System.EventHandler(this.RemoveStudentBtn_Click);
            // 
            // RtLabel
            // 
            this.RtLabel.BackColor = System.Drawing.Color.Transparent;
            this.RtLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtLabel.Location = new System.Drawing.Point(99, 292);
            this.RtLabel.Name = "RtLabel";
            this.RtLabel.Size = new System.Drawing.Size(58, 22);
            this.RtLabel.TabIndex = 55;
            this.RtLabel.Text = "Enter Rt";
            // 
            // StudentLabel
            // 
            this.StudentLabel.BackColor = System.Drawing.Color.Transparent;
            this.StudentLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.Location = new System.Drawing.Point(99, 98);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(99, 22);
            this.StudentLabel.TabIndex = 53;
            this.StudentLabel.Text = "Enter Student";
            // 
            // StudentName
            // 
            this.StudentName.BackColor = System.Drawing.Color.Transparent;
            this.StudentName.BorderRadius = 22;
            this.StudentName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StudentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.StudentName.ItemHeight = 30;
            this.StudentName.Items.AddRange(new object[] {
            "Boys",
            "Girls"});
            this.StudentName.Location = new System.Drawing.Point(324, 84);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(140, 36);
            this.StudentName.TabIndex = 52;
            // 
            // removertLabel
            // 
            this.removertLabel.AutoSize = true;
            this.removertLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removertLabel.Location = new System.Drawing.Point(27, 219);
            this.removertLabel.Name = "removertLabel";
            this.removertLabel.Size = new System.Drawing.Size(140, 26);
            this.removertLabel.TabIndex = 50;
            this.removertLabel.Text = "Remove Rt";
            // 
            // RemoveStudent
            // 
            this.RemoveStudent.AutoSize = true;
            this.RemoveStudent.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveStudent.Location = new System.Drawing.Point(27, 35);
            this.RemoveStudent.Name = "RemoveStudent";
            this.RemoveStudent.Size = new System.Drawing.Size(210, 26);
            this.RemoveStudent.TabIndex = 49;
            this.RemoveStudent.Text = "Remove Student";
            // 
            // RemoveRtandStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 512);
            this.Controls.Add(BackToMenubtn);
            this.Controls.Add(this.dltrt);
            this.Controls.Add(this.RemoveRtBtn);
            this.Controls.Add(this.RemoveStudentBtn);
            this.Controls.Add(this.RtLabel);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.removertLabel);
            this.Controls.Add(this.RemoveStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveRtandStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveRtandStudent";
            this.Load += new System.EventHandler(this.RemoveRtandStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox dltrt;
        private Guna.UI2.WinForms.Guna2Button RemoveRtBtn;
        private Guna.UI2.WinForms.Guna2Button RemoveStudentBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel RtLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel StudentLabel;
        private Guna.UI2.WinForms.Guna2ComboBox StudentName;
        private System.Windows.Forms.Label removertLabel;
        private System.Windows.Forms.Label RemoveStudent;
    }
}