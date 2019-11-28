using System;

namespace AgendaTelefonica
{
    class Program 
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("====================");
            Console.WriteLine("===== Cadastro =====");
            Console.WriteLine("====================");
            System.Console.Write("Digite seu Nome: ");
            string Nome = Console.ReadLine();
            System.Console.Write("Digite seu Telefone: ");
            int Telefone = int.Parse(Console.ReadLine());
            System.Console.Write($"Digite sua data de Aniversário: ");
            DateTime Aniversario = int.Parse(Console.ReadLine());

            Registro registro = new Registro(Nome, Telefone, Aniversario);

            

            
            
        }
    }
}
