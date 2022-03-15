using Xunit;
using sales_taxes;
using sales_taxes.Models;


namespace sales_taxes_test;

public class SalesTaxCalcTest
{
    [Fact]
    public void CalcShoppingCart_Input1()
    {
            Item book = new Item("1 book", Category.BOOK, 12.49, false);
            Item cd = new Item("1 music CD", Category.OTHER, 14.99, false);
            Item bar = new Item("1 chocolate bar", Category.FOOD, 0.85,false);

            ShoppingCart ShoppingCart1 = new ShoppingCart();
            ShoppingCart1.List.Add(book);
            ShoppingCart1.List.Add(cd);
            ShoppingCart1.List.Add(bar);

            SalesTaxCalc calc = new SalesTaxCalc();

            var result = calc.CalcShoppingCart(ShoppingCart1);

            Assert.True(result != null);
    }

    [Fact]
    public void CalcShoppingCart_Input1_Fail()
    {
        Item book = new Item("1 book", Category.BOOK, 12.49, false);
        Item cd = new Item("1 music CD", Category.OTHER, 14.99, false);
        Item bar = new Item("1 chocolate bar", Category.FOOD, 0.85, false);

        ShoppingCart ShoppingCart1 = new ShoppingCart();

        SalesTaxCalc calc = new SalesTaxCalc();

        var result = calc.CalcShoppingCart(ShoppingCart1);

        Assert.True(result == null);
    }

    [Fact]
    public void PrintCalculatedShoppingCart_Input1()
    {
        Item book = new Item("1 book", Category.BOOK, 12.49, false);
        Item cd = new Item("1 music CD", Category.OTHER, 14.99, false);
        Item bar = new Item("1 chocolate bar", Category.FOOD, 0.85, false);

        ShoppingCart ShoppingCart1 = new ShoppingCart();
        ShoppingCart1.List.Add(book);
        ShoppingCart1.List.Add(cd);
        ShoppingCart1.List.Add(bar);

        SalesTaxCalc calc = new SalesTaxCalc();

        var calculatedCart = calc.CalcShoppingCart(ShoppingCart1);

        var result = calc.PrintCalculatedShoppingCart(calculatedCart, 1);

        Assert.True(result != false);
    }

    [Fact]
    public void PrintCalculatedShoppingCart_Input1_Fail()
    {
        Item book = new Item("1 book", Category.BOOK, 12.49, false);
        Item cd = new Item("1 music CD", Category.OTHER, 14.99, false);
        Item bar = new Item("1 chocolate bar", Category.FOOD, 0.85, false);

        ShoppingCart ShoppingCart1 = new ShoppingCart();


        SalesTaxCalc calc = new SalesTaxCalc();

        var calculatedCart = calc.CalcShoppingCart(ShoppingCart1);

        var result = calc.PrintCalculatedShoppingCart(calculatedCart, 1);

        Assert.True(result == false);
    }
}
