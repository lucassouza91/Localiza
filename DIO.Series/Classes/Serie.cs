namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set;}
        private string Titulo { get; set;}
        private string Descricao { get; set;}
        private int Ano { get; set;}

        //Metodos
        public Serie(int Id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }
        
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Enviromment.NewLine;
            retorno += "Título: " + this.Titulo + Enviromment.NewLine;
            retorno += "Descrição: " + this.Descricao + Enviromment.NewLine;
            retorno += "Ano de Início: " + this.Ano;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
    }
}