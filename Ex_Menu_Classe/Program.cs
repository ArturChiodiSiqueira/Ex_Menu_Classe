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
                Console.WriteLine("1 - CADASTRAR\n2 - Imprimir\n0 - SAIR");
                Console.Write("Informe a opcao desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Tchau!");
                        break;

                    case 1:
                        contatos[0] = lerPessoa();
                        break;

                    case 2:
                        imprimirContatos(contatos);
                        break;
                }

            } while (opcao != 0);

            Console.WriteLine(">>>> FIM <<<<");
        }

        static Pessoa lerPessoa()
        {
            string nome;
            int idade;

            Console.Clear();

            Console.Write("Informe o nome da pessoa: ");
            nome = Console.ReadLine();

            Console.Write("Informe a idade: ");
            idade = int.Parse(Console.ReadLine());

            return new Pessoa
            {
                Nome = nome,
                Idade = idade
            };

            //Pessoa pessoa = new Pessoa
            //{
            //    Nome = nome,
            //    Idade = idade
            //};
            //return pessoa;
        }

        static void imprimirContatos(Pessoa[] contatos)
        {
            Console.Clear();
            Console.WriteLine(">>>> CONTATOS <<<<");
            Console.WriteLine(contatos[0]);
        }
    }
}
