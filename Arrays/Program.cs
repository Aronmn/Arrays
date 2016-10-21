using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {   //Övning 1
            string[] ord = new string[10];

            for (int x = 0; x < 10; x++){
                Console.Write("Mata in namn  ");
                ord[x] = Console.ReadLine();
            }

            for (int x = 0; x < 10; x++)
            {
               Console.WriteLine(ord[x]);
            }

            //Övning 2
            string[] siffor = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Mata in siffor   ");
                siffor[i] = Console.ReadLine();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(siffor[i]);

          }
       }
    }
}
