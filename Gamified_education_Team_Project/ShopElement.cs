using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamified_education_Team_Project
{
    class ShopElement
    {
        private string elementName;
        private int price;

        public ShopElement(string elementName, int price)
        {
            this.elementName = elementName;
            this.price = price;
        }

        public string ElementName 
        { 
            get => this.elementName;
        }

        public int Price
        {
            get => this.price;
        }

        public void OutputShopElementInfo()
        {
            Console.WriteLine("Shop el info");
        }
    }
}
