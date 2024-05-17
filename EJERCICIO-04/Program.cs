/*Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que
están en ambos conjuntos. */

class Program
{
    static void Main(string[] args)
    {
        var conjunto1 = new List<int> { 1, 4, 6, 15, 4, 5, 6, 17, 1, 4, 5, 2, 6, 7, 10 };
        var conjunto2 = new List<int> { 1, 4, 8, 8, 6, 2, 35, 10 };

        var interseccion = Interseccion(conjunto1, conjunto2);

        Console.WriteLine("Intersección de conjuntos:");
        foreach (var numero in interseccion)
        {
            Console.WriteLine(numero);
        }
    }

    static List<int> Interseccion(List<int> conjunto1, List<int> conjunto2)
    {
        var resultado = new List<int>();

        foreach (var numero in conjunto1)
        {
            if (conjunto2.Contains(numero) && !resultado.Contains(numero))
            {
                resultado.Add(numero);
            }
        }

        return resultado;
    }
}