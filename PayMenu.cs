using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Diagnostics;

namespace restauntPos
{
    internal class PayMenu
    {
        private List<List<string>> tables = new List<List<string>>();
        private List<int> price = new List<int>();
        private Base baseInstance = new Base();
        private int table = 2;

        public PayMenu()
        {
            // 테이블 개수에 맞게 빈 리스트를 추가
            for (int i = 0; i < 12; i++)
            {
                tables.Add(new List<string>());
                price.Add(i);
            }
        }

        public void TableNum(int tableNum)
        {
            table = tableNum - 1;
        }

        public void Paymenu(int Price, List<string> Menu)
        {
            price.Insert(table, Price);
            baseInstance.SetPrice(price[table]);
            MessageBox.Show(table.ToString());
            // 해당 테이블에 메뉴 추가
            tables[table].AddRange(Menu);

            // 메뉴 설정 및 Base 폼 표시
            baseInstance.SetMenu(table, tables[table]);
            baseInstance.Show();
        }
    }


}
