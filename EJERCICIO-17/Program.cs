/*Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
tienen una longitud determinada y están ordenadas de menor a mayor.*/

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> palabras = new HashSet<string> { "Python", "Programación", "lapiz", "Conjunto", "Ejemplo", "Palabra", "hola" };
        int longitud = 7;

        HashSet<string> palabrasOrdenadas = PalabrasOrdenadas(palabras, longitud);

        Console.WriteLine("Palabras ordenadas con longitud mayor o igual a " + longitud + ":");
        foreach (var palabra in palabrasOrdenadas)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> PalabrasOrdenadas(HashSet<string> conjuntoPalabras, int longitud)
    {
        HashSet<string> palabrasOrdenadas = new HashSet<string>();

        foreach (string palabra in conjuntoPalabras)
        {
            if (palabra.Length >= longitud)
            {
                palabrasOrdenadas.Add(palabra);
            }
        }

        return OrdenarPalabras(palabrasOrdenadas);
    }

    static HashSet<string> OrdenarPalabras(HashSet<string> palabras)
    {
        List<string> listaOrdenada = palabras.ToList();
        listaOrdenada.Sort();
        return new HashSet<string>(listaOrdenada);
    }
}
