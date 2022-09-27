using System.Xml.Serialization;

namespace ListaExercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // QUESTAO 01
            int baseTriangulo, alturaTriangulo;
            Console.WriteLine("Digite o valor da base: ");
            baseTriangulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura: ");
            alturaTriangulo = int.Parse(Console.ReadLine());
            if (baseTriangulo == 0 || alturaTriangulo == 0)
            {
                Console.WriteLine("Valor nao pode ser zero!");
            }
            else
            {
                Console.WriteLine("Valor da base do triangulo = " + (baseTriangulo * alturaTriangulo) / 2);
            }
            */

            /*
            //QUESTAO 02
            int numero;
            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0) Console.WriteLine("o numero é par!");
            else Console.WriteLine("o numero é impar!");
            */

            /*
            //QUESTAO 03
            int num1, num2, num3, num4;
            float media;
            Console.WriteLine("Digite numero 01: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite numero 02: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite numero 03: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite numero 04: ");
            num4 = int.Parse(Console.ReadLine());
            media = (float) (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("Media: " + media);
            Console.Write("Maiores: ");
            if (num1 > media) Console.Write(num1 + " ");
            if (num2 > media) Console.Write(num2 + " ");
            if (num3 > media) Console.Write(num3 + " ");
            if (num4 > media) Console.Write(num4 + " ");
            */

            /*
            //QUESTAO 04
            int qtdHoras01, qtdHoras02;
            float valor01, valor02, salario01, salario02;

            Console.WriteLine("Digite quantidade de horas professor 01: ");
            qtdHoras01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor por hora professor 01: ");
            valor01 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantidade de horas professor 02: ");
            qtdHoras02 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor por hora professor 02: ");
            valor02 = float.Parse(Console.ReadLine());
            salario01 = (float) qtdHoras01 * valor01;
            salario02 = (float)qtdHoras02 * valor02;
            if (salario01 > salario02) Console.WriteLine("Salario do professor 01 é maior que o do 02");
            else if(salario02 > salario01) Console.WriteLine("Salario do professor 02 é maior que o do 02");
            else Console.WriteLine("Salario sao iguais");
            */

            /*
            //QUESTAO 05
            float media, nota01, nota02;
            Console.WriteLine("Digite a primeira nota: ");
            nota01 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            nota02 = float.Parse(Console.ReadLine());
            media = (nota01 + nota02) / 2;
            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }else
            {
                Console.WriteLine("Digite a nota do Exame Final: ");
                float notaExame = float.Parse(Console.ReadLine());
                float mediaFinal = (media + notaExame) / 2;
                if(mediaFinal >= 5)
                    Console.WriteLine("Aprovado");
                else
                    Console.WriteLine("Reprovado");  
            }
            */

            /*
            //QUESTAO 06
            float altura, peso, imc;
            Console.WriteLine("Digite a altura");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso");
            peso = float.Parse(Console.ReadLine());
            imc = peso / (altura * altura);
            if (imc < 18) Console.WriteLine("Baixo peso");
            else if (imc >= 18 && imc < 25 ) Console.WriteLine("peso normal");
            else if (imc >= 25 && imc < 30 ) Console.WriteLine("sobrepeso");
            else if (imc >= 30 && imc < 35 ) Console.WriteLine("obesidade");
            else if (imc >=35) Console.WriteLine("obesidade grau serio");
            */

            /*
            //QUESTAO 07
            string fraseDigitada, palavra;
            Console.WriteLine("Digite uma frase: ");
            fraseDigitada = Console.ReadLine();
            Console.WriteLine("Digite a palavra: ");
            palavra = Console.ReadLine();

            if (fraseDigitada.Contains(palavra))
            {
                Console.WriteLine("Encontrou");
            }
            else
            {
                Console.WriteLine("Não encontrou");
            }
            */

            /*
            //QUESTAO 08
            int codigo;
            string nome;
            float salarioBase, totalVendas;

            Console.WriteLine("Digite o codigo: ");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o salario base: ");
            salarioBase = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas: ");
            totalVendas = float.Parse(Console.ReadLine());

            if(totalVendas > 5000)
            {
                salarioBase = salarioBase + ((totalVendas * 10)/100);
                Console.WriteLine(salarioBase);
            }else if(totalVendas > 1000)
            {
                salarioBase = salarioBase + ((totalVendas * 7) / 100);
                Console.WriteLine(salarioBase);
            }
            else if(totalVendas > 500)
            {
                salarioBase = salarioBase + ((totalVendas * 5) / 100);
                Console.WriteLine(salarioBase);
            }
            */

            /*
            //QUESTAO 09
            int valor01, valor02, valor03;
            float media;
            Console.WriteLine("Digite o primeiro valor:");
            valor01 = int.Parse(Console.ReadLine());
            if (valor01 < 65) Console.WriteLine("Risco de Hipoglicemia");
            else if (valor01 > 250) Console.WriteLine("Risco de Hiperglicemia");
            else Console.WriteLine("Normal");
            Console.WriteLine("Digite o segundo valor:");
            valor02 = int.Parse(Console.ReadLine());
            if (valor02 < 65) Console.WriteLine("Risco de Hipoglicemia");
            else if (valor02 > 250) Console.WriteLine("Risco de Hiperglicemia");
            else Console.WriteLine("Normal");
            Console.WriteLine("Digite o terceiro valor:");
            valor03 = int.Parse(Console.ReadLine());
            if (valor03 < 65) Console.WriteLine("Risco de Hipoglicemia");
            else if (valor03 > 250) Console.WriteLine("Risco de Hiperglicemia");
            else Console.WriteLine("Normal");
            media = (float) (valor01 + valor02 + valor03) / 3;
            Console.WriteLine("RECOMENDACAO: ");
            if (media < 80) Console.WriteLine("Diminua 2 unidades de insulina");
            else if (media > 150) Console.WriteLine("Adicionar 2 unidades de insulina");
            else Console.WriteLine("Continue tomando normal");
            */

            /*
            //QUESTAO 10
            int idade1, idade2;
            float altura1, altura2;
            string nome1, nome2;

            Console.WriteLine("Digite o nome do atleta 01: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite a idade do atleta 01: ");
            idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do atleta 01: ");
            altura1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do atleta 02: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite a idade do atleta 02: ");
            idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do atleta 02: ");
            altura2 = float.Parse(Console.ReadLine());
            if(idade1 > idade2)
            {
                Console.WriteLine("Atleta mais novo é "+ nome1);
            }
            else
            {
                Console.WriteLine("Atleta mais novo é: "+ nome2);
            }

            if (altura1 > altura2)
            {
                Console.WriteLine("Atleta mais alto é: "+ nome1);
            }
            else
            {
                Console.WriteLine("Atleta mais alto é: "+ nome2);
            }
            */

            /*
            //QUESTAO 11
            int hora, minuto;

            Console.WriteLine("Digite a hora: ");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os minutos: ");
            minuto = int.Parse(Console.ReadLine());
            if(((hora >= 0) && (hora <=23)) && ((minuto >=0) && (minuto <= 59))) {
                Console.WriteLine("horario valido: "+ hora + ":" + minuto);
            }
            else
            {
                Console.WriteLine("horario invalido!");
            }
            */

            /*
            //QUESTAO 12
            int codigo, numeroHoras, extra=0;
            Console.WriteLine("Digite o codigo: ");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de horas: ");
            numeroHoras = int.Parse(Console.ReadLine());
            if(numeroHoras > 50)
            {
                int auxiliar = numeroHoras - 50;
                numeroHoras -= auxiliar;
                extra = auxiliar * 20;
                int salario = (numeroHoras * 10) + extra;
                Console.WriteLine("Salario: " + salario);
            } else
            {
                int salario = (numeroHoras * 10);
                Console.WriteLine("Salario: " + salario);
            }
            */

            /*
            //QUESTAO 13
            float altura;
            char sexo;

            Console.WriteLine("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu sexo: (m) ou (f)");
            sexo = char.Parse(Console.ReadLine());

            if(sexo == 'm')
            {
                Console.WriteLine("Peso Ideal: " + ((72.7 * altura) - 58));
            }
            else if(sexo == 'f')
            {
                Console.WriteLine("Peso Ideal: " + ((62.1 * altura) - 44.7));
            }
            */

            //QUESTAO 14
            int tamArq = 0, velInt = 0;

            Console.WriteLine("Digite o tamanho do arquivo: ");

            Console.WriteLine("Digite a velocidade link internet: ");


            /*
            //QUESTAO 15
            int metrosQuadrados, qtdLatas; 
            float qtdLitros, qtdLatasResto;

            Console.WriteLine("Digite a quantidade de metros quadrados: ");
            metrosQuadrados = int.Parse(Console.ReadLine());

            qtdLitros = (float) metrosQuadrados / 3;
            qtdLatas = (int) qtdLitros / 18;
            qtdLatasResto = qtdLitros % 18;
            
            if(qtdLatasResto > 0)
            {
                Console.WriteLine("Quantidade Comprada: " + (qtdLatas + 1));
                Console.WriteLine("Preco Total: " + ((qtdLatas * 80) + 80));
            }
            else
            {
                Console.WriteLine("Quantidade Comprada: " + qtdLatas);
                Console.WriteLine("Preco Total: " + qtdLatas * 80);
            }
            */

            /*
            //QUESTAO 16
            int timeFora, timeCasa;

            Console.WriteLine("Digite total de gols time da casa: ");
            timeCasa = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite total de gols time de fora: ");
            timeFora = int.Parse(Console.ReadLine());

            if(timeFora - timeCasa > 2)
            {
                Console.WriteLine("Time de fora ja se classificou!");
            }
            else
            {
                Console.WriteLine("Vão se enfrentar novamente!");
                Console.WriteLine("Placar segundo jogo: ");
                Console.WriteLine("Digite total de gols time da casa: ");
                int timeCasaNovo = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite total de gols time de fora: ");
                int timeForaNovo = int.Parse(Console.ReadLine());
                if ((timeCasa + timeCasaNovo) > (timeFora + timeForaNovo)) Console.WriteLine("Time de Casa passou de fase");
                else Console.WriteLine("Time de fora passou de fase!");

            }
            */

            /*
            //QUESTAO 17
            int a, b, c;
            
            Console.WriteLine("Digite o valor do lado A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado C: ");
            c = int.Parse(Console.ReadLine());

            if(a < (b + c) && b < (c + a) && c < (a + b))
            {
                Console.WriteLine("é um triangulo!");
                if (a == b && b == c)
                {
                    Console.WriteLine("triangulo equilatero");
                }
                else if (a != b && b != c && a != c)
                {
                    Console.WriteLine("triangulo escaleno");
                }
                else
                {
                    Console.WriteLine("triangulo isosceles");
                }
            }
            else
            {
                Console.WriteLine("não é um triangulo!");
            }
            */

            /*
            //QUESTAO 18
            int valor1, valor2, valor3;
            Console.WriteLine("Digite o primeiro valor:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor:");
            valor3 = int.Parse(Console.ReadLine());
            if(valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine("O maior: " + valor1);
            }else if(valor2 > valor3)
            {
                Console.WriteLine("O maior: "+ valor2);
            }
            else
            {
                Console.WriteLine("O maior: "+ valor3);
            }
            */

            /*
            //QUESTAO 19
            int valor1, valor2, valor3;
            Console.WriteLine("Digite o primeiro valor:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor:");
            valor3 = int.Parse(Console.ReadLine());
            if (valor1 < valor2 && valor1 < valor3)
            {
                if(valor2 < valor3)
                {
                    Console.WriteLine(valor1+" "+valor2+" "+valor3);
                }
                else
                {
                    Console.WriteLine(valor1 + " " + valor3 + " " + valor2);
                }
            }else if(valor2 < valor1 && valor2 < valor3)
            {
                if (valor1 < valor3)
                {
                    Console.WriteLine(valor2 + " " + valor1 + " " + valor3);
                }
                else
                {
                    Console.WriteLine(valor2 + " " + valor3 + " " + valor1);
                }
            }
            else if (valor3 < valor1 && valor3 < valor2)
            {
                if (valor1 < valor2)
                {
                    Console.WriteLine(valor3 + " " + valor1 + " " + valor2);
                }
                else
                {
                    Console.WriteLine(valor3 + " " + valor2 + " " + valor1);
                }
            }
            */

            /*
            //QUESTAO 20
            int numeroSecreto = 15;
            int numeroDigitado = 0;

            Console.WriteLine("Digite um numero: ");
            numeroDigitado = int.Parse(Console.ReadLine());
            if(numeroDigitado == numeroSecreto)
            {
                Console.WriteLine("Acertou!!!");
            }
            else if(numeroDigitado > numeroSecreto){
                Console.WriteLine("Numero digitado é maior!");
                Console.WriteLine("Digite novamente: ");
                numeroDigitado = int.Parse(Console.ReadLine());
                if (numeroDigitado == numeroSecreto)
                {
                    Console.WriteLine("Acertou!!!");
                }
                else if (numeroDigitado > numeroSecreto)
                {
                    Console.WriteLine("Numero digitado é maior!");
                    Console.WriteLine("Digite novamente: ");
                    numeroDigitado = int.Parse(Console.ReadLine());
                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("Acertou!!!");
                    }
                    else
                    {
                        Console.WriteLine("Errou\nAcabou as tentativas");
                    }

                }
                else
                {
                    Console.WriteLine("Numero digitado é menor!");
                    Console.WriteLine("Digite novamente: ");
                    numeroDigitado = int.Parse(Console.ReadLine());
                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("Acertou!!!");
                    }
                    else
                    {
                        Console.WriteLine("Errou\nAcabou as tentativas");
                    }
                }
            }
            else
            {
                Console.WriteLine("Numero digitado é menor!");
                Console.WriteLine("Digite novamente: ");
                numeroDigitado = int.Parse(Console.ReadLine());
                if (numeroDigitado == numeroSecreto)
                {
                    Console.WriteLine("Acertou!!!");
                }
                else if (numeroDigitado > numeroSecreto)
                {
                    Console.WriteLine("Numero digitado é maior!");
                    Console.WriteLine("Digite novamente: ");
                    numeroDigitado = int.Parse(Console.ReadLine());
                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("Acertou!!!");
                    }
                    else
                    {
                        Console.WriteLine("Errou\nNumero de tentativas acabou");
                    }

                }
                else
                {
                    Console.WriteLine("Numero digitado é menor!");
                    Console.WriteLine("Digite novamente: ");
                    numeroDigitado = int.Parse(Console.ReadLine());
                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("Acertou!!!");
                    }
                    else
                    {
                        Console.WriteLine("Errou\nAcabou as tentativas!");
                    }
                }
            }
            */

        }
    }
}