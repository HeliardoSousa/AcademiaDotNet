using System.Runtime.ConstrainedExecution;

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
            //QUESTAO 03
            int numero = 1;
            do
            {
                Console.WriteLine("Digite numero: ");
                numero = int.Parse(Console.ReadLine());
                
                if (numero == 0) continue;

                if(numero % 2 == 0)
                {
                    Console.WriteLine("é par!");
                }
                else
                {
                    Console.WriteLine("é impar");
                }

                int qtdDiv = 0;
                for(int i = 2; i<= numero; i++)
                {
                    if(numero % i == 0)
                    {
                        qtdDiv++;
                    }
                }
                if(qtdDiv == 1)
                {
                    Console.WriteLine("primo");
                }
                else
                {
                    Console.WriteLine("nao e primo");
                }

            } while (numero != 0);
            */

            /*
            //QUESTAO 04
            int qtdJoao = 0, qtdJose = 0, branco = 0;
            string digitado= "fim";
            do
            {
                Console.WriteLine("Digite seu voto:");
                digitado = Console.ReadLine();
                if(digitado == "joao")
                {
                    qtdJoao++;
                }else if(digitado == "jose")
                {
                    qtdJose++;
                }else if( digitado == "branco")
                {
                    branco++;
                }
            } while (digitado != "fim");
            Console.WriteLine("Quantidade de joao: "+ qtdJoao+
                              "\nQuantidade de jose: "+ qtdJose+
                              "\nQuantidade de branco: "+branco
                            );
            */

            /*
            //QUESTAO 05
            int qtdJoao = 0, qtdJose = 0, branco = 0, nulos = 0;
            string digitado = "fim";
            do
            {
                Console.WriteLine("Digite seu voto:");
                digitado = Console.ReadLine();
                if (digitado == "joao")
                {
                    qtdJoao++;
                }
                else if (digitado == "jose")
                {
                    qtdJose++;
                }
                else if (digitado == "branco")
                {
                    branco++;
                }
                else
                {
                    if (digitado == "fim") continue;
                    nulos++;
                }
            } while (digitado != "fim");
            int qtdVotantes = qtdJose + qtdJoao + branco + nulos;
            Console.WriteLine((qtdJoao > qtdJose) ? "Vencedor João!" : "Vencedor Jose!");
            Console.WriteLine("Quantidade de votos nulos: " + nulos +
                              "\nQuantidade de votantes: " + qtdVotantes
                            );
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
            //QUESTAO 07
            string nome;
            int idade = 0;
            float salario = 0;
            Boolean controle = true;
            Boolean statusFinal = false;
            do
            {
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();
                if(nome.Any(char.IsDigit) || string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("Digite um nome valido!");
                    controle = false;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Digite a idade: ");
                        idade = int.Parse(Console.ReadLine());
                        if(idade <= 0)
                        {
                            Console.WriteLine("Digite uma idade valida: ");
                            controle = false;
                        }
                        else
                        {
                            do
                            {
                                Console.WriteLine("Digite o salario: ");
                                salario = float.Parse(Console.ReadLine());
                                if(salario <= 0)
                                {
                                    Console.WriteLine("Digite um salario valido: ");
                                    controle = false;
                                }
                                else
                                {
                                    controle = false;
                                    statusFinal = true;
                                }
                            } while (controle);
                        }
                    } while (controle);
                }
            } while (controle);
            if (statusFinal)
            {
                Console.WriteLine("Nome: "+ nome+
                                  "\nIdade: "+ idade+
                                  "\nSalario: "+salario
                    );
            }
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

            /*
            //QUESTAO 10
            string nome;
            char sexo;
            int idade, qtdMasc = 0, qtdFem = 0, qtdInf30 = 0, qtdSup60 = 0;
            for(int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Digite o nome da pessoa " + i + ": ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o sexo da pessoa "+ i + ": (m/f)");
                sexo = char.Parse(Console.ReadLine());
                Console.WriteLine("Digite a idade da pessoa "+ i +": ");
                idade = int.Parse(Console.ReadLine());
                if(sexo == 'm')
                {
                    qtdMasc++;
                }
                else
                {
                    qtdFem++;
                }
                if(idade < 30)
                {
                    qtdInf30++;
                }
                if(idade > 60) {
                    qtdSup60++;
                }
            }
            Console.WriteLine("Quantidade sexo masculino: "+qtdMasc+
                              "\nQuantidade sexo feminino: "+ qtdFem+
                              "\nQuantidade de pessoas com idade inferior a 30: "+ qtdInf30+
                              "\nQuantidade de pessoas com idade superior a 60: "+qtdSup60
                              );
            */

            /*
            //QUESTAO 11
            int qtdAlunos = 0;
            float notaAlta = 0, nota = 0, notaBaixa = 999, somaNota = 0;
      
            while(nota != -1)
            {
                Console.WriteLine("Ler a nota "+(qtdAlunos + 1)+": ");
                nota = float.Parse(Console.ReadLine());
                if (nota == -1) continue;
                if (nota > notaAlta)
                {
                    notaAlta = nota;
                }
                if(nota < notaBaixa)
                {
                    notaBaixa = nota;
                }
                somaNota = somaNota + nota;
                qtdAlunos++;
            }
            Console.WriteLine("Nota mais alta: "+ notaAlta);
            Console.WriteLine("Nota mais baixa: "+ notaBaixa);
            Console.WriteLine("media aritmetica: "+ somaNota/qtdAlunos);
            Console.WriteLine("Quantidade de alunos: "+ qtdAlunos);
            */

            /*
            //QUESTAO 12
            int soma = 0;
            for(int i = 1; i <=100; i++)
            {
                soma = soma + i;
            }
            Console.WriteLine("Soma dos 100 primeiros inteiros: "+ soma);
            */

            /*
            //QUESTAO 13
            int somaPar = 0;
            for(int i = 2; i < 500; i++)
            {
                if(i % 2 == 0)
                {
                    somaPar = somaPar + i;
                }
            }
            Console.WriteLine("Soma dos pares: " + somaPar);
            */

            /*
            //QUESTAO 14
            int resultado = 1;
            Console.WriteLine("2^0: 1");
            for(int i = 1; i<=10; i++)
            {
                for(int j = 0; j < 1; j++)
                {
                    resultado = resultado * 2;
                }
                Console.WriteLine("2^" + i + ": " +resultado);
            }
            */

            /*
            //QUESTAO 15
            float nota = 0;
            float somaNotas = 0;
            int somaPesos = 0;
            int[] peso = { 2, 1, 2, 4 };

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("digite a "+(i+1)+" nota:");
                nota = float.Parse(Console.ReadLine());
                somaNotas = somaNotas + (nota * peso[i]);
                somaPesos = somaPesos + peso[i];
            }
            float mediaPonderada = (float)somaNotas / somaPesos;
            Console.WriteLine((mediaPonderada >= 7) ? "Aprovado" : "Reprovado");
            */

            /*
            //QUESTAO 16
            int n = 60;
            int produto = 1;
            while(n > 50)
            {
                Console.WriteLine("Digite um numero menor ou igual a 50: ");
                n = int.Parse(Console.ReadLine());
            }

            for(int i = 1; produto<250 ; i++) {
                for(int j = 1; j <= i; j++)
                {
                    produto = produto * 3;
                }
                Console.WriteLine("Produto: "+ produto);
            }
            */

            /*
            //QUESTAO 17
            for(int i = 15; i<=200; i++)
            {
                Console.WriteLine("Quadrado de "+i+" é: "+(i*i));
            }
            */

            /*
            //QUESTAO 18
            int numBase = 4, potencia = 3, resultado=1; 
            for(int i = 1; i<= potencia; i++)
            {
                resultado = resultado * numBase;
            }
            Console.WriteLine("Resultado: "+ resultado);
            */

            /*
            //QUESTAO 19
            int qtdEntrevistados = 0, somaFilhos = 0, qtdFilhos = 0;
            float somaSalario = 0, maiorSalario=0, salario100 = 0;
            float salario = 1;
            do
            {
                Console.WriteLine("Digite o salario: ");
                salario = float.Parse(Console.ReadLine());
                if (salario < 0) break;
                Console.WriteLine("Digite o numero de filhos: ");
                qtdFilhos = int.Parse(Console.ReadLine());
                somaSalario = somaSalario + salario;
                somaFilhos = somaFilhos + qtdFilhos;
                if(salario > maiorSalario) maiorSalario = salario;
                if (salario <= 100) salario100++;
                qtdEntrevistados++;
            } while (true);

            Console.WriteLine("Media Salarial da populacao: "+ ((float) somaSalario/qtdEntrevistados));
            Console.WriteLine("Media filhos da populacao: " + ((float) somaFilhos / qtdEntrevistados));
            Console.WriteLine("Maior Salario: "+ maiorSalario);
            Console.WriteLine("Percentual de pessoas com salario de ate 100: "+ ((float)((salario100 * 100)/qtdEntrevistados)));
            */

            /*
            //QUESTAO 20
            char sexo;
            string corOlhos, corCabelo;
            int idade, idadeMaior = 0, qtdFem = 0;

            do
            {
                Console.WriteLine("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade == -1) break;
                Console.WriteLine("Digite o sexo: (m/f)");
                sexo = char.Parse(Console.ReadLine());
                Console.WriteLine("Digite a cor dos olhos: (azul, verde, castanho)");
                corOlhos = Console.ReadLine();
                Console.WriteLine("Digite a cor do cabelo: (louro, castanho, preto)");
                corCabelo = Console.ReadLine();
                if (idade > idadeMaior) idadeMaior = idade;
                if ((idade > 18 && idade < 35) && corCabelo == "louro" && corOlhos == "verde") qtdFem++;
            } while (true);
            Console.WriteLine("A maior idade: "+idadeMaior);
            Console.WriteLine("Quantidade de sexo feminino com condicoes: "+ qtdFem);
            */
        }
    }
}