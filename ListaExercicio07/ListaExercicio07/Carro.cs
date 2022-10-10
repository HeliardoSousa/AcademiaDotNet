using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio07
{
    internal class Carro
    {
        public string cor;
        public string modelo;
        public int anoFabricacao;
        public string placa;

        public Carro(string modelo, string placa, string cor, int anoFabricacao)
        {
            this.cor = cor;
            this.modelo = modelo;
            this.anoFabricacao = anoFabricacao;
            this.placa = placa;
        }
    }
}
