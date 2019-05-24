namespace A07_DataBase
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtSId = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.SId = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(262, 229);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 18);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(262, 199);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 18);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(262, 168);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 18);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(191, 229);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 18);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(191, 199);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 18);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(191, 168);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(66, 18);
            this.btnInsert.TabIndex = 26;
            this.btnInsert.Text = "추가";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(191, 138);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(66, 18);
            this.btnViewAll.TabIndex = 25;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(76, 229);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(88, 21);
            this.txtPhone.TabIndex = 24;
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(76, 199);
            this.txtSName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(88, 21);
            this.txtSName.TabIndex = 23;
            // 
            // txtSId
            // 
            this.txtSId.Location = new System.Drawing.Point(76, 168);
            this.txtSId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSId.Name = "txtSId";
            this.txtSId.Size = new System.Drawing.Size(88, 21);
            this.txtSId.TabIndex = 22;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(76, 138);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(88, 21);
            this.txtID.TabIndex = 21;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(12, 232);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(53, 12);
            this.Phone.TabIndex = 20;
            this.Phone.Text = "전화번호";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(12, 202);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(29, 12);
            this.Name.TabIndex = 19;
            this.Name.Text = "이름";
            // 
            // SId
            // 
            this.SId.AutoSize = true;
            this.SId.Location = new System.Drawing.Point(12, 171);
            this.SId.Name = "SId";
            this.SId.Size = new System.Drawing.Size(29, 12);
            this.SId.TabIndex = 18;
            this.SId.Text = "학번";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(12, 141);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(16, 12);
            this.ID.TabIndex = 17;
            this.ID.Text = "ID";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 11);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(334, 112);
            this.listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 260);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.txtSId);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.SId);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.listBox1);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtSId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label SId;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ListBox listBox1;
    }
}

