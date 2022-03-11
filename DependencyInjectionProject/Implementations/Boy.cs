using DependencyInjectionProject.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionProject.Implementations
{
    public class Boy : IPerson
    {
        public string GetHelloMessage()
        {
            return "Hello! I am Rahul.";
        }

        public string GetHelloMessage2()
        {
            return "Hello! I am Rahul from Kathmandu.";
        }
    }
}
