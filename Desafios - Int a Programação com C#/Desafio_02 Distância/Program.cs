using System;

class Desafio
{
    static void Main()
    {
        int quilometros = Int32.Parse(Console.ReadLine());
        int minutos = quilometros * 2; // Em t = 60min, d = 30Km.  Logo, t = d(6/3);   minutos = quilometros * 2;

        Console.WriteLine(minutos + " minutos");
    }
}
