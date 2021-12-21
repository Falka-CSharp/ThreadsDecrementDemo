using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadsDecrementDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread start");
            BankAccount a = new BankAccount(10000000);
            Console.WriteLine($"Start money: {a.Money}");
            UserAccount[] accounts = new UserAccount[5];
            for (int i = 0; i < accounts.Length; i++)
            {
                accounts[i] = new UserAccount();
            }

            Thread[] threads = new Thread[5];
            for (int i = 0; i < accounts.Length; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(accounts[i].TransferMoney));
            }

            for (int i = 0; i < accounts.Length; i++)
            {
                threads[i].Start(a);
            }

            for (int i = 0; i < accounts.Length; i++)
            {
                threads[i].Join();
            }
            Console.WriteLine($"Current money: {a.Money}");

            Console.WriteLine("Main thread end");
            Console.ReadKey();
        }
    }
}
