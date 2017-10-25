using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_10
{
    class Program
    {
        static string ZamienZnaki(string napis)
        {
            if (napis.Length > 1)
            {
                return napis = napis.Substring(napis.Length - 1) + napis.Substring(1, napis.Length - 2) + napis.Substring(0, 1);
            }
            else return napis;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź ciąg znaków i naciśnij Enter.");
            string abc = Console.ReadLine();
            Console.WriteLine(ZamienZnaki(abc));
            Console.ReadKey();
        }
    }
}
