using System;
using sales_taxes.Models;

namespace sales_taxes
{
    public static class Program 
    {

        public static void Main(string[] args) 
        {

            //INPUT 1
            Item book = new Item("1 book", Category.BOOK, 12.49, false);
            Item cd = new Item("1 music CD", Category.OTHER, 14.99, false);
            Item bar = new Item("1 chocolate bar", Category.FOOD, 0.85,false);

            ShoppingCart ShoppingCart1 = new ShoppingCart();
            ShoppingCart1.List.Add(book);
            ShoppingCart1.List.Add(cd);
            ShoppingCart1.List.Add(bar);

            //INPUT 2
            Item importedChocBox = new Item("1 imported box of chocolates", Category.FOOD, 10.00, true);
            Item importedPerfume = new Item("1 imported bottle of perfume", Category.OTHER, 47.50, true);

            ShoppingCart ShoppingCart2 = new ShoppingCart();
            ShoppingCart2.List.Add(importedChocBox);
            ShoppingCart2.List.Add(importedPerfume);

            //INPUT 3
            Item importedPerfume2 = new Item("1 imported bottle of perfume", Category.OTHER, 27.99, true);
            Item bottleOfPerfume = new Item("1 bottle of perfume", Category.OTHER, 18.99, false);
            Item pills = new Item("1 packet of headache pills", Category.MEDICAL, 9.75,false);
            Item importedChocBox2 = new Item("1 box of imported chocolates", Category.FOOD, 11.25, true);

            ShoppingCart ShoppingCart3 = new ShoppingCart();
            ShoppingCart3.List.Add(importedPerfume2);
            ShoppingCart3.List.Add(bottleOfPerfume);
            ShoppingCart3.List.Add(pills);
            ShoppingCart3.List.Add(importedChocBox2);

            //Declare and initialize calc class
            SalesTaxCalc calc = new SalesTaxCalc();
            calc.CalcShoppingCart(ShoppingCart1);
            calc.PrintCalculatedShoppingCart(ShoppingCart1, 1);

            calc.CalcShoppingCart(ShoppingCart2);
            calc.PrintCalculatedShoppingCart(ShoppingCart2, 2);

            calc.CalcShoppingCart(ShoppingCart3);
            calc.PrintCalculatedShoppingCart(ShoppingCart3, 3);

        }


    }

}
