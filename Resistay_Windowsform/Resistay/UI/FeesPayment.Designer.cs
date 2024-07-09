namespace Resistay.UI
{
    partial class FeesPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TranscationHistoryLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ChallansCombos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GenerteChallanBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FeesTranscationHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PaymentLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FeesPaymentLabel = new System.Windows.Forms.Label();
            this.ChallanLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PayFeesLabel = new System.Windows.Forms.Label();
            this.FeesPaid = new Guna.UI2.WinForms.Guna2TextBox();
            this.FeesDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PaidFeesDate = new System.Windows.Forms.DateTimePicker();
            this.PayFeesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ChallanCombo2 = new Guna.UI2.WinForms.Guna2ComboBox();
            BackToMenu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.FeesTranscationHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // TranscationHistoryLabel
            // 
            this.TranscationHistoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.TranscationHistoryLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TranscationHistoryLabel.Location = new System.Drawing.Point(352, 294);
            this.TranscationHistoryLabel.Name = "TranscationHistoryLabel";
            this.TranscationHistoryLabel.Size = new System.Drawing.Size(140, 22);
            this.TranscationHistoryLabel.TabIndex = 62;
            this.TranscationHistoryLabel.Text = "All Remaining Dues\r\n";
            // 
            // ChallansCombos
            // 
            this.ChallansCombos.BackColor = System.Drawing.Color.Transparent;
            this.ChallansCombos.BorderRadius = 22;
            this.ChallansCombos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ChallansCombos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChallansCombos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChallansCombos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChallansCombos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ChallansCombos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ChallansCombos.ItemHeight = 30;
            this.ChallansCombos.Items.AddRange(new object[] {
            "Boys",
            "Girls"});
            this.ChallansCombos.Location = new System.Drawing.Point(188, 179);
            this.ChallansCombos.Name = "ChallansCombos";
            this.ChallansCombos.Size = new System.Drawing.Size(140, 36);
            this.ChallansCombos.TabIndex = 60;
            this.ChallansCombos.SelectedIndexChanged += new System.EventHandler(this.ChallansCombos_SelectedIndexChanged);
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
            BackToMenu.TabIndex = 59;
            BackToMenu.Text = "Back To Menu";
            BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // GenerteChallanBtn
            // 
            this.GenerteChallanBtn.BorderRadius = 26;
            this.GenerteChallanBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GenerteChallanBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GenerteChallanBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GenerteChallanBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GenerteChallanBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GenerteChallanBtn.ForeColor = System.Drawing.Color.White;
            this.GenerteChallanBtn.Location = new System.Drawing.Point(445, 71);
            this.GenerteChallanBtn.Name = "GenerteChallanBtn";
            this.GenerteChallanBtn.Size = new System.Drawing.Size(120, 45);
            this.GenerteChallanBtn.TabIndex = 57;
            this.GenerteChallanBtn.Text = "Generate Challan";
            this.GenerteChallanBtn.Click += new System.EventHandler(this.GenerteChallanBtn_Click);
            // 
            // FeesTranscationHistory
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.FeesTranscationHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FeesTranscationHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.FeesTranscationHistory.ColumnHeadersHeight = 4;
            this.FeesTranscationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FeesTranscationHistory.DefaultCellStyle = dataGridViewCellStyle21;
            this.FeesTranscationHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FeesTranscationHistory.Location = new System.Drawing.Point(74, 332);
            this.FeesTranscationHistory.Name = "FeesTranscationHistory";
            this.FeesTranscationHistory.RowHeadersVisible = false;
            this.FeesTranscationHistory.Size = new System.Drawing.Size(670, 130);
            this.FeesTranscationHistory.TabIndex = 56;
            this.FeesTranscationHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.FeesTranscationHistory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.FeesTranscationHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.FeesTranscationHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.FeesTranscationHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.FeesTranscationHistory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.FeesTranscationHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FeesTranscationHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FeesTranscationHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FeesTranscationHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesTranscationHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FeesTranscationHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.FeesTranscationHistory.ThemeStyle.HeaderStyle.Height = 4;
            this.FeesTranscationHistory.ThemeStyle.ReadOnly = false;
            this.FeesTranscationHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FeesTranscationHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FeesTranscationHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesTranscationHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FeesTranscationHistory.ThemeStyle.RowsStyle.Height = 22;
            this.FeesTranscationHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FeesTranscationHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.BackColor = System.Drawing.Color.Transparent;
            this.PaymentLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentLabel.Location = new System.Drawing.Point(24, 240);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.Size = new System.Drawing.Size(228, 22);
            this.PaymentLabel.TabIndex = 55;
            this.PaymentLabel.Text = "Enterr Amount You want to Pay\r\n";
            // 
            // FeesPaymentLabel
            // 
            this.FeesPaymentLabel.AutoSize = true;
            this.FeesPaymentLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesPaymentLabel.Location = new System.Drawing.Point(20, 20);
            this.FeesPaymentLabel.Name = "FeesPaymentLabel";
            this.FeesPaymentLabel.Size = new System.Drawing.Size(273, 26);
            this.FeesPaymentLabel.TabIndex = 52;
            this.FeesPaymentLabel.Text = "Hostel Fees Payment";
            this.FeesPaymentLabel.Click += new System.EventHandler(this.FeesPaymentLabel_Click);
            // 
            // ChallanLabel
            // 
            this.ChallanLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChallanLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChallanLabel.Location = new System.Drawing.Point(24, 179);
            this.ChallanLabel.Name = "ChallanLabel";
            this.ChallanLabel.Size = new System.Drawing.Size(108, 22);
            this.ChallanLabel.TabIndex = 64;
            this.ChallanLabel.Text = "Select Challan\r\n";
            this.ChallanLabel.Click += new System.EventHandler(this.ChallanLabel_Click);
            // 
            // PayFeesLabel
            // 
            this.PayFeesLabel.AutoSize = true;
            this.PayFeesLabel.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayFeesLabel.Location = new System.Drawing.Point(20, 146);
            this.PayFeesLabel.Name = "PayFeesLabel";
            this.PayFeesLabel.Size = new System.Drawing.Size(97, 21);
            this.PayFeesLabel.TabIndex = 65;
            this.PayFeesLabel.Text = "Pay Fees";
            // 
            // FeesPaid
            // 
            this.FeesPaid.AutoRoundedCorners = true;
            this.FeesPaid.BorderRadius = 17;
            this.FeesPaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FeesPaid.DefaultText = "";
            this.FeesPaid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FeesPaid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FeesPaid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FeesPaid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FeesPaid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FeesPaid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FeesPaid.ForeColor = System.Drawing.Color.Black;
            this.FeesPaid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FeesPaid.Location = new System.Drawing.Point(287, 240);
            this.FeesPaid.Name = "FeesPaid";
            this.FeesPaid.PasswordChar = '\0';
            this.FeesPaid.PlaceholderText = "";
            this.FeesPaid.SelectedText = "";
            this.FeesPaid.Size = new System.Drawing.Size(136, 36);
            this.FeesPaid.TabIndex = 66;
            // 
            // FeesDateLabel
            // 
            this.FeesDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.FeesDateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesDateLabel.Location = new System.Drawing.Point(391, 179);
            this.FeesDateLabel.Name = "FeesDateLabel";
            this.FeesDateLabel.Size = new System.Drawing.Size(88, 22);
            this.FeesDateLabel.TabIndex = 67;
            this.FeesDateLabel.Text = "Select Date\r\n\r\n";
            // 
            // PaidFeesDate
            // 
            this.PaidFeesDate.Location = new System.Drawing.Point(525, 179);
            this.PaidFeesDate.Name = "PaidFeesDate";
            this.PaidFeesDate.Size = new System.Drawing.Size(200, 20);
            this.PaidFeesDate.TabIndex = 68;
            // 
            // PayFeesBtn
            // 
            this.PayFeesBtn.BorderRadius = 26;
            this.PayFeesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PayFeesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PayFeesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PayFeesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PayFeesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PayFeesBtn.ForeColor = System.Drawing.Color.White;
            this.PayFeesBtn.Location = new System.Drawing.Point(743, 217);
            this.PayFeesBtn.Name = "PayFeesBtn";
            this.PayFeesBtn.Size = new System.Drawing.Size(120, 45);
            this.PayFeesBtn.TabIndex = 69;
            this.PayFeesBtn.Text = "Pay";
            this.PayFeesBtn.Click += new System.EventHandler(this.PayFeesBtn_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(42, 80);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 22);
            this.guna2HtmlLabel1.TabIndex = 70;
            this.guna2HtmlLabel1.Text = "Select Challan\r\n";
            // 
            // ChallanCombo2
            // 
            this.ChallanCombo2.BackColor = System.Drawing.Color.Transparent;
            this.ChallanCombo2.BorderRadius = 22;
            this.ChallanCombo2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ChallanCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChallanCombo2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChallanCombo2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChallanCombo2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ChallanCombo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ChallanCombo2.ItemHeight = 30;
            this.ChallanCombo2.Items.AddRange(new object[] {
            "Boys",
            "Girls"});
            this.ChallanCombo2.Location = new System.Drawing.Point(205, 80);
            this.ChallanCombo2.Name = "ChallanCombo2";
            this.ChallanCombo2.Size = new System.Drawing.Size(140, 36);
            this.ChallanCombo2.TabIndex = 71;
            // 
            // FeesPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.ChallanCombo2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.PayFeesBtn);
            this.Controls.Add(this.PaidFeesDate);
            this.Controls.Add(this.FeesDateLabel);
            this.Controls.Add(this.FeesPaid);
            this.Controls.Add(this.PayFeesLabel);
            this.Controls.Add(this.ChallanLabel);
            this.Controls.Add(this.TranscationHistoryLabel);
            this.Controls.Add(this.ChallansCombos);
            this.Controls.Add(BackToMenu);
            this.Controls.Add(this.GenerteChallanBtn);
            this.Controls.Add(this.FeesTranscationHistory);
            this.Controls.Add(this.PaymentLabel);
            this.Controls.Add(this.FeesPaymentLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FeesPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeesPayment";
            this.Load += new System.EventHandler(this.FeesPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeesTranscationHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel TranscationHistoryLabel;
        private Guna.UI2.WinForms.Guna2ComboBox ChallansCombos;
        private Guna.UI2.WinForms.Guna2Button GenerteChallanBtn;
        private Guna.UI2.WinForms.Guna2DataGridView FeesTranscationHistory;
        private Guna.UI2.WinForms.Guna2HtmlLabel PaymentLabel;
        private System.Windows.Forms.Label FeesPaymentLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel ChallanLabel;
        private System.Windows.Forms.Label PayFeesLabel;
        private Guna.UI2.WinForms.Guna2TextBox FeesPaid;
        private Guna.UI2.WinForms.Guna2HtmlLabel FeesDateLabel;
        private System.Windows.Forms.DateTimePicker PaidFeesDate;
        private Guna.UI2.WinForms.Guna2Button PayFeesBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox ChallanCombo2;
    }
}