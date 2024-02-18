using System.IO;
using System.CodeDom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static restauntPos.FoodType;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace restauntPos
{
    public partial class MenuListForm : Form
    {

        static Excel.Application excelApp = null;
        static Excel.Workbook workBook = null;
        static Excel.Worksheet workSheet = null;

        public MenuListForm()
        {
            InitializeComponent();
            drawListView(1);
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
                    value = Convert.ToBoolean(this.listView1.Columns[e.Column].Tag);
                }
                catch (Exception)
                {
                }
                this.listView1.Columns[e.Column].Tag = !value;
                foreach (ListViewItem item in this.listView1.Items) item.Checked = !value;
                this.listView1.Invalidate();
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
        public static List<MenuInfo>menuList=new List<MenuInfo>();

        private void drawListView(int i)
        {

            listView1.CheckBoxes = true;
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            ColumnHeader columnHeader_check = new System.Windows.Forms.ColumnHeader();
            ColumnHeader columnHeader_name = new System.Windows.Forms.ColumnHeader();
            ColumnHeader columnHeader_set = new System.Windows.Forms.ColumnHeader();
            ColumnHeader columnHeader_single = new System.Windows.Forms.ColumnHeader();

            switch (i)
            {
                case 1:
                    columnHeader_name.Text = "햄버거";
                    columnHeader_set.Text = "세트";
                    columnHeader_single.Text = "단품";
                    break;
                case 2:
                    columnHeader_name.Text = "치킨";
                    columnHeader_set.Text = "10조각";
                    columnHeader_single.Text = "20조각";
                    break;
                case 3:
                    columnHeader_name.Text = "사이드";
                    columnHeader_set.Text = "10조각";
                    columnHeader_single.Text = "20조각";
                    break;
                case 4:
                    columnHeader_name.Text = "음료";
                    columnHeader_set.Text = "핫";
                    columnHeader_single.Text = "아이스";
                    break;
            }

            listView1.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(drawListColumnHeader);
            listView1.DrawItem += new DrawListViewItemEventHandler(lv_DrawItem);
            listView1.DrawSubItem += new DrawListViewSubItemEventHandler(lv_DrawSubItem);
            listView1.ColumnClick += new ColumnClickEventHandler(lv_ColumnClick);

            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                        columnHeader_check, columnHeader_name,columnHeader_set,columnHeader_single});
            
            /*
            listView1.Columns.Add("햄버거", 300);
            listView1.Columns.Add("세트",100);
            listView1.Columns.Add("단품", 100);
            */
            try
            {
                string path = System.Environment.CurrentDirectory + "\\MenuList.xlsx";                              // 엑셀 파일 저장 경로

                excelApp = new Excel.Application();                             // 엑셀 어플리케이션 생성
                workBook = excelApp.Workbooks.Open(path);                       // 워크북 열기
                workSheet = workBook.Worksheets.get_Item(i) as Excel.Worksheet; // 엑셀 첫번째 워크시트 가져오기

                Excel.Range range = workSheet.UsedRange;    // 사용중인 셀 범위를 가져오기

                string[] sTemp = { "", "", "","" };
                ListViewItem newitem = new ListViewItem(sTemp);
                for (int row = 1; row <= range.Rows.Count; row++) // 가져온 행 만큼 반복
                {
                    string[] sTTemp = new string[4];
                    for (int column = 1; column <= range.Columns.Count; column++)  // 가져온 열 만큼 반복
                    {
                        string str = (string)(range.Cells[row, column] as Excel.Range).Value2;  // 셀 데이터 가져옴
                        sTTemp[column] = str;
                        
                    }
                    newitem = new ListViewItem(sTTemp);
                    menuList.Add(new MenuInfo() { category = foodType.burger, Name = sTTemp[0], price=int.Parse(sTTemp[1]) });
                    listView1.Items.Add(newitem);
                }

                workBook.Close(true);   // 워크북 닫기
                excelApp.Quit();        // 엑셀 어플리케이션 종료
            }
            finally
            {
                ReleaseObject(workSheet);
                ReleaseObject(workBook);
                ReleaseObject(excelApp);
            }
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

        private void burgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            drawListView(1);
        }

        private void chickenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            drawListView(2);
        }

        private void snackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            drawListView(3);
        }

        private void bevarageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            drawListView(4);
        }
    }
}
