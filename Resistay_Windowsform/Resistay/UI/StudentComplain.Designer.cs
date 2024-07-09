namespace Resistay.UI
{
    partial class StudentComplain
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Guna2Button BackToMenu;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComplainBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Complainlabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ComplainIdCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RemoveComplainBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ComplainGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ComplainDetails = new Guna.UI2.WinForms.Guna2TextBox();
            this.Complainlabel3 = new System.Windows.Forms.Label();
            this.Complainlabel1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ComplainDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ComplainDate = new System.Windows.Forms.DateTimePicker();
            this.Complainlabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Complainlabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            BackToMenu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComplainGrid)).BeginInit();
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
            BackToMenu.Location = new System.Drawing.Point(741, 470);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new System.Drawing.Size(110, 23);
            BackToMenu.TabIndex = 62;
            BackToMenu.Text = "Back To Menu";
            BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // ComplainBtn
            // 
            this.ComplainBtn.BorderRadius = 26;
            this.ComplainBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ComplainBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ComplainBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ComplainBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ComplainBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComplainBtn.ForeColor = System.Drawing.Color.White;
            this.ComplainBtn.Location = new System.Drawing.Point(741, 106);
            this.ComplainBtn.Name = "ComplainBtn";
            this.ComplainBtn.Size = new System.Drawing.Size(80, 45);
            this.ComplainBtn.TabIndex = 64;
            this.ComplainBtn.Text = "Add";
            this.ComplainBtn.Click += new System.EventHandler(this.ComplainBtn_Click);
            // 
            // Complainlabel2
            // 
            this.Complainlabel2.BackColor = System.Drawing.Color.Transparent;
            this.Complainlabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complainlabel2.Location = new System.Drawing.Point(22, 64);
            this.Complainlabel2.Name = "Complainlabel2";
            this.Complainlabel2.Size = new System.Drawing.Size(99, 22);
            this.Complainlabel2.TabIndex = 63;
            this.Complainlabel2.Text = "Set Complain";
            // 
            // ComplainIdCombo
            // 
            this.ComplainIdCombo.BackColor = System.Drawing.Color.Transparent;
            this.ComplainIdCombo.BorderRadius = 22;
            this.ComplainIdCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComplainIdCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComplainIdCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComplainIdCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComplainIdCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComplainIdCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComplainIdCombo.ItemHeight = 30;
            this.ComplainIdCombo.Items.AddRange(new object[] {
            "Boys",
            "Girls"});
            this.ComplainIdCombo.Location = new System.Drawing.Point(194, 240);
            this.ComplainIdCombo.Name = "ComplainIdCombo";
            this.ComplainIdCombo.Size = new System.Drawing.Size(140, 36);
            this.ComplainIdCombo.TabIndex = 61;
            // 
            // RemoveComplainBtn
            // 
            this.RemoveComplainBtn.BorderRadius = 26;
            this.RemoveComplainBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RemoveComplainBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RemoveComplainBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveComplainBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RemoveComplainBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveComplainBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveComplainBtn.Location = new System.Drawing.Point(434, 240);
            this.RemoveComplainBtn.Name = "RemoveComplainBtn";
            this.RemoveComplainBtn.Size = new System.Drawing.Size(80, 45);
            this.RemoveComplainBtn.TabIndex = 60;
            this.RemoveComplainBtn.Text = "Remove";
            this.RemoveComplainBtn.Click += new System.EventHandler(this.RemoveComplainBtn_Click);
            // 
            // ComplainGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ComplainGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ComplainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ComplainGrid.ColumnHeadersHeight = 4;
            this.ComplainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ComplainGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ComplainGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ComplainGrid.Location = new System.Drawing.Point(70, 343);
            this.ComplainGrid.Name = "ComplainGrid";
            this.ComplainGrid.RowHeadersVisible = false;
            this.ComplainGrid.Size = new System.Drawing.Size(655, 136);
            this.ComplainGrid.TabIndex = 59;
            this.ComplainGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ComplainGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ComplainGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ComplainGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ComplainGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ComplainGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ComplainGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ComplainGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComplainGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ComplainGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplainGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ComplainGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ComplainGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.ComplainGrid.ThemeStyle.ReadOnly = false;
            this.ComplainGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ComplainGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ComplainGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplainGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ComplainGrid.ThemeStyle.RowsStyle.Height = 22;
            this.ComplainGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ComplainGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ComplainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComplainGrid_CellContentClick);
            // 
            // ComplainDetails
            // 
            this.ComplainDetails.AutoRoundedCorners = true;
            this.ComplainDetails.BorderRadius = 41;
            this.ComplainDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ComplainDetails.DefaultText = "";
            this.ComplainDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ComplainDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ComplainDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ComplainDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ComplainDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComplainDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComplainDetails.ForeColor = System.Drawing.Color.Black;
            this.ComplainDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComplainDetails.Location = new System.Drawing.Point(8, 92);
            this.ComplainDetails.Name = "ComplainDetails";
            this.ComplainDetails.PasswordChar = '\0';
            this.ComplainDetails.PlaceholderText = "";
            this.ComplainDetails.SelectedText = "";
            this.ComplainDetails.Size = new System.Drawing.Size(454, 84);
            this.ComplainDetails.TabIndex = 58;
            // 
            // Complainlabel3
            // 
            this.Complainlabel3.AutoSize = true;
            this.Complainlabel3.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complainlabel3.Location = new System.Drawing.Point(17, 188);
            this.Complainlabel3.Name = "Complainlabel3";
            this.Complainlabel3.Size = new System.Drawing.Size(217, 26);
            this.Complainlabel3.TabIndex = 57;
            this.Complainlabel3.Text = "Delete Complain";
            // 
            // Complainlabel1
            // 
            this.Complainlabel1.AutoSize = true;
            this.Complainlabel1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complainlabel1.Location = new System.Drawing.Point(8, 20);
            this.Complainlabel1.Name = "Complainlabel1";
            this.Complainlabel1.Size = new System.Drawing.Size(138, 26);
            this.Complainlabel1.TabIndex = 56;
            this.Complainlabel1.Text = "Complains";
            this.Complainlabel1.Click += new System.EventHandler(this.Complainlabel1_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ComplainDateLabel
            // 
            this.ComplainDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.ComplainDateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplainDateLabel.Location = new System.Drawing.Point(508, 103);
            this.ComplainDateLabel.Name = "ComplainDateLabel";
            this.ComplainDateLabel.Size = new System.Drawing.Size(39, 22);
            this.ComplainDateLabel.TabIndex = 68;
            this.ComplainDateLabel.Text = "Date";
            // 
            // ComplainDate
            // 
            this.ComplainDate.Location = new System.Drawing.Point(508, 131);
            this.ComplainDate.Name = "ComplainDate";
            this.ComplainDate.Size = new System.Drawing.Size(200, 20);
            this.ComplainDate.TabIndex = 67;
            // 
            // Complainlabel5
            // 
            this.Complainlabel5.BackColor = System.Drawing.Color.Transparent;
            this.Complainlabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complainlabel5.Location = new System.Drawing.Point(333, 304);
            this.Complainlabel5.Name = "Complainlabel5";
            this.Complainlabel5.Size = new System.Drawing.Size(100, 22);
            this.Complainlabel5.TabIndex = 66;
            this.Complainlabel5.Text = "All Complains";
            // 
            // Complainlabel4
            // 
            this.Complainlabel4.BackColor = System.Drawing.Color.Transparent;
            this.Complainlabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complainlabel4.Location = new System.Drawing.Point(22, 240);
            this.Complainlabel4.Name = "Complainlabel4";
            this.Complainlabel4.Size = new System.Drawing.Size(132, 22);
            this.Complainlabel4.TabIndex = 65;
            this.Complainlabel4.Text = "Give Complain Id\r\n";
            // 
            // StudentComplain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 512);
            this.Controls.Add(this.ComplainBtn);
            this.Controls.Add(this.Complainlabel2);
            this.Controls.Add(BackToMenu);
            this.Controls.Add(this.ComplainIdCombo);
            this.Controls.Add(this.RemoveComplainBtn);
            this.Controls.Add(this.ComplainGrid);
            this.Controls.Add(this.ComplainDetails);
            this.Controls.Add(this.Complainlabel3);
            this.Controls.Add(this.Complainlabel1);
            this.Controls.Add(this.ComplainDateLabel);
            this.Controls.Add(this.ComplainDate);
            this.Controls.Add(this.Complainlabel5);
            this.Controls.Add(this.Complainlabel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentComplain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentComplain";
            this.Load += new System.EventHandler(this.StudentComplain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComplainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ComplainBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel Complainlabel2;
        private Guna.UI2.WinForms.Guna2ComboBox ComplainIdCombo;
        private Guna.UI2.WinForms.Guna2Button RemoveComplainBtn;
        private Guna.UI2.WinForms.Guna2DataGridView ComplainGrid;
        private Guna.UI2.WinForms.Guna2TextBox ComplainDetails;
        private System.Windows.Forms.Label Complainlabel3;
        private System.Windows.Forms.Label Complainlabel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel ComplainDateLabel;
        private System.Windows.Forms.DateTimePicker ComplainDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel Complainlabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel Complainlabel4;
    }
}