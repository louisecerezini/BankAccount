using System;
using System.Collections.Generic;


namespace SistemaContaBancaria.Entities
{
    public class BankAccount
    {
        public string Name { get; set; }
        private double Balance { get; set; }

        //construtor recebe nome como parametro
        public BankAccount(string name)
        {
            // valida se o nome é nulo ou vazio. Se for retorna um erro 
            if (string.IsNullOrEmpty(name))
            {
            throw new ArgumentException("nameCanNotBeEmpty");
            }
            // caso o nome seja valido define nome e saldo 
            Name = name;
            Balance = 0;
        }
        // metodo de deposito que recebe valor e adiciona ao saldo
        public void Credit(double amount)
        {
            Balance = Balance + amount;
        }
        //metodo de saque e desconta do saldo 
        public void Debit(double amount)
        {
            Balance -= amount;
        }

        //metodo para checar o saldo da conta 
        public double CheckBalance()
        {
            return Balance;
        }
    }
}
