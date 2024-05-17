/*Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son
palíndromos y están ordenadas de menor a mayor. */

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> palabras = new HashSet<string> { "radar", "oso", "reconocer", "casa", "luz", "ana", "solos" };
        HashSet<string> palindromosOrdenados = PalindromosOrdenados(palabras);

        Console.WriteLine("Palíndromos ordenados:");
        foreach (var palabra in palindromosOrdenados)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> PalindromosOrdenados(HashSet<string> palabras)
    {
        HashSet<string> palindromosOrdenados = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (EsPalindromo(palabra))
            {
                palindromosOrdenados.Add(palabra);
            }
        }

        return OrdenarPalabras(palindromosOrdenados);
    }

    static bool EsPalindromo(string palabra)
    {
        int i = 0;
        int j = palabra.Length - 1;

        while (i < j)
        {
            if (palabra[i] != palabra[j])
            {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }

    static HashSet<string> OrdenarPalabras(HashSet<string> palabras)
    {
        List<string> listaOrdenada = new List<string>(palabras);
        listaOrdenada.Sort();
        return new HashSet<string>(listaOrdenada);
    }
}
