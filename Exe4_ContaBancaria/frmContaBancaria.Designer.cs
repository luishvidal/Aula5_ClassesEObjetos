
namespace Exe4_ContaBancaria
{
    partial class frmContaBancaria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaqueConta = new System.Windows.Forms.Button();
            this.btnDepositoConta = new System.Windows.Forms.Button();
            this.txtDepositoConta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCriarContaEmpresarial = new System.Windows.Forms.Button();
            this.txtLimiteEmprestimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnContaPoupanca = new System.Windows.Forms.Button();
            this.txtTaxaJuros = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaqueContaEmpresarial = new System.Windows.Forms.Button();
            this.btnSaqueContaPoupanca = new System.Windows.Forms.Button();
            this.btnDepositoContaEmpresarial = new System.Windows.Forms.Button();
            this.btnDepositoContaPoupanca = new System.Windows.Forms.Button();
            this.btnEmprestinoContaEmpresarial = new System.Windows.Forms.Button();
            this.txtEmprestimo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAtualizarSaldoPoupanca = new System.Windows.Forms.Button();
            this.lbxContas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N°:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(38, 10);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(119, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(57, 39);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 20);
            this.txtTitular.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titular:";
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Location = new System.Drawing.Point(12, 95);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(145, 23);
            this.btnCriarConta.TabIndex = 4;
            this.btnCriarConta.Text = "Criar Conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(57, 69);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo:";
            // 
            // txtSaque
            // 
            this.txtSaque.Location = new System.Drawing.Point(255, 10);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(100, 20);
            this.txtSaque.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saque:";
            // 
            // btnSaqueConta
            // 
            this.btnSaqueConta.Location = new System.Drawing.Point(213, 42);
            this.btnSaqueConta.Name = "btnSaqueConta";
            this.btnSaqueConta.Size = new System.Drawing.Size(142, 23);
            this.btnSaqueConta.TabIndex = 9;
            this.btnSaqueConta.Text = "Saque Conta";
            this.btnSaqueConta.UseVisualStyleBackColor = true;
            this.btnSaqueConta.Click += new System.EventHandler(this.btnSaqueConta_Click);
            // 
            // btnDepositoConta
            // 
            this.btnDepositoConta.Location = new System.Drawing.Point(399, 42);
            this.btnDepositoConta.Name = "btnDepositoConta";
            this.btnDepositoConta.Size = new System.Drawing.Size(155, 23);
            this.btnDepositoConta.TabIndex = 12;
            this.btnDepositoConta.Text = "Depósito Conta";
            this.btnDepositoConta.UseVisualStyleBackColor = true;
            this.btnDepositoConta.Click += new System.EventHandler(this.btnDepositoConta_Click);
            // 
            // txtDepositoConta
            // 
            this.txtDepositoConta.Location = new System.Drawing.Point(454, 10);
            this.txtDepositoConta.Name = "txtDepositoConta";
            this.txtDepositoConta.Size = new System.Drawing.Size(100, 20);
            this.txtDepositoConta.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Depósito:";
            // 
            // btnCriarContaEmpresarial
            // 
            this.btnCriarContaEmpresarial.Location = new System.Drawing.Point(15, 192);
            this.btnCriarContaEmpresarial.Name = "btnCriarContaEmpresarial";
            this.btnCriarContaEmpresarial.Size = new System.Drawing.Size(197, 23);
            this.btnCriarContaEmpresarial.TabIndex = 15;
            this.btnCriarContaEmpresarial.Text = "Criar Conta Empresarial";
            this.btnCriarContaEmpresarial.UseVisualStyleBackColor = true;
            this.btnCriarContaEmpresarial.Click += new System.EventHandler(this.btnCriarContaEmpresarial_Click);
            // 
            // txtLimiteEmprestimo
            // 
            this.txtLimiteEmprestimo.Location = new System.Drawing.Point(112, 160);
            this.txtLimiteEmprestimo.Name = "txtLimiteEmprestimo";
            this.txtLimiteEmprestimo.Size = new System.Drawing.Size(100, 20);
            this.txtLimiteEmprestimo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Limite Empréstimo:";
            // 
            // btnContaPoupanca
            // 
            this.btnContaPoupanca.Location = new System.Drawing.Point(15, 282);
            this.btnContaPoupanca.Name = "btnContaPoupanca";
            this.btnContaPoupanca.Size = new System.Drawing.Size(197, 23);
            this.btnContaPoupanca.TabIndex = 18;
            this.btnContaPoupanca.Text = "Criar Conta Poupança";
            this.btnContaPoupanca.UseVisualStyleBackColor = true;
            this.btnContaPoupanca.Click += new System.EventHandler(this.btnContaPoupanca_Click);
            // 
            // txtTaxaJuros
            // 
            this.txtTaxaJuros.Location = new System.Drawing.Point(80, 250);
            this.txtTaxaJuros.Name = "txtTaxaJuros";
            this.txtTaxaJuros.Size = new System.Drawing.Size(132, 20);
            this.txtTaxaJuros.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Taxa Juros:";
            // 
            // btnSaqueContaEmpresarial
            // 
            this.btnSaqueContaEmpresarial.Location = new System.Drawing.Point(213, 72);
            this.btnSaqueContaEmpresarial.Name = "btnSaqueContaEmpresarial";
            this.btnSaqueContaEmpresarial.Size = new System.Drawing.Size(142, 23);
            this.btnSaqueContaEmpresarial.TabIndex = 19;
            this.btnSaqueContaEmpresarial.Text = "Saque Conta Empresarial";
            this.btnSaqueContaEmpresarial.UseVisualStyleBackColor = true;
            this.btnSaqueContaEmpresarial.Click += new System.EventHandler(this.btnSaqueContaEmpresarial_Click);
            // 
            // btnSaqueContaPoupanca
            // 
            this.btnSaqueContaPoupanca.Location = new System.Drawing.Point(213, 101);
            this.btnSaqueContaPoupanca.Name = "btnSaqueContaPoupanca";
            this.btnSaqueContaPoupanca.Size = new System.Drawing.Size(142, 23);
            this.btnSaqueContaPoupanca.TabIndex = 20;
            this.btnSaqueContaPoupanca.Text = "Saque Conta Poupança";
            this.btnSaqueContaPoupanca.UseVisualStyleBackColor = true;
            this.btnSaqueContaPoupanca.Click += new System.EventHandler(this.btnSaqueContaPoupanca_Click);
            // 
            // btnDepositoContaEmpresarial
            // 
            this.btnDepositoContaEmpresarial.Location = new System.Drawing.Point(399, 72);
            this.btnDepositoContaEmpresarial.Name = "btnDepositoContaEmpresarial";
            this.btnDepositoContaEmpresarial.Size = new System.Drawing.Size(155, 23);
            this.btnDepositoContaEmpresarial.TabIndex = 21;
            this.btnDepositoContaEmpresarial.Text = "Depósito Conta Empresarial";
            this.btnDepositoContaEmpresarial.UseVisualStyleBackColor = true;
            this.btnDepositoContaEmpresarial.Click += new System.EventHandler(this.btnDepositoContaEmpresarial_Click);
            // 
            // btnDepositoContaPoupanca
            // 
            this.btnDepositoContaPoupanca.Location = new System.Drawing.Point(399, 101);
            this.btnDepositoContaPoupanca.Name = "btnDepositoContaPoupanca";
            this.btnDepositoContaPoupanca.Size = new System.Drawing.Size(155, 23);
            this.btnDepositoContaPoupanca.TabIndex = 22;
            this.btnDepositoContaPoupanca.Text = "Depósito Conta Poupança";
            this.btnDepositoContaPoupanca.UseVisualStyleBackColor = true;
            this.btnDepositoContaPoupanca.Click += new System.EventHandler(this.btnDepositoContaPoupanca_Click);
            // 
            // btnEmprestinoContaEmpresarial
            // 
            this.btnEmprestinoContaEmpresarial.Location = new System.Drawing.Point(251, 192);
            this.btnEmprestinoContaEmpresarial.Name = "btnEmprestinoContaEmpresarial";
            this.btnEmprestinoContaEmpresarial.Size = new System.Drawing.Size(197, 23);
            this.btnEmprestinoContaEmpresarial.TabIndex = 25;
            this.btnEmprestinoContaEmpresarial.Text = "Empréstimo Conta Empresarial";
            this.btnEmprestinoContaEmpresarial.UseVisualStyleBackColor = true;
            this.btnEmprestinoContaEmpresarial.Click += new System.EventHandler(this.btnEmprestinoContaEmpresarial_Click);
            // 
            // txtEmprestimo
            // 
            this.txtEmprestimo.Location = new System.Drawing.Point(348, 160);
            this.txtEmprestimo.Name = "txtEmprestimo";
            this.txtEmprestimo.Size = new System.Drawing.Size(100, 20);
            this.txtEmprestimo.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Empréstimo Conta:";
            // 
            // btnAtualizarSaldoPoupanca
            // 
            this.btnAtualizarSaldoPoupanca.Location = new System.Drawing.Point(251, 233);
            this.btnAtualizarSaldoPoupanca.Name = "btnAtualizarSaldoPoupanca";
            this.btnAtualizarSaldoPoupanca.Size = new System.Drawing.Size(197, 23);
            this.btnAtualizarSaldoPoupanca.TabIndex = 26;
            this.btnAtualizarSaldoPoupanca.Text = "Atualizar Saldo Poupança";
            this.btnAtualizarSaldoPoupanca.UseVisualStyleBackColor = true;
            this.btnAtualizarSaldoPoupanca.Click += new System.EventHandler(this.btnAtualizarSaldoPoupanca_Click);
            // 
            // lbxContas
            // 
            this.lbxContas.FormattingEnabled = true;
            this.lbxContas.Location = new System.Drawing.Point(581, 10);
            this.lbxContas.Name = "lbxContas";
            this.lbxContas.Size = new System.Drawing.Size(436, 433);
            this.lbxContas.TabIndex = 27;
            // 
            // ContaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.lbxContas);
            this.Controls.Add(this.btnAtualizarSaldoPoupanca);
            this.Controls.Add(this.btnEmprestinoContaEmpresarial);
            this.Controls.Add(this.txtEmprestimo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDepositoContaPoupanca);
            this.Controls.Add(this.btnDepositoContaEmpresarial);
            this.Controls.Add(this.btnSaqueContaPoupanca);
            this.Controls.Add(this.btnSaqueContaEmpresarial);
            this.Controls.Add(this.btnContaPoupanca);
            this.Controls.Add(this.txtTaxaJuros);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCriarContaEmpresarial);
            this.Controls.Add(this.txtLimiteEmprestimo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDepositoConta);
            this.Controls.Add(this.txtDepositoConta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSaqueConta);
            this.Controls.Add(this.txtSaque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "ContaBancaria";
            this.Text = "Conta Bancaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaqueConta;
        private System.Windows.Forms.Button btnDepositoConta;
        private System.Windows.Forms.TextBox txtDepositoConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCriarContaEmpresarial;
        private System.Windows.Forms.TextBox txtLimiteEmprestimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnContaPoupanca;
        private System.Windows.Forms.TextBox txtTaxaJuros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaqueContaEmpresarial;
        private System.Windows.Forms.Button btnSaqueContaPoupanca;
        private System.Windows.Forms.Button btnDepositoContaEmpresarial;
        private System.Windows.Forms.Button btnDepositoContaPoupanca;
        private System.Windows.Forms.Button btnEmprestinoContaEmpresarial;
        private System.Windows.Forms.TextBox txtEmprestimo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAtualizarSaldoPoupanca;
        private System.Windows.Forms.ListBox lbxContas;
    }
}

