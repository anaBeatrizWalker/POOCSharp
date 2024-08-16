using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOCSharp.Models
{
    //Herança
    public class Teacher : Person
    {
        public decimal Salary { get; set; }

        //Polimorfismo em tempo de execução
        public override void IntroduceYourself()
        {
            Console.WriteLine($"My name is {Name}, I have {Age} years and I'm a teacher with salary {Salary:C}");
        }
    }
}