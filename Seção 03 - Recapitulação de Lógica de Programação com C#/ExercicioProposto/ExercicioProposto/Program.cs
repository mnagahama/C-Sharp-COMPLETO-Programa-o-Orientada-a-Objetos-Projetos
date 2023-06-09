﻿using System;
using System.Globalization;

namespace ExercicioProposto // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa ?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string lastName = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Seu nome completo é : " + fullName);
            Console.WriteLine("Sua casa tem: " + quartos + " quartos");
            Console.WriteLine("O preço do produto é: "+ preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Seu ultimo nome é: " + lastName);
            Console.WriteLine("Sua idade é: " + age);
            Console.WriteLine("Sua altura é: " + height.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
