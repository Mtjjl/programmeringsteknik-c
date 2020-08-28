using System;
using System.Security.Cryptography.X509Certificates;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int j= 1;
            int i = 0;
            Console.WriteLine("▓▓▓░░░▓▓▓░░░▓▓▓░░░▓▓▓░░░");
            Console.Write("░░░▓▓▓░░░▓▓▓░░░▓▓▓░░░▓▓▓\n▓▓▓░░░▓▓▓░░░▓▓▓░░░▓▓▓░░░\n░░░▓▓▓░░░▓▓▓░░░▓▓▓░░░▓▓▓\n▓▓▓░░░▓▓▓░░░▓▓▓░░░▓▓▓░░░\n░░░▓▓▓░░░▓▓▓░░░▓▓▓░░░▓▓▓\n▓▓▓░░░▓▓▓░░░▓▓▓░░░▓▓▓░░░\n░░░▓▓▓░░░▓▓▓░░░▓▓▓░░░▓▓▓");
            Console.WriteLine("\n\n\n");

            do
            {
                if
(i < j)
                {

                }

                else
                {

                }
            } while (i < j);



            for (var y = 0; y< 8; y++)
            {
                for(var x=0; x<8;x++)
                {
                    int ci = (x / 2 + y) % 2;

                    string c = ci == 0 ? "░░░" : "▓▓▓";

                    
                }

                    Console.Write('\n');

            }






        }






    }
}
