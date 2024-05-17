/*Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
contienen una letra determinada y están ordenadas de mayor a menor.*/

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> palabras = new HashSet<string> { "hola", "manzana", "sistemas", "azul", "marron", "lapiz" };
        char letra = 'a';

        HashSet<string> palabrasConLetraOrdenadas = PalabrasConLetraOrdenada(palabras, letra);

        Console.WriteLine("Palabras que contienen la letra '" + letra + "' ordenadas de mayor a menor:");
        foreach (var palabra in palabrasConLetraOrdenadas)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> PalabrasConLetraOrdenada(HashSet<string> conjuntoPalabras, char letra)
    {
        HashSet<string> palabrasConLetra = new HashSet<string>();

        foreach (string palabra in conjuntoPalabras)
        {
            if (palabra.Contains(letra))
            {
                palabrasConLetra.Add(palabra);
            }
        }

        return OrdenarPalabrasDescendente(palabrasConLetra);
    }

    static HashSet<string> OrdenarPalabrasDescendente(HashSet<string> palabras)
    {
        List<string> listaOrdenada = palabras.ToList();
        listaOrdenada.Sort((a, b) => b.CompareTo(a));
        return new HashSet<string>(listaOrdenada);
    }
}
