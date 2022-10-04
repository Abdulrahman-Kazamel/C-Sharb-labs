using ACT.Asia.Korea;
using System.Linq.Expressions;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int x = 9;
//var name = 8;

//Console.WriteLine($"{x} {name}"); 

//bool y = x == name;
//Console.WriteLine(y);

//var total = 1500;
//var vipThreshold = 1200;
//var isVIP = total >= vipThreshold;

//Console.WriteLine(isVIP);

//var isExclent = true;
//var GPA = 2.5;
//var isEligiableToEarn = isExclent && GPA >= 3 ;
//Console.WriteLine(isEligiableToEarn);


var arr = new string[4] {"Ali","Ahmed","Ibrahmim" ,"Abdulrahman"};

foreach(var a in arr)
{
    Console.WriteLine($" name : {a} ");
}

//for(var i =0 ; i < arr.Length; i++)
//{
  //  Console.WriteLine(arr[i]);
//}

/*====================================================================================================*/

var output = 0d;
string currency;


const double EGPToUSD = 19.25d;
const double EGPToEUR = 19.23d;
const double EGPToGBP = 22.12d;
const double EGPToSAR = 5.12d;
while (true)
{

    Console.WriteLine("Please Enter The Amount: ");
    var amount = Int32.Parse(Console.ReadLine());
   // Exception e;
    
    try
    {            
        Console.WriteLine("Please Enter The Currency: ");
        currency = Console.ReadLine().ToLower();


        if (currency == null)
        {
            Console.WriteLine("Please Enter a known currency type same as USD,SAR,etc.. ");
        }
        else
        {
            switch (currency)
            {
                case "usd":
                case "us":
                    output = amount / EGPToUSD;
                    Console.WriteLine($"{amount} in EGP = {output} in USD ");
                    break;

                case "eur":
                case "eu":
                    output = amount / EGPToEUR;
                    Console.WriteLine($"{amount} in EGP = {output} in Euros ");
                    break;

                case "gbp":
                case "gb":
                case "g":
                    output = amount / EGPToGBP;
                    Console.WriteLine($"{amount} in EGP = {output} in GBP ");
                    break;
                case "sar":
                case "sa":
                    output = amount / EGPToSAR;
                    Console.WriteLine($"{amount} in EGP = {output} in Saudi Arabia Ryal ");
                    break;
                case null:
                    Console.WriteLine("Curreny can not be empty, Please enter a value same as usd, sar,etc..");
                    break;

                default:
                    Console.WriteLine("Please Write a known currency type same as USD,SAR,etc.. ");
                    break;

            }
        }




    }
    // else if (Int32.Parse(amount) < 0 )
    //{
    //  Console.WriteLine(  " Please Enter Number Greater than 0 'Zero' " );
    //}
    catch (Exception e)
    {

        Console.WriteLine("Please Enter a Number greater than 0 ");

    }
    break;
}



//Console.WriteLine($"total is =  {amount+currency}");












