using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace restauntPos
{
    public partial class TableList : UserControl
    {
        public string tableNumber = string.Empty;
        
        public TableList()
        {
            InitializeComponent();
        }
        public void SetTableNum(string tableNum)
        {
            this.tableNumber = tableNum;
        }
        /*
        public void SetTableNumberlabel(string num)
        {
            this.lbTableNumber.text = this.tableNumber;
            this.tableNumber = num;
        }
        public void SetListBox()
        {
            menulistBox.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                menulistBox.Items.Add();
            }
        }
        */
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
