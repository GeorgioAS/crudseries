using System;
using crudseries.Interfaces;
namespace crudseries
{
    public class SerieAplicacao
    {
        private IRepositorio<Serie> _repositorio;
        public SerieAplicacao()
        {
             _repositorio = new SerieRepositorio();
            GeraSerieTeste();
        }

        public void Inserir() {
            foreach (int i in Enum.GetValues<Genero>())
            {
                Console.WriteLine("[{0}] {1}", i, Enum.GetName(typeof(Genero),i));                
            }            
            Console.WriteLine("Digite o genero entre as opções acima.");
            string genero = Console.ReadLine().ToUpper();
            Console.WriteLine("Informe o Título");
            string titulo = Console.ReadLine();
            Console.WriteLine("Informe a Descrição");
            string descricao = Console.ReadLine();
            Console.WriteLine("Informe o Ano");
            string ano = Console.ReadLine().ToUpper();

            Serie serie = new Serie(_repositorio.ProximoID(),
                                    (Genero)Enum.Parse(typeof(Genero), genero),
                                    titulo,
                                    descricao,
                                    int.Parse(ano));

            _repositorio.Insere(serie);
        }
        
        public void Atualizar() {
            Console.WriteLine("Digite o Id da série:");
            string id = Console.ReadLine().ToUpper();
            Serie serie = _repositorio.RetornaPorID(int.Parse(id));
            if (serie == null) {
                Console.WriteLine("Id informado não foi cadastrado:");
            }
            foreach (int i in Enum.GetValues<Genero>())
            {
                Console.WriteLine("[{0}] {1}", i, Enum.GetName(typeof(Genero),i));                
            }            
            Console.WriteLine("Digite o genero entre as opções acima.");
            string genero = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite o Título");
            string titulo =Console.ReadLine();
            Console.WriteLine("Digite a Descrição");
            string descricao =Console.ReadLine();
            Console.WriteLine("Digite o Ano");
            string ano =Console.ReadLine().ToUpper();

            serie.Atualiza((Genero)Enum.Parse(typeof(Genero), genero),
                            titulo,
                            descricao,
                            int.Parse(ano));

            _repositorio.Atualiza(serie.RetornaID(),serie);
        }        
        public void Listar() {
            if (_repositorio.Lista().Count == 0) {
                Console.WriteLine("Não há séries cadastradas.");
            }
            else {
                foreach (var _serie in _repositorio.Lista())
                {                 
                  Console.WriteLine("Id:{0} Título:{1} {2}",_serie.RetornaID(),_serie.RetornaTitulo(),(_serie.Excluido() ? "Excluido" : ""));                                          
                }          
                Console.WriteLine();
            }
        }

         public void Visualizar() {
            Console.WriteLine("Digite o Id da série:");
            string id =Console.ReadLine().ToUpper();
            Serie serie = _repositorio.RetornaPorID(int.Parse(id));
            if (serie != null) {
               Console.WriteLine(serie.ToString());
             } else {
                Console.WriteLine("Id informado não foi cadastrado:");
            }            
        }

         public void Excluir() {
            Console.WriteLine("Digite o Id da série a ser excluído:");
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