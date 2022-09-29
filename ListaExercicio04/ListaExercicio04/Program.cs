namespace ListaExercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //QUESTAO 01
            int[] vetor = new int[10];
            int qtdPar = 0, qtdImpar = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o elemento "+i+": ");
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] % 2 == 0)
                {
                    qtdPar++;
                }
                else
                {
                    qtdImpar++;
                }
            }
            Console.WriteLine("Quantidade de pares: "+ qtdPar);
            Console.WriteLine("Quantidade de impar: " + qtdImpar);
            */

            /*
            //QUESTAO 02
            int[] vetorA = new int[20], vetorB = new int[20], vetorRes = new int[20];

            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite o valor do vetor A posicao "+i+": ");
                vetorA[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do vetor B posicao " + i + ": ");
                vetorB[i] = int.Parse(Console.ReadLine());
                vetorRes[i] = vetorA[i] + vetorB[i];
            }
            */

            /*
            //QUESTAO 03
            int[] vetor = new int[20];
            int qtdDiv = 0;
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite o valor da posicao "+i+": ");
                vetor[i] = int.Parse(Console.ReadLine());
                for(int j = 1; j <= vetor[i]; j++)
                {
                    if(vetor[i] % j == 0)
                    {
                        qtdDiv++;
                    }
                }
                if(qtdDiv == 2)
                {
                    Console.WriteLine("Indice " + i);
                    qtdDiv = 0;
                }
            }
            */

            /*
            //QUESTAO 04
            int[] vetorA = new int[10], vetorB = new int[10], vetorRes = new int[10];

            for(int i = 0; i < vetorA.Length; i++)
            {
                Console.WriteLine("Digite o valor do vetorA posicao "+i);
                vetorA[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do vetorB posicao " + i);
                vetorB[i] = int.Parse(Console.ReadLine());
                vetorRes[i] = vetorA[i] * vetorB[i];
            }

            for(int i = 0; i < vetorRes.Length; i++) {
                Console.WriteLine("VetorRes: "+ vetorRes[i]);
            }
            */

            /*
            //QUESTAO 05
            int[] vetor = new int[80];
            int menor = 100000, pos = 0;
            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um valor: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if(menor > vetor[i])
                {
                    menor = vetor[i];
                    pos = i;
                }
            }
            Console.WriteLine("Menor: "+ menor);
            Console.WriteLine("Posicao: "+ pos);
            */

            /*
            //QUESTAO 06
            int[] vetor = new int[5];
            int[] vetorCont = new int[5];

            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite:");
                vetor[i] = int.Parse(Console.ReadLine());
                vetorCont[vetor.Length - (i+1)] = vetor[i];
            }
            Console.WriteLine("---------------------");
            for(int i = 0; i < vetorCont.Length; i++)
            {
                Console.WriteLine(vetorCont[i]);
            }
            */

            /*
            //QUESTAO 07
            int contIndice = 0;

            int[] vetor = new int[10];
            int[] vetorNovo = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite: ");
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] % 2 == 0)
                {
                    vetorNovo[contIndice] = vetor[i];
                    contIndice++;
                }
            }
            for(int i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    vetorNovo[contIndice] = vetor[i];
                    contIndice++;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("VetorNovo: "+ vetorNovo[i]);
            }
            */

            //QUESTAO 08

            //QUESTAO 09

            //QUESTAO 10

            //QUESTAO 11

            //QUESTAO 12

            //QUESTAO 13

            //QUESTAO 14

            //QUESTAO 15

            //QUESTAO 16




        }
    }
}