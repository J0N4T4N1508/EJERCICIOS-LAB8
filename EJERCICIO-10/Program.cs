/*Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
contienen una letra determinada*/

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> conjuntoPalabras = new HashSet<string> { "hola", "manzana", "sistemas", "azul", "marron", "lapiz" };
        char letra = 'o';

        Console.WriteLine($"Palabras que contienen la letra {letra}: ");
        PalabrasConLetraDeterminada(conjuntoPalabras, letra);
    }

    static void PalabrasConLetraDeterminada(HashSet<string> palabras, char letra)
    {
        foreach (string palabra in palabras)
        {
            if (palabra.Contains(letra))
            {
                Console.WriteLine(palabra);
            }
        }
    }
}
