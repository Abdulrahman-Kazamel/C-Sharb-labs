using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sallary_Slip
{
    public class Empolye
    {
        //  public string F_Name { get; set; }
        //  public string L_Name { get; set; }
        public const double TAX = .03;

        private string total_hours;
        private string hour_cost;

      public string TotalHours
        {
            get { return total_hours; }
            set { total_hours = value; }
        }
     
       
        public string HourCost
        {
            get { return hour_cost; }
            set { hour_cost = value; }
        }
        
        public string net_sallry()
        {
          // total_hours = t_hours;
          //  hour_cost = h_cost;

            if (int.TryParse(this.TotalHours, out var parsed_hours) && parsed_hours > 0)
            {

                if (int.TryParse(this.HourCost, out int parsed_hour_cost) && parsed_hour_cost > 0)
                {
                    var net_Sallary = total_hours() - TAX_Amount();
                    return $"Sallary after Taxes is : {Math.Floor(net_Sallary)} EGP";
                }
                else
                {
                    return "please Enter a valid number, ";
                 
                }

                double total_hours() => parsed_hours * parsed_hour_cost;
                double TAX_Amount() => parsed_hours * parsed_hour_cost * TAX;

            }
            else
            {
                return "Please Enter valid number, ";
            }


        }

  


    }
}
