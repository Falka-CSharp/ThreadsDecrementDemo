using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadsDecrementDemo
{
    public class BankAccount
    {
        public int money;
        public int Money {
            get {
                return money;
            }
            set
            {
                money = value;
            }
        }
        public BankAccount(int m)
        {
            Money = m;
        }
    }
}
