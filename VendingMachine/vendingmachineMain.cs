using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VendingMachine
{
    class vendingmachineMain
    {
        static void Main(string[] args)


        {
            bool start = false;
            while (!start)                                                                                                                                                  // this is to return to start when i break out of my switch stament
            {

            Console.WriteLine("==================================================="); 
            Console.WriteLine("|             This is a vending machine           |");
            Console.WriteLine("===================================================");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("what do you want to buy ");
            Console.WriteLine("1. CocaCola ");
            Console.WriteLine("2. Fanta ");
            Console.WriteLine("3. Cancel transaction and try again ");

            StorageProduct storageproduct = new StorageProduct();                                                                                                           // create storageproduct object of StorageProduct
            coin Coins = new coin();                                                                                                                                        // create Coins object of coin
            int InputFromUser = int.Parse(Console.ReadLine());                                                                                                              // reads input from user
            

                switch (InputFromUser)
            {
                case 1:                                                                                                                                                     // if user wants a CocaCola
                    Console.Clear();
                    Console.WriteLine("There is now : " + storageproduct.countCola() + " Colas left " + " the price is :" + storageproduct.priceofsweetdrink() + "$");
                    Console.WriteLine("Incert 3 dollars to buy a Cola");
                    double inputcoinuser = double.Parse(Console.ReadLine());
                    Console.WriteLine("Here is your CocaCola and your money change : " + Coins.CoinStash(inputcoinuser) + "$");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                case 2:                                                                                                                                                     // if user wants a Fanta
                    Console.Clear();
                    Console.WriteLine("There is now : " + storageproduct.countCola() + " Fantas left " + " the price is :" + storageproduct.priceofsweetdrink() + "$");
                    Console.WriteLine("Incert 3 dollars to buy a Fanta");
                    double inputcoinuser1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Here is your Fanta and your money change : " + Coins.CoinStash(inputcoinuser1) + "$");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                case 3:                                                                                                                                                     // if user dosn´t want to purchase anything
                    Console.Clear();
                    Console.WriteLine("You have canceled the transaction ");
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please enter 1, 2  or 3 ");
                    break;

                }
            }
        }
    }
}