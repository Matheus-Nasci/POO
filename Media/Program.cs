using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            string Entrada = " ";

            System.Console.Write("----- Média -----");
            System.Console.Write("Digite seu Nome: ");
            Entrada = Console.ReadLine();
            aluno.Nome = Entrada;
            System.Console.Write("Nota 1: ");       
            Entrada = Console.ReadLine();
            aluno.Nota1 = Convert.ToDouble(Entrada);    
            System.Console.Write("Nota 2: ");    
            Entrada = Console.ReadLine();
            aluno.Nota2 = Convert.ToDouble(Entrada);         
            System.Console.Write("Nota 3: ");   
            Entrada = Console.ReadLine();
            aluno.Nota3 = Convert.ToDouble(Entrada);        
            System.Console.Write("Nota 4: "); 
            Entrada = Console.ReadLine();
            aluno.Nota4 = Convert.ToDouble(Entrada);      
            aluno.ExibirMedia();
            aluno.Media = Entrada;  
            Console.ReadKey();     
        }
    }
}
