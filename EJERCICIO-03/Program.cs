/*Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que son
 * divisibles por un número determinado. 
*/

class Program
{
    static void Main()
    {
        var conjunto = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int divisor = 2; // Especifica el divisor

        var resultado = NumerosDivisibles(conjunto, divisor);

        Console.WriteLine("Números divisibles por " + divisor + ":");
        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    static List<int> NumerosDivisibles(List<int> numeros, int divisor)
    {
        var resultado = new List<int>();

        foreach (var numero in numeros)
        {
            if (numero % divisor == 0)
            {
                resultado.Add(numero);
            }
        }

        return resultado;
    }
}
