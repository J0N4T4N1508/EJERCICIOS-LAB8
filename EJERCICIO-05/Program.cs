/*Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que
están en el primer conjunto pero no en el segundo. */

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> conjunto1 = new HashSet<int> { 1, 2, 3, 4, 5, 6 };
        HashSet<int> conjunto2 = new HashSet<int> { 5, 6, 7, 8, 9, 10 };

        HashSet<int> diferencia = DiferenciaConjuntos(conjunto1, conjunto2);

        Console.WriteLine("Diferencia de conjuntos:");
        foreach (var numero in diferencia)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> DiferenciaConjuntos(HashSet<int> conjuntoUno, HashSet<int> conjuntoDos)
    {
        conjuntoUno.ExceptWith(conjuntoDos);
        return conjuntoUno;
    }
}
