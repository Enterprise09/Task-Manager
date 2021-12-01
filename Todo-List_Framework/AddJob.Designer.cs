
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_process = new System.Windows.Forms.CheckBox();
            this.cb_notYet = new System.Windows.Forms.CheckBox();
            this.cb_complete = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MesloLGS NF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(89, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 38);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MesloLGS NF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(89, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 38);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MesloLGS NF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(89, 264);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(270, 60);
            this.textBox3.TabIndex = 1;
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
            // cb_process
            // 
            this.cb_process.AutoSize = true;
            this.cb_process.Font = new System.Drawing.Font("MesloLGS NF", 16F);
            this.cb_process.Location = new System.Drawing.Point(237, 330);
            this.cb_process.Name = "cb_process";
            this.cb_process.Size = new System.Drawing.Size(122, 31);
            this.cb_process.TabIndex = 3;
            this.cb_process.Text = "process";
            this.cb_process.UseVisualStyleBackColor = true;
            // 
            // cb_notYet
            // 
            this.cb_notYet.AutoSize = true;
            this.cb_notYet.Font = new System.Drawing.Font("MesloLGS NF", 16F);
            this.cb_notYet.Location = new System.Drawing.Point(237, 367);
            this.cb_notYet.Name = "cb_notYet";
            this.cb_notYet.Size = new System.Drawing.Size(122, 31);
            this.cb_notYet.TabIndex = 3;
            this.cb_notYet.Text = "not yet";
            this.cb_notYet.UseVisualStyleBackColor = true;
            // 
            // cb_complete
            // 
            this.cb_complete.AutoSize = true;
            this.cb_complete.Font = new System.Drawing.Font("MesloLGS NF", 16F);
            this.cb_complete.Location = new System.Drawing.Point(237, 404);
            this.cb_complete.Name = "cb_complete";
            this.cb_complete.Size = new System.Drawing.Size(135, 31);
            this.cb_complete.TabIndex = 3;
            this.cb_complete.Text = "complete";
            this.cb_complete.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Todo_List_Framework.Properties.Resources.login_button;
            this.pictureBox2.Location = new System.Drawing.Point(316, 522);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(450, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cb_complete);
            this.Controls.Add(this.cb_notYet);
            this.Controls.Add(this.cb_process);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddJob";
            this.Text = "AddJob";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddJob_FormClosing);
            this.Load += new System.EventHandler(this.AddJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cb_process;
        private System.Windows.Forms.CheckBox cb_notYet;
        private System.Windows.Forms.CheckBox cb_complete;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}