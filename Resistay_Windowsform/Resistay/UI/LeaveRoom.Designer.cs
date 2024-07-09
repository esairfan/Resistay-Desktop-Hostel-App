namespace Resistay.UI
{
    partial class LeaveRoom
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
            this.leaveRoomlabel = new System.Windows.Forms.Label();
            this.leaveRoomBtn2 = new Guna.UI2.WinForms.Guna2Button();
            this.leaveRoomBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // leaveRoomlabel
            // 
            this.leaveRoomlabel.AutoSize = true;
            this.leaveRoomlabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveRoomlabel.ForeColor = System.Drawing.Color.Black;
            this.leaveRoomlabel.Location = new System.Drawing.Point(72, 100);
            this.leaveRoomlabel.Name = "leaveRoomlabel";
            this.leaveRoomlabel.Size = new System.Drawing.Size(216, 52);
            this.leaveRoomlabel.TabIndex = 52;
            this.leaveRoomlabel.Text = "Are you sure to \r\nleave?";
            this.leaveRoomlabel.Click += new System.EventHandler(this.leaveRoomlabel_Click);
            // 
            // leaveRoomBtn2
            // 
            this.leaveRoomBtn2.BorderRadius = 26;
            this.leaveRoomBtn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.leaveRoomBtn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.leaveRoomBtn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.leaveRoomBtn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.leaveRoomBtn2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.leaveRoomBtn2.ForeColor = System.Drawing.Color.White;
            this.leaveRoomBtn2.Location = new System.Drawing.Point(48, 218);
            this.leaveRoomBtn2.Name = "leaveRoomBtn2";
            this.leaveRoomBtn2.Size = new System.Drawing.Size(80, 45);
            this.leaveRoomBtn2.TabIndex = 51;
            this.leaveRoomBtn2.Text = "Yes";
            this.leaveRoomBtn2.Click += new System.EventHandler(this.leaveRoomBtn2_Click);
            // 
            // leaveRoomBtn
            // 
            this.leaveRoomBtn.BorderRadius = 26;
            this.leaveRoomBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.leaveRoomBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.leaveRoomBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.leaveRoomBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.leaveRoomBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.leaveRoomBtn.ForeColor = System.Drawing.Color.White;
            this.leaveRoomBtn.Location = new System.Drawing.Point(231, 218);
            this.leaveRoomBtn.Name = "leaveRoomBtn";
            this.leaveRoomBtn.Size = new System.Drawing.Size(80, 45);
            this.leaveRoomBtn.TabIndex = 50;
            this.leaveRoomBtn.Text = "No";
            this.leaveRoomBtn.Click += new System.EventHandler(this.leaveRoomBtn_Click);
            // 
            // LeaveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 362);
            this.Controls.Add(this.leaveRoomlabel);
            this.Controls.Add(this.leaveRoomBtn2);
            this.Controls.Add(this.leaveRoomBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeaveRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaveRoom";
            this.Load += new System.EventHandler(this.LeaveRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leaveRoomlabel;
        private Guna.UI2.WinForms.Guna2Button leaveRoomBtn2;
        private Guna.UI2.WinForms.Guna2Button leaveRoomBtn;
    }
}