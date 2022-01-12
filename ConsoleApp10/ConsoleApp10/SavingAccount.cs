using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
   public class SavingAccount : Account
    {
        private String _AccountType;
        public SavingAccount() : base()
        {

        }
        public String AccountType
        {
            get { return _AccountType; }
            set { _AccountType = value; }
        }

        public String AccountSummary()
        {
            String _slip = String.Format("Date : {3}\nAccount Title :{0}\nAccount Balance:{1}\nAccount Number : {2}", this.AccountTitle, this.AccountBalance, this.AccountNumber, DateTime.Now);

            return _slip;
        }

    }
}
