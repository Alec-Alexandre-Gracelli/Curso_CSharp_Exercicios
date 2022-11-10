namespace Curso_CSharp_Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosPessoais pessoa1, pessoa2;

            pessoa1 = new DadosPessoais();
            pessoa2 = new DadosPessoais();

            Console.WriteLine("Insira os dados pessoais da primeira pessoa:");

            Console.Write("Nome:");
            pessoa1.Nome = Console.ReadLine();

            Console.Write("Idade:");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira os dados pessoais da segunda pessoa:");

            Console.Write("Nome:");
            pessoa2.Nome = Console.ReadLine();

            Console.Write("Idade:");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine($"Nome: {pessoa1.Nome}");
            Console.WriteLine($"Idade: {pessoa1.Idade}");

            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine($"Nome: {pessoa2.Nome}");
            Console.WriteLine($"Idade: {pessoa2.Idade}");

            if(pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");
            }

        }
    }
}
