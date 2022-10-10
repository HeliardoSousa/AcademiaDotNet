using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio07
{
    internal class Agenda
    {
        private Pessoa[] pessoa = new Pessoa[10];
        private int qtdPessoas = 0;

        public void armazenarPessoa(string nome, int idade, double altura)
        {
            if(qtdPessoas < 10)
            {
                pessoa[qtdPessoas] = new Pessoa(nome, idade, altura);
                qtdPessoas++;
            }
            else
            {
                Console.WriteLine("Agenda cheia!");
            }
        }

        public void removePessoa(string nome)
        {
            if (qtdPessoas == 0)
            {
                Console.WriteLine("Agenda vazia!");
            }
            else
            {
                for (int i = 0; i < qtdPessoas; i++)
                {
                    if (pessoa[i].getNome().Equals(nome))
                    {
                        pessoa = pessoa.Where((source, index) => index != i).ToArray();
                        qtdPessoas--;
                    }
                }
            }
        }

        public Pessoa? buscaPessoa(string nome)
        {
            if(qtdPessoas == 0)
            {
                Console.WriteLine("Agenda Vazia!");
            }
            else
            {
                for(int i = 0; i < qtdPessoas; i++)
                {
                    if (pessoa[i].getNome().Equals(nome))
                    {
                        return pessoa[i];
                    }
                }
            }
            return null;
        }

        public void imprimeAgenda()
        {
            Console.WriteLine("===AGENDA===");
            for(int i = 0; i < qtdPessoas; i++)
            {
                Console.WriteLine($"Nome: {pessoa[i].getNome()}" +
                    $" Idade: {pessoa[i].getIdade()}" +
                    $" Altura: {pessoa[i].getAltura()}");
            }
        }
    }
}
