using System.Net.Http.Headers;

namespace ListaExercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //QUESTAO 01
            int[,] matriz = new int[5,3];

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite [" + (i + 1) + "," + 1 +"]: ");
                matriz[i, 0] = int.Parse(Console.ReadLine());
                matriz[i, 1] = matriz[i, 0] + 10;
                matriz[i, 2] = matriz[i, 0] * 2;
            }

            for(int i =0; i < 5; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    Console.Write("[" + matriz[i,j]+"] ");
                }
                Console.WriteLine();
            }
            */

            /*
            //QUESTAO 02
            int[,] matriz = new int[3, 3];
            int somaLinha = 0, somaColuna = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite [" + (i + 1) + "," + (j+1) + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mostrando a tabela");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + matriz[i,j]+"]");
                }
                Console.WriteLine();
            }

            Console.WriteLine("A soma dos elementos de cada Linha:");
            for (int i = 0; i < 3; i++)
            {
                somaLinha = 0;
                for (int j = 0; j < 3; j++)
                {
                    somaLinha = somaLinha + matriz[i, j];
                }
                Console.WriteLine("Linha " + i+": "+ somaLinha);
            }
            Console.WriteLine("A soma dos elementos de cada Coluna:");
            for (int i = 0; i < 3; i++)
            {
                somaColuna = 0;
                for (int j = 0; j < 3; j++)
                {
                    somaColuna = somaColuna + matriz[j, i];
                }
                Console.WriteLine("Coluna " + i + ": " + somaColuna);
            }
            */

            /*
            //QUESTAO 03
            int[,] matriz = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Digite [" + (i + 1) + "," + (j + 1) + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mostrando a tabela");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Elementos da Diagonal Principal");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(i == j)
                    {
                        Console.Write("[" + matriz[i, j] + "]");
                    }
                    
                }
                Console.WriteLine();
            }
            */

            /*
            //QUESTAO 04
            int[,] matriz = new int[5, 5];
            int contPar = 0, contImpar = 0, contPos = 0, contNeg = 0, contZero = 0;
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Digite [" + (i + 1) + "," + (j + 1) + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if(matriz[i, j] % 2 == 0)
                    {
                        contPar++;
                    }
                    else
                    {
                        contImpar++;
                    }
                    if(matriz[i, j] > 0)
                    {
                        contPos++;
                    }else if(matriz[i, j] < 0)
                    {
                        contNeg++;
                    }
                    else
                    {
                        contZero++;
                    }
                }
            }
            Console.WriteLine($"Numeros Pares: {contPar}");
            Console.WriteLine($"Numeros Impares: {contImpar}");
            Console.WriteLine($"Numeros Positivos: {contPos}");
            Console.WriteLine($"Numeros Negativos: {contNeg}");
            Console.WriteLine($"Numeros Zeros: {contZero}");
            */

            /*
            //QUESTAO 05
            double[,] matriz01 = new double[2, 3];
            double[,] matriz02 = new double[2, 3];

            Console.WriteLine("Tabela 01:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite [" + (i + 1) + "," + (j + 1) + "]: ");
                    matriz01[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Tabela 02:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite [" + (i + 1) + "," + (j + 1) + "]: ");
                    matriz02[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Mostrando a tabela com a soma:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + (matriz01[i, j]+ matriz02[i, j]) + "]");
                }
                Console.WriteLine();
            }
            */

            /*
            //QUESTAO 06
            int[,] m = new int[4, 4];
            Random random = new Random();
            int maior = -999;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    m[i, j] = random.Next(0, 9);
                }
            }

            Console.WriteLine("Mostrando a tabela com a soma:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("[" + m[i, j]+ "]");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(m[i, j] > maior)
                    {
                        maior = m[i, j];
                    }
                }
            }
            Console.WriteLine("Maior: "+ maior);
            */

            /*
            //QUESTAO 07
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] c = new int[3, 3];

            Console.WriteLine("Tabela A:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite [" + (i + 1) + "," + (j + 1) + "]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Tabela B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite [" + (i + 1) + "," + (j + 1) + "]: ");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Tabela C:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    c[i, j] = a[i, j] - b[i, j];
                    Console.Write("[" + c[i, j] + "]");
                }
                Console.WriteLine();
            }
            */

            //QUESTAO 08
            //NÃO TEM ESSA QUESTÃO

            /*
            //QUESTAO 09
            int[,] matriz = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Digite [" + (i + 1) + "," + (j + 1) + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Mostrando a tabela:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Mostrando a tabela invertida:");
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }
            */

            /*
            //QUESTAO 10
            int[,] matriz = new int[3, 3];
            int numero = 0, cont =0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite [" + (i + 1) + "," + (j + 1) + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite o numero a procura: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        cont++;
                    }   
                }
            }
            if(cont > 0)
            {
                Console.WriteLine("Numero Existe!");
            }
            else
            {
                Console.WriteLine("Numero inexistente");
            }
            */

            /*
            //QUESTAO 11
            int[,] a = new int[4, 4];
            int[,] b = new int[4, 4];
            int somaA = 0, somaB = 0;
            float media = 0;

            Console.WriteLine("Tabela A:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Digite [" + (i + 1) + "," + (j + 1) + "]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                    somaA = somaA+ a[i, j];
                }
            }

            Console.WriteLine("Tabela B:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Digite [" + (i + 1) + "," + (j + 1) + "]: ");
                    b[i, j] = int.Parse(Console.ReadLine());
                    somaB = somaB + b[i, j];
                }
            }
            media = (float)(somaA+somaB) / 32;

            Console.WriteLine("Tabela A => ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i,j] < media)
                    {
                        Console.WriteLine($"o elemento {a[i,j]} é menor");
                    }
                    else if (a[i, j] > media)
                    {
                        Console.WriteLine($"o elemento {a[i, j]} é maior");
                    }
                    else
                    {
                        Console.WriteLine($"o elemento {a[i, j]} é igual");
                    }
                }
            }

            Console.WriteLine("Tabela B => ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (b[i, j] < media)
                    {
                        Console.WriteLine($"o elemento {b[i, j]} é menor");
                    }
                    else if(b[i, j] > media)
                    {
                        Console.WriteLine($"o elemento {b[i, j]} é maior");
                    }
                    else
                    {
                        Console.WriteLine($"o elemento {b[i, j]} é igual");
                    }
                }
            }
            */

            /*
            //QUESTAO 12
            double[,] a = new double[3, 3];
            double[,] matrizResultante = new double[3, 3];

            Console.WriteLine("Tabela A:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite [" + (i + 1) + "," + (j + 1) + "]: ");
                    a[i, j] = double.Parse(Console.ReadLine());
                    if((i + j) == 0)
                    {
                        matrizResultante[i, j] = 0;
                    }
                    else
                    {
                        matrizResultante[i, j] = a[i, j] / (i + j);
                    }
                    
                }
            }

            Console.WriteLine("Mostrando a tabela A:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + a[i, j] + "]");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Mostrando a tabela resultante:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + matrizResultante[i, j] + "]");
                }
                Console.WriteLine();
            }
            */
        }
    }
}