using System;
using sales_taxes.Models;

namespace sales_taxes 
{

    public interface ISalesTaxCalc 
    {

        public void CalcShoppingCart(ShoppingCart cart) {}
        public void PrintCalculatedShoppingCart() {}
    }

}