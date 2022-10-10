using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio07
{
    internal class Pessoa
    {
        /*
        //QUESTAO 02
        string nome;
        int idade;
        float altura, peso;

        public Pessoa(string nome, int idade, float altura, float peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
        }

        public void nomePessoa()
        {
            Console.WriteLine("Nome: "+ this.nome);
        }

        public void idadePessoa()
        {
            Console.WriteLine("Idade: "+ this.idade);
        }
        */

        /*
        //QUESTAO 04
        public Pessoa pai;
        public Pessoa mae;
        public int idade;
        public string nome;

        public Pessoa(Pessoa pai, Pessoa mae,string nome, int idade)
        {
            this.pai = pai;
            this.mae = mae;
            this.idade = idade;
            this.nome = nome;
        }

        public Pessoa(string nome, int idade)
        {
            this.idade = idade;
            this.nome = nome;
        }
        */

        //QUESTAO 06
        private string nome;
        private int idade;
        private double altura;

        public Pessoa(string nome, int idade, double altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }

        public string getNome()
        {
            return this.nome;
        }

        public int getIdade()
        {
            return this.idade;
        }

        public double getAltura()
        {
            return this.altura;
        }

        public void imprimePessoa() {
            Console.WriteLine($"Nome: {this.nome}" +
                    $" Idade: {this.idade}" +
                    $" Altura: {this.altura}");
        }

    }
}
