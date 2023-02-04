using ProjetoTreze;
using System;
using System.Globalization;

namespace Exercicio
{
    class ProjetoTreze
    {
        static void Main(string[] args)
        {
            Pessoas x, y;
            x = new Pessoas();
            y = new Pessoas();

            Console.WriteLine("Digite o seu nome:");
            x.Name = Console.ReadLine();
            Console.WriteLine("Digite a sua idade:");
            x.Oldness = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome do(a) seu(sua) cônjuge:");
            y.Name = Console.ReadLine();
            Console.WriteLine("Digite a respectiva idade:");
            y.Oldness = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x.Oldness > y.Oldness)
            {
                Console.WriteLine("Dos dois, o(a) mais velho(a) é: " + x.Name);
            }
            else if (x.Oldness < y.Oldness)
            {
                Console.WriteLine("Dos dois, o(a) mais velho(a) é: " + y.Name);
            }
            else
            {
                Console.WriteLine("Os dois possuem a mesma idade");
            }

            Console.ReadKey();
        }
    }
}