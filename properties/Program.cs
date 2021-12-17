using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Properties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person("Robin",new DateTime(1988,1,31));
            person.Username = "nixomg";
        
            System.Console.WriteLine("This persons name is: " + person.Name);
            System.Console.WriteLine("The username of this person is: " + person.Username);
            System.Console.WriteLine("The age of this person is: " + person.Age);
        }  
    }
}
