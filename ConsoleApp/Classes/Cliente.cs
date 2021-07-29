using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes
{
    public class Cliente : Base
    {

        /// <summary>
        /// Construtor com 3 parametros
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }
        /// <summary>
        /// Construtor com parametro telefone Inteiro
        /// </summary>
        /// <param name="telefone">Telefone Inteiro</param>
        public Cliente(int telefone)
        {
            this.Telefone = telefone.ToString();
        }
        /// <summary>
        /// Construtor sem Parametros
        /// </summary>
        public Cliente() { }

        public static string Teste;

        private static string caminhoBase()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            if (File.Exists(caminhoBase()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBase()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');

                        var cliente = new Cliente(clienteArquivo[0], clienteArquivo[1], clienteArquivo[2]);
                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;
        }
    }
}
