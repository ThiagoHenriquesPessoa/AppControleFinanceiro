namespace AppControleFinanceiro.Forms
{
    partial class Pagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIdDespesa = new Label();
            txtParcelaAtual = new TextBox();
            lblParcelaAtual = new Label();
            txtQlbParcelas = new TextBox();
            cldDataCriacao = new DateTimePicker();
            cldDataVencimento = new DateTimePicker();
            lblDataVencimento = new Label();
            cbxFormaPagamento = new ComboBox();
            lblFormaPagamento = new Label();
            lblQtdParcelas = new Label();
            cbTipoDespesa = new ComboBox();
            cbxDespesaPaga = new CheckBox();
            lblDespesaPaga = new Label();
            lblDataCriacao = new Label();
            lblTipoDespesa = new Label();
            txtNovaDespesa = new TextBox();
            lblNovaDespesa = new Label();
            btnSalvar = new Button();
            dgvListaDespesas = new DataGridView();
            lblDespesaMesAtual = new Label();
            lblRendaMesAtual = new Label();
            tbxDespesaMesAtual = new TextBox();
            tbxRendaMesAtual = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListaDespesas).BeginInit();
            SuspendLayout();
            // 
            // lblIdDespesa
            // 
            lblIdDespesa.AutoSize = true;
            lblIdDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdDespesa.Location = new Point(103, 573);
            lblIdDespesa.Name = "lblIdDespesa";
            lblIdDespesa.Size = new Size(20, 23);
            lblIdDespesa.TabIndex = 101;
            lblIdDespesa.Text = "0";
            lblIdDespesa.Visible = false;
            // 
            // txtParcelaAtual
            // 
            txtParcelaAtual.Location = new Point(633, 530);
            txtParcelaAtual.Name = "txtParcelaAtual";
            txtParcelaAtual.Size = new Size(56, 27);
            txtParcelaAtual.TabIndex = 100;
            // 
            // lblParcelaAtual
            // 
            lblParcelaAtual.AutoSize = true;
            lblParcelaAtual.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblParcelaAtual.Location = new Point(445, 530);
            lblParcelaAtual.Name = "lblParcelaAtual";
            lblParcelaAtual.Size = new Size(115, 23);
            lblParcelaAtual.TabIndex = 99;
            lblParcelaAtual.Text = "Parcela Atual";
            // 
            // txtQlbParcelas
            // 
            txtQlbParcelas.Location = new Point(307, 530);
            txtQlbParcelas.Name = "txtQlbParcelas";
            txtQlbParcelas.Size = new Size(56, 27);
            txtQlbParcelas.TabIndex = 98;
            // 
            // cldDataCriacao
            // 
            cldDataCriacao.Format = DateTimePickerFormat.Short;
            cldDataCriacao.ImeMode = ImeMode.NoControl;
            cldDataCriacao.Location = new Point(258, 476);
            cldDataCriacao.Name = "cldDataCriacao";
            cldDataCriacao.Size = new Size(105, 27);
            cldDataCriacao.TabIndex = 97;
            cldDataCriacao.Value = new DateTime(2023, 6, 11, 1, 30, 0, 0);
            // 
            // cldDataVencimento
            // 
            cldDataVencimento.Format = DateTimePickerFormat.Short;
            cldDataVencimento.Location = new Point(633, 476);
            cldDataVencimento.Name = "cldDataVencimento";
            cldDataVencimento.Size = new Size(105, 27);
            cldDataVencimento.TabIndex = 96;
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataVencimento.Location = new Point(445, 480);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(172, 23);
            lblDataVencimento.TabIndex = 95;
            lblDataVencimento.Text = "Data de Vencimento";
            // 
            // cbxFormaPagamento
            // 
            cbxFormaPagamento.FormattingEnabled = true;
            cbxFormaPagamento.Items.AddRange(new object[] { "Cartão Nubanck Rayane", "Cartão Nubanck Thiago", "Cartão Riachuelo", "Cartão Renner Rayane", "Cartão Renner Mario", "Cartão Arnaldo", "Cartão Francisca", "Cartão Adalto", "Cartão Joyce", "Cartão Witami", "Cartão Thayse", "Cartão Auzi", "Dinheiro", "Outros" });
            cbxFormaPagamento.Location = new Point(633, 415);
            cbxFormaPagamento.Name = "cbxFormaPagamento";
            cbxFormaPagamento.Size = new Size(171, 28);
            cbxFormaPagamento.TabIndex = 94;
            // 
            // lblFormaPagamento
            // 
            lblFormaPagamento.AutoSize = true;
            lblFormaPagamento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormaPagamento.Location = new Point(445, 420);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(182, 23);
            lblFormaPagamento.TabIndex = 93;
            lblFormaPagamento.Text = "Forma de Pagamento";
            // 
            // lblQtdParcelas
            // 
            lblQtdParcelas.AutoSize = true;
            lblQtdParcelas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblQtdParcelas.Location = new Point(103, 530);
            lblQtdParcelas.Name = "lblQtdParcelas";
            lblQtdParcelas.Size = new Size(198, 23);
            lblQtdParcelas.TabIndex = 92;
            lblQtdParcelas.Text = "Quantidade de Parcelas";
            // 
            // cbTipoDespesa
            // 
            cbTipoDespesa.FormattingEnabled = true;
            cbTipoDespesa.Items.AddRange(new object[] { "Água", "Energia", "Internet", "Claro Rayane", "Claro Thiago", "Academia Rayane", "Academia Thiago", "Feira", "Farmácia", "Combustível", "Emprestimo", "Outros" });
            cbTipoDespesa.Location = new Point(258, 415);
            cbTipoDespesa.Name = "cbTipoDespesa";
            cbTipoDespesa.Size = new Size(171, 28);
            cbTipoDespesa.TabIndex = 91;
            // 
            // cbxDespesaPaga
            // 
            cbxDespesaPaga.AutoSize = true;
            cbxDespesaPaga.Location = new Point(600, 356);
            cbxDespesaPaga.Name = "cbxDespesaPaga";
            cbxDespesaPaga.Size = new Size(56, 24);
            cbxDespesaPaga.TabIndex = 90;
            cbxDespesaPaga.Text = "Sim";
            cbxDespesaPaga.UseVisualStyleBackColor = true;
            // 
            // lblDespesaPaga
            // 
            lblDespesaPaga.AutoSize = true;
            lblDespesaPaga.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDespesaPaga.Location = new Point(445, 357);
            lblDespesaPaga.Name = "lblDespesaPaga";
            lblDespesaPaga.Size = new Size(119, 23);
            lblDespesaPaga.TabIndex = 89;
            lblDespesaPaga.Text = "Despesa Paga";
            // 
            // lblDataCriacao
            // 
            lblDataCriacao.AutoSize = true;
            lblDataCriacao.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataCriacao.Location = new Point(103, 480);
            lblDataCriacao.Name = "lblDataCriacao";
            lblDataCriacao.Size = new Size(137, 23);
            lblDataCriacao.TabIndex = 88;
            lblDataCriacao.Text = "Data de Criação";
            // 
            // lblTipoDespesa
            // 
            lblTipoDespesa.AutoSize = true;
            lblTipoDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoDespesa.Location = new Point(103, 420);
            lblTipoDespesa.Name = "lblTipoDespesa";
            lblTipoDespesa.Size = new Size(141, 23);
            lblTipoDespesa.TabIndex = 87;
            lblTipoDespesa.Text = "Tipo de Despesa";
            // 
            // txtNovaDespesa
            // 
            txtNovaDespesa.Location = new Point(258, 353);
            txtNovaDespesa.Name = "txtNovaDespesa";
            txtNovaDespesa.Size = new Size(171, 27);
            txtNovaDespesa.TabIndex = 86;
            // 
            // lblNovaDespesa
            // 
            lblNovaDespesa.AutoSize = true;
            lblNovaDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNovaDespesa.Location = new Point(103, 357);
            lblNovaDespesa.Name = "lblNovaDespesa";
            lblNovaDespesa.Size = new Size(146, 23);
            lblNovaDespesa.TabIndex = 85;
            lblNovaDespesa.Text = "Valor da Despesa";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(813, 581);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 84;
            btnSalvar.Text = "Pagar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dgvListaDespesas
            // 
            dgvListaDespesas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaDespesas.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListaDespesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaDespesas.Location = new Point(12, 65);
            dgvListaDespesas.Name = "dgvListaDespesas";
            dgvListaDespesas.RowHeadersWidth = 4;
            dgvListaDespesas.RowTemplate.Height = 29;
            dgvListaDespesas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaDespesas.Size = new Size(920, 267);
            dgvListaDespesas.TabIndex = 83;
            // 
            // lblDespesaMesAtual
            // 
            lblDespesaMesAtual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDespesaMesAtual.AutoSize = true;
            lblDespesaMesAtual.Location = new Point(353, 22);
            lblDespesaMesAtual.Name = "lblDespesaMesAtual";
            lblDespesaMesAtual.Size = new Size(86, 20);
            lblDespesaMesAtual.TabIndex = 82;
            lblDespesaMesAtual.Text = "Despesa de";
            // 
            // lblRendaMesAtual
            // 
            lblRendaMesAtual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRendaMesAtual.AutoSize = true;
            lblRendaMesAtual.Location = new Point(48, 22);
            lblRendaMesAtual.Name = "lblRendaMesAtual";
            lblRendaMesAtual.Size = new Size(72, 20);
            lblRendaMesAtual.TabIndex = 81;
            lblRendaMesAtual.Text = "Renda de";
            // 
            // tbxDespesaMesAtual
            // 
            tbxDespesaMesAtual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxDespesaMesAtual.Location = new Point(516, 19);
            tbxDespesaMesAtual.Name = "tbxDespesaMesAtual";
            tbxDespesaMesAtual.Size = new Size(125, 27);
            tbxDespesaMesAtual.TabIndex = 80;
            // 
            // tbxRendaMesAtual
            // 
            tbxRendaMesAtual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxRendaMesAtual.Location = new Point(189, 16);
            tbxRendaMesAtual.Name = "tbxRendaMesAtual";
            tbxRendaMesAtual.Size = new Size(125, 27);
            tbxRendaMesAtual.TabIndex = 79;
            // 
            // Pagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(944, 626);
            Controls.Add(lblIdDespesa);
            Controls.Add(txtParcelaAtual);
            Controls.Add(lblParcelaAtual);
            Controls.Add(txtQlbParcelas);
            Controls.Add(cldDataCriacao);
            Controls.Add(cldDataVencimento);
            Controls.Add(lblDataVencimento);
            Controls.Add(cbxFormaPagamento);
            Controls.Add(lblFormaPagamento);
            Controls.Add(lblQtdParcelas);
            Controls.Add(cbTipoDespesa);
            Controls.Add(cbxDespesaPaga);
            Controls.Add(lblDespesaPaga);
            Controls.Add(lblDataCriacao);
            Controls.Add(lblTipoDespesa);
            Controls.Add(txtNovaDespesa);
            Controls.Add(lblNovaDespesa);
            Controls.Add(btnSalvar);
            Controls.Add(dgvListaDespesas);
            Controls.Add(lblDespesaMesAtual);
            Controls.Add(lblRendaMesAtual);
            Controls.Add(tbxDespesaMesAtual);
            Controls.Add(tbxRendaMesAtual);
            Name = "Pagamento";
            Text = "Pagamento";
            ((System.ComponentModel.ISupportInitialize)dgvListaDespesas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdDespesa;
        private TextBox txtParcelaAtual;
        private Label lblParcelaAtual;
        private TextBox txtQlbParcelas;
        private DateTimePicker cldDataCriacao;
        private DateTimePicker cldDataVencimento;
        private Label lblDataVencimento;
        private ComboBox cbxFormaPagamento;
        private Label lblFormaPagamento;
        private Label lblQtdParcelas;
        private ComboBox cbTipoDespesa;
        private CheckBox cbxDespesaPaga;
        private Label lblDespesaPaga;
        private Label lblDataCriacao;
        private Label lblTipoDespesa;
        private TextBox txtNovaDespesa;
        private Label lblNovaDespesa;
        private Button btnSalvar;
        private DataGridView dgvListaDespesas;
        private Label lblDespesaMesAtual;
        private Label lblRendaMesAtual;
        private TextBox tbxDespesaMesAtual;
        private TextBox tbxRendaMesAtual;
    }
}