namespace AgendaTelefonica {
    public class Registro {
        // Aqui vai os atributos da classe Registro da AgendaTelefonica 
        private string Nome {get;set;}
        private int Telefone {get;set;}
        private int Aniversario {get;set;}

        private Registro(string Nome, int Telefone, int Aniversario)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Aniversario = Aniversario;
        }

    }
}