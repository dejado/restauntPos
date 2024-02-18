
namespace restauntPos
{
    partial class TableList
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
            this.table = new System.Windows.Forms.Label();
            this.menulistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.table.Dock = System.Windows.Forms.DockStyle.Top;
            this.table.Font = new System.Drawing.Font("문체부 쓰기 정체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(295, 28);
            this.table.TabIndex = 0;
            this.table.Text = "table";
            this.table.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menulistBox
            // 
            this.menulistBox.FormattingEnabled = true;
            this.menulistBox.ItemHeight = 12;
            this.menulistBox.Location = new System.Drawing.Point(7, 42);
            this.menulistBox.Name = "menulistBox";
            this.menulistBox.Size = new System.Drawing.Size(279, 160);
            this.menulistBox.TabIndex = 1;
            this.menulistBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menulistBox);
            this.Controls.Add(this.table);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(295, 220);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label table;
        private System.Windows.Forms.ListBox menulistBox;
    }
}
