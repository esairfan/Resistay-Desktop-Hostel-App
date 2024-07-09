namespace Resistay.UI
{
    partial class Rooms
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
            this.dltroom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RoomGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.RoomAddbtn = new Guna.UI2.WinForms.Guna2Button();
            this.RemoveHostelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HostelsDataLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.roomnamelabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Hostellabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RoomNumberLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HostelName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.removebtn = new System.Windows.Forms.Label();
            this.AddHostel = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HostelByroom = new Guna.UI2.WinForms.Guna2ComboBox();
            BackToMenu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGrid)).BeginInit();
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
            BackToMenu.Location = new System.Drawing.Point(745, 438);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new System.Drawing.Size(110, 23);
            BackToMenu.TabIndex = 48;
            BackToMenu.Text = "Back To Menu";
            BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // dltroom
            // 
            this.dltroom.BackColor = System.Drawing.Color.Transparent;
            this.dltroom.BorderRadius = 22;
            this.dltroom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dltroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dltroom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dltroom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dltroom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dltroom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dltroom.ItemHeight = 30;
            this.dltroom.Items.AddRange(new object[] {
            " "});
            this.dltroom.Location = new System.Drawing.Point(218, 151);
            this.dltroom.Name = "dltroom";
            this.dltroom.Size = new System.Drawing.Size(140, 36);
            this.dltroom.TabIndex = 51;
            this.dltroom.SelectedIndexChanged += new System.EventHandler(this.dltroom_SelectedIndexChanged);
            // 
            // RoomGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.RoomGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RoomGrid.ColumnHeadersHeight = 4;
            this.RoomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.RoomGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomGrid.Location = new System.Drawing.Point(120, 287);
            this.RoomGrid.Name = "RoomGrid";
            this.RoomGrid.RowHeadersVisible = false;
            this.RoomGrid.Size = new System.Drawing.Size(655, 136);
            this.RoomGrid.TabIndex = 50;
            this.RoomGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RoomGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RoomGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RoomGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RoomGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RoomGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RoomGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RoomGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RoomGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RoomGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.RoomGrid.ThemeStyle.ReadOnly = false;
            this.RoomGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomGrid.ThemeStyle.RowsStyle.Height = 22;
            this.RoomGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomGrid_CellContentClick);
            // 
            // RoomAddbtn
            // 
            this.RoomAddbtn.BorderRadius = 26;
            this.RoomAddbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RoomAddbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RoomAddbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RoomAddbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RoomAddbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RoomAddbtn.ForeColor = System.Drawing.Color.White;
            this.RoomAddbtn.Location = new System.Drawing.Point(745, 64);
            this.RoomAddbtn.Name = "RoomAddbtn";
            this.RoomAddbtn.Size = new System.Drawing.Size(80, 45);
            this.RoomAddbtn.TabIndex = 49;
            this.RoomAddbtn.Text = "Add";
            this.RoomAddbtn.Click += new System.EventHandler(this.RoomAddbtn_Click);
            // 
            // RemoveHostelBtn
            // 
            this.RemoveHostelBtn.BorderRadius = 26;
            this.RemoveHostelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RemoveHostelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RemoveHostelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveHostelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RemoveHostelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveHostelBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveHostelBtn.Location = new System.Drawing.Point(745, 160);
            this.RemoveHostelBtn.Name = "RemoveHostelBtn";
            this.RemoveHostelBtn.Size = new System.Drawing.Size(80, 45);
            this.RemoveHostelBtn.TabIndex = 47;
            this.RemoveHostelBtn.Text = "Remove";
            this.RemoveHostelBtn.Click += new System.EventHandler(this.RemoveHostelBtn_Click);
            // 
            // HostelsDataLabel
            // 
            this.HostelsDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.HostelsDataLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostelsDataLabel.Location = new System.Drawing.Point(360, 238);
            this.HostelsDataLabel.Name = "HostelsDataLabel";
            this.HostelsDataLabel.Size = new System.Drawing.Size(146, 22);
            this.HostelsDataLabel.TabIndex = 46;
            this.HostelsDataLabel.Text = "All Available Rooms";
            this.HostelsDataLabel.Click += new System.EventHandler(this.HostelsDataLabel_Click);
            // 
            // roomnamelabel
            // 
            this.roomnamelabel.BackColor = System.Drawing.Color.Transparent;
            this.roomnamelabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomnamelabel.Location = new System.Drawing.Point(4, 160);
            this.roomnamelabel.Name = "roomnamelabel";
            this.roomnamelabel.Size = new System.Drawing.Size(94, 22);
            this.roomnamelabel.TabIndex = 45;
            this.roomnamelabel.Text = "Select Room";
            this.roomnamelabel.Click += new System.EventHandler(this.roomnamelabel_Click);
            // 
            // Hostellabel
            // 
            this.Hostellabel.BackColor = System.Drawing.Color.Transparent;
            this.Hostellabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hostellabel.Location = new System.Drawing.Point(413, 64);
            this.Hostellabel.Name = "Hostellabel";
            this.Hostellabel.Size = new System.Drawing.Size(96, 22);
            this.Hostellabel.TabIndex = 44;
            this.Hostellabel.Text = "Select Hostel ";
            this.Hostellabel.Click += new System.EventHandler(this.Hostellabel_Click);
            // 
            // RoomNumberLabel
            // 
            this.RoomNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.RoomNumberLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumberLabel.Location = new System.Drawing.Point(4, 64);
            this.RoomNumberLabel.Name = "RoomNumberLabel";
            this.RoomNumberLabel.Size = new System.Drawing.Size(148, 22);
            this.RoomNumberLabel.TabIndex = 43;
            this.RoomNumberLabel.Text = "Enter Room Number";
            this.RoomNumberLabel.Click += new System.EventHandler(this.RoomNumberLabel_Click);
            // 
            // HostelName
            // 
            this.HostelName.BackColor = System.Drawing.Color.Transparent;
            this.HostelName.BorderRadius = 22;
            this.HostelName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HostelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HostelName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HostelName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HostelName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HostelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.HostelName.ItemHeight = 30;
            this.HostelName.Items.AddRange(new object[] {
            " "});
            this.HostelName.Location = new System.Drawing.Point(568, 64);
            this.HostelName.Name = "HostelName";
            this.HostelName.Size = new System.Drawing.Size(140, 36);
            this.HostelName.TabIndex = 42;
            this.HostelName.SelectedIndexChanged += new System.EventHandler(this.HostelName_SelectedIndexChanged);
            // 
            // RoomNumber
            // 
            this.RoomNumber.AutoRoundedCorners = true;
            this.RoomNumber.BorderRadius = 17;
            this.RoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomNumber.DefaultText = "";
            this.RoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RoomNumber.ForeColor = System.Drawing.Color.Black;
            this.RoomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNumber.Location = new System.Drawing.Point(158, 64);
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.PasswordChar = '\0';
            this.RoomNumber.PlaceholderText = "";
            this.RoomNumber.SelectedText = "";
            this.RoomNumber.Size = new System.Drawing.Size(200, 36);
            this.RoomNumber.TabIndex = 41;
            this.RoomNumber.TextChanged += new System.EventHandler(this.RoomNumber_TextChanged);
            // 
            // removebtn
            // 
            this.removebtn.AutoSize = true;
            this.removebtn.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.Location = new System.Drawing.Point(12, 120);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(174, 26);
            this.removebtn.TabIndex = 40;
            this.removebtn.Text = "Remove Room";
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // AddHostel
            // 
            this.AddHostel.AutoSize = true;
            this.AddHostel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHostel.Location = new System.Drawing.Point(12, 0);
            this.AddHostel.Name = "AddHostel";
            this.AddHostel.Size = new System.Drawing.Size(127, 26);
            this.AddHostel.TabIndex = 39;
            this.AddHostel.Text = "Add Room";
            this.AddHostel.Click += new System.EventHandler(this.AddHostel_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(413, 165);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(96, 22);
            this.guna2HtmlLabel1.TabIndex = 52;
            this.guna2HtmlLabel1.Text = "Select Hostel ";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // HostelByroom
            // 
            this.HostelByroom.BackColor = System.Drawing.Color.Transparent;
            this.HostelByroom.BorderRadius = 22;
            this.HostelByroom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HostelByroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HostelByroom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HostelByroom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HostelByroom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HostelByroom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.HostelByroom.ItemHeight = 30;
            this.HostelByroom.Items.AddRange(new object[] {
            " "});
            this.HostelByroom.Location = new System.Drawing.Point(568, 151);
            this.HostelByroom.Name = "HostelByroom";
            this.HostelByroom.Size = new System.Drawing.Size(140, 36);
            this.HostelByroom.TabIndex = 53;
            this.HostelByroom.SelectedIndexChanged += new System.EventHandler(this.HostelByroom_SelectedIndexChanged);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 473);
            this.Controls.Add(this.HostelByroom);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dltroom);
            this.Controls.Add(this.RoomGrid);
            this.Controls.Add(this.RoomAddbtn);
            this.Controls.Add(BackToMenu);
            this.Controls.Add(this.RemoveHostelBtn);
            this.Controls.Add(this.HostelsDataLabel);
            this.Controls.Add(this.roomnamelabel);
            this.Controls.Add(this.Hostellabel);
            this.Controls.Add(this.RoomNumberLabel);
            this.Controls.Add(this.HostelName);
            this.Controls.Add(this.RoomNumber);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.AddHostel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox dltroom;
        private Guna.UI2.WinForms.Guna2DataGridView RoomGrid;
        private Guna.UI2.WinForms.Guna2Button RoomAddbtn;
        private Guna.UI2.WinForms.Guna2Button RemoveHostelBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel HostelsDataLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel roomnamelabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel Hostellabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel RoomNumberLabel;
        private Guna.UI2.WinForms.Guna2ComboBox HostelName;
        private Guna.UI2.WinForms.Guna2TextBox RoomNumber;
        private System.Windows.Forms.Label removebtn;
        private System.Windows.Forms.Label AddHostel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox HostelByroom;
    }
}