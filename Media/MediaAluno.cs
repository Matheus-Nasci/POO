namespace MediaAluno
{
    public class MediaAluno
    {
        private string _Nome;
        public string Nome
        {
            get //Get significa Obter e Set significa Conjunto 
            {
                return this._Nome;
            }
            set
            {
                this._Nome = value;
            }
        }

        private double _Nota1;
        private double Nota1 
        {   
            get
            {
                return this._Nota1;
            }
            set
            {
                this._Nota1 = value;
            }
        }
        private double _Nota2;
        private double Nota2 
        {   
            get
            {
                return this._Nota2;
            }
            set
            {
                this._Nota2 = value;
            }
        }
        private double _Nota3;
        private double Nota3 
        {   
            get
            {
                return this._Nota3;
            }
            set
            {
                this._Nota3 = value;
            }
        }
        private double _Nota4;
        private double Nota4 
        {   
            get
            {
                return this._Nota4;
            }
            set
            {
                this._Nota4 = value;
            }
        }

        public double Media()
        {
            return (this._Nota1 + this._Nota2 + this._Nota3 + this._Nota4) / 4;
        }

        public void ExibirMedia()
        {
            Console.Clear();
            System.Console.Write($"Nome: {Nome}");
            System.Console.Write($"Nota 1: {this._Nota1}");
            System.Console.Write($"Nota 2: {this._Nota2}");
            System.Console.Write($"Nota 3: {this._Nota3}");
            System.Console.Write($"Nota 4: {this._Nota4}");
            System.Console.Write($"Media: {this.Media()}");
            
        }
    }
}