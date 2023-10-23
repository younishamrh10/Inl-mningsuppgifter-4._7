using System;

namespace Inlämningsuppgifter4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ditt meddelande: ");
            string meddelande = Console.ReadLine();

            Console.Write("Ange antal steg att flytta åt höger (0 för längst till vänster): ");
            int steg = int.Parse(Console.ReadLine());

            for (int i = 0; i < meddelande.Length; i++)
            {
                for (int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}