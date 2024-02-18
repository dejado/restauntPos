namespace restauntPos
{
    partial class Base
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.orderTable5 = new System.Windows.Forms.Label();
            this.orderTable6 = new System.Windows.Forms.Label();
            this.table2 = new System.Windows.Forms.Label();
            this.table1 = new System.Windows.Forms.Label();
            this.table3 = new System.Windows.Forms.Label();
            this.table5 = new System.Windows.Forms.Label();
            this.table6 = new System.Windows.Forms.Label();
            this.table4 = new System.Windows.Forms.Label();
            this.orderTable2 = new System.Windows.Forms.Label();
            this.orderTable1 = new System.Windows.Forms.Label();
            this.orderTable3 = new System.Windows.Forms.Label();
            this.orderTable4 = new System.Windows.Forms.Label();
            this.lbNowDate = new System.Windows.Forms.Label();
            this.lbNowTime = new System.Windows.Forms.Label();
            this.staBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.매장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.포장배달ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.orderTakeout6 = new System.Windows.Forms.Label();
            this.orderTakeout5 = new System.Windows.Forms.Label();
            this.orderTakeout4 = new System.Windows.Forms.Label();
            this.orderTakeout3 = new System.Windows.Forms.Label();
            this.orderTakeout2 = new System.Windows.Forms.Label();
            this.orderTakeout1 = new System.Windows.Forms.Label();
            this.takeout2 = new System.Windows.Forms.Label();
            this.takeout1 = new System.Windows.Forms.Label();
            this.takeout3 = new System.Windows.Forms.Label();
            this.takeout4 = new System.Windows.Forms.Label();
            this.takeout5 = new System.Windows.Forms.Label();
            this.takeout6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.orderTable5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.orderTable6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.table2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.table1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.table3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.table5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.table6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.table4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.orderTable2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.orderTable1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.orderTable3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.orderTable4, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 540);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // orderTable5
            // 
            this.orderTable5.Location = new System.Drawing.Point(5, 389);
            this.orderTable5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTable5.Name = "orderTable5";
            this.orderTable5.Size = new System.Drawing.Size(319, 147);
            this.orderTable5.TabIndex = 8;
            this.orderTable5.Text = "orderTable5";
            this.orderTable5.Click += new System.EventHandler(this.orderTable5_Click);
            // 
            // orderTable6
            // 
            this.orderTable6.Location = new System.Drawing.Point(334, 389);
            this.orderTable6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTable6.Name = "orderTable6";
            this.orderTable6.Size = new System.Drawing.Size(319, 147);
            this.orderTable6.TabIndex = 7;
            this.orderTable6.Text = "orderTable6";
            this.orderTable6.Click += new System.EventHandler(this.orderTable6_Click);
            // 
            // table2
            // 
            this.table2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.table2.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.table2.Location = new System.Drawing.Point(334, 1);
            this.table2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.table2.Name = "table2";
            this.table2.Size = new System.Drawing.Size(319, 28);
            this.table2.TabIndex = 1;
            this.table2.Text = "table2";
            this.table2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table1
            // 
            this.table1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.table1.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.table1.Location = new System.Drawing.Point(5, 1);
            this.table1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(319, 28);
            this.table1.TabIndex = 0;
            this.table1.Text = "table1";
            this.table1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table3
            // 
            this.table3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.table3.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.table3.Location = new System.Drawing.Point(5, 180);
            this.table3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.table3.Name = "table3";
            this.table3.Size = new System.Drawing.Size(319, 28);
            this.table3.TabIndex = 2;
            this.table3.Text = "table3";
            this.table3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table5
            // 
            this.table5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.table5.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.table5.Location = new System.Drawing.Point(5, 359);
            this.table5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.table5.Name = "table5";
            this.table5.Size = new System.Drawing.Size(319, 28);
            this.table5.TabIndex = 4;
            this.table5.Text = "table5";
            this.table5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table6
            // 
            this.table6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.table6.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.table6.Location = new System.Drawing.Point(334, 359);
            this.table6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.table6.Name = "table6";
            this.table6.Size = new System.Drawing.Size(319, 28);
            this.table6.TabIndex = 5;
            this.table6.Text = "table6";
            this.table6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table4
            // 
            this.table4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.table4.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.table4.Location = new System.Drawing.Point(334, 180);
            this.table4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.table4.Name = "table4";
            this.table4.Size = new System.Drawing.Size(319, 28);
            this.table4.TabIndex = 3;
            this.table4.Text = "table4";
            this.table4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderTable2
            // 
            this.orderTable2.Location = new System.Drawing.Point(334, 31);
            this.orderTable2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTable2.Name = "orderTable2";
            this.orderTable2.Size = new System.Drawing.Size(319, 147);
            this.orderTable2.TabIndex = 9;
            this.orderTable2.Text = "orderTable2";
            this.orderTable2.Click += new System.EventHandler(this.orderTable2_Click);
            // 
            // orderTable1
            // 
            this.orderTable1.Location = new System.Drawing.Point(5, 31);
            this.orderTable1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTable1.Name = "orderTable1";
            this.orderTable1.Size = new System.Drawing.Size(319, 147);
            this.orderTable1.TabIndex = 6;
            this.orderTable1.Text = "orderTable1";
            this.orderTable1.Click += new System.EventHandler(this.orderTable1_Click);
            // 
            // orderTable3
            // 
            this.orderTable3.Location = new System.Drawing.Point(5, 210);
            this.orderTable3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTable3.Name = "orderTable3";
            this.orderTable3.Size = new System.Drawing.Size(319, 147);
            this.orderTable3.TabIndex = 11;
            this.orderTable3.Text = "orderTable3";
            this.orderTable3.Click += new System.EventHandler(this.orderTable3_Click);
            // 
            // orderTable4
            // 
            this.orderTable4.Location = new System.Drawing.Point(334, 210);
            this.orderTable4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTable4.Name = "orderTable4";
            this.orderTable4.Size = new System.Drawing.Size(319, 147);
            this.orderTable4.TabIndex = 10;
            this.orderTable4.Text = "orderTable4";
            this.orderTable4.Click += new System.EventHandler(this.orderTable4_Click);
            // 
            // lbNowDate
            // 
            this.lbNowDate.AutoSize = true;
            this.lbNowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNowDate.Location = new System.Drawing.Point(797, 57);
            this.lbNowDate.Name = "lbNowDate";
            this.lbNowDate.Size = new System.Drawing.Size(230, 55);
            this.lbNowDate.TabIndex = 0;
            this.lbNowDate.Text = "NowDate";
            // 
            // lbNowTime
            // 
            this.lbNowTime.AutoSize = true;
            this.lbNowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNowTime.Location = new System.Drawing.Point(797, 141);
            this.lbNowTime.Name = "lbNowTime";
            this.lbNowTime.Size = new System.Drawing.Size(234, 55);
            this.lbNowTime.TabIndex = 1;
            this.lbNowTime.Text = "NowTime";
            // 
            // staBtn
            // 
            this.staBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.staBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.staBtn.Location = new System.Drawing.Point(744, 374);
            this.staBtn.Name = "staBtn";
            this.staBtn.Size = new System.Drawing.Size(296, 80);
            this.staBtn.TabIndex = 2;
            this.staBtn.Text = "통계";
            this.staBtn.UseVisualStyleBackColor = false;
            this.staBtn.Click += new System.EventHandler(this.staBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exitBtn.Location = new System.Drawing.Point(744, 471);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(296, 80);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "종료";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDate.Location = new System.Drawing.Point(717, 70);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(87, 37);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "날짜 :";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTime.Location = new System.Drawing.Point(717, 154);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(87, 37);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "시간 :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.매장ToolStripMenuItem,
            this.포장배달ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 매장ToolStripMenuItem
            // 
            this.매장ToolStripMenuItem.Name = "매장ToolStripMenuItem";
            this.매장ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.매장ToolStripMenuItem.Text = "매장";
            this.매장ToolStripMenuItem.Click += new System.EventHandler(this.매장ToolStripMenuItem_Click);
            // 
            // 포장배달ToolStripMenuItem
            // 
            this.포장배달ToolStripMenuItem.Name = "포장배달ToolStripMenuItem";
            this.포장배달ToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.포장배달ToolStripMenuItem.Text = "포장/배달";
            this.포장배달ToolStripMenuItem.Click += new System.EventHandler(this.포장배달ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 582);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.orderTakeout6, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.orderTakeout5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.orderTakeout4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.orderTakeout3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.orderTakeout2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.orderTakeout1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.takeout2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.takeout1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.takeout3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.takeout4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.takeout5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.takeout6, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(34, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(660, 540);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // orderTakeout6
            // 
            this.orderTakeout6.Location = new System.Drawing.Point(334, 389);
            this.orderTakeout6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTakeout6.Name = "orderTakeout6";
            this.orderTakeout6.Size = new System.Drawing.Size(319, 147);
            this.orderTakeout6.TabIndex = 10;
            this.orderTakeout6.Text = "orderTakeout6";
            this.orderTakeout6.Click += new System.EventHandler(this.orderTakeout6_Click);
            // 
            // orderTakeout5
            // 
            this.orderTakeout5.Location = new System.Drawing.Point(5, 389);
            this.orderTakeout5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTakeout5.Name = "orderTakeout5";
            this.orderTakeout5.Size = new System.Drawing.Size(319, 147);
            this.orderTakeout5.TabIndex = 9;
            this.orderTakeout5.Text = "orderTakeout5";
            this.orderTakeout5.Click += new System.EventHandler(this.orderTakeout5_Click);
            // 
            // orderTakeout4
            // 
            this.orderTakeout4.Location = new System.Drawing.Point(334, 210);
            this.orderTakeout4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTakeout4.Name = "orderTakeout4";
            this.orderTakeout4.Size = new System.Drawing.Size(319, 147);
            this.orderTakeout4.TabIndex = 8;
            this.orderTakeout4.Text = "orderTakeout4";
            this.orderTakeout4.Click += new System.EventHandler(this.orderTakeout4_Click);
            // 
            // orderTakeout3
            // 
            this.orderTakeout3.Location = new System.Drawing.Point(5, 210);
            this.orderTakeout3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTakeout3.Name = "orderTakeout3";
            this.orderTakeout3.Size = new System.Drawing.Size(319, 147);
            this.orderTakeout3.TabIndex = 7;
            this.orderTakeout3.Text = "orderTakeout3";
            this.orderTakeout3.Click += new System.EventHandler(this.orderTakeout3_Click);
            // 
            // orderTakeout2
            // 
            this.orderTakeout2.Location = new System.Drawing.Point(334, 31);
            this.orderTakeout2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTakeout2.Name = "orderTakeout2";
            this.orderTakeout2.Size = new System.Drawing.Size(319, 147);
            this.orderTakeout2.TabIndex = 6;
            this.orderTakeout2.Text = "orderTakeout2";
            this.orderTakeout2.Click += new System.EventHandler(this.orderTakeout2_Click);
            // 
            // orderTakeout1
            // 
            this.orderTakeout1.Location = new System.Drawing.Point(5, 31);
            this.orderTakeout1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTakeout1.Name = "orderTakeout1";
            this.orderTakeout1.Size = new System.Drawing.Size(319, 147);
            this.orderTakeout1.TabIndex = 2;
            this.orderTakeout1.Text = "orderTakeout1";
            this.orderTakeout1.Click += new System.EventHandler(this.orderTakeout1_Click);
            // 
            // takeout2
            // 
            this.takeout2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.takeout2.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.takeout2.Location = new System.Drawing.Point(334, 1);
            this.takeout2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.takeout2.Name = "takeout2";
            this.takeout2.Size = new System.Drawing.Size(319, 28);
            this.takeout2.TabIndex = 1;
            this.takeout2.Text = "takeout2";
            this.takeout2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // takeout1
            // 
            this.takeout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.takeout1.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.takeout1.Location = new System.Drawing.Point(5, 1);
            this.takeout1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.takeout1.Name = "takeout1";
            this.takeout1.Size = new System.Drawing.Size(319, 28);
            this.takeout1.TabIndex = 0;
            this.takeout1.Text = "takeout1";
            this.takeout1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // takeout3
            // 
            this.takeout3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.takeout3.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.takeout3.Location = new System.Drawing.Point(5, 180);
            this.takeout3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.takeout3.Name = "takeout3";
            this.takeout3.Size = new System.Drawing.Size(319, 28);
            this.takeout3.TabIndex = 2;
            this.takeout3.Text = "takeout3";
            this.takeout3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // takeout4
            // 
            this.takeout4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.takeout4.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.takeout4.Location = new System.Drawing.Point(334, 180);
            this.takeout4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.takeout4.Name = "takeout4";
            this.takeout4.Size = new System.Drawing.Size(319, 28);
            this.takeout4.TabIndex = 3;
            this.takeout4.Text = "takeout4";
            this.takeout4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // takeout5
            // 
            this.takeout5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.takeout5.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.takeout5.Location = new System.Drawing.Point(5, 359);
            this.takeout5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.takeout5.Name = "takeout5";
            this.takeout5.Size = new System.Drawing.Size(319, 28);
            this.takeout5.TabIndex = 4;
            this.takeout5.Text = "takeout5";
            this.takeout5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // takeout6
            // 
            this.takeout6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.takeout6.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.takeout6.Location = new System.Drawing.Point(334, 359);
            this.takeout6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.takeout6.Name = "takeout6";
            this.takeout6.Size = new System.Drawing.Size(319, 28);
            this.takeout6.TabIndex = 5;
            this.takeout6.Text = "takeout6";
            this.takeout6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.staBtn);
            this.Controls.Add(this.lbNowTime);
            this.Controls.Add(this.lbNowDate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Base";
            this.Text = "주문 상황";
            this.Load += new System.EventHandler(this.Base_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbNowDate;
        private System.Windows.Forms.Label lbNowTime;
        private System.Windows.Forms.Button staBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 매장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 포장배달ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label table2;
        private System.Windows.Forms.Label table1;
        private System.Windows.Forms.Label table3;
        private System.Windows.Forms.Label table4;
        private System.Windows.Forms.Label table5;
        private System.Windows.Forms.Label table6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label takeout2;
        private System.Windows.Forms.Label takeout1;
        private System.Windows.Forms.Label takeout3;
        private System.Windows.Forms.Label takeout4;
        private System.Windows.Forms.Label takeout5;
        private System.Windows.Forms.Label takeout6;
        private System.Windows.Forms.Label orderTakeout1;
        private System.Windows.Forms.Label orderTable4;
        private System.Windows.Forms.Label orderTable5;
        private System.Windows.Forms.Label orderTable6;
        private System.Windows.Forms.Label orderTable2;
        private System.Windows.Forms.Label orderTable1;
        private System.Windows.Forms.Label orderTable3;
        private System.Windows.Forms.Label orderTakeout6;
        private System.Windows.Forms.Label orderTakeout5;
        private System.Windows.Forms.Label orderTakeout4;
        private System.Windows.Forms.Label orderTakeout3;
        private System.Windows.Forms.Label orderTakeout2;
    }
}

