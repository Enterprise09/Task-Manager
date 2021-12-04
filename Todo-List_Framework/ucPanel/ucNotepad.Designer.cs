
namespace Todo_List_Framework.ucPanel
{
    partial class ucNotepad
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
            this.label1 = new System.Windows.Forms.Label();
            this.pb_AddNote = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AddNote)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MesloLGS NF", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notepad";
            // 
            // pb_AddNote
            // 
            this.pb_AddNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_AddNote.Image = global::Todo_List_Framework.Properties.Resources.addJob_button;
            this.pb_AddNote.Location = new System.Drawing.Point(1260, 840);
            this.pb_AddNote.Name = "pb_AddNote";
            this.pb_AddNote.Size = new System.Drawing.Size(70, 70);
            this.pb_AddNote.TabIndex = 1;
            this.pb_AddNote.TabStop = false;
            this.pb_AddNote.Click += new System.EventHandler(this.pb_AddNote_Click);
            // 
            // ucNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pb_AddNote);
            this.Controls.Add(this.label1);
            this.Name = "ucNotepad";
            this.Size = new System.Drawing.Size(1376, 941);
            ((System.ComponentModel.ISupportInitialize)(this.pb_AddNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_AddNote;
    }
}
