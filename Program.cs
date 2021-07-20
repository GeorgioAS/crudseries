using System;

namespace crudseries
{
    class Program
    {
        static void Main(string[] args)
        {
          

        }

        private static string ObterOpcoes(){
            
            Console.WriteLine("DIO Séries a seu dispor!");            
            Console.WriteLine("Informe a opção desejada:");
            
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir série");
            Console.WriteLine("3 - Atualizar séries");
            Console.WriteLine("4 - Excluir séries");
            Console.WriteLine("5 - Visualizar séries");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");

            string Opcao =Console.ReadLine().ToUpper();
            Console.WriteLine("");
            return Opcao;            
        }

    }
}
