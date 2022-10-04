// See https://aka.ms/new-console-template for more information
using static helloWorld.Person;

using helloWorld.Math;
using System.Runtime.CompilerServices;

var Ahmed = new helloWorld.Person();
int[] numbers = new int[] { 1, 2, 3,4,5 };   
Ahmed.Id = 1;
Ahmed.Name = "Ahmed";
//Ahmed.Prints();



var adds = new Calc();
var result = adds.add(1, 2);
//Console.WriteLine(result);


//numbers.Append(7);
//Console.WriteLine(numbers.Length);


var myname = new string[2] {"Abdulrahman", "Kazamel" };

string myformatedname = String.Join(" , ", myname);

////Console.WriteLine(myformatedname);

bool goldenMember = false;

decimal price = (goldenMember) ? 20 : 25;

//Console.WriteLine(price);

//Console.WriteLine("Please Input a number");
//var x = Console.ReadLine();
// int y = Int16.Parse(x);
///if (y > 0 && y < 10)
//{
//   Console.WriteLine("valid");
//}
//else
//   Console.WriteLine("INvalid");

Console.WriteLine("Please Input a two numbers");
Console.WriteLine("First number");
var num_1 = Console.ReadLine();
Console.WriteLine("Seconed number");
var num_2= Console.ReadLine();

int nums1 = Int32.Parse(num_1);
int nums2 = Int32.Parse(num_2);

if (num_1 == num_2)
    Console.WriteLine("Numbers Equal");

else if (nums1 > nums2)
    Console.WriteLine("first number greater");


else if (nums2 > nums1)
    Console.WriteLine("Sec number is larger");



