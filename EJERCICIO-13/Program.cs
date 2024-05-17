/*Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
están duplicados. */

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int> { 1, 1, 2, 3, 4, 5, 4, 8, 2, 7, 9 };
        HashSet<int> duplicados = NDuplicados(numeros);

        Console.WriteLine("Números duplicados:");
        foreach (var numero in duplicados)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> NDuplicados(List<int> conjunto)
    {
        HashSet<int> duplicados = new HashSet<int>();

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
            if (contar == 2)
            {
                duplicados.Add(conjunto[i]);
            }
        }

        return duplicados;
    }
}