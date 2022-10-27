using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio09
{
    internal class Figurinha
    {
        public string CodigoFigurinha { get; set; }
        public string Selecao { get; set; }
        public string NomeJogador { get; set; }

        public Figurinha(string codigoFigurinha, string selecao, string nomeJogador)
        {
            CodigoFigurinha = codigoFigurinha;
            Selecao = selecao;
            NomeJogador = nomeJogador;
        }
    }
}
