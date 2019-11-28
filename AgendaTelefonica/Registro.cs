namespace AgendaTelefonica {
    public class Registro {
        // Aqui vai os atributos da classe Registro da AgendaTelefonica 
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public int Aniversario { get; set; }

        public Registro (string nome, int telefone, int aniversario) {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Aniversario = aniversario;
        }

    }
}