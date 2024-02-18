namespace restauntPos
{
    partial class Order
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnburger = new System.Windows.Forms.Button();
            this.btnchicken = new System.Windows.Forms.Button();
            this.btnside = new System.Windows.Forms.Button();
            this.btnbeverage = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btAllCancel = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.OrderListView = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btPay = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTableNum = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.MenuListView = new System.Windows.Forms.ListView();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnburger);
            this.flowLayoutPanel2.Controls.Add(this.btnchicken);
            this.flowLayoutPanel2.Controls.Add(this.btnside);
            this.flowLayoutPanel2.Controls.Add(this.btnbeverage);
            this.flowLayoutPanel2.Controls.Add(this.MenuPanel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(466, 69);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(651, 70);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnburger
            // 
            this.btnburger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnburger.Location = new System.Drawing.Point(3, 3);
            this.btnburger.Name = "btnburger";
            this.btnburger.Size = new System.Drawing.Size(157, 63);
            this.btnburger.TabIndex = 1;
            this.btnburger.Text = "버거";
            this.btnburger.UseVisualStyleBackColor = false;
            this.btnburger.Click += new System.EventHandler(this.btnburger_Click);
            // 
            // btnchicken
            // 
            this.btnchicken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnchicken.Location = new System.Drawing.Point(166, 3);
            this.btnchicken.Name = "btnchicken";
            this.btnchicken.Size = new System.Drawing.Size(157, 63);
            this.btnchicken.TabIndex = 2;
            this.btnchicken.Text = "치킨";
            this.btnchicken.UseVisualStyleBackColor = false;
            this.btnchicken.Click += new System.EventHandler(this.btnchicken_Click);
            // 
            // btnside
            // 
            this.btnside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnside.Location = new System.Drawing.Point(329, 3);
            this.btnside.Name = "btnside";
            this.btnside.Size = new System.Drawing.Size(157, 63);
            this.btnside.TabIndex = 3;
            this.btnside.Text = "사이드";
            this.btnside.UseVisualStyleBackColor = false;
            this.btnside.Click += new System.EventHandler(this.btnside_Click);
            // 
            // btnbeverage
            // 
            this.btnbeverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnbeverage.Location = new System.Drawing.Point(3, 72);
            this.btnbeverage.Name = "btnbeverage";
            this.btnbeverage.Size = new System.Drawing.Size(157, 63);
            this.btnbeverage.TabIndex = 4;
            this.btnbeverage.Text = "음료";
            this.btnbeverage.UseVisualStyleBackColor = false;
            this.btnbeverage.Click += new System.EventHandler(this.btnbeverage_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Location = new System.Drawing.Point(3, 141);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(639, 526);
            this.MenuPanel.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btAllCancel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btCancel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btMinus, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btAdd, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btOrder, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(240, 362);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(226, 240);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btAllCancel
            // 
            this.btAllCancel.Location = new System.Drawing.Point(3, 195);
            this.btAllCancel.Name = "btAllCancel";
            this.btAllCancel.Size = new System.Drawing.Size(220, 42);
            this.btAllCancel.TabIndex = 5;
            this.btAllCancel.Text = "전체취소";
            this.btAllCancel.UseVisualStyleBackColor = true;
            this.btAllCancel.Click += new System.EventHandler(this.btAllCancel_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(3, 147);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(220, 42);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "취소";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(3, 99);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(220, 42);
            this.btMinus.TabIndex = 3;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(3, 51);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(220, 42);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btOrder
            // 
            this.btOrder.Location = new System.Drawing.Point(3, 3);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(220, 42);
            this.btOrder.TabIndex = 1;
            this.btOrder.Text = "주문하기";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // OrderListView
            // 
            this.OrderListView.GridLines = true;
            this.OrderListView.HideSelection = false;
            this.OrderListView.Location = new System.Drawing.Point(0, 3);
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.Size = new System.Drawing.Size(465, 354);
            this.OrderListView.TabIndex = 0;
            this.OrderListView.UseCompatibleStateImageBehavior = false;
            this.OrderListView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OrderListView_ItemCheck);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OrderListView);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 602);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btPay);
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Controls.Add(this.lbTableNum);
            this.panel2.Controls.Add(this.btBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 66);
            this.panel2.TabIndex = 5;
            // 
            // btPay
            // 
            this.btPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btPay.Location = new System.Drawing.Point(944, 3);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(169, 63);
            this.btPay.TabIndex = 9;
            this.btPay.Text = "결제하기";
            this.btPay.UseVisualStyleBackColor = false;
            this.btPay.Click += new System.EventHandler(this.btPay_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.Location = new System.Drawing.Point(726, 6);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(150, 57);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "총 금액 : ";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(484, 4);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(150, 57);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "TimeDate";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTableNum
            // 
            this.lbTableNum.Location = new System.Drawing.Point(193, 6);
            this.lbTableNum.Name = "lbTableNum";
            this.lbTableNum.Size = new System.Drawing.Size(150, 57);
            this.lbTableNum.TabIndex = 6;
            this.lbTableNum.Text = "table_num";
            this.lbTableNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btBack.Location = new System.Drawing.Point(3, 3);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(169, 63);
            this.btBack.TabIndex = 6;
            this.btBack.Text = "뒤로가기";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // MenuListView
            // 
            this.MenuListView.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MenuListView.HideSelection = false;
            this.MenuListView.Location = new System.Drawing.Point(466, 141);
            this.MenuListView.Margin = new System.Windows.Forms.Padding(4);
            this.MenuListView.Name = "MenuListView";
            this.MenuListView.OwnerDraw = true;
            this.MenuListView.Size = new System.Drawing.Size(650, 510);
            this.MenuListView.TabIndex = 6;
            this.MenuListView.UseCompatibleStateImageBehavior = false;
            this.MenuListView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.MenuListView_ItemCheck);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 670);
            this.Controls.Add(this.MenuListView);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnburger;
        private System.Windows.Forms.Button btnchicken;
        private System.Windows.Forms.Button btnside;
        private System.Windows.Forms.Button btnbeverage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView OrderListView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAllCancel;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label lbTableNum;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button btPay;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.ListView MenuListView;
    }
}