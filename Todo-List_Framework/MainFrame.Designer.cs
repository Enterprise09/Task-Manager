
namespace Todo_List_Framework
{
    partial class MainFrame
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Indicator = new System.Windows.Forms.Panel();
            this.pb_logout = new System.Windows.Forms.PictureBox();
            this.pb_setting = new System.Windows.Forms.PictureBox();
            this.pb_addJob = new System.Windows.Forms.PictureBox();
            this.pb_notePad = new System.Windows.Forms.PictureBox();
            this.pb_jobList = new System.Windows.Forms.PictureBox();
            this.pb_dashboard = new System.Windows.Forms.PictureBox();
            this.lbl_lobout = new System.Windows.Forms.Label();
            this.lbl_setting = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_notePad = new System.Windows.Forms.Label();
            this.lbl_jobList = new System.Windows.Forms.Label();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_profile_email = new System.Windows.Forms.Label();
            this.lbl_profile_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_notePad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_jobList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dashboard)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Indicator);
            this.panel1.Controls.Add(this.pb_logout);
            this.panel1.Controls.Add(this.pb_setting);
            this.panel1.Controls.Add(this.pb_addJob);
            this.panel1.Controls.Add(this.pb_notePad);
            this.panel1.Controls.Add(this.pb_jobList);
            this.panel1.Controls.Add(this.pb_dashboard);
            this.panel1.Controls.Add(this.lbl_lobout);
            this.panel1.Controls.Add(this.lbl_setting);
            this.panel1.Controls.Add(this.lbl_contact);
            this.panel1.Controls.Add(this.lbl_notePad);
            this.panel1.Controls.Add(this.lbl_jobList);
            this.panel1.Controls.Add(this.lbl_dashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 941);
            this.panel1.TabIndex = 0;
            // 
            // Indicator
            // 
            this.Indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Indicator.Location = new System.Drawing.Point(0, 333);
            this.Indicator.Name = "Indicator";
            this.Indicator.Size = new System.Drawing.Size(12, 94);
            this.Indicator.TabIndex = 1;
            // 
            // pb_logout
            // 
            this.pb_logout.Image = global::Todo_List_Framework.Properties.Resources.log_out;
            this.pb_logout.Location = new System.Drawing.Point(374, 876);
            this.pb_logout.Name = "pb_logout";
            this.pb_logout.Size = new System.Drawing.Size(48, 48);
            this.pb_logout.TabIndex = 2;
            this.pb_logout.TabStop = false;
            // 
            // pb_setting
            // 
            this.pb_setting.Image = global::Todo_List_Framework.Properties.Resources.setting;
            this.pb_setting.Location = new System.Drawing.Point(374, 816);
            this.pb_setting.Name = "pb_setting";
            this.pb_setting.Size = new System.Drawing.Size(48, 48);
            this.pb_setting.TabIndex = 2;
            this.pb_setting.TabStop = false;
            // 
            // pb_addJob
            // 
            this.pb_addJob.Image = global::Todo_List_Framework.Properties.Resources.contact;
            this.pb_addJob.Location = new System.Drawing.Point(345, 614);
            this.pb_addJob.Name = "pb_addJob";
            this.pb_addJob.Size = new System.Drawing.Size(61, 61);
            this.pb_addJob.TabIndex = 2;
            this.pb_addJob.TabStop = false;
            // 
            // pb_notePad
            // 
            this.pb_notePad.Image = global::Todo_List_Framework.Properties.Resources.note;
            this.pb_notePad.Location = new System.Drawing.Point(345, 526);
            this.pb_notePad.Name = "pb_notePad";
            this.pb_notePad.Size = new System.Drawing.Size(61, 61);
            this.pb_notePad.TabIndex = 2;
            this.pb_notePad.TabStop = false;
            // 
            // pb_jobList
            // 
            this.pb_jobList.Image = global::Todo_List_Framework.Properties.Resources.clipboard;
            this.pb_jobList.Location = new System.Drawing.Point(345, 438);
            this.pb_jobList.Name = "pb_jobList";
            this.pb_jobList.Size = new System.Drawing.Size(61, 61);
            this.pb_jobList.TabIndex = 2;
            this.pb_jobList.TabStop = false;
            // 
            // pb_dashboard
            // 
            this.pb_dashboard.Image = global::Todo_List_Framework.Properties.Resources.dashboard;
            this.pb_dashboard.Location = new System.Drawing.Point(345, 350);
            this.pb_dashboard.Name = "pb_dashboard";
            this.pb_dashboard.Size = new System.Drawing.Size(61, 61);
            this.pb_dashboard.TabIndex = 2;
            this.pb_dashboard.TabStop = false;
            // 
            // lbl_lobout
            // 
            this.lbl_lobout.AutoSize = true;
            this.lbl_lobout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_lobout.Font = new System.Drawing.Font("MesloLGS NF", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_lobout.Location = new System.Drawing.Point(194, 878);
            this.lbl_lobout.Name = "lbl_lobout";
            this.lbl_lobout.Size = new System.Drawing.Size(152, 44);
            this.lbl_lobout.TabIndex = 1;
            this.lbl_lobout.Text = "LOGOUT";
            this.lbl_lobout.Click += new System.EventHandler(this.lbl_lobout_Click);
            // 
            // lbl_setting
            // 
            this.lbl_setting.AutoSize = true;
            this.lbl_setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_setting.Font = new System.Drawing.Font("MesloLGS NF", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_setting.Location = new System.Drawing.Point(194, 818);
            this.lbl_setting.Name = "lbl_setting";
            this.lbl_setting.Size = new System.Drawing.Size(174, 44);
            this.lbl_setting.TabIndex = 1;
            this.lbl_setting.Text = "SETTING";
            this.lbl_setting.Click += new System.EventHandler(this.lbl_setting_Click);
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_contact.Font = new System.Drawing.Font("MesloLGS NF", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_contact.Location = new System.Drawing.Point(36, 617);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(212, 54);
            this.lbl_contact.TabIndex = 1;
            this.lbl_contact.Text = "CONTACT";
            this.lbl_contact.Click += new System.EventHandler(this.lbl_contact_Click);
            // 
            // lbl_notePad
            // 
            this.lbl_notePad.AutoSize = true;
            this.lbl_notePad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_notePad.Font = new System.Drawing.Font("MesloLGS NF", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_notePad.Location = new System.Drawing.Point(36, 529);
            this.lbl_notePad.Name = "lbl_notePad";
            this.lbl_notePad.Size = new System.Drawing.Size(212, 54);
            this.lbl_notePad.TabIndex = 1;
            this.lbl_notePad.Text = "NOTEPAD";
            this.lbl_notePad.Click += new System.EventHandler(this.lbl_notePad_Click);
            // 
            // lbl_jobList
            // 
            this.lbl_jobList.AutoSize = true;
            this.lbl_jobList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_jobList.Font = new System.Drawing.Font("MesloLGS NF", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_jobList.Location = new System.Drawing.Point(36, 441);
            this.lbl_jobList.Name = "lbl_jobList";
            this.lbl_jobList.Size = new System.Drawing.Size(239, 54);
            this.lbl_jobList.TabIndex = 1;
            this.lbl_jobList.Text = "JOB LIST";
            this.lbl_jobList.Click += new System.EventHandler(this.lbl_jobList_Click);
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_dashboard.Font = new System.Drawing.Font("MesloLGS NF", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_dashboard.Location = new System.Drawing.Point(36, 353);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(266, 54);
            this.lbl_dashboard.TabIndex = 1;
            this.lbl_dashboard.Text = "DASHBOARD";
            this.lbl_dashboard.Click += new System.EventHandler(this.lbl_dashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 333);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_profile_email, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_profile_name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 333);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_profile_email
            // 
            this.lbl_profile_email.AutoSize = true;
            this.lbl_profile_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_profile_email.Font = new System.Drawing.Font("MesloLGS NF", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_profile_email.Location = new System.Drawing.Point(3, 265);
            this.lbl_profile_email.Name = "lbl_profile_email";
            this.lbl_profile_email.Size = new System.Drawing.Size(438, 68);
            this.lbl_profile_email.TabIndex = 1;
            this.lbl_profile_email.Text = "email@gmail.com";
            this.lbl_profile_email.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_profile_name
            // 
            this.lbl_profile_name.AutoSize = true;
            this.lbl_profile_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_profile_name.Font = new System.Drawing.Font("MesloLGS NF", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_profile_name.Location = new System.Drawing.Point(3, 199);
            this.lbl_profile_name.Name = "lbl_profile_name";
            this.lbl_profile_name.Size = new System.Drawing.Size(438, 66);
            this.lbl_profile_name.TabIndex = 1;
            this.lbl_profile_name.Text = "NAME";
            this.lbl_profile_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Image = global::Todo_List_Framework.Properties.Resources.health_test;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 199);
            this.label1.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPanel.Location = new System.Drawing.Point(1804, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(0, 941);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1804, 941);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_notePad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_jobList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dashboard)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_dashboard;
        private System.Windows.Forms.PictureBox pb_jobList;
        private System.Windows.Forms.PictureBox pb_dashboard;
        private System.Windows.Forms.Label lbl_jobList;
        private System.Windows.Forms.PictureBox pb_addJob;
        private System.Windows.Forms.PictureBox pb_notePad;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_notePad;
        private System.Windows.Forms.PictureBox pb_setting;
        private System.Windows.Forms.Label lbl_setting;
        private System.Windows.Forms.PictureBox pb_logout;
        private System.Windows.Forms.Label lbl_lobout;
        private System.Windows.Forms.Panel Indicator;
        private System.Windows.Forms.Label lbl_profile_email;
        private System.Windows.Forms.Label lbl_profile_name;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}

