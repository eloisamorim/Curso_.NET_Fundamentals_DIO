using System;

class Desafio
{
    static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());  // Entrada N para quantidade de pares que serão lidos

        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split(" ");

            float x = float.Parse(entrada[0]);
            float y = float.Parse(entrada[1]);

            float divisao = x / y;

            if (y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                Console.WriteLine(divisao.ToString("N1"));
            }
        }
    }
}