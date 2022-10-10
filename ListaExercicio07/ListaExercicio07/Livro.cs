using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio07
{
    public class Livro
    {
        string autor, titulo;
        int ano, edicao;

        public Livro(string autor, string titulo, int ano, int edicao)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.ano = ano;
            this.edicao = edicao;
        }

        public void toString()
        {
            Console.WriteLine($"Autor: {this.autor}\nTitulo: {this.titulo}\nAno: {this.ano}\nEdicao: {this.edicao}");
        }
    }
}
