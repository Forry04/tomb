using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomb
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] tomb = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] tomb = new int[10];
            tomb[5] = 100;

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine($"{i + 1}. elem: {tomb[i]}");
            //    i++;
            //}



            //Console.WriteLine(tomb[0]);
            //Console.WriteLine(tomb[9]);
            //Console.WriteLine(tomb.Length - 1);


            //for (int i = tomb.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine($"{i+1}. elem: {tomb[i]}");
            //    Console.WriteLine($"{i+1}. elem: {tomb[i]}");
            //}

            Random veletlen = new Random();

            for (int i = 0; i < 10; i++)
            {
                tomb[i] = veletlen.Next(100);

            }


            foreach (int szam in tomb)
            {
                Console.WriteLine(szam);
            }



            Console.ReadKey();

        }
    }
}