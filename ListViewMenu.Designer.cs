
namespace restauntPos
{
    partial class ListViewMenu
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.burgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chickenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bevarageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 27);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(477, 318);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.burgerToolStripMenuItem,
            this.chickenToolStripMenuItem,
            this.snackToolStripMenuItem,
            this.bevarageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // burgerToolStripMenuItem
            // 
            this.burgerToolStripMenuItem.Name = "burgerToolStripMenuItem";
            this.burgerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.burgerToolStripMenuItem.Text = "burger";
            // 
            // chickenToolStripMenuItem
            // 
            this.chickenToolStripMenuItem.Name = "chickenToolStripMenuItem";
            this.chickenToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.chickenToolStripMenuItem.Text = "chicken";
            // 
            // snackToolStripMenuItem
            // 
            this.snackToolStripMenuItem.Name = "snackToolStripMenuItem";
            this.snackToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.snackToolStripMenuItem.Text = "side";
            // 
            // bevarageToolStripMenuItem
            // 
            this.bevarageToolStripMenuItem.Name = "bevarageToolStripMenuItem";
            this.bevarageToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.bevarageToolStripMenuItem.Text = "bevarage";
            // 
            // ListViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ListViewMenu";
            this.Size = new System.Drawing.Size(480, 348);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem burgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chickenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bevarageToolStripMenuItem;
    }
}
