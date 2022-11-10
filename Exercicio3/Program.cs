using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo;

            retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retâgulo:");

            Console.Write("Largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            Console.WriteLine($"AREA: {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)} ");
            Console.WriteLine($"PERÍMETRO: {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)} ");
            Console.WriteLine($"DIAGONAL: {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)} ");
        }
    }
}
