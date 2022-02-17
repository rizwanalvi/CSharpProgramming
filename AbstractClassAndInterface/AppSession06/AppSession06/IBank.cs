using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSession06
{
   public interface IBank
    {
        void WithDraw(double amount);
        void Deposit(double amount);
    }
}
