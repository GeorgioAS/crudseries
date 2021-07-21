using System;
using crudseries.Interfaces;
namespace crudseries
{
    public class SerieApp
    {
        private IRepositorio<Serie> _repositorio;
        public SerieApp(IRepositorio<Serie> repositorio)
        {
            _repositorio = repositorio;
            GeraSerieTeste();
        }

        public void Inserir() {
            Console.WriteLine("Informe o Genero [1] Ação [2] Aventura [3] Comédia [4] Terror [5] Ficção [6] Fantasia");
            string genero =Console.ReadLine().ToUpper();
            Console.WriteLine("Informe o Título");
            string titulo =Console.ReadLine();
            Console.WriteLine("Informe a Descrição");
            string descricao =Console.ReadLine();
            Console.WriteLine("Informe o Ano");
            string ano =Console.ReadLine().ToUpper();

            Serie serie = new Serie(_repositorio.ProximoID(),
                                    (Genero)Enum.Parse(typeof(Genero), genero),
                                    titulo,
                                    descricao,
                                    int.Parse(ano));

            _repositorio.Insere(serie);
        }
        
        public void Atualizar() {
            Console.WriteLine("Informe o Id da série:");
            string id = Console.ReadLine().ToUpper();
            Serie serie = _repositorio.RetornaPorID(int.Parse(id));
            if (serie == null) {
                Console.WriteLine("Id informado não foi cadastrado:");
            }
            Console.WriteLine("Informe o Genero [1] Ação [2] Aventura [3] Comédia [4] Terror [5] Ficção [6] Fantasia");
            string genero =Console.ReadLine().ToUpper();
            Console.WriteLine("Informe o Título");
            string titulo =Console.ReadLine();
            Console.WriteLine("Informe a Descrição");
            string descricao =Console.ReadLine();
            Console.WriteLine("Informe o Ano");
            string ano =Console.ReadLine().ToUpper();

            serie.Atualiza((Genero)Enum.Parse(typeof(Genero), genero),
                            titulo,
                            descricao,
                            int.Parse(ano));

            _repositorio.Atualiza(serie.RetornaID(),serie);
        }        
        public void Listar() {
            foreach (var _serie in _repositorio.Lista())
            {
                if (!_serie.Excluida()) {
                    Console.WriteLine(_serie.ToString());
                    Console.WriteLine();
                }
            }
            
        }

         public void Visualizar() {
            Console.WriteLine("Informe o Id da série:");
            string id =Console.ReadLine().ToUpper();
            Serie serie = _repositorio.RetornaPorID(int.Parse(id));
            if (serie != null) {
               Console.WriteLine(serie.ToString());
             } else {
                Console.WriteLine("Id informado não foi cadastrado:");
            }            
        }

         public void Excluir() {
            Console.WriteLine("Informe o Id da série a ser excluído:");
            string id =Console.ReadLine().ToUpper();
            Serie serie = _repositorio.RetornaPorID(int.Parse(id));
            if (serie == null) {
                Console.WriteLine("Id informado não foi cadastrado:");
             } else {
               _repositorio.Exclui(serie.RetornaID());
            }            
        }        

        private void GeraSerieTeste() {
            Serie serie = new Serie(_repositorio.ProximoID(),
                                    (Genero)Enum.Parse(typeof(Genero), "6"),
                                    "Game of Thrones",
                                    "Melhor série que já existiu",
                                    2016);
            _repositorio.Insere(serie);

            Serie serie1 = new Serie(_repositorio.ProximoID(),
                                    (Genero)Enum.Parse(typeof(Genero), "1"),
                                    "Swat",
                                    "Série sobre a swat",
                                    1970);
            _repositorio.Insere(serie1);
        }

    }
}