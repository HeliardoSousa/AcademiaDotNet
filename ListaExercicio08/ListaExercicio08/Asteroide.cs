using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio08
{
    internal class Asteroide
    {
        public int PosicaoX { get; set; }
        public int PosicaoY { get; set; }
        public int Tamanho { get; set; }
        public int Velocidade { get; set; }
        public int Energia { get; set; }

        public Asteroide()
        {

        }

        public Asteroide(int posicaoX, int posicaoY)
        {
            this.PosicaoX = posicaoX;
            this.PosicaoY = posicaoY;
        }

        public Asteroide(int posicaoX, int posicaoY, int tamanho, int velocidade, int energia) : this(posicaoX, posicaoY)
        {
            Tamanho = tamanho;
            Velocidade = velocidade;
            Energia = energia;
        }
    }
}
