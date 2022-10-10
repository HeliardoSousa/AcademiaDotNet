using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio07
{
    internal class Televisao
    {
        private int canal = 0;
        private int volume = 0;

        public int getCanal()
        {
            return this.canal;
        }

        public void setCanal(int canal)
        {
            this.canal = canal;
        }

        public int getVolume()
        {
            return this.volume;
        }

        public void setVolume(int volume)
        {
            this.volume = volume;
        }

    }
}
