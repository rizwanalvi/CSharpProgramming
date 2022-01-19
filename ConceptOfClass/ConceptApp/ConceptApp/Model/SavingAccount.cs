using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptApp.Model
{
    class SavingAccount :Account
    {
        private String _AccountType = "Saving Account";
        public override string AccountSummary()
        {
            String _Slip = String.Format("Account Type : {0}\nAccount Number : {1}\nAccount Title : {2}\nAccount Balance :{3}",this._AccountType, this.AccountNumber, this.AccountTitle, this.AccountBalance);
            return _Slip;
        }
    }
}
