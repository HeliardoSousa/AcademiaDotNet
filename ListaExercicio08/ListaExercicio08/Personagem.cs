using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio08
{
    internal class Personagem
    {
        private string Nome { get; set; }
        private int Poder { get; set; }

        public Personagem()
        {

        }

        public Personagem(string nome, int poder)
        {
            Poder = poder;
            Nome = nome;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome Personagem: {Nome}" +
                $" - Poder Personagem: {Poder}");
        }

    }
}
