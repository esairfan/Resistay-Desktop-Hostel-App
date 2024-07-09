namespace Resistay.UI
{
    partial class SalaryReieve
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
            this.CheckCombo2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CheckLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GenerteCheckBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RecieveDatelabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RecieveDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.RecievableChecks = new Guna.UI2.WinForms.Guna2DataGridView();
            this.RecievableCheckLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ChecksLabel = new System.Windows.Forms.Label();
            BackToMenu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.RecievableChecks)).BeginInit();
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
            BackToMenu.Location = new System.Drawing.Point(692, 420);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new System.Drawing.Size(110, 23);
            BackToMenu.TabIndex = 80;
            BackToMenu.Text = "Back To Menu";
            BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // CheckCombo2
            // 
            this.CheckCombo2.BackColor = System.Drawing.Color.Transparent;
            this.CheckCombo2.BorderRadius = 22;
            this.CheckCombo2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CheckCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CheckCombo2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckCombo2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckCombo2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CheckCombo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CheckCombo2.ItemHeight = 30;
            this.CheckCombo2.Items.AddRange(new object[] {
            "Boys",
            "Girls"});
            this.CheckCombo2.Location = new System.Drawing.Point(257, 115);
            this.CheckCombo2.Name = "CheckCombo2";
            this.CheckCombo2.Size = new System.Drawing.Size(140, 36);
            this.CheckCombo2.TabIndex = 74;
            // 
            // CheckLabel
            // 
            this.CheckLabel.BackColor = System.Drawing.Color.Transparent;
            this.CheckLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckLabel.Location = new System.Drawing.Point(50, 115);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(101, 22);
            this.CheckLabel.TabIndex = 73;
            this.CheckLabel.Text = "Select Check\r\n";
            // 
            // GenerteCheckBtn
            // 
            this.GenerteCheckBtn.BorderRadius = 26;
            this.GenerteCheckBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GenerteCheckBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GenerteCheckBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GenerteCheckBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GenerteCheckBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GenerteCheckBtn.ForeColor = System.Drawing.Color.White;
            this.GenerteCheckBtn.Location = new System.Drawing.Point(629, 160);
            this.GenerteCheckBtn.Name = "GenerteCheckBtn";
            this.GenerteCheckBtn.Size = new System.Drawing.Size(120, 45);
            this.GenerteCheckBtn.TabIndex = 72;
            this.GenerteCheckBtn.Text = "Generate Check";
            this.GenerteCheckBtn.Click += new System.EventHandler(this.GenerteCheckBtn_Click);
            // 
            // RecieveDatelabel
            // 
            this.RecieveDatelabel.BackColor = System.Drawing.Color.Transparent;
            this.RecieveDatelabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecieveDatelabel.Location = new System.Drawing.Point(449, 115);
            this.RecieveDatelabel.Name = "RecieveDatelabel";
            this.RecieveDatelabel.Size = new System.Drawing.Size(146, 22);
            this.RecieveDatelabel.TabIndex = 75;
            this.RecieveDatelabel.Text = "Enter Recieve Date";
            // 
            // RecieveDate
            // 
            this.RecieveDate.Checked = true;
            this.RecieveDate.FillColor = System.Drawing.Color.White;
            this.RecieveDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RecieveDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.RecieveDate.Location = new System.Drawing.Point(611, 116);
            this.RecieveDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.RecieveDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.RecieveDate.Name = "RecieveDate";
            this.RecieveDate.Size = new System.Drawing.Size(191, 21);
            this.RecieveDate.TabIndex = 76;
            this.RecieveDate.Value = new System.DateTime(2024, 4, 27, 22, 52, 29, 359);
            // 
            // RecievableChecks
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.RecievableChecks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecievableChecks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RecievableChecks.ColumnHeadersHeight = 4;
            this.RecievableChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RecievableChecks.DefaultCellStyle = dataGridViewCellStyle3;
            this.RecievableChecks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RecievableChecks.Location = new System.Drawing.Point(91, 259);
            this.RecievableChecks.Name = "RecievableChecks";
            this.RecievableChecks.RowHeadersVisible = false;
            this.RecievableChecks.Size = new System.Drawing.Size(658, 146);
            this.RecievableChecks.TabIndex = 77;
            this.RecievableChecks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RecievableChecks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RecievableChecks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RecievableChecks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RecievableChecks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RecievableChecks.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RecievableChecks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RecievableChecks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RecievableChecks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RecievableChecks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecievableChecks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RecievableChecks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RecievableChecks.ThemeStyle.HeaderStyle.Height = 4;
            this.RecievableChecks.ThemeStyle.ReadOnly = false;
            this.RecievableChecks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RecievableChecks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RecievableChecks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecievableChecks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RecievableChecks.ThemeStyle.RowsStyle.Height = 22;
            this.RecievableChecks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RecievableChecks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // RecievableCheckLabel
            // 
            this.RecievableCheckLabel.BackColor = System.Drawing.Color.Transparent;
            this.RecievableCheckLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecievableCheckLabel.Location = new System.Drawing.Point(345, 221);
            this.RecievableCheckLabel.Name = "RecievableCheckLabel";
            this.RecievableCheckLabel.Size = new System.Drawing.Size(171, 22);
            this.RecievableCheckLabel.TabIndex = 78;
            this.RecievableCheckLabel.Text = " All Recievalble Checks";
            // 
            // ChecksLabel
            // 
            this.ChecksLabel.AutoSize = true;
            this.ChecksLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChecksLabel.Location = new System.Drawing.Point(30, 39);
            this.ChecksLabel.Name = "ChecksLabel";
            this.ChecksLabel.Size = new System.Drawing.Size(193, 26);
            this.ChecksLabel.TabIndex = 79;
            this.ChecksLabel.Text = "Checks System";
            // 
            // SalaryReieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 465);
            this.ControlBox = false;
            this.Controls.Add(BackToMenu);
            this.Controls.Add(this.ChecksLabel);
            this.Controls.Add(this.RecievableCheckLabel);
            this.Controls.Add(this.RecievableChecks);
            this.Controls.Add(this.RecieveDate);
            this.Controls.Add(this.RecieveDatelabel);
            this.Controls.Add(this.CheckCombo2);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.GenerteCheckBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalaryReieve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalaryReieve";
            this.Load += new System.EventHandler(this.SalaryReieve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecievableChecks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox CheckCombo2;
        private Guna.UI2.WinForms.Guna2HtmlLabel CheckLabel;
        private Guna.UI2.WinForms.Guna2Button GenerteCheckBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel RecieveDatelabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker RecieveDate;
        private Guna.UI2.WinForms.Guna2DataGridView RecievableChecks;
        private Guna.UI2.WinForms.Guna2HtmlLabel RecievableCheckLabel;
        private System.Windows.Forms.Label ChecksLabel;
    }
}