namespace ListaExercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //QUESTAO 01
            int numero = -1;
            while(numero < 0)
            {
                Console.WriteLine("Digite um numero inteiro positivo: ");
                numero = int.Parse(Console.ReadLine());
                if(numero < 0)
                {
                    Console.WriteLine("Valor incorreto");
                }
            }
            Console.WriteLine("Numero digitado: "+numero);
            Console.Write("Numeros inteiros pares entre 1 e "+numero+":");
            for(int i = 1; i < numero; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i+" ");
                }
            }
            */

            /*
            //QUESTAO 02
            int numero = -1;
            char repete = 's';
            while (repete == 's')
            {
                while (numero < 0)
                {
                    Console.WriteLine("Digite um numero inteiro positivo: ");
                    numero = int.Parse(Console.ReadLine());
                    if (numero < 0)
                    {
                        Console.WriteLine("Valor incorreto");
                    }
                }
                Console.WriteLine("Numero digitado: " + numero);
                Console.Write("Numeros inteiros pares entre 1 e " + numero + ": ");
                for (int i = 1; i < numero; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine("\nDeseja digitar outro numero? (s/n): ");
                repete = char.Parse(Console.ReadLine());
                if(repete == 's')
                {
                    numero = -1;
                }
            }
            */

            /*
            //QUESTAO 06
            int idade = -1;
            while(idade < 0)
            {
                Console.WriteLine("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A idade digitada foi: "+idade);
            */

            /*
            //QUESTAO 08
            float numero = (float)0.5;
            char opcao = 's';
            int numeroConvertido = 0;
            while (opcao == 's')
            {
                while ((numero - numeroConvertido) != 0)
                {
                    Console.WriteLine("Digite um numero inteiro: ");
                    numero = float.Parse(Console.ReadLine());
                    numeroConvertido = (int)numero;
                }
                if (numero % 2 == 0)
                {
                    Console.WriteLine("numero é par!");
                }
                else
                {
                    Console.WriteLine("Numero é impar!");
                }
                Console.WriteLine("Deseja roda o programa novamente? (s/n)");
                opcao = char.Parse(Console.ReadLine());
                if(opcao == 's')
                {
                    numero = (float) (numero + 0.5);
                }
            }
            */

            /*
            //QUESTAO 09
            int quantidade = 0, qtd01And03 = 0, qtd04And07 = 0, qtd08 = 0, qtd0 = 0;
            for(int i = 0; i < 30; i++)
            {
                Console.WriteLine("Quantos filhos vc tem?");
                quantidade = int.Parse(Console.ReadLine());
                if(quantidade >= 1 && quantidade <= 3)
                {
                    qtd01And03++;
                }else if (quantidade >= 4 && quantidade <= 7)
                {
                     qtd04And07++;
                }else if (quantidade >= 8 )
                {
                    qtd08++;
                }else if(quantidade == 0)
                {
                    qtd0++;
                }
            }
            Console.WriteLine("Quantas pessoas tem entre 1 e 3 filhos: "+ qtd01And03);
            Console.WriteLine("Quantas pessoas tem entre 4 e 7 filhos: " + qtd04And07);
            Console.WriteLine("Quantas pessoas tem mais de 8 filhos: "+ qtd08);
            Console.WriteLine("Quantas pessoas não tem filhos: " + qtd0);
            */
        }
    }
}