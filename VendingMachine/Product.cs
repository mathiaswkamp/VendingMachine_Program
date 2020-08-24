using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Product
    {

        // property of Name that i can use for my products
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        // property of priceofproducts that i can use for my products
        private decimal priceofproduct;

        public decimal PriceOfProduct
        {
            get { return priceofproduct; }
            set { priceofproduct = value; }
        }

        // constructor to give name and price

        public Product(string name, decimal price)
        {
            this.name = Name;
            this.priceofproduct = PriceOfProduct;
        }
    }
}