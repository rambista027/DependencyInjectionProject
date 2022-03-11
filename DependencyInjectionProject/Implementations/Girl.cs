using DependencyInjectionProject.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionProject.Implementations
{
    public class Girl : IPerson
    {
        public string GetHelloMessage()
        {
            return "Hi! I am Anjali.";
        }
    }
}
