using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio07
{
    internal class Aluguel
    {
        public float valorDiaria;
        public Cliente cliente;
        public Carro carro;

        public Aluguel(Cliente cliente, Carro carro, float valorDiaria)
        {
            this.cliente = cliente;
            this.carro = carro;
            this.valorDiaria = valorDiaria;
        }

    }
}
