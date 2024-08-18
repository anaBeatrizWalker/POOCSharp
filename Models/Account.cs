using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOCSharp.Models
{
    //Classe abstrata
    public abstract class Account
    {
        //protected protege contra alterações externas, mas as classes filhas podem acessar
        protected decimal balance;

        //Método abstrato
        public abstract void Credit(decimal value);

        public void ShowBalance()
        {
            Console.WriteLine("Current balance: " + balance);
        }

    }
}