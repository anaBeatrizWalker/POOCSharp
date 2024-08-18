using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOCSharp.Models
{
    public class Checking : Account
    {
        public override void Credit(decimal value)
        {
            balance += value;
        }
    }
}