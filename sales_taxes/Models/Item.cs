using System;

namespace sales_taxes.Models
{

    public class Item : ISalesItem
    {

        public Item(string name, Category cat, double price, bool isImported) {
            Name = name;
            ItemCategory = cat;
            Price = price;
            IsImported = isImported;
        }
        public string Name {get; set;}
        public Category ItemCategory {get;set;}
        public double Tax {get; set;}
        public double Price {get; set;}
        public bool IsImported {get; set;}

    }
}
