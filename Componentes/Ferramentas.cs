using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componentes
{
    public class Ferramentas
    {
        internal string MetodoSomenteParaMeuAssembly()
        {
            return "Esse método só pode ser acessado dentro desse assembly Componentes";
        }
        public string MetodoParaTodosQueUtilizaremAssembly()
        {
            return "Esse método é para todos";
        }
        public bool ValidarCPF(string cpf)
        {
            return true;
        }
    }
}
