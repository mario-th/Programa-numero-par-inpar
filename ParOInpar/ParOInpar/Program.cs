using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Programa para verificar si un numero es par o inpar. *****");

        Console.Write("Ingrese el numero entero que desea verificar: ");
        int numero = int.Parse(Console.ReadLine());

        int verificacion = numero % 2;

        if(verificacion == 0)
        {
            Console.WriteLine($"El numero {numero} es Par");
        }
        else
        {
            Console.WriteLine($"El numero {numero} es inpar");
        }
    }
}
