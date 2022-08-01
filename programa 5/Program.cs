using System;

namespace program_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("introduzca un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca otro numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("la suma de los numeros es: " + (num1 + num2));
            Console.WriteLine("la resta de los numeros es: " + (num1 - num2));
        }
    }
}