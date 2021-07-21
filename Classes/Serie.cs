using System.Text;

namespace crudseries
{
    public class Serie:EntidadeBase
    {
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get; set;}
        public Serie(int Id, Genero genero, string titulo, string descricao, int ano) {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public void Atualiza(Genero genero, string titulo, string descricao, int ano) {
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Título: {this.Titulo} (Id {this.RetornaID()})");
            retorno.AppendLine("Descrição: " + this.Descricao);
            retorno.AppendLine("Gênero: " + this.Genero);
            retorno.AppendLine("Ano: " + this.Ano);
            return retorno.ToString();
        }

        public string RetornaTitulo() {
            return this.Titulo;
        }

        public int RetornaID() {
            return this.Id;
        }

        public void Excluir() 
        {
            this.Excluido = true;
        }

        public bool Excluida() 
        {
            return this.Excluido;
        }

    }
}