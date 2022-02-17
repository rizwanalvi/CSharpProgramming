using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSession06
{
   public class Account
    {
        public int AccountNumber { get; set; }
        public String AccountTitle { get; set; }
        public double AccountBalance { get; set; }


        public void Deposit(double amount) {
            AccountBalance = AccountBalance + amount;
        }
        public void WithDraw(double amount) {
            AccountBalance = AccountBalance - amount;

        }
        public void Summary() {
            Console.WriteLine("Account Number : {0}\nAccount Title : {1}\nAccount Balance : {2}",AccountNumber,AccountTitle,AccountBalance);
        }

    }
}
