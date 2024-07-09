namespace Resistay.UI
{
    partial class Annoucementform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AnnoucementIdCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RemoveAnnoucementBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AnnoucementGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Anoucement = new Guna.UI2.WinForms.Guna2TextBox();
            this.Annoucementlabel3 = new System.Windows.Forms.Label();
            this.AddAnnoucement = new System.Windows.Forms.Label();
            this.AnnoucementLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AnnoucementBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.AnnoucementLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AnnoucementDate = new System.Windows.Forms.DateTimePicker();
            this.AnnoucementDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            BackToMenu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.AnnoucementGridView1)).BeginInit();
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
            BackToMenu.Location = new System.Drawing.Point(745, 470);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new System.Drawing.Size(110, 23);
            BackToMenu.TabIndex = 48;
            BackToMenu.Text = "Back To Menu";
            BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // AnnoucementIdCombo
            // 
            this.AnnoucementIdCombo.BackColor = System.Drawing.Color.Transparent;
            this.AnnoucementIdCombo.BorderRadius = 22;
            this.AnnoucementIdCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AnnoucementIdCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnnoucementIdCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AnnoucementIdCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AnnoucementIdCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AnnoucementIdCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AnnoucementIdCombo.ItemHeight = 30;
            this.AnnoucementIdCombo.Items.AddRange(new object[] {
            "Boys",
            "Girls"});
            this.AnnoucementIdCombo.Location = new System.Drawing.Point(198, 240);
            this.AnnoucementIdCombo.Name = "AnnoucementIdCombo";
            this.AnnoucementIdCombo.Size = new System.Drawing.Size(140, 36);
            this.AnnoucementIdCombo.TabIndex = 47;
            this.AnnoucementIdCombo.SelectedIndexChanged += new System.EventHandler(this.AnnoucementIdCombo_SelectedIndexChanged);
            // 
            // RemoveAnnoucementBtn
            // 
            this.RemoveAnnoucementBtn.BorderRadius = 26;
            this.RemoveAnnoucementBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RemoveAnnoucementBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RemoveAnnoucementBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveAnnoucementBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RemoveAnnoucementBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveAnnoucementBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveAnnoucementBtn.Location = new System.Drawing.Point(438, 240);
            this.RemoveAnnoucementBtn.Name = "RemoveAnnoucementBtn";
            this.RemoveAnnoucementBtn.Size = new System.Drawing.Size(80, 45);
            this.RemoveAnnoucementBtn.TabIndex = 46;
            this.RemoveAnnoucementBtn.Text = "Remove";
            this.RemoveAnnoucementBtn.Click += new System.EventHandler(this.RemoveAnnoucementBtn_Click);
            // 
            // AnnoucementGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.AnnoucementGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AnnoucementGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AnnoucementGridView1.ColumnHeadersHeight = 4;
            this.AnnoucementGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AnnoucementGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.AnnoucementGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AnnoucementGridView1.Location = new System.Drawing.Point(74, 343);
            this.AnnoucementGridView1.Name = "AnnoucementGridView1";
            this.AnnoucementGridView1.RowHeadersVisible = false;
            this.AnnoucementGridView1.Size = new System.Drawing.Size(655, 136);
            this.AnnoucementGridView1.TabIndex = 43;
            this.AnnoucementGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AnnoucementGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AnnoucementGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AnnoucementGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AnnoucementGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AnnoucementGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AnnoucementGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AnnoucementGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AnnoucementGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AnnoucementGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnoucementGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AnnoucementGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AnnoucementGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.AnnoucementGridView1.ThemeStyle.ReadOnly = false;
            this.AnnoucementGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AnnoucementGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AnnoucementGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnoucementGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AnnoucementGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.AnnoucementGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AnnoucementGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AnnoucementGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnnoucementGridView1_CellContentClick);
            // 
            // Anoucement
            // 
            this.Anoucement.AutoRoundedCorners = true;
            this.Anoucement.BorderRadius = 41;
            this.Anoucement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Anoucement.DefaultText = "";
            this.Anoucement.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Anoucement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Anoucement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Anoucement.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Anoucement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Anoucement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Anoucement.ForeColor = System.Drawing.Color.Black;
            this.Anoucement.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Anoucement.Location = new System.Drawing.Point(12, 92);
            this.Anoucement.Name = "Anoucement";
            this.Anoucement.PasswordChar = '\0';
            this.Anoucement.PlaceholderText = "";
            this.Anoucement.SelectedText = "";
            this.Anoucement.Size = new System.Drawing.Size(454, 84);
            this.Anoucement.TabIndex = 38;
            this.Anoucement.TextChanged += new System.EventHandler(this.Anoucement_TextChanged);
            // 
            // Annoucementlabel3
            // 
            this.Annoucementlabel3.AutoSize = true;
            this.Annoucementlabel3.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annoucementlabel3.Location = new System.Drawing.Point(21, 188);
            this.Annoucementlabel3.Name = "Annoucementlabel3";
            this.Annoucementlabel3.Size = new System.Drawing.Size(270, 26);
            this.Annoucementlabel3.TabIndex = 37;
            this.Annoucementlabel3.Text = "Delete Annoucement";
            // 
            // AddAnnoucement
            // 
            this.AddAnnoucement.AutoSize = true;
            this.AddAnnoucement.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAnnoucement.Location = new System.Drawing.Point(12, 20);
            this.AddAnnoucement.Name = "AddAnnoucement";
            this.AddAnnoucement.Size = new System.Drawing.Size(250, 26);
            this.AddAnnoucement.TabIndex = 36;
            this.AddAnnoucement.Text = "Annouce Something";
            // 
            // AnnoucementLabel
            // 
            this.AnnoucementLabel.BackColor = System.Drawing.Color.Transparent;
            this.AnnoucementLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnoucementLabel.Location = new System.Drawing.Point(26, 64);
            this.AnnoucementLabel.Name = "AnnoucementLabel";
            this.AnnoucementLabel.Size = new System.Drawing.Size(148, 22);
            this.AnnoucementLabel.TabIndex = 49;
            this.AnnoucementLabel.Text = "Give Annoucement";
            // 
            // AnnoucementBtn
            // 
            this.AnnoucementBtn.BorderRadius = 26;
            this.AnnoucementBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AnnoucementBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AnnoucementBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AnnoucementBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AnnoucementBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AnnoucementBtn.ForeColor = System.Drawing.Color.White;
            this.AnnoucementBtn.Location = new System.Drawing.Point(745, 106);
            this.AnnoucementBtn.Name = "AnnoucementBtn";
            this.AnnoucementBtn.Size = new System.Drawing.Size(80, 45);
            this.AnnoucementBtn.TabIndex = 51;
            this.AnnoucementBtn.Text = "Add";
            this.AnnoucementBtn.Click += new System.EventHandler(this.AnnoucementBtn_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // AnnoucementLabel2
            // 
            this.AnnoucementLabel2.BackColor = System.Drawing.Color.Transparent;
            this.AnnoucementLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnoucementLabel2.Location = new System.Drawing.Point(26, 240);
            this.AnnoucementLabel2.Name = "AnnoucementLabel2";
            this.AnnoucementLabel2.Size = new System.Drawing.Size(167, 22);
            this.AnnoucementLabel2.TabIndex = 52;
            this.AnnoucementLabel2.Text = "Give Annoucement Id\r\n";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(337, 304);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(129, 22);
            this.guna2HtmlLabel3.TabIndex = 53;
            this.guna2HtmlLabel3.Text = "All Annoucement";
            // 
            // AnnoucementDate
            // 
            this.AnnoucementDate.Location = new System.Drawing.Point(512, 131);
            this.AnnoucementDate.Name = "AnnoucementDate";
            this.AnnoucementDate.Size = new System.Drawing.Size(200, 20);
            this.AnnoucementDate.TabIndex = 54;
            // 
            // AnnoucementDateLabel
            // 
            this.AnnoucementDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.AnnoucementDateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnoucementDateLabel.Location = new System.Drawing.Point(512, 103);
            this.AnnoucementDateLabel.Name = "AnnoucementDateLabel";
            this.AnnoucementDateLabel.Size = new System.Drawing.Size(39, 22);
            this.AnnoucementDateLabel.TabIndex = 55;
            this.AnnoucementDateLabel.Text = "Date";
            // 
            // Annoucementform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 512);
            this.Controls.Add(this.AnnoucementDateLabel);
            this.Controls.Add(this.AnnoucementDate);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.AnnoucementLabel2);
            this.Controls.Add(this.AnnoucementBtn);
            this.Controls.Add(this.AnnoucementLabel);
            this.Controls.Add(BackToMenu);
            this.Controls.Add(this.AnnoucementIdCombo);
            this.Controls.Add(this.RemoveAnnoucementBtn);
            this.Controls.Add(this.AnnoucementGridView1);
            this.Controls.Add(this.Anoucement);
            this.Controls.Add(this.Annoucementlabel3);
            this.Controls.Add(this.AddAnnoucement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Annoucementform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Annoucement";
            this.Load += new System.EventHandler(this.Annoucement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnnoucementGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox AnnoucementIdCombo;
        private Guna.UI2.WinForms.Guna2Button RemoveAnnoucementBtn;
        private Guna.UI2.WinForms.Guna2DataGridView AnnoucementGridView1;
        private Guna.UI2.WinForms.Guna2TextBox Anoucement;
        private System.Windows.Forms.Label Annoucementlabel3;
        private System.Windows.Forms.Label AddAnnoucement;
        private Guna.UI2.WinForms.Guna2HtmlLabel AnnoucementLabel;
        private Guna.UI2.WinForms.Guna2Button AnnoucementBtn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel AnnoucementLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel AnnoucementDateLabel;
        private System.Windows.Forms.DateTimePicker AnnoucementDate;
    }
}