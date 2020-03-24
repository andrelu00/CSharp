namespace VetoresArmazenandoObjetos
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string name, double price) 
        {
            Nome = name;
            Preco = price;
        }
    }
}
