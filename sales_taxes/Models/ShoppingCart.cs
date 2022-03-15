using System;

namespace sales_taxes.Models 
{
    public class ShoppingCart 
    {

        public List<Item> List {get;set;}
        public double Total {
            get
            {
                double _total = 0.00;
                foreach(var itm in List)
                    _total += itm.Price;
                return _total;
            }
        }
        public ShoppingCart() {
            List = new List<Item>();
        }
    }
}