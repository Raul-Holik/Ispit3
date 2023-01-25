using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ispit3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Fibonaccijev niz definiran je na sljedeći način:
            // • prvi član niza je 0
            // • drugi član niza je 1
            // • svaki sljedeći član niza jednak je zbroju prethodna dva člana
            //Napišite program koji će zatražiti od korisnika da unese broj n, te će izračunati n-ti član Fibonaccijevog niza.

            int n,r;
            Console.WriteLine("Upišite n broj.");
            n = Convert.ToInt32(Console.ReadLine());
            r = 2 + n;
            int[] niz = {0, 1, 2, n, r};

           

            for(int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);

            }
            Console.WriteLine("N-ti član je: " + r);
            Console.ReadKey();
        }
    }
}
