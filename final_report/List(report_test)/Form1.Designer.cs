namespace List_report_test_
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.titlebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.commentbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlebox
            // 
            this.titlebox.Location = new System.Drawing.Point(651, 53);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(432, 35);
            this.titlebox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "title";
            // 
            // commentbox
            // 
            this.commentbox.Location = new System.Drawing.Point(651, 119);
            this.commentbox.Multiline = true;
            this.commentbox.Name = "commentbox";
            this.commentbox.Size = new System.Drawing.Size(432, 118);
            this.commentbox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "comment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 839);
            this.Controls.Add(this.commentbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commentbox;
        private System.Windows.Forms.Label label2;
    }
}

