using System;
using System.Globalization;

namespace AppProvaLogicProg_Exerc_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Praticando uso de variaveis. - C#
            Console.WriteLine("Entre com seu nome completo: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int bedrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura (Mesma Linha)");
            string[] vet = Console.ReadLine().Split(' ');

            string lastName = vet[0].ToString();
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(fullName);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine(); 
        }
    }
}
