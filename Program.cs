using System;

namespace crudseries
{
    class Program
    {      
        static void Main(string[] args)
        {
          string opcao = ObterOpcoes();
          SerieRepositorio _repositorio = new SerieRepositorio();
          SerieApp _aplicacaoSerie = new SerieApp(_repositorio);

          while (opcao != "X") {
              switch (opcao) {
                  case "1": 
                    _aplicacaoSerie.Listar();
                    break;
                  case "2":
                    _aplicacaoSerie.Inserir();
                    break;
                  case "4":
                    _aplicacaoSerie.Excluir();
                    break;
                  case "3":
                    _aplicacaoSerie.Atualizar();
                    break;
                  case "5":
                    _aplicacaoSerie.Visualizar();
                    break;
                  case "C":
                    Console.Clear();
                    break;
                  default: 
                    break;
              }
              opcao = ObterOpcoes();
              if (opcao.Equals("X")) {
                  return;
              }
          }

        }

        private static string ObterOpcoes(){
            
            Console.WriteLine("DIO Séries a seu dispor!");            
            Console.WriteLine("Informe a opção desejada:");
            
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir série");
            Console.WriteLine("3 - Atualizar séries");
            Console.WriteLine("4 - Excluir séries");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");

            string Opcao =Console.ReadLine().ToUpper();
            Console.WriteLine("");
            return Opcao;            
        }

    }
}
