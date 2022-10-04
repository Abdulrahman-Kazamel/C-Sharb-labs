using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Con
{
    public class Human
    {

        private int age;
        private string name;

        private Human(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public static Human Create(int age, string name)
        {
            return new Human(age, name);
        }

        public string Print()
        {
            return $"this Human age is {age} and his name is {name}";
        }



    }
}
