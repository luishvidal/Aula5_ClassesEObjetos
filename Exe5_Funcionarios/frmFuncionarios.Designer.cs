
namespace Exe4_Funcionarios
{
    partial class frmFuncionarios
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.txtValorPorHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInterno = new System.Windows.Forms.RadioButton();
            this.rbTerceirizado = new System.Windows.Forms.RadioButton();
            this.txtValeAlimentacao = new System.Windows.Forms.TextBox();
            this.lblValeAlimentacao = new System.Windows.Forms.Label();
            this.txtDespesaAdicional = new System.Windows.Forms.TextBox();
            this.lblDespesaAdicional = new System.Windows.Forms.Label();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FGTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTotalPagamentos = new System.Windows.Forms.Button();
            this.btnTotalFgts = new System.Windows.Forms.Button();
            this.lblTotalPagamentos = new System.Windows.Forms.Label();
            this.lblTotalFgts = new System.Windows.Forms.Label();
            this.btnCriarFuncionario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(157, 7);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(278, 26);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horas trabalhadas:";
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(157, 50);
            this.txtHorasTrabalhadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(278, 23);
            this.txtHorasTrabalhadas.TabIndex = 3;
            // 
            // txtValorPorHora
            // 
            this.txtValorPorHora.Location = new System.Drawing.Point(157, 87);
            this.txtValorPorHora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorPorHora.Name = "txtValorPorHora";
            this.txtValorPorHora.Size = new System.Drawing.Size(278, 23);
            this.txtValorPorHora.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "R$ por hora:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTerceirizado);
            this.groupBox1.Controls.Add(this.rbInterno);
            this.groupBox1.Location = new System.Drawing.Point(212, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 64);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rbInterno
            // 
            this.rbInterno.AutoSize = true;
            this.rbInterno.Location = new System.Drawing.Point(7, 23);
            this.rbInterno.Name = "rbInterno";
            this.rbInterno.Size = new System.Drawing.Size(70, 21);
            this.rbInterno.TabIndex = 0;
            this.rbInterno.TabStop = true;
            this.rbInterno.Text = "Interno";
            this.rbInterno.UseVisualStyleBackColor = true;
            this.rbInterno.CheckedChanged += new System.EventHandler(this.rbInterno_CheckedChanged);
            // 
            // rbTerceirizado
            // 
            this.rbTerceirizado.AutoSize = true;
            this.rbTerceirizado.Location = new System.Drawing.Point(112, 22);
            this.rbTerceirizado.Name = "rbTerceirizado";
            this.rbTerceirizado.Size = new System.Drawing.Size(105, 21);
            this.rbTerceirizado.TabIndex = 1;
            this.rbTerceirizado.TabStop = true;
            this.rbTerceirizado.Text = "Terceirizado";
            this.rbTerceirizado.UseVisualStyleBackColor = true;
            this.rbTerceirizado.CheckedChanged += new System.EventHandler(this.rbTerceirizado_CheckedChanged);
            // 
            // txtValeAlimentacao
            // 
            this.txtValeAlimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValeAlimentacao.Location = new System.Drawing.Point(157, 216);
            this.txtValeAlimentacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtValeAlimentacao.Name = "txtValeAlimentacao";
            this.txtValeAlimentacao.Size = new System.Drawing.Size(278, 26);
            this.txtValeAlimentacao.TabIndex = 8;
            this.txtValeAlimentacao.Visible = false;
            // 
            // lblValeAlimentacao
            // 
            this.lblValeAlimentacao.AutoSize = true;
            this.lblValeAlimentacao.Location = new System.Drawing.Point(18, 222);
            this.lblValeAlimentacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValeAlimentacao.Name = "lblValeAlimentacao";
            this.lblValeAlimentacao.Size = new System.Drawing.Size(121, 17);
            this.lblValeAlimentacao.TabIndex = 7;
            this.lblValeAlimentacao.Text = "Vale Alimentação:";
            this.lblValeAlimentacao.Visible = false;
            // 
            // txtDespesaAdicional
            // 
            this.txtDespesaAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDespesaAdicional.Location = new System.Drawing.Point(155, 257);
            this.txtDespesaAdicional.Margin = new System.Windows.Forms.Padding(4);
            this.txtDespesaAdicional.Name = "txtDespesaAdicional";
            this.txtDespesaAdicional.Size = new System.Drawing.Size(278, 26);
            this.txtDespesaAdicional.TabIndex = 10;
            this.txtDespesaAdicional.Visible = false;
            // 
            // lblDespesaAdicional
            // 
            this.lblDespesaAdicional.AutoSize = true;
            this.lblDespesaAdicional.Location = new System.Drawing.Point(18, 263);
            this.lblDespesaAdicional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDespesaAdicional.Name = "lblDespesaAdicional";
            this.lblDespesaAdicional.Size = new System.Drawing.Size(129, 17);
            this.lblDespesaAdicional.TabIndex = 9;
            this.lblDespesaAdicional.Text = "Despesa Adicional:";
            this.lblDespesaAdicional.Visible = false;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Pagamento,
            this.FGTS});
            this.dgvFuncionarios.Location = new System.Drawing.Point(21, 300);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(414, 163);
            this.dgvFuncionarios.TabIndex = 11;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Pagamento
            // 
            this.Pagamento.HeaderText = "Pagamento";
            this.Pagamento.Name = "Pagamento";
            // 
            // FGTS
            // 
            this.FGTS.HeaderText = "FGTS";
            this.FGTS.Name = "FGTS";
            // 
            // btnTotalPagamentos
            // 
            this.btnTotalPagamentos.Location = new System.Drawing.Point(21, 469);
            this.btnTotalPagamentos.Name = "btnTotalPagamentos";
            this.btnTotalPagamentos.Size = new System.Drawing.Size(158, 31);
            this.btnTotalPagamentos.TabIndex = 12;
            this.btnTotalPagamentos.Text = "Total Pagamentos";
            this.btnTotalPagamentos.UseVisualStyleBackColor = true;
            this.btnTotalPagamentos.Click += new System.EventHandler(this.btnTotalPagamentos_Click);
            // 
            // btnTotalFgts
            // 
            this.btnTotalFgts.Location = new System.Drawing.Point(277, 469);
            this.btnTotalFgts.Name = "btnTotalFgts";
            this.btnTotalFgts.Size = new System.Drawing.Size(158, 31);
            this.btnTotalFgts.TabIndex = 13;
            this.btnTotalFgts.Text = "Total FGTS";
            this.btnTotalFgts.UseVisualStyleBackColor = true;
            this.btnTotalFgts.Click += new System.EventHandler(this.btnTotalFgts_Click);
            // 
            // lblTotalPagamentos
            // 
            this.lblTotalPagamentos.AutoSize = true;
            this.lblTotalPagamentos.Location = new System.Drawing.Point(26, 511);
            this.lblTotalPagamentos.Name = "lblTotalPagamentos";
            this.lblTotalPagamentos.Size = new System.Drawing.Size(127, 17);
            this.lblTotalPagamentos.TabIndex = 14;
            this.lblTotalPagamentos.Text = "Total Pagamentos:";
            // 
            // lblTotalFgts
            // 
            this.lblTotalFgts.AutoSize = true;
            this.lblTotalFgts.Location = new System.Drawing.Point(274, 511);
            this.lblTotalFgts.Name = "lblTotalFgts";
            this.lblTotalFgts.Size = new System.Drawing.Size(85, 17);
            this.lblTotalFgts.TabIndex = 15;
            this.lblTotalFgts.Text = "Total FGTS:";
            // 
            // btnCriarFuncionario
            // 
            this.btnCriarFuncionario.Location = new System.Drawing.Point(16, 134);
            this.btnCriarFuncionario.Name = "btnCriarFuncionario";
            this.btnCriarFuncionario.Size = new System.Drawing.Size(137, 64);
            this.btnCriarFuncionario.TabIndex = 16;
            this.btnCriarFuncionario.Text = "Criar Funcionário";
            this.btnCriarFuncionario.UseVisualStyleBackColor = true;
            this.btnCriarFuncionario.Click += new System.EventHandler(this.btnCriarFuncionario_Click);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 537);
            this.Controls.Add(this.btnCriarFuncionario);
            this.Controls.Add(this.lblTotalFgts);
            this.Controls.Add(this.lblTotalPagamentos);
            this.Controls.Add(this.btnTotalFgts);
            this.Controls.Add(this.btnTotalPagamentos);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.txtDespesaAdicional);
            this.Controls.Add(this.lblDespesaAdicional);
            this.Controls.Add(this.txtValeAlimentacao);
            this.Controls.Add(this.lblValeAlimentacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValorPorHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFuncionarios";
            this.Text = "Funcionários";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.TextBox txtValorPorHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTerceirizado;
        private System.Windows.Forms.RadioButton rbInterno;
        private System.Windows.Forms.TextBox txtValeAlimentacao;
        private System.Windows.Forms.Label lblValeAlimentacao;
        private System.Windows.Forms.TextBox txtDespesaAdicional;
        private System.Windows.Forms.Label lblDespesaAdicional;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FGTS;
        private System.Windows.Forms.Button btnTotalPagamentos;
        private System.Windows.Forms.Button btnTotalFgts;
        private System.Windows.Forms.Label lblTotalPagamentos;
        private System.Windows.Forms.Label lblTotalFgts;
        private System.Windows.Forms.Button btnCriarFuncionario;
    }
}

