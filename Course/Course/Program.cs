﻿namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F'; // character ''
            char letra = '\u0041'; //unicode
            byte n1= 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 21474836478L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Thaina Mai"; //string ""

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
        }   
    }
}