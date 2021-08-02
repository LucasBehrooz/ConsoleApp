using Calculo;
using Diretorio;
using Funcoes;
using System;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;
        public const int CADASTRAR_USUARIOS = 5;
        public const int CADASTRAR_FORNECEDOR = 6;

    public static void Criar()
        {
            while (true)
            {
                string mensagem = "Olá usuario, bem vindo ao programa\n" +
                    "\nAplicação Console final" +
                    "\n\n" +
                    "\n      Digite uma das opções abaixo:" +
                    "\n      0 - Sair do Programa" +
                    "\n      1 - Para Ler Arquivos" +
                    "\n      2 - Para executar a Tabuada" +
                    "\n      3 - Para Calcular Média de Alunos" + 
                    "\n      4 - Cadastrar Clientes" + 
                    "\n      5 - Cadastrar Usuarios" + 
                    "\n      6 - Cadastrar Fornecedores";

                Console.WriteLine(mensagem);
                Console.Write("\n\nDigite a Opção Desejada: ");
                int valor = int.Parse(Console.ReadLine());
                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("========== Opção Ler Arquivos ==========");
                    Arquivo.Ler(1);
                    Console.WriteLine("\n==============================\n");

                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("========== Opção Tabuada ==========");
                    Console.Write("Digite o numero que deseja na tabuada: ");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("\n==============================\n");

                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("========== Calculo da Média de Alunos ==========");
                    Media.Aluno();
                    //CalcularMediaAluno();

                }
                else if (valor == CADASTRAR_CLIENTES)
                {
                    Console.WriteLine("========== Cadastrar Clientes ==========");
                    TelaCliente.Chamar();
                    Console.WriteLine("\n==============================\n");

                }
                else if (valor == CADASTRAR_USUARIOS)
                {
                    //Console.WriteLine("========== Cadastrar Clientes ==========");
                    TelaUsuario.Chamar();
                    Console.WriteLine("\n==============================\n");

                }
                else if (valor == CADASTRAR_FORNECEDOR)
                {
                    //Console.WriteLine("========== Cadastrar Clientes ==========");
                    TelaFornecedor.Chamar();
                    Console.WriteLine("\n==============================\n");

                }
                else
                {
                    Console.WriteLine("Opção Invalida digite novamente");
                }
            }
        }
    }
}