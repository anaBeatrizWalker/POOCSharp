using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOCSharp.Models
{
    //Herança e Classe Selada
    public sealed class Teacher : Person
    {
        //Construtores por herança
        public Teacher()
        {
            
        }
        public Teacher(string name) : base(name) //base passa o nome para a classe pai
        {
            
        }

        public decimal Salary { get; set; }

        //Polimorfismo em tempo de execução
        public override void IntroduceYourself()
        {
            Console.WriteLine($"My name is {Name}, I have {Age} years and I'm a teacher with salary {Salary:C}");
        }
    }
}