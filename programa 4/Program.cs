using System;
namespace progam_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduzca su nombre:");
            string name = Console.ReadLine();
            Console.WriteLine("introduzca su edad:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("su nombre es: {0} y tiene {1} años de edad", name, edad);

        }
    }
}