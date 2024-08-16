using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOCSharp.Models
{
    public class CheckingAccount
    {
        public CheckingAccount(int accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        public int AccountNumber { get; set; }

        //Encapsulamento
        private decimal Balance { get; set; }

        public void Withdraw(decimal value)
        {
            if(Balance >= value)
            {
                Balance -= value;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("O valor desejado é maior que o saldo disponível.");
            }
            
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Saldo atual: {Balance}");
        }
    }
}