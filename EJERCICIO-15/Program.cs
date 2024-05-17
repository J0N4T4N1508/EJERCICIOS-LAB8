/*Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que son
primos y están ordenados de menor a mayor. */

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> conjuntoNumeros = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        HashSet<int> numerosPrimosOrdenados = NumerosPrimosOrdenados(conjuntoNumeros);

        Console.WriteLine("Números primos ordenados:");
        foreach (var numero in numerosPrimosOrdenados)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> NumerosPrimosOrdenados(HashSet<int> numeros)
    {
        HashSet<int> numerosPrimosOrdenados = new HashSet<int>();

        foreach (int numero in numeros)
        {
            if (EsPrimo(numero))
            {
                numerosPrimosOrdenados.Add(numero);
            }
        }

        return numerosPrimosOrdenados;
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
