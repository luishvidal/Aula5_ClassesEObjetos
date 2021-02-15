﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_ContaBancaria
{
    class ContaEmpresarial : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresarial(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
        {
            this.LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double valor)
        {
            if (valor <= LimiteEmprestimo)
            {
                this.Saldo += valor;
            }
        }
    }
}
