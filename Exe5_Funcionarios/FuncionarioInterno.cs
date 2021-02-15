using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_Funcionarios
{
    class FuncionarioInterno : Funcionario 
    {
        public double ValeAlimentacao { get; set; }

        public FuncionarioInterno(string nome, int horas, double valorHoraTrabalhada, double valeAlimentacao) : base(nome, horas, valorHoraTrabalhada)
        {
            ValeAlimentacao = valeAlimentacao;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + ValeAlimentacao;
        }

        public override double Fgts()
        {
            return Pagamento() * 0.15;
        }
    }
}
