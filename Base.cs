using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauntPos
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();

        }

        private void Base_Load(object sender, EventArgs e)
        {
            this.lbNowDate.Text = DateTime.Now.ToString("yyyy.mm.dd");
            this.lbNowTime.Text = DateTime.Now.ToString("tt hh:mm:ss");
            panel1.Visible = false;
            

        }


        private void staBtn_Click(object sender, EventArgs e)
        {

        }

        private void 매장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void 포장배달ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        public string[] order = new string[3];

        public void FormShow()
        {
            Order orderTable = new Order(this);
            orderTable.Owner = this;
            Label[] tableNum = new Label[] { table1,table2,table3,table4,table5,table6,
            orderTable6,takeout1, takeout2, takeout3, takeout4, takeout5, takeout6};
            string name=tableNum[numTable-1].Text;
            PayMenu paymenu = new PayMenu();
            paymenu.TableNum(numTable);
            orderTable.SetText(name);
            orderTable.Show();
            Hide();
        }
        string price = string.Empty;

        public void SetPrice(int price)
        {
            Label[] tables= new Label[] { table1, table2, table3, table4, table5, table6,
                takeout1, takeout2, takeout3, takeout4, takeout5, takeout6 };
            int index = numTable - 1;
            if (index >= 0 && index < tables.Length)
                tables[numTable - 1].Text += " :" + price.ToString() + "원";
            else
                MessageBox.Show("인덱스가 범위에서 벗어남:" + index);
        }
        public void SetMenu(int tableNum,List<string>Menu)
        {
            Label[] OrderMenu = new Label[] {orderTable1,orderTable2,orderTable3,orderTable4,orderTable5,orderTable6,
            orderTakeout1,orderTakeout2, orderTakeout3,orderTakeout4, orderTakeout5,orderTakeout6};
            int food = 0;
            OrderMenu[tableNum].Text = "";
            MessageBox.Show(tableNum.ToString());
            foreach (var menu in Menu) {
                //OrderMenu[numTable - 1].Text +=menu;
                food++;
                if (food % 3 == 0)
                    OrderMenu[tableNum].Text += menu+"\n";
                else
                    OrderMenu[tableNum].Text += menu+"*";
            }
        }
        int numTable = 1;
        private void orderTakeout1_Click(object sender, EventArgs e)
        {
            numTable = 7;
            FormShow();
        }

        private void orderTakeout2_Click(object sender, EventArgs e)
        {
            numTable = 8;
            FormShow();
        }

        private void orderTakeout3_Click(object sender, EventArgs e)
        {
            numTable = 9;
            FormShow();
        }

        private void orderTakeout4_Click(object sender, EventArgs e)
        {
            numTable = 10;
            FormShow();
        }

        private void orderTakeout5_Click(object sender, EventArgs e)
        {
            numTable = 11;
            FormShow();
        }

        private void orderTakeout6_Click(object sender, EventArgs e)
        {
            numTable = 12;
            FormShow();
        }

        private void orderTable4_Click(object sender, EventArgs e)
        {
            numTable = 4;
            FormShow();
        }

        private void orderTable2_Click(object sender, EventArgs e)
        {
            numTable = 2;
            FormShow();
        }

        private void orderTable3_Click(object sender, EventArgs e)
        {
            numTable = 3;
            FormShow();
        }

        private void orderTable1_Click(object sender, EventArgs e)
        {
            numTable = 1;
            FormShow();
        }

        private void orderTable5_Click(object sender, EventArgs e)
        {
            numTable = 5;
            FormShow();
        }

        private void orderTable6_Click(object sender, EventArgs e)
        {
            numTable = 6;
            FormShow();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }




        /*
            private void timer1_Tick(object sender, EventArgs e)
            {
                this.lbNowDate.Text = DateTime.Now.ToString("yyyy.mm.dd");
                this.lbNowTime.Text = DateTime.Now.ToString("HH.mm.ss");
            }
        */
    }
}
