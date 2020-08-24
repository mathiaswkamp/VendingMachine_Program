using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class StorageProduct
    {

        // CocaCola array with 15 objects of Cola
        Cola[] _CocaCola =
        {
            new Cola(priceofproductcola: 3),
            new Cola(priceofproductcola: 3),
            new Cola(priceofproductcola: 3),
            new Cola(priceofproductcola: 3),
            new Cola(priceofproductcola: 3),
            new Cola(priceofproductcola: 3),
            new Cola(priceofproductcola: 3),
            new Cola(priceofproductcola: 3),
            new Cola(priceofproductcola: 3),
            new Cola(priceofproductcola: 3),
            new Cola(priceofproductcola: 3),
            new Cola(priceofproductcola: 3),
            new Cola(priceofproductcola: 3),
            new Cola(priceofproductcola: 3),
            new Cola(priceofproductcola: 3)
        };

        // Fanta array with 15 objects of fanta
        Fanta[] _Fanta =
        {
            new Fanta(priceofproductfanta: 3),
            new Fanta(priceofproductfanta: 3),
            new Fanta(priceofproductfanta: 3),
            new Fanta(priceofproductfanta: 3),
            new Fanta(priceofproductfanta: 3),
            new Fanta(priceofproductfanta: 3),
            new Fanta(priceofproductfanta: 3),
            new Fanta(priceofproductfanta: 3),
            new Fanta(priceofproductfanta: 3),
            new Fanta(priceofproductfanta: 3),
            new Fanta(priceofproductfanta: 3),
            new Fanta(priceofproductfanta: 3),
            new Fanta(priceofproductfanta: 3),
            new Fanta(priceofproductfanta: 3),
            new Fanta(priceofproductfanta: 3)
        };

       
        
        /// <summary>
        /// Method of priceofsweetdrinks to return the predefined price 
        /// </summary>
        /// <returns></returns>
        public int priceofsweetdrink()
        {
            int priceofproduct = 3;
            return priceofproduct;
        }


        /// <summary>
        /// i still need to implement this method so that it will delete one product of _Cola array
        /// </summary>
        public void DecrementCola()
        {
            int decrementCola = _CocaCola.Length;
               _CocaCola[decrementCola] = null;
               decrementCola--;


        }

        /// <summary>
        /// i still need to implement this method so that it will delete one product of _Fanta array
        /// </summary>
        /// <returns></returns>
        public int DecremetFanta()
        {
            int decrementFanta = 14;
            _CocaCola[decrementFanta] = null;
            decrementFanta--;
            return decrementFanta;
        }

        /// <summary>
        /// Method to count Cola array and return the amout of Colas in _Cola array
        /// </summary>
        /// <returns></returns>
        public int countCola ()
        {
            int variable = 0;
            for (variable = 0; variable < _CocaCola.Length; variable++)
            {


            }
            return variable;
        }

        /// <summary>
        /// Method to count Cola array and return the amout of Fantas in _Fanta array
        /// </summary>
        /// <returns></variable>
        public int countFanta()
        {
            int variable = 0;
            for (variable = 0; variable < _Fanta.Length; variable++)
            {

               
            }
            return variable;
        }
  
    }
}