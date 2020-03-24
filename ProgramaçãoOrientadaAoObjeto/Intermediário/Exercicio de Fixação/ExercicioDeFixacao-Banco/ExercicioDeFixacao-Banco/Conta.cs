using System.Globalization;


namespace ExercicioDeFixacao_Banco
{
    class Conta
    {
        public string numConta { get; private set; }
        public string Titular { get; set; }
        public float DepositoInicial { get; private set; }
        

        public Conta(string numero, string nome) 
        {
            numConta = numero;
            Titular = nome;
        }
        
        
        public Conta(string numero, string nome,float DepositoInicial): this(numero, nome) 
        {
            Deposito(DepositoInicial);
        }

        public float Saldo() 
        {
            return DepositoInicial;
        }

        public void Deposito(float QuantiaAdd) 
        {
            DepositoInicial += QuantiaAdd;
        }

        public void Saque(float QuantiaRet) 
        {
            DepositoInicial -= QuantiaRet + 5;
        }


        public override string ToString()
        {
            return "Conta " + numConta + ", Titular: " + Titular + ", Saldo: R$" + Saldo().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
