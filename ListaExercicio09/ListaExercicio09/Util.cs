using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio09
{
    internal class Util
    {
        

        public static void gravarFigurinhaArquivo(Figurinha figurinha, string nomeArquivo)
        {
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true); //Abre o arquivo para escrita
            escritor.WriteLine(figurinha.CodigoFigurinha + ";" + figurinha.Selecao + ";" + figurinha.NomeJogador);
            escritor.Flush();
            escritor.Close();
        }

        

        

        public static void popularArquivoNaListaFigurinha(List<Figurinha> lista, string nomeArquivo)
        {
            try
            {
                string linha;
                string[] dadosLinha;
                Figurinha figurinha;
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);

                do
                {
                    linha = leitor.ReadLine();
                    dadosLinha = linha.Split(";");
                    figurinha = new Figurinha(dadosLinha[0], dadosLinha[1], dadosLinha[2]);
                    lista.Add(figurinha);
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void mostrarListaFigurinha(List<Figurinha> lista, string nomeArquivo, string tipo)
        {
            Console.WriteLine("Lista de figurinhas..." + tipo.ToUpper());
            StreamWriter escritor = new StreamWriter(nomeArquivo);
            foreach (var figurinha in lista)
            {
                Console.WriteLine($"Codigo Figura: {figurinha.CodigoFigurinha} - Selecao:  {figurinha.Selecao} - Nome do Jogador: {figurinha.NomeJogador}");
                Console.WriteLine("------------------------------");
                escritor.WriteLine($"Codigo Figura: {figurinha.CodigoFigurinha} - Selecao:  {figurinha.Selecao} - Nome do Jogador: {figurinha.NomeJogador}");
                escritor.WriteLine("------------------------------");
            }
        }

        public static bool jaNaListaPessoa(Figurinha figurinha, List<Figurinha> lista){
            foreach (var i in lista){
                if (figurinha.CodigoFigurinha == i.CodigoFigurinha){
                    return true;
                }
            }
            return false;
        }
    }
}
