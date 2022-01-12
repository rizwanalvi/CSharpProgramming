using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Account _Imran = new Account(123456, "Imran Khan", 200);

            Console.WriteLine("Account Title {0}\nAccoutn Number : {1}\nAccount Balance :{2}",_Imran.AccountTitle,_Imran.AccountNumber,_Imran.AccountBalance);
            _Imran.Deposit(1500);
            Console.WriteLine("Account Title {0}\nAccoutn Number : {1}\nAccount Balance :{2}", _Imran.AccountTitle, _Imran.AccountNumber, _Imran.AccountBalance);
            _Imran.WithDraw(150);
            Console.WriteLine("Account Title {0}\nAccoutn Number : {1}\nAccount Balance :{2}", _Imran.AccountTitle, _Imran.AccountNumber, _Imran.AccountBalance);
            Account _umer = new Account(1234678,"Umer Khan",25000);
            Console.WriteLine("Account Title {0}\nAccoutn Number : {1}\nAccount Balance :{2}", _umer.AccountTitle, _umer.AccountNumber, _umer.AccountBalance);

            SavingAccount _Sv = new SavingAccount();
            _Sv.AccountTitle = "AZHAN ALI";

            Console.WriteLine(_Sv.AccountSummary());
            
            Console.ReadKey();

            
        }
    }
}
