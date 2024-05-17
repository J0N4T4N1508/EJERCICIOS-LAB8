/*Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
están ordenados de menor a mayor. */

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> conjunto = new HashSet<int> { 1, 5, 2, 6, 4, 3 };
        HashSet<int> conjuntoOrdenado = ConjuntoOrdenado(conjunto);

        Console.WriteLine("Conjunto ordenado:");
        foreach (var numero in conjuntoOrdenado)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> ConjuntoOrdenado(HashSet<int> conjunto)
    {
        List<int> listaOrdenada = conjunto.ToList();
        listaOrdenada.Sort();

        return new HashSet<int>(listaOrdenada);
    }
}
