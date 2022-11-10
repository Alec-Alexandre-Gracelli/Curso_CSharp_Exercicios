using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosSalariais funcionario1, funcionario2;

            funcionario1 = new DadosSalariais();
            funcionario2 = new DadosSalariais();

            Console.WriteLine("Insira os dados do primeiro funcionário:");

            Console.Write("Nome:");
            funcionario1.Nome = Console.ReadLine();

            Console.Write("Salário:");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira os dados do segundo funcionário:");

            Console.Write("Nome:");
            funcionario2.Nome = Console.ReadLine();

            Console.Write("Salário:");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.WriteLine($"Nome: {funcionario1.Nome}");
            Console.WriteLine($"Idade: {funcionario1.Salario}");

            Console.WriteLine("Dados do segundo funcionário:");
            Console.WriteLine($"Nome: {funcionario2.Nome}");
            Console.WriteLine($"Idade: {funcionario2.Salario}");

            double media = (funcionario1.Salario + funcionario2.Salario) / 2.0;

            Console.WriteLine($"Salário médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");

           

        }
    }
}