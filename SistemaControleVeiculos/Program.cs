using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> ListaDeVeiculos = new List<Veiculo>();
            try
            {
                Veiculo veiculo1 = new Veiculo("Toyota", "Corolla", 2015, 50000);
                ListaDeVeiculos.Add(veiculo1);

                var veiculo2 = new Veiculo("Wolksvagen", "Fox", 2009, 126000 );
                ListaDeVeiculos.Add(veiculo2);

                var veiculo3 = new Veiculo("Audi", "R8", 2021, 42000);
                ListaDeVeiculos.Add(veiculo3);

                foreach(var veiculo in ListaDeVeiculos){
                    veiculo.ExibeNaTela();
                }
            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);  
            }

        }

        public class Veiculo
        {


            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Ano { get; set; }
            public int Quilometragem { get; set; }


            public Veiculo(string marca, string modelo, int ano, int quilometragem)
            {
                if (ano < 1886)
                {
                    throw new ArgumentOutOfRangeException(nameof(ano), "Não existiam carros antes de 1886!");
                }

                if (quilometragem < 0)
                {
                    throw new ArgumentException("Não existem KM negativo!!!");
                }

                if (string.IsNullOrWhiteSpace(marca))
                {
                    throw new ArgumentException("Marca não pode ser vazia.");
                }

                if (string.IsNullOrWhiteSpace(modelo))
                {
                    throw new ArgumentException("Modelo não pode ser vazio.");
                }

                this.Marca = marca;
                this.Modelo = modelo;
                this.Ano = ano;
                this.Quilometragem = quilometragem;
            }
            public void ExibeNaTela()
            {   
                  Console.WriteLine("");
                Console.WriteLine("======================================");
                Console.WriteLine("");
                Console.WriteLine("Veículo cadastrado:");
                Console.WriteLine($"Marca: {Marca}");
                Console.WriteLine($"Modelo: {Modelo}");
                Console.WriteLine($"Ano: {Ano}");
                Console.WriteLine($"Quilometragem: {Quilometragem}");
            }




        }


    }
}