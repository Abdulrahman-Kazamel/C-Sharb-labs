using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Con
{
    internal class Money
    {
        private decimal amount;
        public decimal Amount =>amount;


        public Money(decimal value)
        {
            this.amount = Math.Round(value,2);
        }

        public static Money operator +(Money money1,Money money2)
        {
            var value = money1.Amount + money2.Amount;
            return new Money(value);
        }



    }
}
