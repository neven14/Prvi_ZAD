using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvi_Zad
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zbrojPros = new int[5];
            Console.WriteLine("Upisite 5 cijelih brojeva:");
            for (int i = 0; i < 5; i++)
            {
                string s = Console.ReadLine();
                zbrojPros[i] = Convert.ToInt32(s);
            }
            KlasaC x = new KlasaC();
            int zbroj = x.Zbroj(zbrojPros);
            double prosjek = x.Prosjek(zbrojPros);
            Console.WriteLine("Zbroj " + zbroj + ", prosjek " + prosjek);
        }
    }
}
