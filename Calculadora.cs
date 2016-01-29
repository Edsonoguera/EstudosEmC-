namespace MainProject
{
    class Calculadora
    {
        //Declara as PROPRIEDADES 
        private readonly decimal _meuNumero1;
        private readonly decimal _meuNumero2;

        //Declara o CONSTRUTOR e realiza as operações em seu bloco
        public Calculadora(decimal meuNumero1, decimal meuNumero2)
        {
            _meuNumero1 = meuNumero1;
            _meuNumero2 = meuNumero2;
        }
        
        
        //Declara os MÉTODOS
        public decimal Calculo()
        {
            return _meuNumero1 + _meuNumero2;
        }

        public decimal Multiplicacao()
        {
            return _meuNumero1 * _meuNumero2;
        }
    }
}
