using Sallary_Slip;

while (true)
{
    string TotalHours;
    string HourCost;

    Empolye[] emps = new Empolye[2];
    Empolye emp1 = new Empolye();
      
    Console.WriteLine("First Emp Data: ");
    Console.Write("Total hours is: ");

    emp1.TotalHours = Console.ReadLine();

    Console.Write("Please Enter your hour cost: ");
    emp1.HourCost = Console.ReadLine();


    //Console.WriteLine(emp1.net_sallry(emp1.TotalHours, emp1.HourCost));  //right
 
   
    emps[0] = emp1;

    Console.WriteLine(emps[0]);

  //  Empolye emp2 = new Empolye();
   // Console.WriteLine("Sec Emp Data: ");
   // Console.Write("Total hours is: ");

   //  emp2.TotalHours = Console.ReadLine();

  //  Console.Write("Please Enter your hour cost: ");
   //  emp2.HourCost = Console.ReadLine();

   // Console.WriteLine(emp2.net_sallry(emp1.TotalHours, emp2.HourCost));  //right

    break;
}

