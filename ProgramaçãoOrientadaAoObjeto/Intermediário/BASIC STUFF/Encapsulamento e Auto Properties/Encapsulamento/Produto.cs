using System.Globalization;
namespace Encapsulamento
{
    class Produto
    {
        private string _nome;   //Não é possivel definir uma auto propertie pois _nome possui lógica prórpia de get e set
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        // public int MyProperty { get; set; } snipet: "prop", TAB 2X

        public Produto() { }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        

        //Get e Set para modificar váriaveis em private
        public string Nome 
        {
            get { return _nome;}
            set
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

      

       

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
