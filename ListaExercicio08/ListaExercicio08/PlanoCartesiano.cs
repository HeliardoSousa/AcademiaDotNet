using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio08
{
    internal class PlanoCartesiano
    {
        private int x;
        private int y;

        public PlanoCartesiano(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y;
            set => y = value;
        }

        public void Exibir()
        {
            Console.WriteLine($"({x},{y})");
        }
    }
}
