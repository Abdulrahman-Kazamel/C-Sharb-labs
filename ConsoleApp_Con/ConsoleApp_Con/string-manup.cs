using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Con
{

    public delegate string mydelgate(string text);
    internal class string_manup
    {
        public static string TextStatue(string text)
        {
            if (text == text.ToUpper()) return "Your Text is Capital";
            else if (text == text.ToLower()) return "Your text is Lower";
            else return "You Text is mixed";
        } 

        public string TextLenght(string text)
        {
            return string.Format("it's Lenght = {0}",text.Length);
        }

       

    }
}
