
namespace Todo_List_Framework
{
    partial class AddNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNoteForm));
            this.tb_content = new System.Windows.Forms.TextBox();
            this.lbl_noteTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_addNote = new System.Windows.Forms.PictureBox();
            this.pb_plusNoteTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_plusNoteTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_content
            // 
            this.tb_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_content.Font = new System.Drawing.Font("MesloLGS NF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_content.Location = new System.Drawing.Point(90, 182);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.Size = new System.Drawing.Size(270, 300);
            this.tb_content.TabIndex = 2;
            this.tb_content.Text = "Content";
            this.tb_content.Enter += new System.EventHandler(this.tb_content_Enter);
            this.tb_content.Leave += new System.EventHandler(this.tb_content_Leave);
            // 
            // lbl_noteTitle
            // 
            this.lbl_noteTitle.AutoSize = true;
            this.lbl_noteTitle.Font = new System.Drawing.Font("MesloLGS NF", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noteTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.lbl_noteTitle.Location = new System.Drawing.Point(199, 81);
            this.lbl_noteTitle.Name = "lbl_noteTitle";
            this.lbl_noteTitle.Size = new System.Drawing.Size(147, 61);
            this.lbl_noteTitle.TabIndex = 4;
            this.lbl_noteTitle.Text = "Note";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Todo_List_Framework.Properties.Resources.logo_background2;
            this.pictureBox1.Location = new System.Drawing.Point(-52, 502);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 273);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pb_addNote
            // 
            this.pb_addNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_addNote.Image = global::Todo_List_Framework.Properties.Resources.login_button;
            this.pb_addNote.Location = new System.Drawing.Point(316, 522);
            this.pb_addNote.Name = "pb_addNote";
            this.pb_addNote.Size = new System.Drawing.Size(50, 50);
            this.pb_addNote.TabIndex = 3;
            this.pb_addNote.TabStop = false;
            this.pb_addNote.Click += new System.EventHandler(this.pb_addNote_Click);
            // 
            // pb_plusNoteTitle
            // 
            this.pb_plusNoteTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pb_plusNoteTitle.Image = global::Todo_List_Framework.Properties.Resources.plus_icon;
            this.pb_plusNoteTitle.Location = new System.Drawing.Point(132, 81);
            this.pb_plusNoteTitle.Name = "pb_plusNoteTitle";
            this.pb_plusNoteTitle.Size = new System.Drawing.Size(61, 61);
            this.pb_plusNoteTitle.TabIndex = 0;
            this.pb_plusNoteTitle.TabStop = false;
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(450, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_noteTitle);
            this.Controls.Add(this.pb_addNote);
            this.Controls.Add(this.tb_content);
            this.Controls.Add(this.pb_plusNoteTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNoteForm";
            this.Text = "AddNoteForm";
            this.Load += new System.EventHandler(this.AddNoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_plusNoteTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_plusNoteTitle;
        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.PictureBox pb_addNote;
        private System.Windows.Forms.Label lbl_noteTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}