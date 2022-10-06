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

            nomePessoas.Sort();
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

            /*
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
                            Console.WriteLine("Digite um email: ");
                            email = Console.ReadLine().ToUpper();
                            while (!email.Contains("@"))
                            {
                                Console.WriteLine("Digite um email valido: ");
                                email = Console.ReadLine().ToUpper();
                            }
                            while (emails.Contains(email))
                            {
                                Console.WriteLine("Email já cadastrado!!");
                                Console.WriteLine("Digite um email: ");
                                email = Console.ReadLine().ToUpper();
                            }
                            emails.Add(email);
                            Console.WriteLine("======ADICIONADO======");
                            break;
                        }
                        break;

                    case 2:
                        foreach(string email in emails)
                        {
                            Console.WriteLine(email);
                        }
                        break;
                    case 3:
                        isTrue = false;
                        Console.WriteLine("Encerrando...");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }

            }while (isTrue);
            */

            /*
            //QUESTAO 04
            Boolean isTrue = true;
            int opcao = 0;
            List<string> criptomoedas = new List<string>();

            do
            {
                Console.WriteLine("=====MENU======");
                Console.WriteLine("1 - Cadastrar criptomoeda");
                Console.WriteLine("2 - Listar criptomoedas");
                Console.WriteLine("3 - Remover criptomoedas");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        while (true)
                        {
                            string criptomoeda = "";
                            Console.WriteLine("Digite uma criptomoeda: ");
                            criptomoeda = Console.ReadLine().ToUpper();
                            while (criptomoedas.Contains(criptomoeda))
                            {
                                Console.WriteLine("Email já cadastrado!!");
                                Console.WriteLine("Digite um email: ");
                                criptomoeda = Console.ReadLine().ToUpper();
                            }
                            criptomoedas.Add(criptomoeda);
                            Console.WriteLine("======ADICIONADO======");
                            break;
                        }
                        break;

                    case 2:
                        criptomoedas.Sort();
                        foreach (string cripto in criptomoedas)
                        {
                            Console.WriteLine(cripto);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite qual criptmoeda quer remover: ");
                        string criptoRemove = Console.ReadLine().ToUpper();
                        criptomoedas.Remove(criptoRemove);
                        break;
                    case 4:
                        isTrue = false;
                        Console.WriteLine("Encerrando...");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }

            } while (isTrue);
            */

            /*
            //QUESTAO 05
            Random random = new Random();
            List<int> lista01 = new List<int>();
            List<int> lista02 = new List<int>();
            int qtd = 0;

            Console.WriteLine("Digite a quantidade a ser preenchida:");
            qtd = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtd; i++)
            {
                lista01.Add(random.Next(100,200));
                lista02.Add(random.Next(100, 200));
            }

            Console.WriteLine("Lista 01");
            foreach(int i in lista01)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Lista 02");
            foreach (int i in lista02)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Que tem nos dois");
            foreach (int i in lista02)
            {
                if (lista01.Contains(i))
                {
                    Console.WriteLine(i);
                }
            }
            */


            //QUESTAO 06
            
            
        }
    }
}