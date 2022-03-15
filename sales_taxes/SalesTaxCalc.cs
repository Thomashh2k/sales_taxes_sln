using System;
using sales_taxes.Models;

namespace sales_taxes 
{

    public class SalesTaxCalc : ISalesTaxCalc
    {
        public SalesTaxCalc()
        {
        }
        public ShoppingCart CalcShoppingCart(ShoppingCart cart) 
        {
            try
            {
                if (cart.List.Count == 0)
                    return null;

                for(var i = 0; i < cart.List.Count; i++) 
                {
                    double priceWithTax = 0.00;
                    //Check if item has basic taxes
                    if(cart.List[i].ItemCategory == Category.OTHER) 
                    {
                        var priceAtOnePercent = cart.List[i].Price / 100;
                        priceWithTax +=  priceAtOnePercent * 10;
                    }
                    //Check if item is imported
                    if(cart.List[i].IsImported) 
                    {
                        var priceAtOnePercent = cart.List[i].Price / 100;
                        priceWithTax += priceAtOnePercent * 5;
                    }
                    cart.List[i].Tax = priceWithTax;
                }


                return cart;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool PrintCalculatedShoppingCart(ShoppingCart cart, int outputCounter)
        {
            try
            {
                //Initialize rounder class
                Rounder roundI = new Rounder();

                Console.WriteLine("Output " + outputCounter + ": ");
                //Count items and the prices
                for(var i = 0; i < cart.List.Count; i++) {
                    double fullPrice = cart.List[i].Price + cart.List[i].Tax;
                    Console.WriteLine("> " + cart.List[i].Name + ": " + roundI.RoundItem(fullPrice));
                }

                double OrderTax = 0.00;
                //Show full taxes
                foreach(var itm in cart.List) {
                    OrderTax += itm.Tax;
                }
                Console.WriteLine("> Sales Taxes: " + roundI.RoundItem(OrderTax));
                //Print total price
                double totalPrice = cart.Total + OrderTax;
                Console.WriteLine("> Total: " + roundI.RoundItem(totalPrice));
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

            
        }
    }

}