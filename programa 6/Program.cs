using System;

namespace programa_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("introduzca un numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca un numero:");
            num2 = int.Parse(Console.ReadLine());
            var suma = num1 + num2;
            Console.WriteLine("la suma de los numeros es: {0}", suma);
            var resta = num1 - num2;
            Console.WriteLine("la resta de los numeros es: {0}", resta);
            var multiplicacion = num1 * num2;
            Console.WriteLine("la multiplicacion de los numeros es: {0}", multiplicacion);
            var division = num1 / num2;
            Console.WriteLine("la division de los numeros es: {0}", division);


            
        }
    }
}
