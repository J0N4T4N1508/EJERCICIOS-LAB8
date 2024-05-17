/* Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que comienzan con una letra determinada. */

class Program
{
    static void Main(string[] args)
    {
        var palabras = new List<string> { "sistemas", "programacion", "consola", "universidad" ,"perro"};
        char letraDeterminada = 'p'; // Especifica la letra determinada

        var resultado = ConjuntoPalabras(palabras, letraDeterminada);

        Console.WriteLine("Palabras que comienzan con la letra '" + letraDeterminada + "':");
        foreach (var palabra in resultado)
        {
            Console.WriteLine(palabra);
        }
    }

    static List<string> ConjuntoPalabras(List<string> palabras, char letra)
    {
        var resultado = new List<string>();

        foreach (var palabra in palabras)
        {
            if (!string.IsNullOrEmpty(palabra) && palabra[0] == letra)
            {
                resultado.Add(palabra);
            }
        }

        return resultado;
    }
}
