using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Con
{
    public class IP
    {

        private int[] segmants { get; set; } = new int[4];


        public int this[int index]
        {
            get
            {
                return segmants[index];
            }
            set
            {
                segmants[index] = value;
            }
        }


        public IP(string ipAddress)
        {
            var segs = ipAddress.Split('.');

            for (int i = 0; i <= segs.Length; i++)
            {

                segmants[i] = Convert.ToInt32(segs[i]);
            }

        }

        public IP(int segmant1, int segmant2, int segmant3, int segmant4)
        {
            segmants[0] = segmant1;
            segmants[1] = segmant2;
            segmants[2] = segmant3;
            segmants[3] = segmant4;


        }




        public string Address() => string.Join('.', segmants);



        
    }
}
