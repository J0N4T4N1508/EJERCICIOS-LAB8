/*Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son
palíndromos. */

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> conjuntoPalabras = new HashSet<string> { "estructuradedatos","radar", "oso", "reconocer", "casa", "sistemas", "ana", "solos" };

        HashSet<string> palindromos = EncontrarPalindromos(conjuntoPalabras);

        Console.WriteLine("Palabras en el conjunto:");
        foreach (var palabra in conjuntoPalabras)
        {
            Console.WriteLine(palabra);
        }

        Console.WriteLine("\nPalabras que son palíndromos:");
        foreach (var palindromo in palindromos)
        {
            Console.WriteLine(palindromo);
        }
    }

    static HashSet<string> EncontrarPalindromos(HashSet<string> conjuntoPalabras)
    {
        HashSet<string> palindromos = new HashSet<string>();

        foreach (string palabra in conjuntoPalabras)
        {
            if (EsPalindromo(palabra))
            {
                palindromos.Add(palabra);
            }
        }

        return palindromos;
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
}
