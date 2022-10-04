//var arr = new string[4] { "Ali", "Ahmed", "Ibrahmim", "Abdulrahman" };

/*foreach (var a in arr)
{
  //  Console.WriteLine($" name : {a} ");
}

for(var i =0 ; i < arr.Length; i++)
{
  //Console.WriteLine($"names in list: {arr[i]}");
}
*/
/*====================================================================================================*/

var output = 0d;
string currency;

const double EGPToUSD = 19.25d;
const double EGPToEUR = 19.23d;
const double EGPToGBP = 22.12d;
const double EGPToSAR = 5.12d;
while (true)
{

    Console.Write("Please Enter The Amount in Numirc values : ");
    var amount = Console.ReadLine();
    // Exception e;

    if ( double.TryParse(amount, out double parsed_amount) || parsed_amount > 0 || parsed_amount == null )
    {
        while (true)
        {
              Console.Write("Please Enter The Currency: ");
              currency = Console.ReadLine().ToLower();

            if (currency == null || currency == "")
            {
                Console.WriteLine("Please Enter a known currency type same as USD,SAR,etc..========== ");
               

            }
            else
            {
                switch (currency)
                {
                    case "usd":
                    case "us":
                        output = parsed_amount / EGPToUSD;
                        Console.WriteLine($"{amount} in EGP = {Math.Floor(output)} in USD ");
                        break;

                    case "eur":
                    case "eu":
                        output = parsed_amount / EGPToEUR;
                        Console.WriteLine($"{amount} in EGP = {Math.Floor(output)} in Euros ");
                        break;

                    case "gbp":
                    case "gb":
                    case "g":
                        output = parsed_amount / EGPToGBP;
                        Console.WriteLine($"{amount} in EGP = {Math.Floor(output)} in GBP ");
                        break;
                    case "sar":
                    case "sa":
                    case "s":
                        output = parsed_amount / EGPToSAR;
                        Console.WriteLine($"{amount} in EGP = {Math.Floor(output)} in Saudi Arabia Ryal ");
                        break;
                    case null:
                        Console.WriteLine("Curreny can not be empty, Please enter a value same as usd, sar,etc..");
                        continue;

                    default:
                        Console.WriteLine("Please Write a known currency type same as USD,SAR,etc..+++++++++++ ");
                        continue;

                }
                break;
            }
            
        }






    }
    else
    {

        Console.WriteLine("Please Enter a Number greater than 0 ");
        continue;
    }
break;
}


