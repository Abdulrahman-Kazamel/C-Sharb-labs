using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Con
{
    public class Empolyee
    {
        private int id;
        private string name;
        private char gender;
        private int totalSales;

        public int ID { get { return id;  } set { ID= this.id; }}
        public string Name { get { return name; } set { Name = name; } }
        public char Gender { get { return gender; } set { Gender = this.gender; } }
        public int TotalSales{ get{ return totalSales;} set{TotalSales = totalSales;} }
  

        public Empolyee(int id, string name, char gender, int totalSales)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.totalSales = totalSales;
          
        }

       

        // public static Empolyee Create(int id, string fName, string lName)
        //// {
        //      return new Empolyee(id, fName, lName);
        //}

       // public string Print()
       // {
       //     return $"ID: {this.id}, \nName: {this.name}, \nGender: {gender},\nTotal Sales: {totalSales} ";
       // }

    }
}
