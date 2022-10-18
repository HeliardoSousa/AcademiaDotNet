using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio08
{
    internal class Gerente : Funcionario
    {
        public Gerente(string nome, string departamento, double salario, string data, string rg) : base(nome, departamento, salario, data, rg)
        {
        }

        public override void ExecutaTrbalho()
        {
            Console.WriteLine("O trabalho exercido é de Gerente!");
        }
    }
}
