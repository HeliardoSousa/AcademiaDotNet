using System.Runtime.CompilerServices;

namespace ListaExercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //QUESTAO 01
            string autor, titulo;
            int ano, edicao;

            Console.WriteLine("Digite o autor do livro: ");
            autor = Console.ReadLine();
            Console.WriteLine("Digite o titulo do livro: ");
            titulo = Console.ReadLine();
            Console.WriteLine("Digite o ano do livro: ");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a edicao do livro: ");
            edicao = int.Parse(Console.ReadLine());

            Console.WriteLine("Imprimindo o livro");
            Livro livro01 = new Livro(autor, titulo, ano, edicao);
            */

            /*
            //QUESTAO 02
            string nome;
            int idade;
            float altura, peso;

            Console.WriteLine("Digite o autor do livro: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o titulo do livro: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano do livro: ");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a edicao do livro: ");
            peso = float.Parse(Console.ReadLine());

            Pessoa pessoa01 = new Pessoa(nome, idade, altura, peso);
            */

            /*
            //QUESTAO 03
            Cliente cliente01 = new Cliente("Heliardo", 22);
            Carro carro01 = new Carro("Classica", "s2s2s333", "Cinza", 2010);
            Aluguel aluguel01 = new Aluguel(cliente01, carro01, 30);
            */

            /*
            //QUESTAO 04
            Pessoa pessoa01 = new Pessoa("Manuel", 52);
            Pessoa pessoa02 = new Pessoa("Francisca", 52);

            Pessoa pessoa03 = new Pessoa(pessoa01, pessoa02, "Heliardo", 22);
            Pessoa pessoa04 = new Pessoa(pessoa01, pessoa02, "Heloisa", 26);

            Console.WriteLine(pessoa04.pai.idade);
            */

            /*
            //QUESTAO 06
            Agenda agenda = new Agenda();

            agenda.armazenarPessoa("Heliardo", 22, 1.73);
            agenda.armazenarPessoa("Heloisa", 26, 1.67);
            agenda.armazenarPessoa("Manuel", 52, 1.70);
            agenda.armazenarPessoa("Miuda", 52, 1.59);

            agenda.imprimeAgenda();

            agenda.removePessoa("Manuel");

            Console.WriteLine("Depois da remocao");

            agenda.imprimeAgenda();

            agenda.buscaPessoa("Heliardo");
            */

            /*
            //QUESTAO 07
            Elevador elevador = new Elevador(6, 4);
            elevador.entrar();
            elevador.entrar();

            elevador.sobe();
            Console.WriteLine(elevador.getPresenteElevador());
            Console.WriteLine(elevador.getAndarAtual());
            */

            /*
            //QUESTAO 08
            ControleRemoto cr = new ControleRemoto();
            cr.consultarCanal();
            cr.consultarVolume();

            cr.aumentarCanal();
            cr.aumentarVolume();

            cr.consultarCanal();
            cr.consultarVolume();

            cr.mudarCanal();
            cr.consultarVolume();
            */
        }
    }
}