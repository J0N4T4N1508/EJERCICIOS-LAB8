/*Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
están ordenados de menor a mayor y que no están duplicados. */

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int> { 1, 1, 2, 3, 4, 5, 4, 8, 2, 7, 9 };
        HashSet<int> numerosOrdenadosSinDuplicados = NoDuplicadosOrdenados(numeros);

        Console.WriteLine("Números ordenados sin duplicados:");
        foreach (var numero in numerosOrdenadosSinDuplicados)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> NoDuplicadosOrdenados(List<int> conjunto)
    {
        HashSet<int> numerosOrdenadosSinDuplicados = new HashSet<int>();

        foreach (int numero in conjunto)
        {
            if (contarOcurrencias(conjunto, numero) == 1)
            {
                numerosOrdenadosSinDuplicados.Add(numero);
            }
        }

        List<int> listaOrdenada = new List<int>(numerosOrdenadosSinDuplicados);
        listaOrdenada.Sort();
        return new HashSet<int>(listaOrdenada);
    }

    static int contarOcurrencias(List<int> conjunto, int numero)
    {
        int contar = 0;
        foreach (int n in conjunto)
        {
            if (n == numero)
            {
                contar++;
            }
        }
        return contar;
    }
}