﻿namespace OperadorLogico
{
    class Program
    {

        static void Main(string[] args) {

            //Operador && sempre tem que retornar os dois valores verdadeiros
            bool c1 = 2 > 3 || 4 != 5;

            //Um dos valores serão verdadeiros
            bool c2 = ! (2 > 3) && 4 != 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("-------------------------------------");

            bool c3 = 10< 5;
            bool c4 = c1 || c2 && c3;

            Console.WriteLine(c3);
            Console.WriteLine(c4);
        }
    }
}
