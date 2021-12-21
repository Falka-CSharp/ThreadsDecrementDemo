using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadsDecrementDemo
{
    public class UserAccount
    {
       
        public int money { get; set; }
        public void TransferMoney(object o)
        {
            
            BankAccount a = o as BankAccount;
            for (int i = 0; i < 1000000; i++)
            {
                money = money + 1;
                Interlocked.Decrement(ref a.money);
            }
        }
    }
}
