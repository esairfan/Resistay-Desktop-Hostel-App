namespace Resistay.UI
{
    partial class AdminMenu
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ResuistayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.addrtbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Removalrtbtn = new Guna.UI2.WinForms.Guna2Button();
            this.LogOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RukesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AnnoucementBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.StudentsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HostelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Roombtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.AllotFeesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.salarybtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ResuistayLabel
            // 
            this.ResuistayLabel.AutoSize = true;
            this.ResuistayLabel.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResuistayLabel.ForeColor = System.Drawing.Color.Black;
            this.ResuistayLabel.Location = new System.Drawing.Point(587, 8);
            this.ResuistayLabel.Name = "ResuistayLabel";
            this.ResuistayLabel.Size = new System.Drawing.Size(140, 56);
            this.ResuistayLabel.TabIndex = 2;
            this.ResuistayLabel.Text = "Resistay";
            this.ResuistayLabel.Click += new System.EventHandler(this.ResuistayLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAVIGATOR BAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(606, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = " ";
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLabel.ForeColor = System.Drawing.Color.Black;
            this.ProfileLabel.Location = new System.Drawing.Point(20, 84);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(0, 20);
            this.ProfileLabel.TabIndex = 45;
            this.ProfileLabel.Click += new System.EventHandler(this.ProfileLabel_Click);
            // 
            // addrtbtn
            // 
            this.addrtbtn.BorderRadius = 26;
            this.addrtbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.addrtbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.addrtbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addrtbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addrtbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addrtbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addrtbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addrtbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.addrtbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrtbtn.ForeColor = System.Drawing.Color.Black;
            this.addrtbtn.Image = global::Resistay.Properties.Resources.new_student;
            this.addrtbtn.Location = new System.Drawing.Point(12, 369);
            this.addrtbtn.Name = "addrtbtn";
            this.addrtbtn.Size = new System.Drawing.Size(211, 42);
            this.addrtbtn.TabIndex = 14;
            this.addrtbtn.Text = "Add Resident Tutor";
            this.addrtbtn.Click += new System.EventHandler(this.addrtbtn_Click);
            // 
            // Removalrtbtn
            // 
            this.Removalrtbtn.BorderRadius = 26;
            this.Removalrtbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Removalrtbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.Removalrtbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Removalrtbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Removalrtbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Removalrtbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Removalrtbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Removalrtbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Removalrtbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removalrtbtn.ForeColor = System.Drawing.Color.Black;
            this.Removalrtbtn.Image = global::Resistay.Properties.Resources.new_student;
            this.Removalrtbtn.Location = new System.Drawing.Point(12, 431);
            this.Removalrtbtn.Name = "Removalrtbtn";
            this.Removalrtbtn.Size = new System.Drawing.Size(211, 42);
            this.Removalrtbtn.TabIndex = 13;
            this.Removalrtbtn.Text = "Remove Rt or Student ";
            this.Removalrtbtn.Click += new System.EventHandler(this.Removalrtbtn_Click);
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
            this.LogOutBtn.Location = new System.Drawing.Point(12, 725);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(211, 40);
            this.LogOutBtn.TabIndex = 12;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // RukesBtn
            // 
            this.RukesBtn.BorderRadius = 26;
            this.RukesBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.RukesBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.RukesBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RukesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RukesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RukesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RukesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RukesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.RukesBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.RukesBtn.ForeColor = System.Drawing.Color.Black;
            this.RukesBtn.Image = global::Resistay.Properties.Resources.rules_removebg_preview;
            this.RukesBtn.Location = new System.Drawing.Point(12, 668);
            this.RukesBtn.Name = "RukesBtn";
            this.RukesBtn.Size = new System.Drawing.Size(211, 40);
            this.RukesBtn.TabIndex = 11;
            this.RukesBtn.Text = "Rules";
            this.RukesBtn.Click += new System.EventHandler(this.RukesBtn_Click);
            // 
            // AnnoucementBtn
            // 
            this.AnnoucementBtn.BorderRadius = 26;
            this.AnnoucementBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AnnoucementBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.AnnoucementBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AnnoucementBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AnnoucementBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AnnoucementBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AnnoucementBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AnnoucementBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AnnoucementBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AnnoucementBtn.ForeColor = System.Drawing.Color.Black;
            this.AnnoucementBtn.Image = global::Resistay.Properties.Resources.List_of_Paid___Dues_Students1;
            this.AnnoucementBtn.Location = new System.Drawing.Point(12, 610);
            this.AnnoucementBtn.Name = "AnnoucementBtn";
            this.AnnoucementBtn.Size = new System.Drawing.Size(211, 40);
            this.AnnoucementBtn.TabIndex = 10;
            this.AnnoucementBtn.Text = "Annoucements";
            this.AnnoucementBtn.Click += new System.EventHandler(this.AnnoucementBtn_Click);
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
            this.ExitBtn.Location = new System.Drawing.Point(1320, 19);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.PressedDepth = 20;
            this.ExitBtn.Size = new System.Drawing.Size(33, 40);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // StudentsBtn
            // 
            this.StudentsBtn.BorderRadius = 26;
            this.StudentsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.StudentsBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.StudentsBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StudentsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StudentsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StudentsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StudentsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StudentsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.StudentsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsBtn.ForeColor = System.Drawing.Color.Black;
            this.StudentsBtn.Image = global::Resistay.Properties.Resources.new_student;
            this.StudentsBtn.Location = new System.Drawing.Point(12, 186);
            this.StudentsBtn.Name = "StudentsBtn";
            this.StudentsBtn.Size = new System.Drawing.Size(211, 42);
            this.StudentsBtn.TabIndex = 8;
            this.StudentsBtn.Text = "Allot Students";
            this.StudentsBtn.Click += new System.EventHandler(this.StudentsBtn_Click);
            // 
            // HostelBtn
            // 
            this.HostelBtn.BorderRadius = 26;
            this.HostelBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HostelBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.HostelBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HostelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HostelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HostelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HostelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HostelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.HostelBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostelBtn.ForeColor = System.Drawing.Color.Black;
            this.HostelBtn.Image = global::Resistay.Properties.Resources.all_student_living1;
            this.HostelBtn.Location = new System.Drawing.Point(12, 310);
            this.HostelBtn.Name = "HostelBtn";
            this.HostelBtn.Size = new System.Drawing.Size(211, 40);
            this.HostelBtn.TabIndex = 7;
            this.HostelBtn.Text = "Manage Hostels";
            this.HostelBtn.Click += new System.EventHandler(this.HostelBtn_Click);
            // 
            // Roombtn
            // 
            this.Roombtn.BorderRadius = 26;
            this.Roombtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Roombtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.Roombtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Roombtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Roombtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Roombtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Roombtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Roombtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Roombtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roombtn.ForeColor = System.Drawing.Color.Black;
            this.Roombtn.Image = global::Resistay.Properties.Resources.room;
            this.Roombtn.Location = new System.Drawing.Point(12, 248);
            this.Roombtn.Name = "Roombtn";
            this.Roombtn.Size = new System.Drawing.Size(211, 40);
            this.Roombtn.TabIndex = 3;
            this.Roombtn.Text = "Manage Rooms";
            this.Roombtn.Click += new System.EventHandler(this.Roombtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2PictureBox1.BorderRadius = 30;
            this.guna2PictureBox1.Image = global::Resistay.Properties.Resources.hostel;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(229, 113);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1106, 661);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // AllotFeesBtn
            // 
            this.AllotFeesBtn.BorderRadius = 26;
            this.AllotFeesBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AllotFeesBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.AllotFeesBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AllotFeesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AllotFeesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AllotFeesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AllotFeesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AllotFeesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AllotFeesBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AllotFeesBtn.ForeColor = System.Drawing.Color.Black;
            this.AllotFeesBtn.Image = global::Resistay.Properties.Resources.rules_removebg_preview;
            this.AllotFeesBtn.Location = new System.Drawing.Point(12, 548);
            this.AllotFeesBtn.Name = "AllotFeesBtn";
            this.AllotFeesBtn.Size = new System.Drawing.Size(211, 40);
            this.AllotFeesBtn.TabIndex = 46;
            this.AllotFeesBtn.Text = "Allot Fees";
            this.AllotFeesBtn.Click += new System.EventHandler(this.AllotFeesBtn_Click);
            // 
            // salarybtn
            // 
            this.salarybtn.BorderRadius = 26;
            this.salarybtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.salarybtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.salarybtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.salarybtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salarybtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salarybtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salarybtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salarybtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.salarybtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.salarybtn.ForeColor = System.Drawing.Color.Black;
            this.salarybtn.Image = global::Resistay.Properties.Resources.rules_removebg_preview;
            this.salarybtn.Location = new System.Drawing.Point(12, 491);
            this.salarybtn.Name = "salarybtn";
            this.salarybtn.Size = new System.Drawing.Size(211, 40);
            this.salarybtn.TabIndex = 47;
            this.salarybtn.Text = "Allot Salary";
            this.salarybtn.Click += new System.EventHandler(this.salarybtn_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 786);
            this.Controls.Add(this.salarybtn);
            this.Controls.Add(this.AllotFeesBtn);
            this.Controls.Add(this.ProfileLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addrtbtn);
            this.Controls.Add(this.Removalrtbtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.RukesBtn);
            this.Controls.Add(this.AnnoucementBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StudentsBtn);
            this.Controls.Add(this.HostelBtn);
            this.Controls.Add(this.Roombtn);
            this.Controls.Add(this.ResuistayLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button Roombtn;
        private Guna.UI2.WinForms.Guna2Button HostelBtn;
        private Guna.UI2.WinForms.Guna2Button StudentsBtn;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button AnnoucementBtn;
        private Guna.UI2.WinForms.Guna2Button RukesBtn;
        private Guna.UI2.WinForms.Guna2Button LogOutBtn;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private System.Windows.Forms.Label ResuistayLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Removalrtbtn;
        private Guna.UI2.WinForms.Guna2Button addrtbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProfileLabel;
        private Guna.UI2.WinForms.Guna2Button AllotFeesBtn;
        private Guna.UI2.WinForms.Guna2Button salarybtn;
    }
}