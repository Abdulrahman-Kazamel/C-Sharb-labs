using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public String Intro()
        {
          return  "Hello There, " + Name + " " + "You are not accepted to login";
        }

        public void Prints()
        {
            Console.WriteLine("Reda Is doing a great job");
        }
    }
}
