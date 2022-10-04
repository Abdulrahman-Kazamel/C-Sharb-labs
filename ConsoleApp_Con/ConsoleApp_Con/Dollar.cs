using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Con
{
    public class Dollar
    {

        private int amount;
        public int Amount
        {
            get { return this.amount; }
            private set { 
                        if (value <= 0)
                        {
                            this.amount = 0;
                        }
                        else
                        {
                               this.amount = Proc(value);

                        }
                
                }
    
        }


        public void setAmount(int value)
        {
             Amount = value;
        }

        public Dollar(int amount)
        {
            this.amount = Proc(amount);
        }


        private int Proc(int value) => value <= 0 ? 0 : value;

    }
}
