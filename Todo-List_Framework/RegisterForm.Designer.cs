
namespace Todo_List_Framework
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_register = new System.Windows.Forms.PictureBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_checkpw = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.tb_gender = new System.Windows.Forms.TextBox();
            this.tb_job = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_register)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Todo_List_Framework.Properties.Resources.logo_background;
            this.pictureBox1.Location = new System.Drawing.Point(-52, 501);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 273);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pb_register
            // 
            this.pb_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_register.Image = global::Todo_List_Framework.Properties.Resources.login_button;
            this.pb_register.Location = new System.Drawing.Point(335, 504);
            this.pb_register.Name = "pb_register";
            this.pb_register.Size = new System.Drawing.Size(50, 50);
            this.pb_register.TabIndex = 1;
            this.pb_register.TabStop = false;
            this.pb_register.Click += new System.EventHandler(this.pb_register_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("MesloLGS NF", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.lbl_welcome.Location = new System.Drawing.Point(117, 46);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(267, 61);
            this.lbl_welcome.TabIndex = 2;
            this.lbl_welcome.Text = "Welcome!";
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_id.Font = new System.Drawing.Font("MesloLGS NF", 20F);
            this.tb_id.ForeColor = System.Drawing.Color.Silver;
            this.tb_id.Location = new System.Drawing.Point(115, 142);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(270, 41);
            this.tb_id.TabIndex = 3;
            this.tb_id.Text = "id or email";
            this.tb_id.Enter += new System.EventHandler(this.tb_id_Enter);
            this.tb_id.Leave += new System.EventHandler(this.tb_id_Leave);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_password.Font = new System.Drawing.Font("MesloLGS NF", 20F);
            this.tb_password.ForeColor = System.Drawing.Color.Silver;
            this.tb_password.Location = new System.Drawing.Point(115, 189);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(270, 41);
            this.tb_password.TabIndex = 3;
            this.tb_password.Text = "password";
            this.tb_password.Enter += new System.EventHandler(this.tb_password_Enter);
            this.tb_password.Leave += new System.EventHandler(this.tb_password_Leave);
            // 
            // tb_checkpw
            // 
            this.tb_checkpw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_checkpw.Font = new System.Drawing.Font("MesloLGS NF", 20F);
            this.tb_checkpw.ForeColor = System.Drawing.Color.Silver;
            this.tb_checkpw.Location = new System.Drawing.Point(115, 236);
            this.tb_checkpw.Name = "tb_checkpw";
            this.tb_checkpw.Size = new System.Drawing.Size(270, 41);
            this.tb_checkpw.TabIndex = 3;
            this.tb_checkpw.Text = "check password";
            this.tb_checkpw.Enter += new System.EventHandler(this.tb_checkpw_Enter);
            this.tb_checkpw.Leave += new System.EventHandler(this.tb_checkpw_Leave);
            // 
            // tb_phone
            // 
            this.tb_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_phone.Font = new System.Drawing.Font("MesloLGS NF", 20F);
            this.tb_phone.ForeColor = System.Drawing.Color.Silver;
            this.tb_phone.Location = new System.Drawing.Point(115, 305);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(270, 41);
            this.tb_phone.TabIndex = 3;
            this.tb_phone.Text = "phone number";
            this.tb_phone.Enter += new System.EventHandler(this.tb_phone_Enter);
            this.tb_phone.Leave += new System.EventHandler(this.tb_phone_Leave);
            // 
            // tb_age
            // 
            this.tb_age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_age.Font = new System.Drawing.Font("MesloLGS NF", 20F);
            this.tb_age.ForeColor = System.Drawing.Color.Silver;
            this.tb_age.Location = new System.Drawing.Point(115, 354);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(270, 41);
            this.tb_age.TabIndex = 3;
            this.tb_age.Text = "age";
            this.tb_age.Enter += new System.EventHandler(this.tb_age_Enter);
            this.tb_age.Leave += new System.EventHandler(this.tb_age_Leave);
            // 
            // tb_gender
            // 
            this.tb_gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_gender.Font = new System.Drawing.Font("MesloLGS NF", 20F);
            this.tb_gender.ForeColor = System.Drawing.Color.Silver;
            this.tb_gender.Location = new System.Drawing.Point(115, 401);
            this.tb_gender.Name = "tb_gender";
            this.tb_gender.Size = new System.Drawing.Size(270, 41);
            this.tb_gender.TabIndex = 3;
            this.tb_gender.Text = "gender";
            this.tb_gender.Enter += new System.EventHandler(this.tb_gender_Enter);
            this.tb_gender.Leave += new System.EventHandler(this.tb_gender_Leave);
            // 
            // tb_job
            // 
            this.tb_job.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_job.Font = new System.Drawing.Font("MesloLGS NF", 20F);
            this.tb_job.ForeColor = System.Drawing.Color.Silver;
            this.tb_job.Location = new System.Drawing.Point(115, 448);
            this.tb_job.Name = "tb_job";
            this.tb_job.Size = new System.Drawing.Size(270, 41);
            this.tb_job.TabIndex = 3;
            this.tb_job.Text = "job";
            this.tb_job.Enter += new System.EventHandler(this.tb_job_Enter);
            this.tb_job.Leave += new System.EventHandler(this.tb_job_Leave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.tb_job);
            this.Controls.Add(this.tb_gender);
            this.Controls.Add(this.tb_checkpw);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.pb_register);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_register)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_register;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_checkpw;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.TextBox tb_gender;
        private System.Windows.Forms.TextBox tb_job;
    }
}