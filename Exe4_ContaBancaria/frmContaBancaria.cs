using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe4_ContaBancaria
{
    public partial class frmContaBancaria : Form
    {
        Conta conta;
        ContaEmpresarial contaEmpresarial;
        ContaPoupanca contaPoupanca;

        public frmContaBancaria()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            conta = new Conta(Convert.ToInt32(txtNumero.Text), txtTitular.Text, Convert.ToDouble(txtSaldo.Text));

            lbxContas.Items.Add("Conta Bancária: ");
            lbxContas.Items.Add("Titular: " + conta.Titular);
            lbxContas.Items.Add("Número Conta: " + conta.Numero);
            lbxContas.Items.Add("Saldo: " + conta.Saldo);
            lbxContas.Items.Add("=====================================");
        }

        private void btnCriarContaEmpresarial_Click(object sender, EventArgs e)
        {
            contaEmpresarial = new ContaEmpresarial(Convert.ToInt32(txtNumero.Text), txtTitular.Text, Convert.ToDouble(txtSaldo.Text), Convert.ToDouble(txtLimiteEmprestimo.Text));

            lbxContas.Items.Add("Conta Bancária: ");
            lbxContas.Items.Add("Titular: " + contaEmpresarial.Titular);
            lbxContas.Items.Add("Número Conta: " + contaEmpresarial.Numero);
            lbxContas.Items.Add("Saldo: " + contaEmpresarial.Saldo);
            lbxContas.Items.Add("Limite Empréstimo: " + contaEmpresarial.LimiteEmprestimo);
            lbxContas.Items.Add("=====================================");
        }

        private void btnContaPoupanca_Click(object sender, EventArgs e)
        {
            contaPoupanca = new ContaPoupanca(Convert.ToInt32(txtNumero.Text), txtTitular.Text, Convert.ToDouble(txtSaldo.Text), Convert.ToDouble(txtTaxaJuros.Text));

            lbxContas.Items.Add("Conta Bancária: ");
            lbxContas.Items.Add("Titular: " + contaPoupanca.Titular);
            lbxContas.Items.Add("Número Conta: " + contaPoupanca.Numero);
            lbxContas.Items.Add("Saldo: " + contaPoupanca.Saldo);
            lbxContas.Items.Add("Taxa Juros: " + contaPoupanca.TaxaJuros);
            lbxContas.Items.Add("=====================================");
        }

        private void btnSaqueConta_Click(object sender, EventArgs e)
        {
            conta.Saque(Convert.ToDouble(txtSaque.Text));

            lbxContas.Items.Add("Atualização Conta Bancária: ");
            lbxContas.Items.Add("Titular: " + conta.Titular);
            lbxContas.Items.Add("Saldo: " + conta.Saldo);
            lbxContas.Items.Add("=====================================");
        }

        private void btnSaqueContaEmpresarial_Click(object sender, EventArgs e)
        {
            contaEmpresarial.Saque(Convert.ToDouble(txtSaque.Text));

            lbxContas.Items.Add("Atualização Conta Empresarial: ");
            lbxContas.Items.Add("Titular: " + contaEmpresarial.Titular);
            lbxContas.Items.Add("Saldo: " + contaEmpresarial.Saldo);
            lbxContas.Items.Add("=====================================");
        }

        private void btnSaqueContaPoupanca_Click(object sender, EventArgs e)
        {
            contaPoupanca.Saque(Convert.ToDouble(txtSaque.Text));

            lbxContas.Items.Add("Atualização Conta Poupança: ");
            lbxContas.Items.Add("Titular: " + contaPoupanca.Titular);
            lbxContas.Items.Add("Saldo: " + contaPoupanca.Saldo);
            lbxContas.Items.Add("=====================================");
        }

        private void btnEmprestinoContaEmpresarial_Click(object sender, EventArgs e)
        {
            contaEmpresarial.Emprestimo(Convert.ToDouble(txtEmprestimo.Text));

            lbxContas.Items.Add("Empréstimo Conta Empresarial: ");
            lbxContas.Items.Add("Titular: " + contaEmpresarial.Titular);
            lbxContas.Items.Add("Saldo: " + contaEmpresarial.Saldo);
            lbxContas.Items.Add("=====================================");
        }

        private void btnAtualizarSaldoPoupanca_Click(object sender, EventArgs e)
        {
            contaPoupanca.AtualizaSaldo();

            lbxContas.Items.Add("Atualização Conta Poupança: ");
            lbxContas.Items.Add("Titular: " + contaPoupanca.Titular);
            lbxContas.Items.Add("Saldo: " + contaPoupanca.Saldo);
            lbxContas.Items.Add("=====================================");
        }

        private void btnDepositoConta_Click(object sender, EventArgs e)
        {
            conta.Deposito(Convert.ToDouble(txtDepositoConta.Text));

            lbxContas.Items.Add("Depósito Conta Bancária: ");
            lbxContas.Items.Add("Titular: " + conta.Titular);
            lbxContas.Items.Add("Saldo: " + conta.Saldo);
            lbxContas.Items.Add("=====================================");
        }

        private void btnDepositoContaEmpresarial_Click(object sender, EventArgs e)
        {
            contaEmpresarial.Deposito(Convert.ToDouble(txtDepositoConta.Text));

            lbxContas.Items.Add("Depósito Conta Empresarial: ");
            lbxContas.Items.Add("Titular: " + contaEmpresarial.Titular);
            lbxContas.Items.Add("Saldo: " + contaEmpresarial.Saldo);
            lbxContas.Items.Add("=====================================");
        }

        private void btnDepositoContaPoupanca_Click(object sender, EventArgs e)
        {
            contaPoupanca.Deposito(Convert.ToDouble(txtDepositoConta.Text));

            lbxContas.Items.Add("Depósito Conta Poupança: ");
            lbxContas.Items.Add("Titular: " + contaPoupanca.Titular);
            lbxContas.Items.Add("Saldo: " + contaPoupanca.Saldo);
            lbxContas.Items.Add("=====================================");
        }
    }
}
