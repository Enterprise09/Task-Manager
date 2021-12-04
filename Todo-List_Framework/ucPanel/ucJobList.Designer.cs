
namespace Todo_List_Framework.ucPanel
{
    partial class ucJobList
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
            this.pb_addJob = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addJob)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_addJob
            // 
            this.pb_addJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_addJob.Image = global::Todo_List_Framework.Properties.Resources.addJob_button;
            this.pb_addJob.Location = new System.Drawing.Point(1264, 840);
            this.pb_addJob.Name = "pb_addJob";
            this.pb_addJob.Size = new System.Drawing.Size(70, 70);
            this.pb_addJob.TabIndex = 1;
            this.pb_addJob.TabStop = false;
            this.pb_addJob.Click += new System.EventHandler(this.pb_addJob_Click);
            // 
            // ucJobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pb_addJob);
            this.Name = "ucJobList";
            this.Size = new System.Drawing.Size(1376, 941);
            ((System.ComponentModel.ISupportInitialize)(this.pb_addJob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_addJob;
    }
}
