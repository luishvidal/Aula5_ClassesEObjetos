using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_Funcionarios
{
    abstract class Funcionario
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorHoraTrabalhada { get; set; }

        public Funcionario (string nome, int horas, double valorHoraTrabalhada)
        {
            Nome = nome;
            Horas = horas;
            ValorHoraTrabalhada = valorHoraTrabalhada;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorHoraTrabalhada;
        }

        public abstract double Fgts();
    }
}
