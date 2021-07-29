using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Base : Pessoa
    {

        public Base(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        public Base()
        {
        }


        public string Nome;
        public string Telefone;
        public string CPF;

        private string sobrenome = "Santos";

        public virtual void Gravar()
        {
            var dados = new Base().Ler();
            dados.Add(this);
            if (File.Exists(diretorioComArquivo()))
            {
                StreamWriter r = new StreamWriter(diretorioComArquivo());
                r.WriteLine("nome;telefone;cpf;");
                foreach (Base b in dados)
                {
                    var linha = b.Nome + ";" + b.Telefone + ";" + b.CPF + ";";
                    r.WriteLine(linha);
                }
                r.Close();
            }
        }

        public List<Base> Ler()
        {
            var dados = new List<Base>();
            if (File.Exists(diretorioComArquivo()))
            {
                using (StreamReader arquivo = File.OpenText(diretorioComArquivo()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseArquivo = linha.Split(';');

                        var cliente = new Base(baseArquivo[0], baseArquivo[1], baseArquivo[2]);
                        dados.Add(cliente);
                    }
                }
            }
            return dados;
        }

        private string diretorioComArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".txt";
        }

        public virtual void Olhar()
        {
            Console.WriteLine("O Cliente " + this.Nome + " " + this.sobrenome + " está olhando para");
        }

        protected int CalcularUmMaisDois()
        {
            return 1 + 2;
        }
        private int CalcularUmMaisDois2()
        {
            return 1 + 2;
        }
        public int CalcularUmMaisDois3()
        {
            return 1 + 2;
        }
        internal int CalcularUmMaisDois4()
        {
            return 1 + 2;
        }
    }
}
