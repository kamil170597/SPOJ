using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Wczytywanie
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Wczytaj sekwencje s
            string line1 =  Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string line2 = Console.ReadLine();
            string[] tab2 = line2.Split(new char[] {' '});

            int[] s = new int[n];
            for(int i=0;i<n;i++)
            {
                s[i] = int.Parse(tab2[i]);
            }

            //wczytaj sekwencje Q
            string line3 = Console.ReadLine();
            int m = Convert.ToInt32(line3);
            string line4 = Console.ReadLine();
            string[] tab4 = line4.Split(new char[] {' '},
            StringSplitOptions.RemoveEmptyEntries);

            Debug.Assert(tab4.Length == n);
            int[] q = new int[m];
            for(int i=0;i<m;i++)
            {
                q[i] = int.Parse(tab4[i]);
            }

            string wynik = "";
            for (int i = 0; i < Math.Min(n, m); i++)
            {
                if (s[i] == q[i])
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(wynik.Trim());
        


        }
        static string test1 = @"5
-2-2-114
6
-3-2-1123";
        static string test2 = "5\n-2-2-114\n6\n-3-2-1123";

    }
}
