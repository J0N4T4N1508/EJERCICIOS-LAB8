/*Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son
anagramas. */

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> conjuntoPalabrasEjemplo = new HashSet<string> { "listen", "silent", "enlist", "hello", "world", "python" };

        HashSet<string> resultadoAnagramas = EncontrarAnagramas(conjuntoPalabrasEjemplo);

        Console.WriteLine("Conjunto de palabras:");
        foreach (var palabra in conjuntoPalabrasEjemplo)
        {
            Console.WriteLine(palabra);
        }

        Console.WriteLine("\nConjunto de anagramas:");
        foreach (var anagrama in resultadoAnagramas)
        {
            Console.WriteLine(anagrama);
        }
    }

    static HashSet<string> EncontrarAnagramas(HashSet<string> conjuntoPalabras)
    {
        HashSet<string> anagramas = new HashSet<string>();

        foreach (string palabra1 in conjuntoPalabras)
        {
            foreach (string palabra2 in conjuntoPalabras)
            {
                if (palabra1 != palabra2 && SonAnagramas(palabra1, palabra2))
                {
                    anagramas.Add(palabra1);
                    anagramas.Add(palabra2);
                }
            }
        }

        return anagramas;
    }

    static bool SonAnagramas(string palabra1, string palabra2)
    {
        if (palabra1.Length != palabra2.Length)
            return false;

        var arrayPalabra1 = palabra1.ToCharArray();
        var arrayPalabra2 = palabra2.ToCharArray();

        Array.Sort(arrayPalabra1);
        Array.Sort(arrayPalabra2);

        return arrayPalabra1.SequenceEqual(arrayPalabra2);
    }
}