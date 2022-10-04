using ConsoleApp_Con;
//Date d1 = new Date(8,1992);
//Console.WriteLine(d1.Print());


//Empolyee emp1 = Empolyee.Create(100, "Ahmed", "Sabry");

//Human Ahmed = Human.Create(30, "Ahmed");


//Console.WriteLine( Ahmed.Print());



//Dollar dol1 = new Dollar(-199);
//dol1.setAmount(1555);
//Console.WriteLine(dol1.Amount);

//IP ip1 = new IP("125.22.36.15");

//Console.WriteLine(ip1.Address);
//Console.WriteLine(ip1[0]);
/* var emps = new Empolyee[] {

    new Empolyee (1,"Ahmed",'M',90000),
    new Empolyee (2,"ALi",'M',85000),
    new Empolyee (3,"Abdulrahman",'M',60000),
    new Empolyee (4,"Moaaz",'M',35000),
    new Empolyee (5,"Saad",'M',60_000),
    new Empolyee (6,"Sara",'F',90000),
    new Empolyee (7,"Aya",'F',45_000),
    new Empolyee (8,"Mona",'F',30_000)

};
var report = new Report();

report.Process(emps, "~~~~~~~~~~~~  Empolyee Greater than 80,000 $ ~~~~~~~~~~~~\n", e => e.TotalSales > 80000);

report.Process(emps, "\n~~~~~~~~~~~~   Empolyee Between $   ~~~~~~~~~~~~\n", e => e.TotalSales < 80000 && e.TotalSales > 35000 );

report.Process(emps, "\n~~~~~~~~~~~~   Empolyee Less than 35,000$  ~~~~~~~~~~~~\n", e => e.TotalSales < 35000 );


************************************************/
var m1 = new Money(15);
var m2 = new Money(30);
var m3 = m1 + m2;
//Make.MakeSomeGarbage();
//Console.WriteLine(m1.Amount);
//Console.WriteLine(m2.Amount);
//Console.WriteLine(m3.Amount);

//Console.WriteLine($"Memory used before collecting is: {GC.GetTotalMemory(false):N0}");
//Console.WriteLine($"Memory used After collecting is: {GC.GetTotalMemory(true):N0}");

var strin = new string_manup();
string? returned = "";

Console.WriteLine("Please Enter a text: ");
returned = Console.ReadLine();

Console.WriteLine( $" {string_manup.TextStatue(returned)} and {strin.TextLenght(returned)} ");







