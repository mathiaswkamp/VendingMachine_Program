using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine 
{
    class Fanta : Product // inherits from Product
    {
        /// <summary>
        /// class of Fanta
        /// </summary>
        /// <param name="priceofproductfanta"></param>
        public Fanta(decimal priceofproductfanta) : base("fanta", priceofproductfanta)
        {
        }


       
    }
}