using System.Security.Cryptography.X509Certificates;

namespace ListaExercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //-- QUESTÃO 01 --
            float num1 = 3, num2 = 2;
            Console.WriteLine("A média aritmética é: " + ((num1 + num2) / 2));
            */

            /*
            //-- Questão 02 --
            float num1 = 5, num2 = 5, num3 = 5, num4 = 3;
            Console.WriteLine("A média aritmética é: " + ((num1 + num2 + num3 + num4) / 4));
            */

            /*
            //-- QUESTÃO 03 --
            int var01 = 3, var02 = 9, auxiliar;
            Console.WriteLine("inicialmente, variavel 01: "+var01+" e variavel 02: "+var02);
            auxiliar = var01;
            var01 = var02;
            var02 = auxiliar;
            Console.WriteLine("Depois, variavel 01: " + var01 + " e variavel 02: " + var02);
            */

            /*
            //-- QUESTÃO 04 --
            int dia, mes, ano;
            Console.WriteLine("Digite o dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano: ");
            ano = int.Parse(Console.ReadLine());
            DateTime data = new DateTime(ano, mes, dia);
            Console.WriteLine(data.ToString("yyyy/MM/dd"));
            Console.WriteLine(data.ToString("yy/MM/dd"));
            */

            /*
            //-- QUESTAO 05 --
            float quilometrosPercorridos = 954;
            float consumidoLitro = 56;
            Console.WriteLine("Consumo: " + (quilometrosPercorridos / consumidoLitro) + "/l");
            */

            /*
            //-- QUESTAO 06 --
            int codigoParafusoA, quantidadeA, codigoParafusoB, quantidadeB;
            float valorUnitárioA, porcentagemA, valorUnitárioB, porcentagemB;
            Console.WriteLine("Digite o codido do parafuso A: ");
            codigoParafusoA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o codido do parafuso B: ");
            codigoParafusoB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do parafuso A: ");
            codigoParafusoA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do parafuso A: ");
            codigoParafusoB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do parafuso A: ");
            valorUnitárioA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do parafuso A: ");
            valorUnitárioB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem do parafuso A: ");
            porcentagemA = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem do parafuso A: ");
            porcentagemB = float.Parse(Console.ReadLine());
            */

            /*
            //-- QUESTAO 07 --
            int numeroVendedor;
            float salarioVendedor, totalVendas, percentualSobreVenda;
            Console.WriteLine("Digite o numero do vendedor: ");
            numeroVendedor = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o salario do vendedor: ");
            salarioVendedor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas do vendedor: ");
            totalVendas = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual sobre vendas do vendedor: ");
            percentualSobreVenda = float.Parse(Console.ReadLine());
            Console.WriteLine("Salario do vendedor codigo "+numeroVendedor+": " + (((percentualSobreVenda * totalVendas) / 100) + salarioVendedor));
            */

            /*
            //--QUESTAO 08--
            float temperaturaCelsius;
            Console.WriteLine("Digite uma temperatura em graus celsius");
            temperaturaCelsius = float.Parse(Console.ReadLine());
            Console.WriteLine("Graus Celsius: "+temperaturaCelsius+"º");
            Console.WriteLine("Graus Fahrenheit: " + (((9 * temperaturaCelsius) + 160) / 5) + "º");
            */

            /*
            //-- QUESTAO 09 --
            float valorMercadoria, valorMercadoriaQuebrado, entradaPrestacao, RestantePrestacao;
            int prestacaoInteira;
            Console.WriteLine("Digite o valor da mercadoria: ");
            valorMercadoria = float.Parse(Console.ReadLine());
            valorMercadoriaQuebrado = valorMercadoria % 3
            valorMercadoria = valorMercadoria - (valorMercadoria%3);
            if ((valorMercadoriaQuebrado % 3) != 0){
                Console.WriteLine("Primeira parcela: "+((valorMercadoria / 3)+valorMercadoriaQuebrado));
                Console.WriteLine("Segunda parcela: " + (valorMercadoria / 3));
                Console.WriteLine("Terceira parcela: " + (valorMercadoria / 3));

            }else{
                Console.WriteLine("O valor de cada prestação é: " + valorMercadoria / 3);
            }
            */

            /*
            //-- QUESTAO 10 --
            int qtd100 = 0, qtd50 = 0, qtd20 = 0, qtd10 = 0, qtd5 = 0, qtd2 = 0, qtd1 = 0;
            double saque;

            Console.WriteLine("Digite o valor do saque");
            saque = double.Parse(Console.ReadLine());

            qtd100 = (int)(saque / 100);
            Console.WriteLine("Notas de 100: " + qtd100);
            saque = saque - (qtd100 * 100);

            qtd50 = (int)(saque / 50);
            Console.WriteLine("Notas de 50: " + qtd50);
            saque = saque - (qtd50 * 50);

            qtd20 = (int)(saque / 20);
            Console.WriteLine("Notas de 20: " + qtd20);
            saque = saque - (qtd20 * 20);

            qtd10 = (int)(saque / 10);
            Console.WriteLine("Notas de 10: " + qtd10);
            saque = saque - (qtd10 * 10);

            qtd5 = (int)(saque / 5);
            Console.WriteLine("Notas de 5: " + qtd5);
            saque = saque - (qtd5 * 5);

            qtd2 = (int)(saque / 2);
            Console.WriteLine("Notas de 2: " + qtd2);
            saque = saque - (qtd2 * 2);

            qtd1 = (int)(saque / 1);
            Console.WriteLine("Notas de 1: " + qtd1);
            saque = saque - (qtd1 * 1);
            */

            /*
            //-- QUESTAO 11 --
            int numeroEleitores, votosBrancos, votosNulos, votosValidos;
            Console.WriteLine("Digite o numero de eleitores: ");
            numeroEleitores = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de votos brancos: ");
            votosBrancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de votos nulos: ");
            votosNulos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de votos validos: ");
            votosValidos = int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentagem branco: "+ ((100 * votosBrancos) / numeroEleitores));
            Console.WriteLine("Porcentagem branco: " + ((100 * votosNulos) / numeroEleitores));
            Console.WriteLine("Porcentagem branco: " + ((100 * votosValidos) / numeroEleitores));
            */

            /*
            // -- QUESTAO 12 --
            float precoGasolina = float.Parse("6,90");
            float quilometroInicio = 1250;
            float quilometroFinal = 1550;
            int litrosGastos = 16;
            float valorRecebido = float.Parse("190");
            Console.WriteLine("Total quilometragem: "+ (quilometroFinal - quilometroInicio));
            Console.WriteLine("Media do Consumo: " + ((quilometroFinal - quilometroInicio)/litrosGastos)+"/l");
            Console.WriteLine("Lucro do dia: " + (valorRecebido-(litrosGastos * precoGasolina)));
            */

            /*
            //-- QUESTAO 13 --
            float salarioMinimo, precoCustoBicicleta, salarioEmpresa;
            int numeroVendidas;
            Console.WriteLine("Escreva o valor do salario minimo: ");
            salarioMinimo = float.Parse(Console.ReadLine());
            salarioEmpresa = 2 * salarioMinimo;
            Console.WriteLine("Escreva o valor do custo da bicicleta: ");
            precoCustoBicicleta = float.Parse(Console.ReadLine());
            precoCustoBicicleta = precoCustoBicicleta * float.Parse("1,50");
            Console.WriteLine("Escreva o numero de bicicletas vendidas: ");
            numeroVendidas = int.Parse(Console.ReadLine());
            Console.WriteLine("Salario do vendedor: " + (salarioEmpresa + (((15 * precoCustoBicicleta) / 100) * numeroVendidas)));
            */
        }
    }
}