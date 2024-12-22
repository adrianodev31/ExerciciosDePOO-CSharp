using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    internal class Program
    {
        public static List<Livro> ListaDeLivros = new List<Livro>();
        static void Main(string[] args)
        {
            try{
               Menu(ListaDeLivros);
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }

        

        public static void Menu(List<Livro>ListaDeLivros){
            Console.Clear();
            Console.Write("Digite o título do livro: ");
            var tituloDigitado = Console.ReadLine();
            Console.Write("Digite o nome do Autor: ");
            var nomeAutor = Console.ReadLine(); 
            Console.Write("Digite o ano de publicação: ");
            var anoPublicado = int.Parse(Console.ReadLine());   
            Console.Write("Digite a quantida de páginas: ");
            var numeroDePaginas = int.Parse(Console.ReadLine());    

            var novoLivro = new Livro(tituloDigitado,nomeAutor,anoPublicado,numeroDePaginas);
            ListaDeLivros.Add(novoLivro);  

            Console.WriteLine("Deseja adicionar um novo livro ? (S/N)");
            var respostaSouN = char.Parse(Console.ReadLine()); 
            var respostaTratada = respostaSouN; 
                if(respostaTratada == 's'){
                    Menu(ListaDeLivros);
                }
                else if(respostaTratada == 'n'){
                foreach (var (livro, index) in ListaDeLivros.Select((value, i) => (value, i)))
                {
                    livro.ExibirLivros(index);
                }
                }


        }

        public class Livro {
            public Livro (string titulo, string autor, int anoPublicado, int qtdPaginas){

                if(string.IsNullOrEmpty(titulo)){
                    throw new ArgumentNullException("O Título do livro não pode ser vazio.");
                }

                if(string.IsNullOrEmpty(autor)){
                    throw new ArgumentNullException("O Nome do autor não pode ser vazio.");
                }

                if(anoPublicado < 1450){
                    throw new ArgumentException("Não existiam livros impressos antes de 1450!!");
                }
                
                if(qtdPaginas < 1){
                    throw new ArgumentException("Não existem livros com menos de 1 pagina.");
                }
                this.Titulo = titulo;
                this.Autor = autor;
                this.AnoPublicado = anoPublicado;
                this.QtdPaginas = qtdPaginas;
            }

            public string Titulo {get;set;}
            public string Autor {get; set;}
            public int AnoPublicado {get; set;}
            public int QtdPaginas {get; set;} 

            
            
            public void ExibirLivros (int index){
                
                Console.WriteLine($"{index+1}. Nome do livro: {Titulo} - {Autor} ({AnoPublicado}) - {QtdPaginas} páginas)");
                
            }

        }
    }
}