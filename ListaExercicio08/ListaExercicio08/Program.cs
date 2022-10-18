using System.Runtime.CompilerServices;

namespace ListaExercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //QUESTAO 01
            string nome;
            int poder, maiorPoder = -1;
            Personagem pers = new Personagem();
            Personagem[] personagem = new Personagem[3];
       
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Informe o nome do personagem {i+1}:");
                nome = Console.ReadLine();
                Console.WriteLine($"Informe o poder(0 - 10) do personagem {i + 1}: ");
                poder = int.Parse(Console.ReadLine());
                while(poder < 0 || poder > 10)
                {
                    Console.WriteLine($"Informe um valor de 0 a 10: ");
                    poder = int.Parse(Console.ReadLine());
                }
                personagem[i] = new Personagem(nome, poder);
                if (maiorPoder < poder)
                {
                    pers = personagem[i];
                    maiorPoder = poder;
                }
            }
            Console.WriteLine("Personagem com maior poder: ");
            pers.ExibirDados();
            */

            //QUESTAO 02


            /*
            //QUESTAO 03
            List<Asteroide> asteroides = new List<Asteroide>();
            int opcao;
            do
            {
                Console.WriteLine("====MENU====");
                Console.WriteLine("1 - CADASTRAR ASTEROIDE");
                Console.WriteLine("2 - LISTAR ASTEROIDES");
                Console.WriteLine("0 - ENCERRAR O PROGRAMA");
                Console.WriteLine("Digite a opcao: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        int posX, posY, tamanho = 0, velocidade = 0, energia = 0;
                        Console.WriteLine("Digite a posicao X");
                        posX = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a posicao Y");
                        posY = int.Parse(Console.ReadLine());
                        while(tamanho < 1 || tamanho > 10)
                        {
                            Console.WriteLine("Digite o tamanho do asteroide: ");
                            tamanho = int.Parse(Console.ReadLine());
                        }
                        while (velocidade < 1 || velocidade > 5)
                        {
                            Console.WriteLine("Digite a velocidade do asteroide: ");
                            velocidade = int.Parse(Console.ReadLine());
                        }
                        while (energia < 1 || energia > 5)
                        {
                            Console.WriteLine("Digite a energia do asteroide: ");
                            energia = int.Parse(Console.ReadLine());
                        }
                        asteroides.Add(new Asteroide(posX, posY, tamanho, velocidade, energia));
                        break;
                    case 2:
                        int cont = 1;
                        foreach(var asteroide in asteroides)
                        {
                            Console.WriteLine($"Asteroide {cont} -> Posicao X: {asteroide.PosicaoX}, Posicao Y: {asteroide.PosicaoY}");
                            cont++;
                        }
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }
            } while (opcao != 0);
            */

            /*
            //QUESTAO 04
            int opcap = 0;
            string descricao;
            float altura;
            Console.WriteLine("Digite a descricao: ");
            descricao = Console.ReadLine();
            Console.WriteLine("Digite a altura: ");
            altura = float.Parse(Console.ReadLine());
            Cenario cenario = new Cenario(descricao, altura);
            Thread.Sleep(10000);
            cenario.ExibirDados();
            cenario.ExibirTempoExistencia();
            */

            //QUESTAO 05

            /*
            //FALTA FINALIZAR
            //QUESTAO 06
            List<Funcionario> func = new List<Funcionario>();
            int opcao = 0;

            do
            {
                Console.WriteLine("====MENU====");
                Console.WriteLine("1 - CADASTRAR FUNCIONARIO");
                Console.WriteLine("2 - LISTAR TODOS FUNCIONARIOS");
                Console.WriteLine("0 - SAIR");
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do funcionario:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o departamento do funcionario:");
                        string departamento = Console.ReadLine();
                        Console.WriteLine("Digite o salario do funcionario:");
                        double salario = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a data de entrada do funcionario:");
                        string data = Console.ReadLine();
                        Console.WriteLine("Digite o rg do funcionario:");
                        string rg = Console.ReadLine();
                        func.Add(new Funcionario(nome, departamento, salario, data, rg));
                        break;
                    case 2:
                        Console.WriteLine("Funcionarios:");
                        foreach(var f in func)
                        {
                            Console.WriteLine($"Nome: {f.Nome}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Digite uma opcao valida!");
                        break;
                }
            } while (opcao != 0);
            */


            /*
            //QUESTAO 07
            Dictionary<string, int> livros = new Dictionary<string, int>();
            int opcao = 0;

            do
            {
                Console.WriteLine("=====MENU=====");
                Console.WriteLine("1 - CADASTRAR LIVRO");
                Console.WriteLine("2 - LISTAR LIVROS");
                Console.WriteLine("3 - PESQUISAR PELO NOME LIVRO");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine("Digite a opcao desejada:");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        string nome;
                        int qtd;
                        Console.WriteLine("Digite o nome do livro:");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite a quantidade de paginas:");
                        qtd = int.Parse(Console.ReadLine());
                        livros.Add(nome, qtd);
                        break;
                    case 2:
                        foreach(KeyValuePair<string, int> livro in livros)
                        {
                            Console.WriteLine(livro.Key+" "+livro.Value);
                        }
                        break;
                    case 3:
                        string nomeLivro;
                        Console.WriteLine("Digite o nome do livro a ser pesquisado: ");
                        nomeLivro = Console.ReadLine();

                        if (livros.TryGetValue(nomeLivro, out qtd))
                        {
                            Console.WriteLine($"Quantidade livro pesquisado: {qtd}");
                        }
                        else
                        {
                            Console.WriteLine("Livro nao encontrado");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Digite um opcao valida!");
                        break;
                }
            } while (opcao != 0);
            */
        }
    }
}