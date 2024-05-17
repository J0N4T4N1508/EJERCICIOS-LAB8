/*Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
están ordenados de mayor a menor.*/

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> numeros = new HashSet<int> { 1, 5, 2, 6, 4, 3 };
        HashSet<int> conjuntoOrdenado = ConjuntoOrdenado(numeros);

        Console.WriteLine("Conjunto ordenado de mayor a menor:");
        foreach (var numero in conjuntoOrdenado)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> ConjuntoOrdenado(HashSet<int> conjunto)
    {
        List<int> listaOrdenada = conjunto.ToList();
        listaOrdenada.Sort((a, b) => b.CompareTo(a));

        return new HashSet<int>(listaOrdenada);
    }
}
