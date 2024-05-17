/*Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que no
están duplicados. */

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int> { 1, 1, 2, 3, 4, 5, 4, 8, 2, 7, 9 };
        HashSet<int> noDuplicados = NoDuplicados(numeros);

        Console.WriteLine("Números no duplicados:");
        foreach (var numero in noDuplicados)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> NoDuplicados(List<int> conjunto)
    {
        HashSet<int> noDuplicados = new HashSet<int>();

        for (int i = 0; i < conjunto.Count; i++)
        {
            int contar = 0;
            for (int j = 0; j < conjunto.Count; j++)
            {
                if (conjunto[i] == conjunto[j])
                {
                    contar++;
                }
            }
            if (contar == 1)
            {
                noDuplicados.Add(conjunto[i]);
            }
        }

        return noDuplicados;
    }
}