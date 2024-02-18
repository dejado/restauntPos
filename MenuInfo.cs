using static restauntPos.FoodType;
using static restauntPos.ChooseSet;

namespace restauntPos
{
    public class MenuInfo
    {
        public foodType category = foodType.none;
        public chooseSet chose1 = chooseSet.none;

        private string name;

        public int price =0;
        public int cnt = 0;
        public string imagePath=string.Empty;
        public string barcodeString = string.Empty;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                imagePath = SetImagePath(category, name);
            }
        }

        public string SetImagePath(foodType category,string name)
        {
            string path = string.Empty;
            string RootPath = System.Environment.CurrentDirectory;

            switch(category)
            {
                case foodType.total:
                    RootPath += "\\total\\";
                    break;
                case foodType.burger:
                    RootPath += "\\burger\\";
                    break;
                case foodType.chicken:
                    RootPath += "\\chicken\\";
                    break;
                case foodType.side:
                    RootPath += "\\side\\";
                    break;
                case foodType.bevarage:
                    RootPath += "\\bevarage\\";
                    break;
                default:
                    break;
            }
            path = RootPath + name + ".png";
            return path;
        }
    }
}