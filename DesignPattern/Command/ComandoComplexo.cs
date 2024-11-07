namespace Command
{
    public class ComandoComplexo : ICommand
    {
        private Receiver _receiver;
        private string _a;
        private string _b;

        public ComandoComplexo(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Executar() 
        {
            this._receiver.PrimeiroPedido(_a);
            this._receiver.SegundoPedido(_b);
        }
    }
}
