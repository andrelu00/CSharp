using System;
using System.Globalization;

namespace Construtores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public Produto(string nome, double preco, int quantidade) //Agora será necessário apresentar esses dados quando a classe for solicitada
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;

            //Palavra this diferencia os atributos da classe do parametro do construtor, útil caso tenham o mesmo nome
        }

        /*
        public Produto(string nome, double preco)  //Agora podera apresentar somente esses dois parametros
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; //Também podemos apresentar um valor para os atributos não definidos que por padrão é 0 
        }
        */
        /*
        public Produto(string nome, double preco, int qunatidade) : this(nome, preco) 
        {
            Quantidade = quantidade;

            Você pode usar o this para referenciar um construtor em outro construtor 
        }
        */

        public Produto() 
        {
            //Construtor Padrão
        }

        //Não há limite para a quantidade de Construtores e Sobrecargas

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
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
