
namespace Todo_List_Framework
{
    partial class AddContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContactForm));
            this.lbl_contactTitle = new System.Windows.Forms.Label();
            this.tb_who = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.pb_addContact = new System.Windows.Forms.PictureBox();
            this.pb_plusContactTitle = new System.Windows.Forms.PictureBox();
            this.pb_logo_bg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_plusContactTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo_bg)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_contactTitle
            // 
            this.lbl_contactTitle.AutoSize = true;
            this.lbl_contactTitle.Font = new System.Drawing.Font("MesloLGS NF", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.lbl_contactTitle.Location = new System.Drawing.Point(156, 80);
            this.lbl_contactTitle.Name = "lbl_contactTitle";
            this.lbl_contactTitle.Size = new System.Drawing.Size(237, 61);
            this.lbl_contactTitle.TabIndex = 0;
            this.lbl_contactTitle.Text = "Contact";
            // 
            // tb_who
            // 
            this.tb_who.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_who.Font = new System.Drawing.Font("MesloLGS NF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_who.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_who.Location = new System.Drawing.Point(101, 187);
            this.tb_who.Name = "tb_who";
            this.tb_who.Size = new System.Drawing.Size(270, 34);
            this.tb_who.TabIndex = 2;
            this.tb_who.Text = "who";
            this.tb_who.Enter += new System.EventHandler(this.tb_who_Enter);
            this.tb_who.Leave += new System.EventHandler(this.tb_who_Leave);
            // 
            // tb_phone
            // 
            this.tb_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_phone.Font = new System.Drawing.Font("MesloLGS NF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_phone.Location = new System.Drawing.Point(101, 227);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(270, 34);
            this.tb_phone.TabIndex = 2;
            this.tb_phone.Text = "phone";
            this.tb_phone.Enter += new System.EventHandler(this.tb_phone_Enter);
            this.tb_phone.Leave += new System.EventHandler(this.tb_phone_Leave);
            // 
            // tb_note
            // 
            this.tb_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_note.Font = new System.Drawing.Font("MesloLGS NF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_note.Location = new System.Drawing.Point(101, 267);
            this.tb_note.Multiline = true;
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(270, 100);
            this.tb_note.TabIndex = 2;
            this.tb_note.Text = "note";
            this.tb_note.Enter += new System.EventHandler(this.tb_note_Enter);
            this.tb_note.Leave += new System.EventHandler(this.tb_note_Leave);
            // 
            // pb_addContact
            // 
            this.pb_addContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_addContact.Image = global::Todo_List_Framework.Properties.Resources.login_button;
            this.pb_addContact.Location = new System.Drawing.Point(316, 522);
            this.pb_addContact.Name = "pb_addContact";
            this.pb_addContact.Size = new System.Drawing.Size(50, 50);
            this.pb_addContact.TabIndex = 3;
            this.pb_addContact.TabStop = false;
            this.pb_addContact.Click += new System.EventHandler(this.pb_addContact_Click);
            // 
            // pb_plusContactTitle
            // 
            this.pb_plusContactTitle.Image = global::Todo_List_Framework.Properties.Resources.plus_icon1;
            this.pb_plusContactTitle.Location = new System.Drawing.Point(89, 80);
            this.pb_plusContactTitle.Name = "pb_plusContactTitle";
            this.pb_plusContactTitle.Size = new System.Drawing.Size(61, 61);
            this.pb_plusContactTitle.TabIndex = 1;
            this.pb_plusContactTitle.TabStop = false;
            // 
            // pb_logo_bg
            // 
            this.pb_logo_bg.Image = global::Todo_List_Framework.Properties.Resources.logo_background2;
            this.pb_logo_bg.Location = new System.Drawing.Point(-52, 502);
            this.pb_logo_bg.Name = "pb_logo_bg";
            this.pb_logo_bg.Size = new System.Drawing.Size(287, 273);
            this.pb_logo_bg.TabIndex = 6;
            this.pb_logo_bg.TabStop = false;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(450, 700);
            this.Controls.Add(this.pb_logo_bg);
            this.Controls.Add(this.pb_addContact);
            this.Controls.Add(this.tb_note);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_who);
            this.Controls.Add(this.pb_plusContactTitle);
            this.Controls.Add(this.lbl_contactTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddContactForm";
            this.Text = "Add Contact";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_addContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_plusContactTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo_bg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_contactTitle;
        private System.Windows.Forms.PictureBox pb_plusContactTitle;
        private System.Windows.Forms.TextBox tb_who;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.PictureBox pb_addContact;
        private System.Windows.Forms.PictureBox pb_logo_bg;
    }
}