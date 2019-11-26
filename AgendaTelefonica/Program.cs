using System;

namespace AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Cadastro Agenda Telefónica");
            Console.WriteLine();
            Console.Write("Digite seu Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Digite seu Telefone: ");
            string Telefone = Console.ReadLine();
            Console.Write("Digite seu Aniversário: ");
            string Aniversario = Console.ReadLine();

            Usuario usuario = new Usuario();
            
        }
    }
}
