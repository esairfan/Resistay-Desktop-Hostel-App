namespace Resistay.UI
{
    partial class Complainform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComplainBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Complain1label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RemoveComplainBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ComplainGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.complain = new Guna.UI2.WinForms.Guna2TextBox();
            this.complaindltlabel = new System.Windows.Forms.Label();
            this.Complainslabel1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.complainIdcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.complainDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ComplainDate = new System.Windows.Forms.DateTimePicker();
            this.ComplainLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Complainlabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            BackToMenu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComplainGrid)).BeginInit();
            this.SuspendLayout();
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
            this.ComplainBtn.Location = new System.Drawing.Point(716, 115);
            this.ComplainBtn.Name = "ComplainBtn";
            this.ComplainBtn.Size = new System.Drawing.Size(80, 45);
            this.ComplainBtn.TabIndex = 75;
            this.ComplainBtn.Text = "Add";
            this.ComplainBtn.Click += new System.EventHandler(this.ComplainBtn_Click);
            // 
            // Complain1label
            // 
            this.Complain1label.BackColor = System.Drawing.Color.Transparent;
            this.Complain1label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complain1label.Location = new System.Drawing.Point(22, 64);
            this.Complain1label.Name = "Complain1label";
            this.Complain1label.Size = new System.Drawing.Size(99, 22);
            this.Complain1label.TabIndex = 74;
            this.Complain1label.Text = "Set Complain";
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
            BackToMenu.TabIndex = 73;
            BackToMenu.Text = "Back To Menu";
            BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
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
            this.RemoveComplainBtn.TabIndex = 72;
            this.RemoveComplainBtn.Text = "Remove";
            this.RemoveComplainBtn.Click += new System.EventHandler(this.RemoveComplainBtn_Click);
            // 
            // ComplainGrid
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.ComplainGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ComplainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ComplainGrid.ColumnHeadersHeight = 4;
            this.ComplainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ComplainGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.ComplainGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ComplainGrid.Location = new System.Drawing.Point(70, 343);
            this.ComplainGrid.Name = "ComplainGrid";
            this.ComplainGrid.RowHeadersVisible = false;
            this.ComplainGrid.Size = new System.Drawing.Size(655, 136);
            this.ComplainGrid.TabIndex = 71;
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
            // 
            // complain
            // 
            this.complain.AutoRoundedCorners = true;
            this.complain.BorderRadius = 41;
            this.complain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.complain.DefaultText = "";
            this.complain.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.complain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.complain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.complain.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.complain.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.complain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.complain.ForeColor = System.Drawing.Color.Black;
            this.complain.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.complain.Location = new System.Drawing.Point(8, 92);
            this.complain.Name = "complain";
            this.complain.PasswordChar = '\0';
            this.complain.PlaceholderText = "";
            this.complain.SelectedText = "";
            this.complain.Size = new System.Drawing.Size(454, 84);
            this.complain.TabIndex = 70;
            // 
            // complaindltlabel
            // 
            this.complaindltlabel.AutoSize = true;
            this.complaindltlabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaindltlabel.Location = new System.Drawing.Point(17, 188);
            this.complaindltlabel.Name = "complaindltlabel";
            this.complaindltlabel.Size = new System.Drawing.Size(217, 26);
            this.complaindltlabel.TabIndex = 69;
            this.complaindltlabel.Text = "Delete Complain";
            // 
            // Complainslabel1
            // 
            this.Complainslabel1.AutoSize = true;
            this.Complainslabel1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complainslabel1.Location = new System.Drawing.Point(8, 20);
            this.Complainslabel1.Name = "Complainslabel1";
            this.Complainslabel1.Size = new System.Drawing.Size(138, 26);
            this.Complainslabel1.TabIndex = 68;
            this.Complainslabel1.Text = "Complains";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // complainIdcombo
            // 
            this.complainIdcombo.BackColor = System.Drawing.Color.Transparent;
            this.complainIdcombo.BorderRadius = 22;
            this.complainIdcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.complainIdcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.complainIdcombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.complainIdcombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.complainIdcombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.complainIdcombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.complainIdcombo.ItemHeight = 30;
            this.complainIdcombo.Items.AddRange(new object[] {
            "Boys",
            "Girls"});
            this.complainIdcombo.Location = new System.Drawing.Point(184, 226);
            this.complainIdcombo.Name = "complainIdcombo";
            this.complainIdcombo.Size = new System.Drawing.Size(140, 36);
            this.complainIdcombo.TabIndex = 80;
            // 
            // complainDateLabel
            // 
            this.complainDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.complainDateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainDateLabel.Location = new System.Drawing.Point(494, 101);
            this.complainDateLabel.Name = "complainDateLabel";
            this.complainDateLabel.Size = new System.Drawing.Size(39, 22);
            this.complainDateLabel.TabIndex = 79;
            this.complainDateLabel.Text = "Date";
            // 
            // ComplainDate
            // 
            this.ComplainDate.Location = new System.Drawing.Point(494, 129);
            this.ComplainDate.Name = "ComplainDate";
            this.ComplainDate.Size = new System.Drawing.Size(200, 20);
            this.ComplainDate.TabIndex = 78;
            // 
            // ComplainLabel3
            // 
            this.ComplainLabel3.BackColor = System.Drawing.Color.Transparent;
            this.ComplainLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplainLabel3.Location = new System.Drawing.Point(333, 304);
            this.ComplainLabel3.Name = "ComplainLabel3";
            this.ComplainLabel3.Size = new System.Drawing.Size(100, 22);
            this.ComplainLabel3.TabIndex = 77;
            this.ComplainLabel3.Text = "All Complains ";
            // 
            // Complainlabel2
            // 
            this.Complainlabel2.BackColor = System.Drawing.Color.Transparent;
            this.Complainlabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complainlabel2.Location = new System.Drawing.Point(22, 240);
            this.Complainlabel2.Name = "Complainlabel2";
            this.Complainlabel2.Size = new System.Drawing.Size(93, 22);
            this.Complainlabel2.TabIndex = 76;
            this.Complainlabel2.Text = "Give Rule Id";
            // 
            // Complainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 512);
            this.Controls.Add(this.ComplainBtn);
            this.Controls.Add(this.Complain1label);
            this.Controls.Add(BackToMenu);
            this.Controls.Add(this.RemoveComplainBtn);
            this.Controls.Add(this.ComplainGrid);
            this.Controls.Add(this.complain);
            this.Controls.Add(this.complaindltlabel);
            this.Controls.Add(this.Complainslabel1);
            this.Controls.Add(this.complainIdcombo);
            this.Controls.Add(this.complainDateLabel);
            this.Controls.Add(this.ComplainDate);
            this.Controls.Add(this.ComplainLabel3);
            this.Controls.Add(this.Complainlabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Complainform";
            this.Text = "Complainform";
            this.Load += new System.EventHandler(this.Complainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComplainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ComplainBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel Complain1label;
        private Guna.UI2.WinForms.Guna2Button RemoveComplainBtn;
        private Guna.UI2.WinForms.Guna2DataGridView ComplainGrid;
        private Guna.UI2.WinForms.Guna2TextBox complain;
        private System.Windows.Forms.Label complaindltlabel;
        private System.Windows.Forms.Label Complainslabel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ComboBox complainIdcombo;
        private Guna.UI2.WinForms.Guna2HtmlLabel complainDateLabel;
        private System.Windows.Forms.DateTimePicker ComplainDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel ComplainLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel Complainlabel2;
    }
}