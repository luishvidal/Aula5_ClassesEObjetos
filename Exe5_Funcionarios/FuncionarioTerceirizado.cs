using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_Funcionarios
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional { get; set; }

        public FuncionarioTerceirizado(string nome, int horas, double valorHoraTrabalhada, double despesaAdicional) : base (nome, horas, valorHoraTrabalhada)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + DespesaAdicional;
        }

        public override double Fgts()
        {
            return Pagamento() * 0.20;
        }
    }
}
