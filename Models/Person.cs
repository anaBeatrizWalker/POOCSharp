using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOCSharp.Models
{
    //Abstração
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is {Name} and I have {Age}");
        }

    }
}