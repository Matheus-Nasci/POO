namespace AgendaTelefonica {
    public class Registro {
        // Aqui vai os atributos da classe Usuário da AgendaTelefonica 
        private string Nome;
        private string Telefone;
        private string Aniversario;
        // Criar uma Classe para o construtor 
        private Registro(string Nome, string Telefone, string Aniversario)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Aniversario = Aniversario;
        }
        

    }
}