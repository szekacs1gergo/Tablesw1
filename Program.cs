using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace doblak_20220920
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1, 7);
                Console.WriteLine($"A tömb {i}-edik eleme: {tomb[i]}");
            }
            Console.WriteLine("Elválasztás");
            foreach (var item in tomb)
            {
                tomb[item] = rnd.Next(1, 7);
                Console.WriteLine($"A tömb {item}-edik elem: {tomb[item]}");
            }

            Console.WriteLine("Kocsik: ");
            string[] autok = { "Audi", "VolksWagen", "Mercedes"};
            foreach (var item in autok)
            {
                Console.WriteLine(item);
            }
            var tomb2d = new int[,]
                {
                    { 1, 2, 3},
                    { 4, 5, 6},
                    { 7, 8, 9}
                };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tomb2d[i,j]);
                    Console.Write(" ");
                }
            }
            //Első lehetőség
            Console.WriteLine();

            for (int i = 1; i < tomb2d.Length + 1; i++)
            {
                Console.Write(i+" ");
            }
            //Második lehetőség
            Console.WriteLine();

            foreach (var item in tomb2d)
            {
                Console.Write(item+" ");
            }
            //Harmadik lehetőség
            Console.WriteLine();

            for (int i = 0; i < tomb2d.GetLength(0); i++)
            {
                for (int j = 0; j < tomb2d.GetLength(1); j++)
                {
                    Console.Write(tomb2d[i, j]);
                    Console.Write(" ");
                }
            }

            var tombok = new int[][]
                {
                    new int[] {1,2,3},
                    new int[] {4,5,6},
                    new int[] {7,8,9}
                };
            foreach (var sor in tombok)
            {
                foreach (var oszlop in sor)
                {
                    Console.Write(oszlop);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
