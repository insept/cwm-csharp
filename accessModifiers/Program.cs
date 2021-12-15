// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessModifiers
{
    public class Program
    {
        static void Main(string[] args) 
        {
            var person = new Person();

            person.SetBirthdate(new DateTime(1988,01,31));
            System.Console.WriteLine(person.GetBirthdate());
        }
    }
}
