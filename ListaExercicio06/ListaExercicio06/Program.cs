namespace ListaExercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //QUESTAO 01
            List<string> nomePessoas = new List<string>();
            string nome;
            do
            {
                Console.WriteLine("Digite um nome ou 'sair': ");
                nome = Console.ReadLine().ToUpper();
                if (nome == "SAIR")
                {
                    break;
                }

                string[] nomeSeparados = nome.Split(" ");
                if(nomeSeparados.Length >= 2)
                {
                    if (nomePessoas.Contains(nome))
                    {
                        Console.WriteLine("Nome já cadastrado!!");
                    }
                    else
                    {
                        nomePessoas.Add(nome);
                        Console.WriteLine("======ADICIONADO======");
                    }
                }
                else
                {
                    Console.WriteLine("Digite um nome completo!");
                }
            } while (true);

            foreach(var nomes in nomePessoas)
            {
                Console.WriteLine(nomes);
            }
            */

            /*
            //QUESTAO 02
            List<int> numeros = new List<int>();
            Random random = new Random();
            int qtd = 0;

            Console.WriteLine("Quantos numeros deseja armazenar?");
            qtd = int.Parse(Console.ReadLine());

            for(int i=0; i < qtd; i++)
            {
                numeros.Add(random.Next(0,1000));
            }

            Console.WriteLine("Numeros gerados aleatoriamente:");
            foreach(int num in numeros)
            {
                Console.WriteLine(num);
            }
            */

            //QUESTAO 03
            Boolean isTrue = true;
            int opcao = 0;
            List<string> emails = new List<string>();

            do
            {
                Console.WriteLine("=====MENU======");
                Console.WriteLine("1 - Cadastrar email");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        while (true)
                        {
                            string email = "";
                            Console.WriteLine("Digite um nome ou 'sair': ");
                            email = Console.ReadLine().ToUpper();
                            if (emails.Contains(email))
                            {
                                Console.WriteLine("Email já cadastrado!!");
                            }
                            else
                            {
                                emails.Add(email);
                                Console.WriteLine("======ADICIONADO======");
                            }
                            
                        }
                        break;

                    case 2:
                        foreach(string email in emails)
                        {
                            Console.WriteLine(email);
                        }
                        break;
                    case 0:
                        isTrue = false;
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }

            }while (isTrue);

            //QUESTAO 04

            //QUESTAO 05

            //QUESTAO 06
        }
    }
}