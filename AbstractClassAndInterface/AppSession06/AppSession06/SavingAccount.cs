using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSession06
{
   public  sealed class SavingAccount
    {
        public int Number { get; set; }
        public String Title { get; set; }
        public double Balance { get; set; }

        public void Deposit(double Balance) {
            this.Balance = this.Balance + Balance;
        }
        public void WithDraw(double Balance)
        {
            this.Balance = this.Balance - Balance;
            //this.Balance -= Balance;
        }

        public void Summary() {

            Console.WriteLine("Account Type: Current\nAccount Number : {0}\nAccount Title : {1}\nAccount Balance : {2}", this.Number, this.Title, this.Balance);

        }
    }
}
