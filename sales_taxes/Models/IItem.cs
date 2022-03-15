using System;

namespace sales_taxes.Models{
    public interface ISalesItem { 
        
        public string Name {get; set;}
        public Category ItemCategory {get;set;}
        public double Tax {get; set;}
        public double Price {get; set;}
        public bool IsImported {get; set;}

    }
}