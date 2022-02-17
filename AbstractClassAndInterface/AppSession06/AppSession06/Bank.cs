using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSession06
{
public abstract class Bank
    {
        public abstract int AccountType { get; set; }
        public abstract void WithDraw(double amount);
        public abstract void Deposit(double amount);
        public void Summary() {

        }

    }
}
