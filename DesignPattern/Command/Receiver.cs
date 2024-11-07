using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Receiver
    {
        public void PrimeiroPedido(string a)
        {
            Console.WriteLine("Comando Recebido: " + a);
        }

        public void SegundoPedido(string b)
        {
            Console.WriteLine("Outro comando Recebido " + b);
        }
    }
}
