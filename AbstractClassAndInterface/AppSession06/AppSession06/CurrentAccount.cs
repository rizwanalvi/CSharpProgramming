using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSession06
{
   public static class CurrentAccount
    {
        public static int Number { get; set; }
        public static String Title { get; set; }
        public static double Balance { get; set; }

        public static void Deposit(double Balance)
        {
            Balance = Balance + Balance;
        }
        public static void WithDraw(double Balance)
        {
            Balance = Balance - Balance;
            //this.Balance -= Balance;
        }

        public static void Summary()
        {

            Console.WriteLine("Account Type: Saving\nAccount Number : {0}\nAccount Title : {1}\nAccount Balance : {2}", Number, Title,Balance);

        }
    }
}
