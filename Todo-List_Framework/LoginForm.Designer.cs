
namespace Todo_List_Framework
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_login_id = new System.Windows.Forms.TextBox();
            this.tb_login_pw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_register = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MesloLGS NF", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(42, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi There!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MesloLGS NF", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(121, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Get some important thing that manage\r\nyour own loutine and get some break!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MesloLGS NF", 38F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(82, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "Task-Board";
            // 
            // tb_login_id
            // 
            this.tb_login_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_login_id.Font = new System.Drawing.Font("MesloLGS NF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login_id.ForeColor = System.Drawing.Color.Silver;
            this.tb_login_id.Location = new System.Drawing.Point(115, 315);
            this.tb_login_id.MaxLength = 20;
            this.tb_login_id.Name = "tb_login_id";
            this.tb_login_id.Size = new System.Drawing.Size(270, 38);
            this.tb_login_id.TabIndex = 1;
            this.tb_login_id.TabStop = false;
            this.tb_login_id.Text = "id or email";
            this.tb_login_id.Enter += new System.EventHandler(this.tb_login_id_Enter);
            this.tb_login_id.Leave += new System.EventHandler(this.tb_login_id_Leave);
            // 
            // tb_login_pw
            // 
            this.tb_login_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_login_pw.Font = new System.Drawing.Font("MesloLGS NF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login_pw.ForeColor = System.Drawing.Color.Silver;
            this.tb_login_pw.Location = new System.Drawing.Point(115, 365);
            this.tb_login_pw.MaxLength = 20;
            this.tb_login_pw.Name = "tb_login_pw";
            this.tb_login_pw.Size = new System.Drawing.Size(270, 38);
            this.tb_login_pw.TabIndex = 1;
            this.tb_login_pw.Text = "password";
            this.tb_login_pw.Enter += new System.EventHandler(this.tb_login_pw_Enter);
            this.tb_login_pw.Leave += new System.EventHandler(this.tb_login_pw_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MesloLGS NF", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label4.Location = new System.Drawing.Point(167, 661);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "your are not member?";
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_register.Font = new System.Drawing.Font("MesloLGS NF", 13F);
            this.lbl_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lbl_register.Location = new System.Drawing.Point(383, 660);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(98, 23);
            this.lbl_register.TabIndex = 3;
            this.lbl_register.Text = "Register";
            this.lbl_register.Click += new System.EventHandler(this.lbl_register_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Todo_List_Framework.Properties.Resources.logo_background;
            this.pictureBox2.Location = new System.Drawing.Point(-52, 501);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 273);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pb_login
            // 
            this.pb_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_login.Image = global::Todo_List_Framework.Properties.Resources.login_button;
            this.pb_login.Location = new System.Drawing.Point(345, 440);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(50, 50);
            this.pb_login.TabIndex = 2;
            this.pb_login.TabStop = false;
            this.pb_login.Click += new System.EventHandler(this.pb_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.pb_login);
            this.Controls.Add(this.tb_login_pw);
            this.Controls.Add(this.tb_login_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_login_id;
        private System.Windows.Forms.TextBox tb_login_pw;
        private System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}