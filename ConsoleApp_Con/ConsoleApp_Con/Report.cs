using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Con
{
    internal class Report
    {
        public delegate bool isIllagiable(Empolyee e);
        public void  Process(Empolyee[] empolyees,string title, isIllagiable isIllagiable) {

            Console.WriteLine(title);
            foreach (Empolyee emp in empolyees)
            {
                if (isIllagiable (emp))
                {
                Console.WriteLine($"Empolyee ID : {emp.ID} ||||||||| Name: {emp.Name} ||| {emp.Gender} || with Sales {emp.TotalSales} ");
              //  Console.WriteLine("============================================================");
                }

            
            }   
        }











    }
}
