using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaFornecedor
    {
        public static void Chamar()
        {
            Console.WriteLine("========== Cadastro de Fornecedores ==========\n");

            while (true)
            {
                string mensagem = "\nDigite uma das opções abaixo: \n" +
                    "\n      0 - Sair do Cadastro" +
                    "\n      1 - Cadastrar Fornecedores" +
                    "\n      2 - Listar Fornecedores";

                Console.WriteLine(mensagem);
                Console.Write("\n\nDigite a Opção Desejada: ");
                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var fornecedor = new Fornecedor();

                    Console.Write("Digite o CNPJ do Fornecedor: ");
                    fornecedor.CNPJ = Console.ReadLine();

                    Console.Write("Digite o nome do Fornecedor: ");
                    fornecedor.Nome = Console.ReadLine();

                    Console.Write("Digite o Telefone do Fornecedor: ");
                    fornecedor.Telefone = Console.ReadLine();

                    Console.Write("Digite o CPF do Gerente: ");
                    fornecedor.CPF = Console.ReadLine();

                    fornecedor.Gravar();

                }
                else
                {
                    var Fornecedores = new Fornecedor().Ler();
                    foreach (Fornecedor c in Fornecedores)
                    {
                        Console.WriteLine("==========================================");
                        Console.WriteLine("CNPJ: " + c.CNPJ);
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF do Gerente: " + c.CPF);

                        Console.WriteLine("==========================================");
                    }
                }

            }
        }
    }
}
