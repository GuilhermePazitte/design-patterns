using System;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controle controle = new Controle();
            Receiver receiver = new Receiver();

            controle.EnviarComandoSimples(new SimplesComando("Dizer Oi!"));
            controle.EnviarComandoComplexo(new ComandoComplexo(receiver, "Oi tudo bem!", "Espero que esteje bem!"));

            controle.Fazer();

            Console.ReadKey();

        }
    }
}
