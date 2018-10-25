using Snai.Razor.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snai.Razor.Business.Implement
{
    public class Greeting:IGreeting
    {
        public string Greet(string greet, string name)
        {
            return $"{greet} {name}!";

        }
    }
}
