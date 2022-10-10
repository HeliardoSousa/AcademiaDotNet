using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio07
{
    internal class Elevador
    {
        private int andarAtual = 0;
        private int totalAndares;
        private int capacidadeElevador;
        private int presenteElevador = 0;

        public Elevador(int totalAndares, int capacidadeElevador)
        {
            this.totalAndares = totalAndares;
            this.capacidadeElevador = capacidadeElevador;
        }

        public void entrar()
        {
            if(presenteElevador < capacidadeElevador)
            {
                Console.WriteLine("A pessoa entrou!");
                presenteElevador++;
            }
            else
            {
                Console.WriteLine("Elevador sem espaco!");
            }
        }

        public void sai()
        {
            if(presenteElevador == 0)
            {
                Console.WriteLine("Elevador Vazio!");
            }
            else
            {
                presenteElevador--;
            }
        }

        public void sobe()
        {
            if(andarAtual == totalAndares)
            {
                Console.WriteLine("Já esta no ultimo andar!");
            }
            else
            {
                Console.WriteLine("Subindo!");
                andarAtual++;
            }
        }

        public void desce()
        {
            if(andarAtual == 0)
            {
                Console.WriteLine("Impossivel descer!");
            }
            else
            {
                Console.WriteLine("Descendo!");
                andarAtual--;
            }
        }

        public int getAndarAtual()
        {
            return this.andarAtual;
        }

        public int getTotalAndares()
        {
            return this.totalAndares;
        }

        public void setTotalAndares(int totalAndares)
        {
            this.totalAndares = totalAndares;
        }

        public int getCapacidadeElevador()
        {
            return this.capacidadeElevador;
        }

        public void setCapacidadeElevador(int capacidadeElevador)
        {
            this.capacidadeElevador = capacidadeElevador;
        }

        public int getPresenteElevador()
        {
            return this.presenteElevador;
        }

        public void setPresenteElevador(int presenteElevador)
        {
            this.presenteElevador = presenteElevador;
        }

    }
}
