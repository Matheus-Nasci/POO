using System;

namespace Pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Meu Nome é: {Nome} ");
            string Nome = Console.ReadLine(); 
            Console.Write($"Eu tenho {Altura} Metros de Altura !");
            double Altura = double.Parse(Console.ReadLine());
            
            string Entrada = " ";
            Pessoa Pessoa1;
            Pessoa1 = new Pessoa();
            System.Console.Write("Efetue a Leitura dos dados de 3 Pessoas");
            System.Console.Write("Informe o seu Nome: ");
            Entrada = Console.ReadLine();
            Pessoa1.Nome = Entrada;
            System.Console.Write("Informe sua Altura: ");
            Entrada = Console.ReadLine();
            Pessoa1.Altura = Convert.ToDouble(Entrada);
            Pessoa1.FaleSobreVoce();
            Console.ReadKey();

            Pessoa Pessoa2;
            Pessoa2 = new Pessoa();
            System.Console.Write("Informe o seu Nome: ");
            Entrada = Console.ReadLine();
            Pessoa2.Nome = Entrada;
            System.Console.Write("Informe sua Altura: ");
            Pessoa2.Altura = Convert.ToDouble(Entrada);
            Pessoa2.FaleSobreVoce();
            Console.ReadKey();
        }
    }
}
