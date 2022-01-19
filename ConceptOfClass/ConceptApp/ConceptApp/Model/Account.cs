using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptApp.Model
{
  public  class Account
    {
        public int AccountNumber { get; set; }
        public String AccountTitle { get; set; }
        public double AccountBalance { get; set; }
        public void WithDraw(double amount) {
            AccountBalance += AccountBalance - amount;
        }
        public void WithDraw(float amount)
        {
            AccountBalance += AccountBalance - amount;
        }

        public void Deposit(double amount)
        {
            AccountBalance += AccountBalance + amount;
        }
        public void Deposit(float amount)
        {
            AccountBalance += AccountBalance + amount;
        }

        public virtual string AccountSummary()
        {
            String _Slip = String.Format("Account Number : {0}\nAccount Title : {1}\nAccount Balance :{2}", this.AccountNumber, this.AccountTitle, this.AccountBalance);

            return _Slip;

        }
    }
}
