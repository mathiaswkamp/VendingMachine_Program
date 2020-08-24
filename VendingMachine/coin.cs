using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class coin
    {


        // property of moneypuch 
        private int moneypouch;

        public int MoneyPouch
        {
            get { return moneypouch; }
            set { moneypouch = value; }
        }



        // property of priceofsweets
        private int priceofsweets;

        public int PriceOfSweets
        {
            get { return priceofsweets; }
            set { priceofsweets = value; }
        }



        /// <summary>
        /// This method checks on the UserCoinInput and returns the persons change
        /// </there is predefined that my sweets are costing 3 dollars and i have default 100 dollars in my money pouch>
        /// <param name="UserCoinInput"></param>
        /// <returns></returns>

        public double CoinStash(double UserCoinInput)
        {
            priceofsweets = 3;
            moneypouch = 100;
            double result = 0;


            if ((UserCoinInput != priceofsweets) && moneypouch != 0)
            {
                result = UserCoinInput - priceofsweets;
            }

            else
            {
                result = 0;
            }

            return result;
        }
    }
}