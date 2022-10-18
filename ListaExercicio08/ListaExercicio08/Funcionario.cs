using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio08
{
    internal class Funcionario
    {
        private string _nome;
        private string Departamento { get; }
        private double Salario { get; set; }
        private string Data { get; }
        private string Rg { get; }
        private bool Ativo { get; set; }

        public Funcionario(string nome, string departamento, double salario, string data, string rg)
        {
            this._nome = nome;
            this.Departamento = departamento;
            this.Salario = salario;
            this.Data = data;
            this.Rg = rg;
            Ativo = true;
        }

        public void bonifica(double bonus)
        {
            Salario += bonus;
        }

        public void demite()
        {
            Ativo = false;
        }

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
    }
}
