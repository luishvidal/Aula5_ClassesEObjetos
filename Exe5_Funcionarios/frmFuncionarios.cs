using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe4_Funcionarios
{
    public partial class frmFuncionarios : Form
    {
        List<Funcionario> listaFuncionario = new List<Funcionario>();

        public frmFuncionarios()
        {
            InitializeComponent();
        }

        public void CarregarGrid()
        {
            int numLinha = 0;
            dgvFuncionarios.Rows.Clear();

            foreach(Funcionario funcionario in listaFuncionario)
            {
                dgvFuncionarios.Rows.Add();
                dgvFuncionarios[0, numLinha].Value = funcionario.Nome;
                dgvFuncionarios[1, numLinha].Value = funcionario.Pagamento();
                dgvFuncionarios[2, numLinha].Value = funcionario.Fgts();
                numLinha++;
            }
        }

        private void rbInterno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInterno.Checked)
            {
                lblValeAlimentacao.Visible = true;
                txtValeAlimentacao.Visible = true;
                txtValeAlimentacao.Clear();

                lblDespesaAdicional.Visible = false;
                txtDespesaAdicional.Visible = false;
                txtDespesaAdicional.Clear();
            }
        }

        private void rbTerceirizado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTerceirizado.Checked)
            {
                lblDespesaAdicional.Visible = true;
                txtDespesaAdicional.Visible = true;
                txtDespesaAdicional.Clear();

                lblValeAlimentacao.Visible = false;
                txtValeAlimentacao.Visible = false;
                txtValeAlimentacao.Clear(); 
            }
        }

        private void btnCriarFuncionario_Click(object sender, EventArgs e)
        {
            if (rbInterno.Checked)
            {
                listaFuncionario.Add(new FuncionarioInterno(txtNome.Text, Convert.ToInt32(txtHorasTrabalhadas.Text), Convert.ToDouble(txtValorPorHora.Text), Convert.ToDouble(txtValeAlimentacao.Text)));

                CarregarGrid();
            }

            if (rbTerceirizado.Checked)
            {
                listaFuncionario.Add(new FuncionarioTerceirizado(txtNome.Text, Convert.ToInt32(txtHorasTrabalhadas.Text), Convert.ToDouble(txtValorPorHora.Text), Convert.ToDouble(txtDespesaAdicional.Text)));

                CarregarGrid();
            }
        }

        private void btnTotalPagamentos_Click(object sender, EventArgs e)
        {
            double totalPagamentos = 0;

            foreach(Funcionario funcionario in listaFuncionario) 
            {
                totalPagamentos += funcionario.Pagamento();
            }

            lblTotalPagamentos.Text = "Total Pagamentos: " + totalPagamentos;
        }

        private void btnTotalFgts_Click(object sender, EventArgs e)
        {
            double totalFgts = 0;

            foreach (Funcionario funcionario in listaFuncionario)
            {
                totalFgts += funcionario.Fgts();
            }

            lblTotalFgts.Text = "Total FGTS: " + totalFgts;
        }
    }
}
