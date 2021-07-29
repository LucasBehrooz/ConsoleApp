using Classes;
using Componentes;
using System;
using System.Collections.Generic;
using Tela;

namespace TorneseUmProgramador
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu.Criar();
            Console.WriteLine("\n==================== Cadastro de Cliente ====================\n");
            Cliente c = new Cliente();
            c.Nome = "Cliente";
            c.Telefone = "5531323131";
            c.CPF = "1313131321";
            c.Gravar();


            foreach (Cliente c1 in new Cliente().Ler())
            {
                Console.WriteLine(c1.Nome);
                Console.WriteLine(c1.Telefone);
                Console.WriteLine(c1.CPF);
                Console.WriteLine("==================================");
            }

            Console.WriteLine("\n==================== Cadastro de Usuarios ====================\n");
                        Usuario u = new Usuario();
            u.Nome = "Usuario";
            u.Telefone = "5531323131";
            u.CPF = "1313131321";
            u.Gravar();
            foreach (Usuario us in new Usuario().Ler())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.CPF);
                Console.WriteLine("==================================");
            }



            /*
             Ferramentas f = new Ferramentas();
               bool d = f.ValidarCPF("12345678900");

               Cliente c = new Cliente();
               c.CalcularUmMaisDois4();
               Console.WriteLine("\n==================== Cadastro de Usuario ====================\n");

*/
        }
    }
}
