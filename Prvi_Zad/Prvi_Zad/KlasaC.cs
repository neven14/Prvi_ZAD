using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvi_Zad
{
    class KlasaC
    {
        public int Zbroj(int[] arr)
        {
            int zbr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                zbr += arr[i];
            }
            return zbr;
        }
        public double Prosjek(int[] prosjek)
        {
            int sum = 0;
            for (int i = 0; i < prosjek.Length; i++)
            {
                sum += prosjek[i];
            }
         return sum / prosjek.Length;
        }
    }
}
