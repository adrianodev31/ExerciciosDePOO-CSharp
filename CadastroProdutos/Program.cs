using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            try 
            {

                var agua = new Produto(1, "Água com gás", 10);
                agua.ExibirInformacoes();

                Console.WriteLine("\n=======================\n");

                var refrigerante = new Produto(2, "Coca-Cola", 11.50m);
                refrigerante.ExibirInformacoes();

                Console.WriteLine("\n=======================\n");

                var cafe = new Produto(3, "Café", -21.50m);
                cafe.ExibirInformacoes();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }


            
        }

        public class Produto 
        {

            public int Id {get; private set;}
            public string Nome {get; private set;}
            private decimal _preco;

            public decimal Preco
            {
                get { return _preco; }   
                private set{
                    if(value < 0)
                    {
                        throw new ArgumentException("Preço negativo, impossivel realizar o cadastro do produto");
                    }
                    _preco = value;
                }
            }

            public Produto(int id, string nome, decimal preco){
                Id = id;
                Nome = nome;
                Preco = preco;
            }

         


            public void ExibirInformacoes (){
                Console.WriteLine($"Id: {Id} \nProduto: {Nome}\nPreço: {Preco:C}");
            }
        }
    }
}