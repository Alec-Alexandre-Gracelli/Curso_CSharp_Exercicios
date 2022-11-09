namespace Curso_CSharp_Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosPessoais Pessoa1, Pessoa2;

            Pessoa1 = new DadosPessoais();
            Pessoa2 = new DadosPessoais();

            Console.WriteLine("Insira os dados pessoais da primeira pessoa:");

            Console.Write("Nome:");
            Pessoa1.Nome = Console.ReadLine();

            Console.Write("Idade:");
            Pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira os dados pessoais da segunda pessoa:");

            Console.Write("Nome:");
            Pessoa2.Nome = Console.ReadLine();

            Console.Write("Idade:");
            Pessoa2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine($"Nome: {Pessoa1.Nome}");
            Console.WriteLine($"Idade: {Pessoa1.Idade}");

            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine($"Nome: {Pessoa2.Nome}");
            Console.WriteLine($"Idade: {Pessoa2.Idade}");

            if(Pessoa1.Idade > Pessoa2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {Pessoa1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {Pessoa2.Nome}");
            }

        }
    }
}
