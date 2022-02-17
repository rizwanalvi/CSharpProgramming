using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSession06
{
    class Program
    {
        static void Main(string[] args)
        {
            Account _ac = new Account() {AccountNumber = 1000,AccountTitle="Ahmed Khan",AccountBalance=3455.567 };
            _ac.Summary();
            _ac.WithDraw(500);
            _ac.Summary();
            _ac.Deposit(1500);
            _ac.Summary();
            Account _im = new Account() {AccountTitle="noman ahmed",AccountNumber=134567,AccountBalance=5000 };
            _im.Summary();

            SavingAccount _img = new SavingAccount() { Number=131314,Title="Imran Khan",Balance= 1500};
            _img.Summary();

            CurrentAccount.Title = "FAIZAN AHMED KHAN";
            CurrentAccount.Number = 1234567;
            CurrentAccount.Balance = 50000;
            CurrentAccount.Summary();
            Console.ReadKey();
        }
    }
}
