using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");

            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = aluno.NotaFinal();
            Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}");

            if (notaFinal > 60.00)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                double restante = 60.00 - aluno.NotaFinal();
                Console.WriteLine($"FALTARAM {restante.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }


        }
    }
}
