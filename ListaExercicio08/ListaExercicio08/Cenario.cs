using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio08
{
    internal class Cenario
    {
        private string descricao;
        private DateTime data;
        private float altura;

        public Cenario(string descricao, float altura)
        {
            this.descricao = descricao; 
            this.data = DateTime.Now;
            this.altura = altura;
        }

        public string Descricao
        {
            get => descricao;
            set => descricao = value;
        }

        public DateTime Data
        {
            get => data;
            set => data = value;
        }
        
        public float Altura
        {
            get => altura;
            set => altura = value;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Descricao: {descricao}\nData de Criacao: {data.ToString()}\nAltura: {altura}");
        }

        public void ExibirTempoExistencia()
        {
            Console.WriteLine(data - DateTime.Now);
        }
    }
}
