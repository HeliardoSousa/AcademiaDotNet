using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio07
{
    internal class ControleRemoto
    {
        Televisao tv = new Televisao();

        public void aumentarVolume()
        {
            int novoVolume = tv.getVolume() + 10;
            tv.setVolume(novoVolume);
        }

        public void diminuirVolume()
        {
            if(tv.getVolume() == 0)
            {
                Console.WriteLine("Volume no minimo ja!");
            }
            else
            {
                int novoVolume = tv.getVolume() - 10;
                tv.setVolume(novoVolume);
            } 
        }

        public void aumentarCanal()
        {
            int novoCanal = tv.getVolume() + 1;
            tv.setCanal(novoCanal);
        }

        public void diminuirCanal()
        {
            int novoCanal = tv.getVolume() - 1;
            tv.setCanal(novoCanal);
        }

        public void mudarCanal()
        {
            Console.WriteLine("Digite o novo canal!");
            int canalNovo = int.Parse(Console.ReadLine());
            tv.setVolume(canalNovo);
        }

        public void consultarVolume()
        {
            Console.WriteLine(tv.getVolume());
        }

        public void consultarCanal()
        {
            Console.WriteLine(tv.getCanal()); 
        }

    }
}
