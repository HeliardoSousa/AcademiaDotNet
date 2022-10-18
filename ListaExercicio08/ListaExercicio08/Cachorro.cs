using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio08
{
    internal class Cachorro
    {
        private string nome;
        private int idade;

        public Cachorro(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public int Idade
        {
            get => idade;
            set => idade = value;
        }
    }
}
