using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaCliente
    {
        public static void Chamar()
        {
            Console.WriteLine("========== Cadastro de Cliente ==========\n");
           
            while (true)
            {
                string mensagem = "Digite uma das opções abaixo:" +
                    "\n      0 - Sair do Cadastro" +
                    "\n      1 - Cadastrar Clientes" +
                    "\n      2 - Listar Clientes";

                Console.WriteLine(mensagem);
                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var cliente = new Cliente();

                    Console.Write("Digite o nome do Cliente: ");
                    cliente.Nome = Console.ReadLine();

                    Console.Write("Digite o Telefone do Cliente: ");
                    cliente.Telefone = Console.ReadLine();

                    Console.Write("Digite o CPF do Cliente: ");
                    cliente.CPF = Console.ReadLine();

                    cliente.Gravar();

                }
                else
                {
                    var clientes = Cliente.LerClientes();
                    foreach (Cliente c in clientes)
                    {
                        Console.WriteLine(c.Nome);
                        Console.WriteLine(c.Telefone);
                        Console.WriteLine(c.CPF);

                        Console.WriteLine("=====================");
                    }
                }

            }
        }
    }
}
