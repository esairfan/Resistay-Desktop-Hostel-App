namespace Resistay.UI
{
    partial class Ruleform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RulesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Rules1label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RemoveRuleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RulesGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Rule = new Guna.UI2.WinForms.Guna2TextBox();
            this.DltRuleLabel = new System.Windows.Forms.Label();
            this.RulesLabel1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RulesDate = new System.Windows.Forms.DateTimePicker();
            this.RulesDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rulesId = new Guna.UI2.WinForms.Guna2ComboBox();
            BackToMenu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.RulesGrid)).BeginInit();
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
            BackToMenu.Location = new System.Drawing.Point(749, 470);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new System.Drawing.Size(110, 23);
            BackToMenu.TabIndex = 60;
            BackToMenu.Text = "Back To Menu";
            BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // RulesBtn
            // 
            this.RulesBtn.BorderRadius = 26;
            this.RulesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RulesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RulesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RulesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RulesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RulesBtn.ForeColor = System.Drawing.Color.White;
            this.RulesBtn.Location = new System.Drawing.Point(724, 115);
            this.RulesBtn.Name = "RulesBtn";
            this.RulesBtn.Size = new System.Drawing.Size(80, 45);
            this.RulesBtn.TabIndex = 62;
            this.RulesBtn.Text = "Add";
            this.RulesBtn.Click += new System.EventHandler(this.RulesBtn_Click);
            // 
            // Rules1label
            // 
            this.Rules1label.BackColor = System.Drawing.Color.Transparent;
            this.Rules1label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rules1label.Location = new System.Drawing.Point(30, 64);
            this.Rules1label.Name = "Rules1label";
            this.Rules1label.Size = new System.Drawing.Size(66, 22);
            this.Rules1label.TabIndex = 61;
            this.Rules1label.Text = "Set Rules";
            // 
            // RemoveRuleBtn
            // 
            this.RemoveRuleBtn.BorderRadius = 26;
            this.RemoveRuleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RemoveRuleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RemoveRuleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveRuleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RemoveRuleBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveRuleBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveRuleBtn.Location = new System.Drawing.Point(442, 240);
            this.RemoveRuleBtn.Name = "RemoveRuleBtn";
            this.RemoveRuleBtn.Size = new System.Drawing.Size(80, 45);
            this.RemoveRuleBtn.TabIndex = 58;
            this.RemoveRuleBtn.Text = "Remove";
            this.RemoveRuleBtn.Click += new System.EventHandler(this.RemoveRuleBtn_Click);
            // 
            // RulesGrid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.RulesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RulesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.RulesGrid.ColumnHeadersHeight = 4;
            this.RulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RulesGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.RulesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RulesGrid.Location = new System.Drawing.Point(78, 343);
            this.RulesGrid.Name = "RulesGrid";
            this.RulesGrid.RowHeadersVisible = false;
            this.RulesGrid.Size = new System.Drawing.Size(655, 136);
            this.RulesGrid.TabIndex = 57;
            this.RulesGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RulesGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RulesGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RulesGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RulesGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RulesGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RulesGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RulesGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RulesGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RulesGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RulesGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RulesGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.RulesGrid.ThemeStyle.ReadOnly = false;
            this.RulesGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RulesGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RulesGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RulesGrid.ThemeStyle.RowsStyle.Height = 22;
            this.RulesGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RulesGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Rule
            // 
            this.Rule.AutoRoundedCorners = true;
            this.Rule.BorderRadius = 41;
            this.Rule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rule.DefaultText = "";
            this.Rule.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Rule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Rule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rule.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rule.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Rule.ForeColor = System.Drawing.Color.Black;
            this.Rule.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rule.Location = new System.Drawing.Point(16, 92);
            this.Rule.Name = "Rule";
            this.Rule.PasswordChar = '\0';
            this.Rule.PlaceholderText = "";
            this.Rule.SelectedText = "";
            this.Rule.Size = new System.Drawing.Size(454, 84);
            this.Rule.TabIndex = 56;
            this.Rule.TextChanged += new System.EventHandler(this.RulesDescription_TextChanged);
            // 
            // DltRuleLabel
            // 
            this.DltRuleLabel.AutoSize = true;
            this.DltRuleLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DltRuleLabel.Location = new System.Drawing.Point(25, 188);
            this.DltRuleLabel.Name = "DltRuleLabel";
            this.DltRuleLabel.Size = new System.Drawing.Size(162, 26);
            this.DltRuleLabel.TabIndex = 55;
            this.DltRuleLabel.Text = "Delete Rule";
            // 
            // RulesLabel1
            // 
            this.RulesLabel1.AutoSize = true;
            this.RulesLabel1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesLabel1.Location = new System.Drawing.Point(16, 20);
            this.RulesLabel1.Name = "RulesLabel1";
            this.RulesLabel1.Size = new System.Drawing.Size(83, 26);
            this.RulesLabel1.TabIndex = 54;
            this.RulesLabel1.Text = "Rules";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(341, 304);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(61, 22);
            this.guna2HtmlLabel3.TabIndex = 64;
            this.guna2HtmlLabel3.Text = "All Rules";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(30, 240);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(93, 22);
            this.guna2HtmlLabel2.TabIndex = 63;
            this.guna2HtmlLabel2.Text = "Give Rule Id";
            // 
            // RulesDate
            // 
            this.RulesDate.Location = new System.Drawing.Point(502, 129);
            this.RulesDate.Name = "RulesDate";
            this.RulesDate.Size = new System.Drawing.Size(200, 20);
            this.RulesDate.TabIndex = 65;
            // 
            // RulesDateLabel
            // 
            this.RulesDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.RulesDateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesDateLabel.Location = new System.Drawing.Point(502, 101);
            this.RulesDateLabel.Name = "RulesDateLabel";
            this.RulesDateLabel.Size = new System.Drawing.Size(39, 22);
            this.RulesDateLabel.TabIndex = 66;
            this.RulesDateLabel.Text = "Date";
            // 
            // rulesId
            // 
            this.rulesId.BackColor = System.Drawing.Color.Transparent;
            this.rulesId.BorderRadius = 22;
            this.rulesId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rulesId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rulesId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rulesId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rulesId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rulesId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.rulesId.ItemHeight = 30;
            this.rulesId.Items.AddRange(new object[] {
            "Boys",
            "Girls"});
            this.rulesId.Location = new System.Drawing.Point(192, 226);
            this.rulesId.Name = "rulesId";
            this.rulesId.Size = new System.Drawing.Size(140, 36);
            this.rulesId.TabIndex = 67;
            this.rulesId.SelectedIndexChanged += new System.EventHandler(this.rulesId_SelectedIndexChanged);
            // 
            // Ruleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.rulesId);
            this.Controls.Add(this.RulesDateLabel);
            this.Controls.Add(this.RulesDate);
            this.Controls.Add(this.RulesBtn);
            this.Controls.Add(this.Rules1label);
            this.Controls.Add(BackToMenu);
            this.Controls.Add(this.RemoveRuleBtn);
            this.Controls.Add(this.RulesGrid);
            this.Controls.Add(this.Rule);
            this.Controls.Add(this.DltRuleLabel);
            this.Controls.Add(this.RulesLabel1);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ruleform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rule";
            this.Load += new System.EventHandler(this.Rule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RulesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button RulesBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel Rules1label;
        private Guna.UI2.WinForms.Guna2Button RemoveRuleBtn;
        private Guna.UI2.WinForms.Guna2DataGridView RulesGrid;
        private Guna.UI2.WinForms.Guna2TextBox Rule;
        private System.Windows.Forms.Label DltRuleLabel;
        private System.Windows.Forms.Label RulesLabel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.DateTimePicker RulesDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel RulesDateLabel;
        private Guna.UI2.WinForms.Guna2ComboBox rulesId;
    }
}