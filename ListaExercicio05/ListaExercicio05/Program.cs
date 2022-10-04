using System;
using System.Data.Common;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.Arm;
using System.Xml;

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

            /*
            //QUESTAO 08
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
            //QUESTAO 09
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
            //QUESTAO 10
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
            //QUESTAO 11
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

            /*
            //QUESTAO 12
            int[,] matriz = new int[4,3];
            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = random.Next(0, 100);
                }
            }

            Console.WriteLine("Mostrando a tabela:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("Mostrando onde a soma dos indices sao pares: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if((i+j) % 2 == 0)
                    {
                        Console.Write("[" + matriz[i, j] + "] ");
                    }
                }
            }
            */

            /*
            //QUESTAO 13
            int ordem = 5, cont = 0;
            int[,] matriz = new int[ordem, ordem];
            int somaPrincipal = 0, somaSecundaria = 0;
            Random random = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(0, 10);
                }
            }
            Console.WriteLine("Mostrando a tabela:");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                    if (i == j)
                    {
                        somaPrincipal = somaPrincipal + matriz[i, j];
                        somaSecundaria = somaSecundaria + matriz[i, ordem - (j + 1)];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Soma da diagonal principal: {somaPrincipal}");
            Console.WriteLine($"Soma da diagonal Secundaria: {somaSecundaria}");
            */


            /*
            //QUESTAO 14
            int ordem = 5, cont = 0;
            int[,] matriz = new int[ordem, ordem];
            Random random = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i},{j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mostrando a tabela:");
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                    if(i == j)
                    {
                        if (matriz[i,j] == matriz[i, ordem- (j + 1)])
                        {
                            cont++;
                        }
                    }
                }
                Console.WriteLine();
            }
            if(cont == ordem)
            {
                Console.WriteLine("A diagonal principal e secundaria sao iguais");
            }
            else
            {
                Console.WriteLine("a diagonal principal e secundaria nao sao iguais");
            }
            */


            /*
            //QUESTAO 15
            int[,] matrizA = new int[4, 4], matrizB = new int[4,4];
            int[,] matrizResultante = new int[4,4];
            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrizA[i, j] = random.Next(0, 100);
                    matrizB[i, j] = random.Next(0, 100);
                    matrizResultante[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            Console.WriteLine("Mostrando a tabela A:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("[" + matrizA[i, j] + "]");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Mostrando a tabela B:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("[" + matrizB[i, j] + "]");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Mostrando a tabela resultante:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("[" + matrizResultante[i, j] + "]");
                }
                Console.WriteLine();
            }
            */


            /*
            //QUESTAO 16
            int[,] matriz = new int[3, 4];
            int[,] matrizTransposta = new int[4, 3];

            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(0, 10);
                }
            }

            Console.WriteLine("Mostrando a tabela:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                    matrizTransposta[j, i] = matriz[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine("Mostrando a tabela transposta:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + matrizTransposta[i, j] + "]");
                }
                Console.WriteLine();
            }
            */

            /*
            //QUESTAO 17
            //DESAFIO
            int[,] matriz = new int[10, 10];
            int miniMax = 999, linha =  0, coluna=0;
            int maiorElem = -999;
            Random random = new Random();

            //Preenchendo aleatoriamente
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = random.Next(0, 100);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if(maiorElem < matriz[i, j])
                    {
                        maiorElem = matriz[i, j];
                        linha = i;
                    }
                }
            }
            for(int i = 0; i < 10; i++)
            {
                if (matriz[linha, i] < miniMax)
                {
                    miniMax = matriz[linha, i];
                    coluna = i;
                }
            }
            Console.WriteLine("Mostrando a tabela:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"O maior elemento é {maiorElem}");
            Console.WriteLine($"O minimax elemento é {miniMax}");
            Console.WriteLine($"Econtrado na linha {linha+1} e coluna {coluna+1}");
            */

        }
    }
}