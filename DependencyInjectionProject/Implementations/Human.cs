using DependencyInjectionProject.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionProject.Implementations
{
    public class Human
    {
        private readonly IPerson _person;
        public Human(IPerson person)
        {
            _person = person;
        }

        public void DisplayHelloMessage() => Console.WriteLine(_person.GetHelloMessage());
        //public void DisplayHelloMessage() => Console.WriteLine((new Boy()).GetHelloMessage());

    }
}
