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
                for(int j = 2; j <= vetor[i]; j++)
                {
                    if(vetor[i] % j == 0)
                    {
                        qtdDiv++;
                    }
                }
                if(qtdDiv == 1)
                {
                    Console.WriteLine("Primo, Indice " + i);
                }
                qtdDiv = 0;
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

            /*
            //QUESTAO 08
            float[] vetor = new float[30];
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Digite: ");
                vetor[i] = float.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 30; i++)
            {
                if (vetor[i] < 0)
                {
                    Console.WriteLine("Posicao: " + (i+1));
                }
            }
            */

            /*
            //QUESTAO 09
            int[] vetor = new int[10];
            int aux = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite:");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j < 10; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }

            Console.WriteLine("Novo vetor crescente");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            */

            /*
            //QUESTAO 10
            int[] vetor = new int[5];
            int[] vetorResultado = new int[5];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor da posicao "+(i+1)+": ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            //MOSTRANDO VETOR
            Console.WriteLine("Vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(" " + vetor[i]);
                if(vetor[i] == 0)
                {
                    vetorResultado[i] = 2 ;
                }
                else
                {
                    vetorResultado[i] = vetor[i];
                }
            }
            //MOSTRANDO VETOR RESULTADO
            Console.WriteLine("\nVetor Resultado:");
            for(int i = 0; i < vetor.Length; i++)
            {
                Console.Write(" " + vetorResultado[i]);
            }
            */

            /*
            //QUESTAO 11
            int[] vetor = new int[5], vetorAux = new int[5];

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("digite: ");
                vetor[i] = int.Parse(Console.ReadLine());
                vetorAux[4-i] = vetor[i];
            }
            Console.WriteLine("------------");
            for (int i = 0; i < 5; i++)
            {
                vetor[i] = vetorAux[i];
                Console.WriteLine(vetor[i]);
            }
            */

            /*
            //QUESTAO 12
            int[] vetor = new int[10];
            int ocorre = 0, numero = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite o numero a procura: ");
            numero = int.Parse(Console.ReadLine());
            for(int i = 0; i < 10; i++)
            {
                if (vetor[i] == numero)
                {
                    Console.WriteLine("Numero encontrado!");
                    Console.WriteLine("Posicao: "+(i+1));
                    ocorre++;
                }
            }
            if (ocorre == 0) Console.WriteLine("Numero nao encontrado");
            */

            /*
            //QUESTAO 13
            int[] vetor = new int[100];
            int cont = 0;

            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] == 2 || vetor[i] == 4 || vetor[i] == 8)
                {
                    cont++;
                }
            }
            Console.WriteLine($"Os numero 2, 4 e 8 aparecem {cont} vezes");
            */

            /*
            //QUESTAO 14
            int codigo = 0;
            int[] vetor = new int[5];
            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("Digite um codigo: ");
                codigo = int.Parse(Console.ReadLine());
                switch (codigo)
                {
                    case 0:
                        Console.WriteLine("Encerrando o programa!");
                        break;
                    case 1:
                        Console.WriteLine("Vetor em ordem normal: ");
                        for (int i = 0; i < vetor.Length; i++)
                        {
                            Console.Write(" " + vetor[i]);
                        }
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.WriteLine("vetor em ordem reversa: ");
                        for (int i = 0; i < vetor.Length; i++)
                        {
                            Console.Write(" " + vetor[vetor.Length - (i + 1)]);
                        }
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }  
            } while (codigo != 0);
            */

            /*
            //QUESTAO 15
            int[] vetor = new int[5];
            int[] vetorInvertido = new int[5];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                vetorInvertido[i] = vetor[vetor.Length - (i+1)];
            }
            Console.WriteLine("Vetor normal:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($" {vetor[i]}");
            }
            Console.WriteLine("\nVetor invertido:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($" {vetorInvertido[i]}");
            }
            */


            //QUESTAO 16
            int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] y = new int[10] { 1, 6, 30, 4, 5, 60, 7, 9, 10, 11 };
            int[] uniao = new int[20];
            int[] diferenca = new int[10];
            int[] interseccao = new int[10];
            Console.WriteLine("UNIÃO");
            x.CopyTo(uniao, 0);
            int auxU = 10;
            //                        0  1  2  3  4  5  6  7  8   9            
            //int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };            
            //int[] y = new int[10] { 1, 6,30, 4, 5,60, 7, 9,10, 11 };
            for (int i = 0; i < y.Length; i++)
            {
                //elementos de x e elementos y que não estão em X            
                for (int j = 0; j < x.Length; j++)
                {
                    if (y[i] == x[j])
                    {
                        break;
                    }
                    if (j == (x.Length - 1))
                    {
                        uniao[auxU] = y[i];
                        auxU++;
                    }
                }
            }
            for (int i = 0; i<auxU; i++)
            {
                Console.WriteLine(uniao[i]);
            }
            Console.WriteLine("");


            Console.WriteLine("DIFERENÇA");
            //diferença - elementos de X que não estão no Y            
            //                        0  1  2  3  4  5  6  7  8   9            
            //int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };            
            //int[] y = new int[10] { 1, 6,30, 4, 5,60, 7, 9,10, 11 };
            int auxD = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        break;
                    }
                    if (j == (y.Length - 1))
                    {
                        diferenca[auxD] = x[i];
                        auxD++;
                    }
                }
            }
            for (int i = 0; i < auxD; i++)
            {
                Console.WriteLine(diferenca[i]);
            }
            Console.WriteLine("");


            Console.WriteLine("INTERSECCAO");
            int auxI = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for(int j = 0; j < y.Length; j++)
                {
                    if(x[i] == y[j])
                    {

                    }
                }
            }

            Console.WriteLine("INTERSECÇÃO");
            //os elementos que aparecem em X e Y
            auxI = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[i])
                    {
                        interseccao[auxI] = x[i];
                        auxI++;
                        break;
                    }
                }
            }
            for (int i = 0; i < auxI; i++)
            {
                Console.WriteLine(interseccao[i]);
            }
            Console.WriteLine("");

        }
    }
}