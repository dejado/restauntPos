using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static restauntPos.FoodType;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;


namespace restauntPos
{
    public partial class Order : Form
    {
        Base myBase;
        static Excel.Application excelApp = null;
        static Excel.Workbook workBook = null;
        static Excel.Worksheet workSheet = null;


        public delegate void OrderCompleteHandler(object sender,EventArgs e);
        public OrderCompleteHandler OrderComplete;

        public delegate void SetListBox();
        public event SetListBox setListBox;

        // public static List<Order> orders = new List<Order>();
        string tableNum = string.Empty;
        
        public Order(Base b)
        {
           InitializeComponent();
            myBase = b;
           
        }
        public void SetText(string tNum)
        {
            tableNum = tNum;
        }

        private void OrderMenuSet()
        {
            OrderListView.View = View.Details;
            OrderListView.GridLines=true;
            OrderListView.FullRowSelect=true;
            OrderListView.CheckBoxes=true;

            OrderListView.Columns.Add("메뉴", 150);
            OrderListView.Columns.Add("가격", 100);
            OrderListView.Columns.Add("수량", 100);
        }
       
        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
            myBase.Show();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            drawListView(1);
            OrderMenuSet();
            SumPrice();
            price = 0;

            this.lbDate.Text = DateTime.Now.ToString("MM.dd. tt hh:mm");
            lbTableNum.Text = tableNum;


        }

