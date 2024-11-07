using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class SimplesComando : ICommand
    {
        private string _solicitacao = string.Empty;

        public SimplesComando(string solicitacao)
        {
            _solicitacao = solicitacao;
        }

        public void Executar()
        {
            Console.WriteLine("Estou executando comando de " + this._solicitacao);
        }
    }
}
