using System;

class minhaClasse
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 2; i++)
        {
            string[] entrada = Console.ReadLine().Split(" ");

            double H = double.Parse(entrada[0]);
            double P = double.Parse(entrada[1]);

            double media = H / P;

            Console.WriteLine(Math.Round(media, 2));
        }
    }
}