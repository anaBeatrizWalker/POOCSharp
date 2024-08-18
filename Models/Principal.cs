using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOCSharp.Models
{
    public class Principal : Teacher
    {
        //ERROR: 'Principal.IntroduceYourself()': cannot override inherited member 'Teacher.IntroduceYourself()' because it is sealed
        // public sealed override void IntroduceYourself()
        // {
        //     Console.WriteLine($"My name is {Name}, I have {Age} years and I'm a principal");
        // }
    }
}