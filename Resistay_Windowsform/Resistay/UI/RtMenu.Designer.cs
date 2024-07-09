namespace Resistay.UI
{
    partial class RtMenu
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.AnnoucemntBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ComplainsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RulesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LogOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.hosteDetailbtn = new Guna.UI2.WinForms.Guna2Button();
            this.leavehostelbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResuistayLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.recievesalarybtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2PictureBox1.BorderRadius = 30;
            this.guna2PictureBox1.Image = global::Resistay.Properties.Resources.hostel;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(240, 115);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1106, 661);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 62;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // AnnoucemntBtn
            // 
            this.AnnoucemntBtn.BorderRadius = 26;
            this.AnnoucemntBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AnnoucemntBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.AnnoucemntBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AnnoucemntBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AnnoucemntBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AnnoucemntBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AnnoucemntBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AnnoucemntBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AnnoucemntBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnoucemntBtn.ForeColor = System.Drawing.Color.Black;
            this.AnnoucemntBtn.Image = global::Resistay.Properties.Resources.all_student_living1;
            this.AnnoucemntBtn.Location = new System.Drawing.Point(23, 227);
            this.AnnoucemntBtn.Name = "AnnoucemntBtn";
            this.AnnoucemntBtn.Size = new System.Drawing.Size(211, 40);
            this.AnnoucemntBtn.TabIndex = 65;
            this.AnnoucemntBtn.Text = "Check Annoucements";
            this.AnnoucemntBtn.Click += new System.EventHandler(this.AnnoucemntBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ExitBtn.BorderRadius = 26;
            this.ExitBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ExitBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.ExitBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitBtn.FillColor = System.Drawing.SystemColors.Control;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Image = global::Resistay.Properties.Resources.Close_all_jframe;
            this.ExitBtn.Location = new System.Drawing.Point(1331, 21);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.PressedDepth = 20;
            this.ExitBtn.Size = new System.Drawing.Size(33, 40);
            this.ExitBtn.TabIndex = 67;
            // 
            // ComplainsBtn
            // 
            this.ComplainsBtn.BorderRadius = 26;
            this.ComplainsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ComplainsBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.ComplainsBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComplainsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ComplainsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ComplainsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ComplainsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ComplainsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ComplainsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ComplainsBtn.ForeColor = System.Drawing.Color.Black;
            this.ComplainsBtn.Image = global::Resistay.Properties.Resources.List_of_Paid___Dues_Students1;
            this.ComplainsBtn.Location = new System.Drawing.Point(23, 313);
            this.ComplainsBtn.Name = "ComplainsBtn";
            this.ComplainsBtn.Size = new System.Drawing.Size(211, 40);
            this.ComplainsBtn.TabIndex = 68;
            this.ComplainsBtn.Text = "Check Complains";
            this.ComplainsBtn.Click += new System.EventHandler(this.ComplainsBtn_Click);
            // 
            // RulesBtn
            // 
            this.RulesBtn.BorderRadius = 26;
            this.RulesBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.RulesBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.RulesBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RulesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RulesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RulesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RulesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RulesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.RulesBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.RulesBtn.ForeColor = System.Drawing.Color.Black;
            this.RulesBtn.Image = global::Resistay.Properties.Resources.rules_removebg_preview;
            this.RulesBtn.Location = new System.Drawing.Point(23, 572);
            this.RulesBtn.Name = "RulesBtn";
            this.RulesBtn.Size = new System.Drawing.Size(211, 40);
            this.RulesBtn.TabIndex = 69;
            this.RulesBtn.Text = "Rules";
            this.RulesBtn.Click += new System.EventHandler(this.RulesBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BorderRadius = 26;
            this.LogOutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.LogOutBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.LogOutBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LogOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogOutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LogOutBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LogOutBtn.ForeColor = System.Drawing.Color.Black;
            this.LogOutBtn.Image = global::Resistay.Properties.Resources.logout;
            this.LogOutBtn.Location = new System.Drawing.Point(23, 657);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(211, 40);
            this.LogOutBtn.TabIndex = 70;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // hosteDetailbtn
            // 
            this.hosteDetailbtn.BorderRadius = 26;
            this.hosteDetailbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.hosteDetailbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.hosteDetailbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.hosteDetailbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hosteDetailbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hosteDetailbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hosteDetailbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hosteDetailbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.hosteDetailbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosteDetailbtn.ForeColor = System.Drawing.Color.Black;
            this.hosteDetailbtn.Image = global::Resistay.Properties.Resources.rules_removebg_preview;
            this.hosteDetailbtn.Location = new System.Drawing.Point(23, 143);
            this.hosteDetailbtn.Name = "hosteDetailbtn";
            this.hosteDetailbtn.Size = new System.Drawing.Size(211, 42);
            this.hosteDetailbtn.TabIndex = 71;
            this.hosteDetailbtn.Text = "Check Hostel Details";
            this.hosteDetailbtn.Click += new System.EventHandler(this.hosteDetailbtn_Click);
            // 
            // leavehostelbtn
            // 
            this.leavehostelbtn.BorderRadius = 26;
            this.leavehostelbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.leavehostelbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.leavehostelbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.leavehostelbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.leavehostelbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.leavehostelbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.leavehostelbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.leavehostelbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.leavehostelbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leavehostelbtn.ForeColor = System.Drawing.Color.Black;
            this.leavehostelbtn.Image = global::Resistay.Properties.Resources.logout;
            this.leavehostelbtn.Location = new System.Drawing.Point(23, 488);
            this.leavehostelbtn.Name = "leavehostelbtn";
            this.leavehostelbtn.Size = new System.Drawing.Size(211, 42);
            this.leavehostelbtn.TabIndex = 74;
            this.leavehostelbtn.Text = "Leave Hostel";
            this.leavehostelbtn.Click += new System.EventHandler(this.leavehostelbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 35);
            this.label1.TabIndex = 63;
            this.label1.Text = "NAVIGATOR BAR";
            // 
            // ResuistayLabel
            // 
            this.ResuistayLabel.AutoSize = true;
            this.ResuistayLabel.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResuistayLabel.ForeColor = System.Drawing.Color.Black;
            this.ResuistayLabel.Location = new System.Drawing.Point(598, 10);
            this.ResuistayLabel.Name = "ResuistayLabel";
            this.ResuistayLabel.Size = new System.Drawing.Size(140, 56);
            this.ResuistayLabel.TabIndex = 64;
            this.ResuistayLabel.Text = "Resistay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(617, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 35);
            this.label2.TabIndex = 72;
            this.label2.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLabel.ForeColor = System.Drawing.Color.Black;
            this.ProfileLabel.Location = new System.Drawing.Point(31, 86);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(0, 20);
            this.ProfileLabel.TabIndex = 73;
            // 
            // recievesalarybtn
            // 
            this.recievesalarybtn.BorderRadius = 26;
            this.recievesalarybtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.recievesalarybtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.recievesalarybtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.recievesalarybtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.recievesalarybtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.recievesalarybtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.recievesalarybtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.recievesalarybtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.recievesalarybtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.recievesalarybtn.ForeColor = System.Drawing.Color.Black;
            this.recievesalarybtn.Image = global::Resistay.Properties.Resources.List_of_Paid___Dues_Students1;
            this.recievesalarybtn.Location = new System.Drawing.Point(23, 396);
            this.recievesalarybtn.Name = "recievesalarybtn";
            this.recievesalarybtn.Size = new System.Drawing.Size(211, 40);
            this.recievesalarybtn.TabIndex = 75;
            this.recievesalarybtn.Text = "Generate Salary Checks";
            this.recievesalarybtn.Click += new System.EventHandler(this.recievesalarybtn_Click);
            // 
            // RtMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 786);
            this.Controls.Add(this.recievesalarybtn);
            this.Controls.Add(this.ProfileLabel);
            this.Controls.Add(this.leavehostelbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hosteDetailbtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.RulesBtn);
            this.Controls.Add(this.ComplainsBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AnnoucemntBtn);
            this.Controls.Add(this.ResuistayLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RtMenu";
            this.Text = "RtMenu";
            this.Load += new System.EventHandler(this.RtMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button AnnoucemntBtn;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private Guna.UI2.WinForms.Guna2Button ComplainsBtn;
        private Guna.UI2.WinForms.Guna2Button RulesBtn;
        private Guna.UI2.WinForms.Guna2Button LogOutBtn;
        private Guna.UI2.WinForms.Guna2Button hosteDetailbtn;
        private Guna.UI2.WinForms.Guna2Button leavehostelbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResuistayLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ProfileLabel;
        private Guna.UI2.WinForms.Guna2Button recievesalarybtn;
    }
}