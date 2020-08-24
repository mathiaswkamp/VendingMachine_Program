using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Cola : Product // Class Cola inherits from Product
    {

        /// <summary>
        /// Class of Cola 
        /// </summary>
        /// <param name="priceofproductcola"></param>
        public Cola(decimal priceofproductcola) : base("CocaCola", priceofproductcola)
        {
        }

        
    }
}