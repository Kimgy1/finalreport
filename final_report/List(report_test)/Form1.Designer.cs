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
            this.comboBox_check = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.check2 = new System.Windows.Forms.RadioButton();
            this.check1 = new System.Windows.Forms.RadioButton();
            this.save_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.delbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // comboBox_check
            // 
            this.comboBox_check.FormattingEnabled = true;
            this.comboBox_check.Items.AddRange(new object[] {
            "과제",
            "시험"});
            this.comboBox_check.Location = new System.Drawing.Point(651, 264);
            this.comboBox_check.Name = "comboBox_check";
            this.comboBox_check.Size = new System.Drawing.Size(187, 32);
            this.comboBox_check.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "선택";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.check2);
            this.groupBox2.Controls.Add(this.check1);
            this.groupBox2.Location = new System.Drawing.Point(37, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 87);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "중요도";
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(196, 38);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(89, 28);
            this.check2.TabIndex = 1;
            this.check2.TabStop = true;
            this.check2.Text = "보통";
            this.check2.UseVisualStyleBackColor = true;
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(14, 38);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(89, 28);
            this.check1.TabIndex = 0;
            this.check1.TabStop = true;
            this.check1.Text = "중요";
            this.check1.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(510, 360);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(573, 74);
            this.save_button.TabIndex = 25;
            this.save_button.Text = "등록";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.delbutton);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(37, 457);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 362);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "check";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "과제",
            "시험"});
            this.comboBox1.Location = new System.Drawing.Point(24, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 32);
            this.comboBox1.TabIndex = 3;
            // 
            // delbutton
            // 
            this.delbutton.Location = new System.Drawing.Point(817, 26);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(229, 52);
            this.delbutton.TabIndex = 2;
            this.delbutton.Text = "일정삭제";
            this.delbutton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 839);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox_check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commentbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "List";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commentbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton check2;
        private System.Windows.Forms.RadioButton check1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

