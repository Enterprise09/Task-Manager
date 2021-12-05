
namespace Todo_List_Framework.ucView
{
    partial class NoteView
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_delete_note = new System.Windows.Forms.PictureBox();
            this.lbl_register_date = new System.Windows.Forms.Label();
            this.tb_content = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_delete_note)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_delete_note
            // 
            this.pb_delete_note.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_delete_note.Image = global::Todo_List_Framework.Properties.Resources.yellow_del_button1;
            this.pb_delete_note.Location = new System.Drawing.Point(219, 14);
            this.pb_delete_note.Name = "pb_delete_note";
            this.pb_delete_note.Size = new System.Drawing.Size(33, 8);
            this.pb_delete_note.TabIndex = 1;
            this.pb_delete_note.TabStop = false;
            this.pb_delete_note.Click += new System.EventHandler(this.pb_delete_note_Click);
            // 
            // lbl_register_date
            // 
            this.lbl_register_date.AutoSize = true;
            this.lbl_register_date.Font = new System.Drawing.Font("MesloLGS NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lbl_register_date.Location = new System.Drawing.Point(15, 8);
            this.lbl_register_date.Name = "lbl_register_date";
            this.lbl_register_date.Size = new System.Drawing.Size(153, 21);
            this.lbl_register_date.TabIndex = 3;
            this.lbl_register_date.Text = "register_date";
            // 
            // tb_content
            // 
            this.tb_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.tb_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_content.Font = new System.Drawing.Font("MesloLGS NF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_content.Location = new System.Drawing.Point(15, 40);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.ReadOnly = true;
            this.tb_content.Size = new System.Drawing.Size(240, 245);
            this.tb_content.TabIndex = 0;
            this.tb_content.Text = "Content";
            // 
            // NoteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbl_register_date);
            this.Controls.Add(this.pb_delete_note);
            this.Controls.Add(this.tb_content);
            this.Name = "NoteView";
            this.Padding = new System.Windows.Forms.Padding(15, 40, 15, 15);
            this.Size = new System.Drawing.Size(270, 300);
            ((System.ComponentModel.ISupportInitialize)(this.pb_delete_note)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_delete_note;
        internal System.Windows.Forms.Label lbl_register_date;
        internal System.Windows.Forms.TextBox tb_content;
    }
}
