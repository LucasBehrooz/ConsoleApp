using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaUsuario
    {
        public static void Chamar()
        {
            Console.WriteLine("========== Cadastro de Usuario ==========\n");

            while (true)
            {
                string mensagem = "\nDigite uma das opções abaixo: \n" +
                    "\n      0 - Sair do Cadastro" +
                    "\n      1 - Cadastrar Usuarios" +
                    "\n      2 - Listar Usuarios";

                Console.WriteLine(mensagem);
                Console.Write("\n\nDigite a Opção Desejada: ");
                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var usuario = new Usuario();

                    Console.Write("Digite o nome do Usuario: ");
                    usuario.Nome = Console.ReadLine();

                    Console.Write("Digite o Telefone do Usuario: ");
                    usuario.Telefone = Console.ReadLine();

                    Console.Write("Digite o CPF do Usuario: ");
                    usuario.CPF = Console.ReadLine();

                    usuario.Gravar();

                }
                else
                {
                    var Usuarios = new Usuario().Ler();
                    foreach (Usuario c in Usuarios)
                    {
                        Console.WriteLine("==========================================");
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF: " + c.CPF);

                        Console.WriteLine("==========================================");
                    }
                }

            }
        }
    }
}
