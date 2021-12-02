
namespace Todo_List_Framework
{
    partial class AddJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddJob));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.tb_endline = new System.Windows.Forms.TextBox();
            this.tb_request = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.insertJob_button = new System.Windows.Forms.PictureBox();
            this.state_group = new System.Windows.Forms.GroupBox();
            this.rb_complete = new System.Windows.Forms.RadioButton();
            this.rb_process = new System.Windows.Forms.RadioButton();
            this.rb_notYet = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertJob_button)).BeginInit();
            this.state_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MesloLGS NF", 48F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(75, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Job";
            // 
            // tb_from
            // 
            this.tb_from.Font = new System.Drawing.Font("MesloLGS NF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_from.Location = new System.Drawing.Point(89, 176);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(270, 38);
            this.tb_from.TabIndex = 1;
            // 
            // tb_endline
            // 
            this.tb_endline.Font = new System.Drawing.Font("MesloLGS NF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endline.Location = new System.Drawing.Point(89, 220);
            this.tb_endline.Name = "tb_endline";
            this.tb_endline.Size = new System.Drawing.Size(270, 38);
            this.tb_endline.TabIndex = 1;
            // 
            // tb_request
            // 
            this.tb_request.Font = new System.Drawing.Font("MesloLGS NF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_request.Location = new System.Drawing.Point(89, 264);
            this.tb_request.Multiline = true;
            this.tb_request.Name = "tb_request";
            this.tb_request.Size = new System.Drawing.Size(270, 60);
            this.tb_request.TabIndex = 1;
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
            // insertJob_button
            // 
            this.insertJob_button.Image = global::Todo_List_Framework.Properties.Resources.login_button;
            this.insertJob_button.Location = new System.Drawing.Point(309, 521);
            this.insertJob_button.Name = "insertJob_button";
            this.insertJob_button.Size = new System.Drawing.Size(50, 50);
            this.insertJob_button.TabIndex = 4;
            this.insertJob_button.TabStop = false;
            this.insertJob_button.Click += new System.EventHandler(this.insertJob_button_Click);
            // 
            // state_group
            // 
            this.state_group.Controls.Add(this.rb_complete);
            this.state_group.Controls.Add(this.rb_process);
            this.state_group.Controls.Add(this.rb_notYet);
            this.state_group.Font = new System.Drawing.Font("MesloLGS NF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_group.Location = new System.Drawing.Point(198, 330);
            this.state_group.Name = "state_group";
            this.state_group.Size = new System.Drawing.Size(161, 153);
            this.state_group.TabIndex = 5;
            this.state_group.TabStop = false;
            this.state_group.Text = "state";
            // 
            // rb_complete
            // 
            this.rb_complete.AutoSize = true;
            this.rb_complete.Location = new System.Drawing.Point(24, 104);
            this.rb_complete.Name = "rb_complete";
            this.rb_complete.Size = new System.Drawing.Size(116, 28);
            this.rb_complete.TabIndex = 4;
            this.rb_complete.TabStop = true;
            this.rb_complete.Text = "complete";
            this.rb_complete.UseVisualStyleBackColor = true;
            // 
            // rb_process
            // 
            this.rb_process.AutoSize = true;
            this.rb_process.Location = new System.Drawing.Point(24, 70);
            this.rb_process.Name = "rb_process";
            this.rb_process.Size = new System.Drawing.Size(105, 28);
            this.rb_process.TabIndex = 4;
            this.rb_process.TabStop = true;
            this.rb_process.Text = "process";
            this.rb_process.UseVisualStyleBackColor = true;
            // 
            // rb_notYet
            // 
            this.rb_notYet.AutoSize = true;
            this.rb_notYet.Location = new System.Drawing.Point(24, 36);
            this.rb_notYet.Name = "rb_notYet";
            this.rb_notYet.Size = new System.Drawing.Size(105, 28);
            this.rb_notYet.TabIndex = 4;
            this.rb_notYet.TabStop = true;
            this.rb_notYet.Text = "not yet";
            this.rb_notYet.UseVisualStyleBackColor = true;
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(450, 700);
            this.Controls.Add(this.state_group);
            this.Controls.Add(this.insertJob_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_request);
            this.Controls.Add(this.tb_endline);
            this.Controls.Add(this.tb_from);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddJob";
            this.Text = "AddJob";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddJob_FormClosing);
            this.Load += new System.EventHandler(this.AddJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertJob_button)).EndInit();
            this.state_group.ResumeLayout(false);
            this.state_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.TextBox tb_endline;
        private System.Windows.Forms.TextBox tb_request;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox insertJob_button;
        private System.Windows.Forms.GroupBox state_group;
        private System.Windows.Forms.RadioButton rb_complete;
        private System.Windows.Forms.RadioButton rb_process;
        private System.Windows.Forms.RadioButton rb_notYet;
    }
}