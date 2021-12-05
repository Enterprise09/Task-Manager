
namespace Todo_List_Framework
{
    partial class AddJobForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddJobForm));
            this.lbl_jobTitle = new System.Windows.Forms.Label();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.tb_endline = new System.Windows.Forms.TextBox();
            this.tb_request = new System.Windows.Forms.TextBox();
            this.state_group = new System.Windows.Forms.GroupBox();
            this.rb_process = new System.Windows.Forms.RadioButton();
            this.rb_notYet = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.insertJob_button = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rb_complete = new System.Windows.Forms.RadioButton();
            this.state_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertJob_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_jobTitle
            // 
            this.lbl_jobTitle.AutoSize = true;
            this.lbl_jobTitle.Font = new System.Drawing.Font("MesloLGS NF", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jobTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.lbl_jobTitle.Location = new System.Drawing.Point(199, 81);
            this.lbl_jobTitle.Name = "lbl_jobTitle";
            this.lbl_jobTitle.Size = new System.Drawing.Size(117, 61);
            this.lbl_jobTitle.TabIndex = 0;
            this.lbl_jobTitle.Text = "Job";
            // 
            // tb_from
            // 
            this.tb_from.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_from.Font = new System.Drawing.Font("MesloLGS NF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_from.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_from.Location = new System.Drawing.Point(90, 181);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(270, 34);
            this.tb_from.TabIndex = 1;
            this.tb_from.Text = "From";
            this.tb_from.Enter += new System.EventHandler(this.tb_from_Enter);
            this.tb_from.Leave += new System.EventHandler(this.tb_from_Leave);
            // 
            // tb_endline
            // 
            this.tb_endline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_endline.Font = new System.Drawing.Font("MesloLGS NF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_endline.Location = new System.Drawing.Point(90, 225);
            this.tb_endline.Name = "tb_endline";
            this.tb_endline.Size = new System.Drawing.Size(270, 34);
            this.tb_endline.TabIndex = 1;
            this.tb_endline.Text = "End Line";
            this.tb_endline.Enter += new System.EventHandler(this.tb_endline_Enter);
            this.tb_endline.Leave += new System.EventHandler(this.tb_endline_Leave);
            // 
            // tb_request
            // 
            this.tb_request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_request.Font = new System.Drawing.Font("MesloLGS NF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_request.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_request.Location = new System.Drawing.Point(90, 269);
            this.tb_request.Multiline = true;
            this.tb_request.Name = "tb_request";
            this.tb_request.Size = new System.Drawing.Size(270, 100);
            this.tb_request.TabIndex = 1;
            this.tb_request.Text = "Request";
            this.tb_request.Enter += new System.EventHandler(this.tb_request_Enter);
            this.tb_request.Leave += new System.EventHandler(this.tb_request_Leave);
            // 
            // state_group
            // 
            this.state_group.Controls.Add(this.rb_complete);
            this.state_group.Controls.Add(this.rb_process);
            this.state_group.Controls.Add(this.rb_notYet);
            this.state_group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.state_group.Font = new System.Drawing.Font("MesloLGS NF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_group.Location = new System.Drawing.Point(244, 375);
            this.state_group.Name = "state_group";
            this.state_group.Size = new System.Drawing.Size(116, 115);
            this.state_group.TabIndex = 5;
            this.state_group.TabStop = false;
            // 
            // rb_process
            // 
            this.rb_process.AutoSize = true;
            this.rb_process.Font = new System.Drawing.Font("MesloLGS NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_process.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.rb_process.Location = new System.Drawing.Point(6, 47);
            this.rb_process.Name = "rb_process";
            this.rb_process.Size = new System.Drawing.Size(98, 25);
            this.rb_process.TabIndex = 4;
            this.rb_process.Text = "process";
            this.rb_process.UseVisualStyleBackColor = true;
            // 
            // rb_notYet
            // 
            this.rb_notYet.AutoSize = true;
            this.rb_notYet.Checked = true;
            this.rb_notYet.Font = new System.Drawing.Font("MesloLGS NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_notYet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.rb_notYet.Location = new System.Drawing.Point(6, 16);
            this.rb_notYet.Name = "rb_notYet";
            this.rb_notYet.Size = new System.Drawing.Size(98, 25);
            this.rb_notYet.TabIndex = 4;
            this.rb_notYet.TabStop = true;
            this.rb_notYet.Text = "not yet";
            this.rb_notYet.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Todo_List_Framework.Properties.Resources.plus_icon;
            this.pictureBox2.Location = new System.Drawing.Point(132, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 61);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // insertJob_button
            // 
            this.insertJob_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertJob_button.Image = global::Todo_List_Framework.Properties.Resources.login_button;
            this.insertJob_button.Location = new System.Drawing.Point(316, 522);
            this.insertJob_button.Name = "insertJob_button";
            this.insertJob_button.Size = new System.Drawing.Size(50, 50);
            this.insertJob_button.TabIndex = 4;
            this.insertJob_button.TabStop = false;
            this.insertJob_button.Click += new System.EventHandler(this.insertJob_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Todo_List_Framework.Properties.Resources.logo_background1;
            this.pictureBox1.Location = new System.Drawing.Point(-52, 502);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 273);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // rb_complete
            // 
            this.rb_complete.AutoSize = true;
            this.rb_complete.Font = new System.Drawing.Font("MesloLGS NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_complete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.rb_complete.Location = new System.Drawing.Point(6, 78);
            this.rb_complete.Name = "rb_complete";
            this.rb_complete.Size = new System.Drawing.Size(108, 25);
            this.rb_complete.TabIndex = 4;
            this.rb_complete.Text = "complete";
            this.rb_complete.UseVisualStyleBackColor = true;
            // 
            // AddJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(450, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.state_group);
            this.Controls.Add(this.insertJob_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_request);
            this.Controls.Add(this.tb_endline);
            this.Controls.Add(this.tb_from);
            this.Controls.Add(this.lbl_jobTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddJobForm";
            this.Text = "AddJob";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddJob_FormClosing);
            this.Load += new System.EventHandler(this.AddJob_Load);
            this.state_group.ResumeLayout(false);
            this.state_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertJob_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_jobTitle;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.TextBox tb_endline;
        private System.Windows.Forms.TextBox tb_request;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox insertJob_button;
        private System.Windows.Forms.GroupBox state_group;
        private System.Windows.Forms.RadioButton rb_process;
        private System.Windows.Forms.RadioButton rb_notYet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rb_complete;
    }
}