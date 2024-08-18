using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOCSharp.Models
{
    //Herança
    public class Teacher : Person
    {
        //Construtores por herança
        public Teacher()
        {
            
        }
        public Teacher(string name) : base(name) //base passa o nome para a classe pai
        {
            
        }

        public decimal Salary { get; set; }

        //Polimorfismo em tempo de execução e Método selado
        public sealed override void IntroduceYourself()
        {
            Console.WriteLine($"My name is {Name}, I have {Age} years and I'm a teacher with salary {Salary:C}");
        }
    }
}