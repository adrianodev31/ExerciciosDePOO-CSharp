using System;

namespace MyApp
{

    internal class Program
    {
        public static List<Aluno> alunos = new List<Aluno>{
        new Aluno("Adriano", 20),
        new Aluno("Claudio", 15)
        };


        static void Main(string[] args)
        {
            Menu();
        }


        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Adicionar Alunos a lista\n2 - Consultar Alunos\n3 - Sair");
            var opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1: AddAlunos(); break;
                case 2: Consulta(); break;
                case 3: System.Environment.Exit(0); break;
                default: Menu();break;
            }
        }

        public static void AddAlunos(){
            Console.Clear();
            Console.WriteLine("Digite o nome do Aluno que deseja add a lista: ");
            var nomeAlunoDigitado = Console.ReadLine();
            Console.WriteLine("Digite a idade do aluno: ");
            var idadeAlunoDigitado = int.Parse(Console.ReadLine()); 
            var aluno = new Aluno(nomeAlunoDigitado, idadeAlunoDigitado);
            alunos.Add(aluno);
            Thread.Sleep(2000);
            Menu();
        }

        public static void Consulta()
        {
            Console.WriteLine("Digite um nome: ");
            var digitado = Console.ReadLine();
            var nomeFiltrado = alunos.Find(a => a.Nome.Equals(digitado, StringComparison.OrdinalIgnoreCase));
            if (nomeFiltrado != null)
            {
                Console.WriteLine($"O nome {digitado} existe na lista");
            }
            else
            {
                Console.WriteLine($"O nome {digitado} não existe na lista");
            }
            Thread.Sleep(2000);
            Menu();
        }

        public class Aluno
        {
            public Aluno(string nome, int idade){
                Nome = nome;
                Idade = idade;
            }

            public string Nome { get; set; }
            public int Idade { get; set; }   
        }
    }
}