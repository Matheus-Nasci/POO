using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {   
            double Entrada;
            Triangulo Objeto;
            Objeto = new Triangulo();

            Console.WriteLine("Verificar se é um Triângulo");
            System.Console.WriteLine("Digite o Valor dos Lados do Triângulo");

            System.Console.Write("LadoA: ");
            Entrada = double.Parse(Console.ReadLine());
            Objeto.LadoA = Convert.ToInt32(Entrada);

            System.Console.Write("LadoB: ");
            Entrada = double.Parse(Console.ReadLine());
            Objeto.LadoB = Convert.ToInt32(Entrada);

            System.Console.Write("LadoC: ");
            Entrada = double.Parse(Console.ReadLine());
            Objeto.LadoC = Convert.ToInt32(Entrada);

            Objeto.VerificarTriangulo();

            

            
        }
    }
}
