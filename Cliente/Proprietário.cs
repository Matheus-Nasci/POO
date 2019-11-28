namespace Cliente
{
    public class Proprietário
    {
        public string Nome {get;set;}

        public int Cpf {get;set;}
        public int Rg {get;set;}
        public int DatadeNascimento {get;set;}
        public string Rua {get;set;}
        public string Bairro {get;set;}
        public string Cidade {get;set;}
        public string Estado {get;set;}
        public int Cep {get;set;}

        public Proprietário(string Nome, int CPF, int RG, int DatadeNascimento, string Rua, string Bairro, string Cidade, string Estado, int CEP)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Rg = Rg;
            this.DatadeNascimento = DatadeNascimento;
            this.Rua = Rua;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Estado = Estado;
            this.Cep = Cep;
        }
    }
}