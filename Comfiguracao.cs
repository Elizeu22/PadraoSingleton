using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConfiguracoes
{
    public sealed class Comfiguracao
    {
        private static readonly Comfiguracao _configuracao = new();

        public static Comfiguracao Configurar => _configuracao;

        private Comfiguracao() { }

        public void Servidor(string sistemaEmpresa,string servidorEmpresa)
        {
            Console.WriteLine($"Sistema Empresa:{sistemaEmpresa}");
            Console.WriteLine($"Servidor Empresa:{servidorEmpresa}");
        }
    }
}
