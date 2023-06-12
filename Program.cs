using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula04Leitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeFuncionario;

            string produto1;
            int qtdProduto1;

            string produto2;
            int qtdProduto2;

            Console.WriteLine("Bem-vindo ao sistema de estoque do Conradito.");
            Console.WriteLine("Digite o nome do funcionário responsável: ");
            nomeFuncionario = Console.ReadLine();

            Console.WriteLine($"\n\nO cadastro de estoque será feito no nome de {nomeFuncionario}\n\n");

            Console.WriteLine("--- CADASTRO DE PRODUTOS");
            Console.Write("Digite o nome do Produto 1: ");
            produto1 = Console.ReadLine();

            Console.Write($"Digite a quantidade em estoque de {produto1}: ");
            qtdProduto1 = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o nome do Produto 2: ");
            produto2 = Console.ReadLine();

            Console.Write($"Digite a quantidade em estoque de {produto2}: ");
            qtdProduto2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n\n- Os produtos foram cadastrados com sucesso!\n");

            Console.WriteLine($"-- LISTA DE PRODUTOS CADASTRADOS POR {nomeFuncionario}: ");
            Console.WriteLine($"- {produto1} contém {qtdProduto1} itens em estoque");
            Console.WriteLine($"- {produto2} contém {qtdProduto2} itens em estoque");
            Console.WriteLine($"- Total de itens no estoque: {qtdProduto1 + qtdProduto2}\n");

            Console.WriteLine("----- FIM DO SISTEMA -----");


            Console.ReadKey();
        }
    }
}
