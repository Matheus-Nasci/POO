namespace Elevador {
    public class Elevador {
        public int AndarAtual {get;set;}
        public int AndarTotal {get;set;}

        Capacidade capacidade = new Capacidade ();
        Total total = new Total ();
        public Elevador (int Andar, int AndarTotal) {
            this.AndarAtual = 0;
            this.AndarTotal = 12;

            if(capacidade <= 1)
            {
                System.Console.WriteLine("Não pode remover se não houver alguém dentro.");
            }

            while ((capacidade > 1)&&(capacidade <= 10))
            {
                System.Console.WriteLine("Pode acresentar Pessoas !");
            } 

            if (Total == 12)
            {
                System.Console.WriteLine("Não como subir.");
            }

            if (AndarTotal == 0)
            {
                System.Console.WriteLine("Não como descer.");
            }
        }
    }
}