using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauntPos
{
    public partial class MenuList : UserControl
    {
        private MenuInfo menuInfo = new MenuInfo();
        public event EventHandler onMenuClick;

        public MenuList(MenuInfo menuList)
        {
            InitializeComponent();
            SetData(menuList);

        }

        private void SetData(MenuInfo menuList)
        {
            menuInfo = menuList;
            pictureBox1.Image = Image.FromFile(menuList.imagePath);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            MenuName.Text = menuList.Name;
            MenuPrice.Text = Convert.ToString(menuList.price)+"원";
        }

        private void MenuList_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(onMenuClick != null)
                onMenuClick(this, null);
        }
        public MenuInfo GetData()
        {
            return menuInfo;
        }
    }
}
