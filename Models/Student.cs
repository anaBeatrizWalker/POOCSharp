using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOCSharp.Models
{
    //Herança
    public class Student : Person
    {
        public double Score { get; set; }

        //Polimorfismo em tempo de execução
        public override void IntroduceYourself()
        {
            Console.WriteLine($"My name is {Name}, I have {Age} years and I'm a student with score {Score}");
        }

         //Polimorfismo em tempo de compilação (não depende de herança e só muda pela quantidade de parâmetros)
        public void IntroduceYourself(string parameter)
        {
            Console.WriteLine($"My name is {Name}, I have {Age} years and I'm a student with score {Score}");
        }
    }
}