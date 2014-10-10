using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIV_Crafting_Calculator
{
    class Item
    {
        public string Name;
        public int Quantity;
        public decimal Price;
        public bool fromShop = false;

        public void ClearQuantity()
        {
            Quantity = 0;
        }
    }
}
