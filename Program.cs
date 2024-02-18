using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.CodeDom;
using Excel = Microsoft.Office.Interop.Excel;
using static restauntPos.FoodType;

namespace restauntPos
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Base());
        }
        public static List<MenuInfo>tempList=new List<MenuInfo>();   //임시 주문서
    }
        
    
}
