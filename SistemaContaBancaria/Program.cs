using System;
using System.Globalization;
using SistemaContaBancaria.Entities;

namespace SistemaContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Bolt");
            account.Credit(10000);
            Console.WriteLine(account.Name);
            Console.WriteLine(account.CheckBalance());
        }
    }
}