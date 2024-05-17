/*Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
tienen una longitud determinada. */

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> conjuntoPalabras = new HashSet<string> { "hola mundo", "programacion", "naranja", "negro" };
        int longitud = 10;

        HashSet<string> palabrasLongitudDeterminada = LongitudPalabra(conjuntoPalabras, longitud);

        Console.WriteLine("Palabras con longitud igual o mayor a " + longitud + ":");
        foreach (var palabra in palabrasLongitudDeterminada)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> LongitudPalabra(HashSet<string> palabras, int longitud = 10)
    {
        HashSet<string> palabrasLongitud = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Length >= longitud)
            {
                palabrasLongitud.Add(palabra);
            }
        }

        return palabrasLongitud;
    }
}