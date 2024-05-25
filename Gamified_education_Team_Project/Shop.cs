using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamified_education_Team_Project
{
    class Shop
    {
        private ShopElement shopElement;

        public Shop(ShopElement shopElement)
        {
            this.shopElement = shopElement;
        }

        public void OutputShopList()
        {
            Console.WriteLine("list");
        }

        public void BuyElement()
        {
            Console.WriteLine("Buy");
        }
    }
}
