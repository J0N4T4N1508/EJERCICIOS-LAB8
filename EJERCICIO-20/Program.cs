/*Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son
palíndromos, tienen una longitud determinada y están ordenadas de menor a mayor. */

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> palabras = new HashSet<string> { "radar", "oso", "reconocer", "casa", "luz", "ana", "solos" };
        int longitud = 5;

        HashSet<string> palindromosOrdenados = PalindromosOrdenados(palabras, longitud);

        Console.WriteLine("Palíndromos de longitud " + longitud + " ordenados:");
        foreach (var palabra in palindromosOrdenados)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> PalindromosOrdenados(HashSet<string> conjuntoPalabras, int longitud)
    {
        HashSet<string> palindromos = new HashSet<string>();

        foreach (string palabra in conjuntoPalabras)
        {
            if (EsPalindromo(palabra) && palabra.Length == longitud)
            {
                palindromos.Add(palabra);
            }
        }

        return OrdenarPalabras(palindromos);
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
        List<string> listaOrdenada = palabras.ToList();
        listaOrdenada.Sort();
        return new HashSet<string>(listaOrdenada);
    }
}
