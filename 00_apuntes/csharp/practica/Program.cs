//Emilio Vega de Llergo Vargas
//00549955

using System; //Librería básica para entrada y salida

class InputOutput
{
    static void Main(string[] args)
    {
        string nombre;
        int n1, n2;

        Console.WriteLine("¿Cuál es tu nombre?"); //Salida de datos
        nombre = Console.ReadLine(); //Entrada de datos

        Console.WriteLine("Hola " + nombre + ", escribe dos valores enteros: ");
        n1 = Convert.ToInt32(Console.ReadLine()); //Entrada de datos y conversión a entero
        n2 = Convert.ToInt32(Console.ReadLine()); //Entrada de datos y conversión a entero

        Console.WriteLine("La suma de " + n1 + " y " + n2 + " es: " + (n1 + n2)); //Salida de datos

    }
}