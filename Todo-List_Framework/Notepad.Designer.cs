
namespace Todo_List_Framework
{
    partial class Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_profile_email = new System.Windows.Forms.Label();
            this.lbl_profile_name = new System.Windows.Forms.Label();
            this.pb_profile = new System.Windows.Forms.PictureBox();
            this.pb_logout = new System.Windows.Forms.PictureBox();
            this.lbl_jobList = new System.Windows.Forms.Label();
            this.pb_setting = new System.Windows.Forms.PictureBox();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.pb_addJob = new System.Windows.Forms.PictureBox();
            this.lbl_notePad = new System.Windows.Forms.Label();
            this.pb_notePad = new System.Windows.Forms.PictureBox();
            this.lbl_addJob = new System.Windows.Forms.Label();
            this.pb_jobList = new System.Windows.Forms.PictureBox();
            this.lbl_setting = new System.Windows.Forms.Label();
            this.pb_dashboard = new System.Windows.Forms.PictureBox();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_notePad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_jobList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pb_logout);
            this.panel1.Controls.Add(this.lbl_jobList);
            this.panel1.Controls.Add(this.pb_setting);
            this.panel1.Controls.Add(this.lbl_dashboard);
            this.panel1.Controls.Add(this.pb_addJob);
            this.panel1.Controls.Add(this.lbl_notePad);
            this.panel1.Controls.Add(this.pb_notePad);
            this.panel1.Controls.Add(this.lbl_addJob);
            this.panel1.Controls.Add(this.pb_jobList);
            this.panel1.Controls.Add(this.lbl_setting);
            this.panel1.Controls.Add(this.pb_dashboard);
            this.panel1.Controls.Add(this.lbl_logout);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 941);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(0, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 94);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_profile_email);
            this.panel2.Controls.Add(this.lbl_profile_name);
            this.panel2.Controls.Add(this.pb_profile);
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 333);
            this.panel2.TabIndex = 3;
            // 
            // lbl_profile_email
            // 
            this.lbl_profile_email.AutoSize = true;
            this.lbl_profile_email.Font = new System.Drawing.Font("MesloLGS NF", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_profile_email.Location = new System.Drawing.Point(127, 251);
            this.lbl_profile_email.Name = "lbl_profile_email";
            this.lbl_profile_email.Size = new System.Drawing.Size(190, 24);
            this.lbl_profile_email.TabIndex = 1;
            this.lbl_profile_email.Text = "email@gmail.com";
            // 
            // lbl_profile_name
            // 
            this.lbl_profile_name.AutoSize = true;
            this.lbl_profile_name.Font = new System.Drawing.Font("MesloLGS NF", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_profile_name.Location = new System.Drawing.Point(168, 194);
            this.lbl_profile_name.Name = "lbl_profile_name";
            this.lbl_profile_name.Size = new System.Drawing.Size(108, 44);
            this.lbl_profile_name.TabIndex = 1;
            this.lbl_profile_name.Text = "NAME";
            // 
            // pb_profile
            // 
            this.pb_profile.Image = global::Todo_List_Framework.Properties.Resources.health_test;
            this.pb_profile.Location = new System.Drawing.Point(147, 30);
            this.pb_profile.Name = "pb_profile";
            this.pb_profile.Size = new System.Drawing.Size(150, 150);
            this.pb_profile.TabIndex = 2;
            this.pb_profile.TabStop = false;
            // 
            // pb_logout
            // 
            this.pb_logout.Image = global::Todo_List_Framework.Properties.Resources.log_out;
            this.pb_logout.Location = new System.Drawing.Point(373, 877);
            this.pb_logout.Name = "pb_logout";
            this.pb_logout.Size = new System.Drawing.Size(48, 48);
            this.pb_logout.TabIndex = 11;
            this.pb_logout.TabStop = false;
            // 
            // lbl_jobList
            // 
            this.lbl_jobList.AutoSize = true;
            this.lbl_jobList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_jobList.Font = new System.Drawing.Font("MesloLGS NF", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_jobList.Location = new System.Drawing.Point(35, 442);
            this.lbl_jobList.Name = "lbl_jobList";
            this.lbl_jobList.Size = new System.Drawing.Size(239, 54);
            this.lbl_jobList.TabIndex = 10;
            this.lbl_jobList.Text = "JOB LIST";
            // 
            // pb_setting
            // 
            this.pb_setting.Image = global::Todo_List_Framework.Properties.Resources.setting;
            this.pb_setting.Location = new System.Drawing.Point(373, 817);
            this.pb_setting.Name = "pb_setting";
            this.pb_setting.Size = new System.Drawing.Size(48, 48);
            this.pb_setting.TabIndex = 12;
            this.pb_setting.TabStop = false;
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_dashboard.Font = new System.Drawing.Font("MesloLGS NF", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_dashboard.Location = new System.Drawing.Point(35, 354);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(266, 54);
            this.lbl_dashboard.TabIndex = 9;
            this.lbl_dashboard.Text = "DASHBOARD";
            // 
            // pb_addJob
            // 
            this.pb_addJob.Image = global::Todo_List_Framework.Properties.Resources.add_job;
            this.pb_addJob.Location = new System.Drawing.Point(344, 615);
            this.pb_addJob.Name = "pb_addJob";
            this.pb_addJob.Size = new System.Drawing.Size(61, 61);
            this.pb_addJob.TabIndex = 13;
            this.pb_addJob.TabStop = false;
            // 
            // lbl_notePad
            // 
            this.lbl_notePad.AutoSize = true;
            this.lbl_notePad.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_notePad.Font = new System.Drawing.Font("MesloLGS NF", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_notePad.Location = new System.Drawing.Point(35, 530);
            this.lbl_notePad.Name = "lbl_notePad";
            this.lbl_notePad.Size = new System.Drawing.Size(212, 54);
            this.lbl_notePad.TabIndex = 8;
            this.lbl_notePad.Text = "NOTEPAD";
            // 
            // pb_notePad
            // 
            this.pb_notePad.Image = global::Todo_List_Framework.Properties.Resources.note;
            this.pb_notePad.Location = new System.Drawing.Point(344, 527);
            this.pb_notePad.Name = "pb_notePad";
            this.pb_notePad.Size = new System.Drawing.Size(61, 61);
            this.pb_notePad.TabIndex = 14;
            this.pb_notePad.TabStop = false;
            // 
            // lbl_addJob
            // 
            this.lbl_addJob.AutoSize = true;
            this.lbl_addJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_addJob.Font = new System.Drawing.Font("MesloLGS NF", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_addJob.Location = new System.Drawing.Point(35, 618);
            this.lbl_addJob.Name = "lbl_addJob";
            this.lbl_addJob.Size = new System.Drawing.Size(212, 54);
            this.lbl_addJob.TabIndex = 7;
            this.lbl_addJob.Text = "ADD JOB";
            // 
            // pb_jobList
            // 
            this.pb_jobList.Image = global::Todo_List_Framework.Properties.Resources.clipboard;
            this.pb_jobList.Location = new System.Drawing.Point(344, 439);
            this.pb_jobList.Name = "pb_jobList";
            this.pb_jobList.Size = new System.Drawing.Size(61, 61);
            this.pb_jobList.TabIndex = 15;
            this.pb_jobList.TabStop = false;
            // 
            // lbl_setting
            // 
            this.lbl_setting.AutoSize = true;
            this.lbl_setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_setting.Font = new System.Drawing.Font("MesloLGS NF", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_setting.Location = new System.Drawing.Point(193, 819);
            this.lbl_setting.Name = "lbl_setting";
            this.lbl_setting.Size = new System.Drawing.Size(174, 44);
            this.lbl_setting.TabIndex = 6;
            this.lbl_setting.Text = "SETTING";
            // 
            // pb_dashboard
            // 
            this.pb_dashboard.Image = global::Todo_List_Framework.Properties.Resources.dashboard;
            this.pb_dashboard.Location = new System.Drawing.Point(344, 351);
            this.pb_dashboard.Name = "pb_dashboard";
            this.pb_dashboard.Size = new System.Drawing.Size(61, 61);
            this.pb_dashboard.TabIndex = 16;
            this.pb_dashboard.TabStop = false;
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_logout.Font = new System.Drawing.Font("MesloLGS NF", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_logout.Location = new System.Drawing.Point(193, 879);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(152, 44);
            this.lbl_logout.TabIndex = 5;
            this.lbl_logout.Text = "LOGOUT";
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1804, 941);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notepad_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_notePad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_jobList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_profile_email;
        private System.Windows.Forms.Label lbl_profile_name;
        private System.Windows.Forms.PictureBox pb_profile;
        private System.Windows.Forms.PictureBox pb_logout;
        private System.Windows.Forms.Label lbl_jobList;
        private System.Windows.Forms.PictureBox pb_setting;
        private System.Windows.Forms.Label lbl_dashboard;
        private System.Windows.Forms.PictureBox pb_addJob;
        private System.Windows.Forms.Label lbl_notePad;
        private System.Windows.Forms.PictureBox pb_notePad;
        private System.Windows.Forms.Label lbl_addJob;
        private System.Windows.Forms.PictureBox pb_jobList;
        private System.Windows.Forms.Label lbl_setting;
        private System.Windows.Forms.PictureBox pb_dashboard;
        private System.Windows.Forms.Label lbl_logout;
    }
}