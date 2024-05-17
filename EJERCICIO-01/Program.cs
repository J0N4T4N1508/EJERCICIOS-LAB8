
// Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números primos. 


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var conjunto = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var conjuntoPrimos = EncontrarPrimos(conjunto);

        Console.WriteLine("Conjunto de numeros primos:");
        Console.WriteLine("");

        foreach (int item in conjuntoPrimos)
        {
            Console.WriteLine(item);
        }
    }

    static List<int> EncontrarPrimos(List<int> numeros)
    {
        var primos = new List<int>();

        foreach (int numero in numeros)
        {
            int divisores = 0; 
            for (int i = 1; i <= numero; i++) 
            {
                if (numero % i == 0)
                {
                    divisores++;
                }
            }
            if (divisores == 2)
            {
                primos.Add(numero);
            }
        }

        return primos;
    }
}
