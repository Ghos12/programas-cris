using System;

namespace practca_cris_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables 
            string firstname = "cristian";
            String lastname = "yahir";
            int edad = 18;
            //concatenacion de varables 
            var name = firstname + " " + lastname;
            //imprmir varables dentro del textof
            Console.WriteLine("Su nombre es: {0} y su edad es: {1}", name, edad);
        }
    }
}