using System;

namespace numeros_divisores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            double divisor = 0;
            String aux = ""; // Acumula los numeros es un String, para luego mostrarlos

            Console.WriteLine("Ingrese un numero entre el 1 - 100");
            try
            {
                numero = double.Parse(Console.ReadLine());
                for (int i = 1; i <= numero; i++)
                {
                    divisor = numero / i;
                    if (divisor == Math.Floor(divisor))
                    {
                        aux += " " + i;
                    }
                }
                Console.WriteLine("Los divisores son:{0}", aux);

            } 
            catch (Exception e)
            {
                Console.Beep(); 
                Console.WriteLine($"Error: {e.Message}");
            }


            Console.WriteLine("\nPresione cualquier tecla para salir... ");
            Console.ReadKey();
        }
    }
}
