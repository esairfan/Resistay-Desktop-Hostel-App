namespace Resistay.UI
{
    partial class AllotmentofRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AllotRoomNoCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AllotBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AllotedStudenrGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AllotHostelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AllotStudentLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AllotHostelCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Allotementlabel = new System.Windows.Forms.Label();
            this.AllotStudentCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AllotRoomLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AllotedStudentLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            BackToMenu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllotedStudenrGridView)).BeginInit();
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
            BackToMenu.Location = new System.Drawing.Point(753, 470);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new System.Drawing.Size(110, 23);
            BackToMenu.TabIndex = 48;
            BackToMenu.Text = "Back To Menu";
            BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // AllotRoomNoCombo
            // 
            this.AllotRoomNoCombo.BackColor = System.Drawing.Color.Transparent;
            this.AllotRoomNoCombo.BorderRadius = 22;
            this.AllotRoomNoCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AllotRoomNoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AllotRoomNoCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllotRoomNoCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllotRoomNoCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AllotRoomNoCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AllotRoomNoCombo.ItemHeight = 30;
            this.AllotRoomNoCombo.Items.AddRange(new object[] {
            " "});
            this.AllotRoomNoCombo.Location = new System.Drawing.Point(194, 152);
            this.AllotRoomNoCombo.Name = "AllotRoomNoCombo";
            this.AllotRoomNoCombo.Size = new System.Drawing.Size(140, 36);
            this.AllotRoomNoCombo.TabIndex = 47;
            this.AllotRoomNoCombo.SelectedIndexChanged += new System.EventHandler(this.AllotRoomNoCombo_SelectedIndexChanged);
            // 
            // AllotBtn
            // 
            this.AllotBtn.BorderRadius = 26;
            this.AllotBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AllotBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AllotBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AllotBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AllotBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AllotBtn.ForeColor = System.Drawing.Color.White;
            this.AllotBtn.Location = new System.Drawing.Point(587, 143);
            this.AllotBtn.Name = "AllotBtn";
            this.AllotBtn.Size = new System.Drawing.Size(80, 45);
            this.AllotBtn.TabIndex = 45;
            this.AllotBtn.Text = "Allot";
            this.AllotBtn.Click += new System.EventHandler(this.AllotBtn_Click);
            // 
            // AllotedStudenrGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AllotedStudenrGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllotedStudenrGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AllotedStudenrGridView.ColumnHeadersHeight = 4;
            this.AllotedStudenrGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllotedStudenrGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.AllotedStudenrGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllotedStudenrGridView.Location = new System.Drawing.Point(74, 248);
            this.AllotedStudenrGridView.Name = "AllotedStudenrGridView";
            this.AllotedStudenrGridView.RowHeadersVisible = false;
            this.AllotedStudenrGridView.Size = new System.Drawing.Size(670, 214);
            this.AllotedStudenrGridView.TabIndex = 43;
            this.AllotedStudenrGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AllotedStudenrGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AllotedStudenrGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AllotedStudenrGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AllotedStudenrGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AllotedStudenrGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AllotedStudenrGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllotedStudenrGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AllotedStudenrGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AllotedStudenrGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllotedStudenrGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AllotedStudenrGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AllotedStudenrGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.AllotedStudenrGridView.ThemeStyle.ReadOnly = false;
            this.AllotedStudenrGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AllotedStudenrGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AllotedStudenrGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllotedStudenrGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AllotedStudenrGridView.ThemeStyle.RowsStyle.Height = 22;
            this.AllotedStudenrGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllotedStudenrGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // AllotHostelLabel
            // 
            this.AllotHostelLabel.BackColor = System.Drawing.Color.Transparent;
            this.AllotHostelLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllotHostelLabel.Location = new System.Drawing.Point(421, 84);
            this.AllotHostelLabel.Name = "AllotHostelLabel";
            this.AllotHostelLabel.Size = new System.Drawing.Size(96, 22);
            this.AllotHostelLabel.TabIndex = 41;
            this.AllotHostelLabel.Text = "Select Hostel";
            // 
            // AllotStudentLabel
            // 
            this.AllotStudentLabel.BackColor = System.Drawing.Color.Transparent;
            this.AllotStudentLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllotStudentLabel.Location = new System.Drawing.Point(12, 84);
            this.AllotStudentLabel.Name = "AllotStudentLabel";
            this.AllotStudentLabel.Size = new System.Drawing.Size(107, 22);
            this.AllotStudentLabel.TabIndex = 40;
            this.AllotStudentLabel.Text = "Select Student";
            // 
            // AllotHostelCombo
            // 
            this.AllotHostelCombo.BackColor = System.Drawing.Color.Transparent;
            this.AllotHostelCombo.BorderRadius = 22;
            this.AllotHostelCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AllotHostelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AllotHostelCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllotHostelCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllotHostelCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AllotHostelCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AllotHostelCombo.ItemHeight = 30;
            this.AllotHostelCombo.Items.AddRange(new object[] {
            "Boys",
            "Girls"});
            this.AllotHostelCombo.Location = new System.Drawing.Point(551, 75);
            this.AllotHostelCombo.Name = "AllotHostelCombo";
            this.AllotHostelCombo.Size = new System.Drawing.Size(140, 36);
            this.AllotHostelCombo.TabIndex = 39;
            this.AllotHostelCombo.SelectedIndexChanged += new System.EventHandler(this.AllotHostelCombo_SelectedIndexChanged);
            // 
            // Allotementlabel
            // 
            this.Allotementlabel.AutoSize = true;
            this.Allotementlabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allotementlabel.Location = new System.Drawing.Point(20, 20);
            this.Allotementlabel.Name = "Allotementlabel";
            this.Allotementlabel.Size = new System.Drawing.Size(281, 26);
            this.Allotementlabel.TabIndex = 36;
            this.Allotementlabel.Text = "ALLot Student Hostel";
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
            this.AllotStudentCombo.Location = new System.Drawing.Point(194, 84);
            this.AllotStudentCombo.Name = "AllotStudentCombo";
            this.AllotStudentCombo.Size = new System.Drawing.Size(140, 36);
            this.AllotStudentCombo.TabIndex = 49;
            this.AllotStudentCombo.SelectedIndexChanged += new System.EventHandler(this.AllotStudentCombo_SelectedIndexChanged);
            // 
            // AllotRoomLabel
            // 
            this.AllotRoomLabel.BackColor = System.Drawing.Color.Transparent;
            this.AllotRoomLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllotRoomLabel.Location = new System.Drawing.Point(12, 152);
            this.AllotRoomLabel.Name = "AllotRoomLabel";
            this.AllotRoomLabel.Size = new System.Drawing.Size(90, 22);
            this.AllotRoomLabel.TabIndex = 50;
            this.AllotRoomLabel.Text = "SelectRoom";
            // 
            // AllotedStudentLabel
            // 
            this.AllotedStudentLabel.BackColor = System.Drawing.Color.Transparent;
            this.AllotedStudentLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllotedStudentLabel.Location = new System.Drawing.Point(345, 209);
            this.AllotedStudentLabel.Name = "AllotedStudentLabel";
            this.AllotedStudentLabel.Size = new System.Drawing.Size(120, 22);
            this.AllotedStudentLabel.TabIndex = 51;
            this.AllotedStudentLabel.Text = "Alloted Students";
            // 
            // AllotmentofRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.AllotedStudentLabel);
            this.Controls.Add(this.AllotRoomLabel);
            this.Controls.Add(this.AllotStudentCombo);
            this.Controls.Add(BackToMenu);
            this.Controls.Add(this.AllotRoomNoCombo);
            this.Controls.Add(this.AllotBtn);
            this.Controls.Add(this.AllotedStudenrGridView);
            this.Controls.Add(this.AllotHostelLabel);
            this.Controls.Add(this.AllotStudentLabel);
            this.Controls.Add(this.AllotHostelCombo);
            this.Controls.Add(this.Allotementlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllotmentofRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllotmentofRoom";
            this.Load += new System.EventHandler(this.AllotmentofRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllotedStudenrGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox AllotRoomNoCombo;
        private Guna.UI2.WinForms.Guna2Button AllotBtn;
        private Guna.UI2.WinForms.Guna2DataGridView AllotedStudenrGridView;
        private Guna.UI2.WinForms.Guna2HtmlLabel AllotHostelLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel AllotStudentLabel;
        private Guna.UI2.WinForms.Guna2ComboBox AllotHostelCombo;
        private System.Windows.Forms.Label Allotementlabel;
        private Guna.UI2.WinForms.Guna2ComboBox AllotStudentCombo;
        private Guna.UI2.WinForms.Guna2HtmlLabel AllotRoomLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel AllotedStudentLabel;
    }
}