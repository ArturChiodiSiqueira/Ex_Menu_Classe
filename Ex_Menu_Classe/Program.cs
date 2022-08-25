using System;

namespace Ex_Menu_Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] contatos = new Pessoa[10];
            int opcao;

            do
            {
                Console.WriteLine("1 - CADASTRAR\n0 - SAIR");
                Console.Write("Informe a ocao desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Tchau!");
                        break;

                    case 1:

                        break;
                }

            } while (opcao != 0);

            Console.WriteLine(">>>>FIM<<<<");
        }
    }
}