        private void drawListColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.DrawBackground();
                bool value = false;
                try
                {
                    value = Convert.ToBoolean(e.Header.Tag);
                }
                catch (Exception)
                {
                }
                CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(e.Bounds.Left + 4, e.Bounds.Top + 4),
                    value ? System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal :
                    System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            }
            else e.DrawDefault = true;
        }
        private void lv_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                bool value = false;
                try
                {
                    value = Convert.ToBoolean(this.MenuListView.Columns[e.Column].Tag);
                }
                catch (Exception)
                {
                }
                this.MenuListView.Columns[e.Column].Tag = !value;
                foreach (ListViewItem item in this.MenuListView.Items) item.Checked = !value;
                this.MenuListView.Invalidate();


            }
        }
        private void lv_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
        private void lv_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }
        public static List<MenuInfo> menuList = new List<MenuInfo>();

        private void drawListView(int i)
        {

            MenuListView.CheckBoxes = true;
            MenuListView.GridLines = true;
            MenuListView.View = View.Details;
            MenuListView.FullRowSelect = true;

            ColumnHeader columnHeader_check = new System.Windows.Forms.ColumnHeader();
            ColumnHeader columnHeader_name = new System.Windows.Forms.ColumnHeader();
            ColumnHeader columnHeader_single = new System.Windows.Forms.ColumnHeader();
            ColumnHeader columnHeader_set = new System.Windows.Forms.ColumnHeader();

            columnHeader_name.Width = 200;
            columnHeader_set.Width = 120;
            columnHeader_single.Width = 120;

            switch (i)
            {
                case 1:
                    columnHeader_name.Text = "햄버거";
                    columnHeader_single.Text = "단품";
                    columnHeader_set.Text = "세트";
                    break;
                case 2:
                    columnHeader_name.Text = "치킨";
                    columnHeader_single.Text = "small";
                    columnHeader_set.Text = "large";
                    break;
                case 3:
                    columnHeader_name.Text = "사이드";
                    columnHeader_single.Text = "10조각";
                    columnHeader_set.Text = "20조각";
                    break;
                case 4:
                    columnHeader_name.Text = "음료";
                    columnHeader_single.Text = "핫";
                    columnHeader_set.Text = "아이스";
                    break;

            }

            MenuListView.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(drawListColumnHeader);
            MenuListView.DrawItem += new DrawListViewItemEventHandler(lv_DrawItem);
            MenuListView.DrawSubItem += new DrawListViewSubItemEventHandler(lv_DrawSubItem);
            MenuListView.ColumnClick += new ColumnClickEventHandler(lv_ColumnClick);

            MenuListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                        columnHeader_check, columnHeader_name,columnHeader_single,columnHeader_set});


            try
            {
                string path = System.Environment.CurrentDirectory + "\\MenuList1.xlsx";
                excelApp = new Excel.Application();                             // 엑셀 어플리케이션 생성
                workBook = excelApp.Workbooks.Open(path);                       // 워크북 열기
                workSheet = workBook.Worksheets.get_Item(i) as Excel.Worksheet; // 엑셀 첫번째 워크시트 가져오기
                Path(path);
            }
            catch(Exception e)
            {
                var filePath=string.Empty;
                using(OpenFileDialog dlg = new OpenFileDialog())
                {
                    //바탕화면으로 기본 폴더 설정
                    dlg.InitialDirectory=Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    MessageBox.Show("파일은 C:\\Users\\joan3\\Desktop\\C\\c#\\restauntPos\\bin\\Debug 안 MenuList1.xlsx 입니다.");
                    if(dlg.ShowDialog() == DialogResult.OK)
                    { filePath = dlg.FileName; } //전체 경로와 파일명

                    string path = filePath;
                    excelApp = new Excel.Application();                             // 엑셀 어플리케이션 생성
                    workBook = excelApp.Workbooks.Open(path);                       // 워크북 열기
                    workSheet = workBook.Worksheets.get_Item(i) as Excel.Worksheet; // 엑셀 첫번째 워크시트 가져오기
                    Path(path);
                }
            }
            finally
            {
                ReleaseObject(workSheet);
                ReleaseObject(workBook);
                ReleaseObject(excelApp);
            }
        }
        private void Path(string road)
        {                      // 엑셀 파일 저장 경로

            

            Excel.Range range = workSheet.UsedRange;    // 사용중인 셀 범위를 가져오기

            string[] sTemp = { "", "", "", "" };
            ListViewItem newitem = new ListViewItem(sTemp);
            for (int row = 2; row <= range.Rows.Count; row++) // 가져온 행 만큼 반복
            {
                string[] sTTemp = new string[4];
                for (int column = 4; column <= range.Columns.Count; column++)  // 가져온 열 만큼 반복
                {
                    string str = (string)(range.Cells[row, column] as Excel.Range).Value2;  // 셀 데이터 가져옴
                    sTTemp[column - 3] = str;

                }
                newitem = new ListViewItem(sTTemp);
                //menuList.Add(new MenuInfo() { category = foodType.burger, Name = sTTemp[0], price = sTTemp[1] });
                MenuListView.Items.Add(newitem);
            }

            workBook.Close(true);   // 워크북 닫기
            excelApp.Quit();        // 엑셀 어플리케이션 종료
        }
        static void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);  // 액셀 객체 해제
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();   // 가비지 수집
            }
        }
        int categori = 1;
        private void btnburger_Click(object sender, EventArgs e)
        {
            MenuListView.Clear();
            drawListView(1);
            categori = 1;
        }

        private void btnbeverage_Click(object sender, EventArgs e)
        {
            MenuListView.Clear();
            drawListView(4);
            categori = 4;
        }

        private void btnside_Click(object sender, EventArgs e)
        {
            MenuListView.Clear();
            drawListView(3);
            categori = 3;
        }

        private void btnchicken_Click(object sender, EventArgs e)
        {
            MenuListView.Clear();
            drawListView(2);
            categori = 2;
        }

        private void MenuListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string[] sTemp = new string[3];
            ListViewItem newitem = new ListViewItem(sTemp);
            if (e.CurrentValue == CheckState.Unchecked)
            {
                int index=e.Index;
                sTemp[0] = MenuListView.Items[index].SubItems[1].Text;
                string answer=string.Empty;
                if (categori == 1)
                    answer = "세트 메뉴를 선택하시겠습니까?";
                else if (categori == 2)
                    answer = "Large 사이즈로 선택하겠습니까?";
                else if (categori == 3)
                    answer = "20조각 선택하겠습니까?";
                else
                    answer = "아이스를 선택하겠습니까?";
                if (MessageBox.Show(answer,"사이즈 선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    sTemp[1] = MenuListView.Items[index].SubItems[2].Text;
                else
                    sTemp[1] = MenuListView.Items[index].SubItems[3].Text;

                sTemp[2] = "1";
                newitem = new ListViewItem(sTemp);
                OrderListView.Items.Add(newitem);
                SumPrice();
                price = 0;

            }
            else if ((e.CurrentValue == CheckState.Checked))
            {
                //price -= Double.Parse(
                //    this.ListView1.Items[e.Index].SubItems[1].Text);
                
            }

            // Output the price to TextBox1.
            //TextBox1.Text = price.ToString();
        }


        int OrderCounter = 1;
        int index = 0;
        string[] menu = new string[3];
        private void btOrder_Click(object sender, EventArgs e)
        {
            PayMenu payMenu = new PayMenu();
            SumPrice();

            List<string> Menu = new List<string>();
            for(int i = 0; i < OrderListView.Items.Count; i++)
            {
                 Menu.Add(OrderListView.Items[i].SubItems[0].Text);
                Menu.Add(OrderListView.Items[i].SubItems[1].Text);
                 Menu.Add(OrderListView.Items[i].SubItems[2].Text);
            }
            payMenu.Paymenu(price, Menu);
            Close();
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            OrderListView.Items.RemoveAt(index);
            SumPrice();
            price = 0;

        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            OrderCounter--;
            OrderListView.Items[index].SubItems[2].Text = OrderCounter.ToString();

            if (OrderCounter==0)
                OrderListView.Items.RemoveAt(index);
            SumPrice();
            price = 0;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            OrderCounter++;
            OrderListView.Items[index].SubItems[2].Text = OrderCounter.ToString();
            SumPrice();
            price = 0;
        }

        private void btAllCancel_Click(object sender, EventArgs e)
        {
            OrderListView.Items.Clear();
            SumPrice();
            price = 0;
        }

        private void OrderListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Unchecked)
            {
                index=e.Index;
                

            }
            else if ((e.CurrentValue == CheckState.Checked))
            {

            }
        }
        int price = 0;
        private void SumPrice()
        {
            string sTemp,sTemp1;

            for (int i = 0; i < OrderListView.Items.Count; i++)
            {
                sTemp = OrderListView.Items[i].SubItems[2].Text;
                sTemp1=OrderListView.Items[i].SubItems[1].Text;
                price += int.Parse(sTemp)*int.Parse(sTemp1);
            }
            
            lbPrice.Text="총 금액: "+price.ToString()+"원";

        }

        private void btPay_Click(object sender, EventArgs e)
        {

        }
    }
}
