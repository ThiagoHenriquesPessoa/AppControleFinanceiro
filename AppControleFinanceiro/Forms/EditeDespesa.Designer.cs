namespace AppControleFinanceiro.Forms
{
    partial class EditeDespesa
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
            btnExibirLista = new Button();
            dtpDataInicial = new DateTimePicker();
            dtpDataFim = new DateTimePicker();
            btnExcluir = new Button();
            lblListaDespesa = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaDespesas).BeginInit();
            SuspendLayout();
            // 
            // lblIdDespesa
            // 
            lblIdDespesa.AutoSize = true;
            lblIdDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdDespesa.Location = new Point(84, 544);
            lblIdDespesa.Name = "lblIdDespesa";
            lblIdDespesa.Size = new Size(20, 23);
            lblIdDespesa.TabIndex = 85;
            lblIdDespesa.Text = "0";
            lblIdDespesa.Visible = false;
            // 
            // txtParcelaAtual
            // 
            txtParcelaAtual.Location = new Point(614, 501);
            txtParcelaAtual.Name = "txtParcelaAtual";
            txtParcelaAtual.Size = new Size(56, 27);
            txtParcelaAtual.TabIndex = 84;
            // 
            // lblParcelaAtual
            // 
            lblParcelaAtual.AutoSize = true;
            lblParcelaAtual.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblParcelaAtual.Location = new Point(426, 501);
            lblParcelaAtual.Name = "lblParcelaAtual";
            lblParcelaAtual.Size = new Size(115, 23);
            lblParcelaAtual.TabIndex = 83;
            lblParcelaAtual.Text = "Parcela Atual";
            // 
            // txtQlbParcelas
            // 
            txtQlbParcelas.Location = new Point(288, 501);
            txtQlbParcelas.Name = "txtQlbParcelas";
            txtQlbParcelas.Size = new Size(56, 27);
            txtQlbParcelas.TabIndex = 82;
            // 
            // cldDataCriacao
            // 
            cldDataCriacao.Format = DateTimePickerFormat.Short;
            cldDataCriacao.ImeMode = ImeMode.NoControl;
            cldDataCriacao.Location = new Point(239, 447);
            cldDataCriacao.Name = "cldDataCriacao";
            cldDataCriacao.Size = new Size(105, 27);
            cldDataCriacao.TabIndex = 81;
            cldDataCriacao.Value = new DateTime(2023, 6, 11, 1, 30, 0, 0);
            // 
            // cldDataVencimento
            // 
            cldDataVencimento.Format = DateTimePickerFormat.Short;
            cldDataVencimento.Location = new Point(614, 447);
            cldDataVencimento.Name = "cldDataVencimento";
            cldDataVencimento.Size = new Size(105, 27);
            cldDataVencimento.TabIndex = 80;
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataVencimento.Location = new Point(426, 451);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(172, 23);
            lblDataVencimento.TabIndex = 79;
            lblDataVencimento.Text = "Data de Vencimento";
            // 
            // cbxFormaPagamento
            // 
            cbxFormaPagamento.FormattingEnabled = true;
            cbxFormaPagamento.Items.AddRange(new object[] { "Cartão Nubanck Rayane", "Cartão Nubanck Thiago", "Cartão Riachuelo", "Cartão Renner Rayane", "Cartão Renner Mario", "Cartão Arnaldo", "Cartão Francisca", "Cartão Adalto", "Cartão Joyce", "Cartão Witami", "Cartão Thayse", "Cartão Auzi", "Dinheiro", "Outros" });
            cbxFormaPagamento.Location = new Point(614, 386);
            cbxFormaPagamento.Name = "cbxFormaPagamento";
            cbxFormaPagamento.Size = new Size(171, 28);
            cbxFormaPagamento.TabIndex = 78;
            // 
            // lblFormaPagamento
            // 
            lblFormaPagamento.AutoSize = true;
            lblFormaPagamento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormaPagamento.Location = new Point(426, 391);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(182, 23);
            lblFormaPagamento.TabIndex = 77;
            lblFormaPagamento.Text = "Forma de Pagamento";
            // 
            // lblQtdParcelas
            // 
            lblQtdParcelas.AutoSize = true;
            lblQtdParcelas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblQtdParcelas.Location = new Point(84, 501);
            lblQtdParcelas.Name = "lblQtdParcelas";
            lblQtdParcelas.Size = new Size(198, 23);
            lblQtdParcelas.TabIndex = 76;
            lblQtdParcelas.Text = "Quantidade de Parcelas";
            // 
            // cbTipoDespesa
            // 
            cbTipoDespesa.FormattingEnabled = true;
            cbTipoDespesa.Items.AddRange(new object[] { "Água", "Energia", "Internet", "Claro Rayane", "Claro Thiago", "Academia Rayane", "Academia Thiago", "Feira", "Farmácia", "Combustível", "Emprestimo", "Outros" });
            cbTipoDespesa.Location = new Point(239, 386);
            cbTipoDespesa.Name = "cbTipoDespesa";
            cbTipoDespesa.Size = new Size(171, 28);
            cbTipoDespesa.TabIndex = 75;
            // 
            // cbxDespesaPaga
            // 
            cbxDespesaPaga.AutoSize = true;
            cbxDespesaPaga.Location = new Point(581, 327);
            cbxDespesaPaga.Name = "cbxDespesaPaga";
            cbxDespesaPaga.Size = new Size(56, 24);
            cbxDespesaPaga.TabIndex = 74;
            cbxDespesaPaga.Text = "Sim";
            cbxDespesaPaga.UseVisualStyleBackColor = true;
            // 
            // lblDespesaPaga
            // 
            lblDespesaPaga.AutoSize = true;
            lblDespesaPaga.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDespesaPaga.Location = new Point(426, 328);
            lblDespesaPaga.Name = "lblDespesaPaga";
            lblDespesaPaga.Size = new Size(119, 23);
            lblDespesaPaga.TabIndex = 73;
            lblDespesaPaga.Text = "Despesa Paga";
            // 
            // lblDataCriacao
            // 
            lblDataCriacao.AutoSize = true;
            lblDataCriacao.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataCriacao.Location = new Point(84, 451);
            lblDataCriacao.Name = "lblDataCriacao";
            lblDataCriacao.Size = new Size(137, 23);
            lblDataCriacao.TabIndex = 72;
            lblDataCriacao.Text = "Data de Criação";
            // 
            // lblTipoDespesa
            // 
            lblTipoDespesa.AutoSize = true;
            lblTipoDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoDespesa.Location = new Point(84, 391);
            lblTipoDespesa.Name = "lblTipoDespesa";
            lblTipoDespesa.Size = new Size(141, 23);
            lblTipoDespesa.TabIndex = 71;
            lblTipoDespesa.Text = "Tipo de Despesa";
            // 
            // txtNovaDespesa
            // 
            txtNovaDespesa.Location = new Point(239, 324);
            txtNovaDespesa.Name = "txtNovaDespesa";
            txtNovaDespesa.Size = new Size(171, 27);
            txtNovaDespesa.TabIndex = 70;
            // 
            // lblNovaDespesa
            // 
            lblNovaDespesa.AutoSize = true;
            lblNovaDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNovaDespesa.Location = new Point(84, 328);
            lblNovaDespesa.Name = "lblNovaDespesa";
            lblNovaDespesa.Size = new Size(146, 23);
            lblNovaDespesa.TabIndex = 69;
            lblNovaDespesa.Text = "Valor da Despesa";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(817, 568);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 68;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dgvListaDespesas
            // 
            dgvListaDespesas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaDespesas.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListaDespesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaDespesas.Location = new Point(34, 74);
            dgvListaDespesas.Name = "dgvListaDespesas";
            dgvListaDespesas.RowHeadersWidth = 4;
            dgvListaDespesas.RowTemplate.Height = 29;
            dgvListaDespesas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaDespesas.Size = new Size(877, 221);
            dgvListaDespesas.TabIndex = 62;
            // 
            // btnExibirLista
            // 
            btnExibirLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExibirLista.Location = new Point(514, 30);
            btnExibirLista.Name = "btnExibirLista";
            btnExibirLista.Size = new Size(94, 29);
            btnExibirLista.TabIndex = 67;
            btnExibirLista.Text = "Exibir";
            btnExibirLista.UseVisualStyleBackColor = true;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Format = DateTimePickerFormat.Short;
            dtpDataInicial.ImeMode = ImeMode.NoControl;
            dtpDataInicial.Location = new Point(229, 30);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(105, 27);
            dtpDataInicial.TabIndex = 66;
            // 
            // dtpDataFim
            // 
            dtpDataFim.Format = DateTimePickerFormat.Short;
            dtpDataFim.Location = new Point(358, 30);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(105, 27);
            dtpDataFim.TabIndex = 65;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(696, 568);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 64;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lblListaDespesa
            // 
            lblListaDespesa.AutoSize = true;
            lblListaDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaDespesa.Location = new Point(56, 30);
            lblListaDespesa.Name = "lblListaDespesa";
            lblListaDespesa.Size = new Size(149, 23);
            lblListaDespesa.TabIndex = 63;
            lblListaDespesa.Text = "Lista de Despesas";
            // 
            // EditeDespesa
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
            Controls.Add(btnExibirLista);
            Controls.Add(dtpDataInicial);
            Controls.Add(dtpDataFim);
            Controls.Add(btnExcluir);
            Controls.Add(lblListaDespesa);
            Name = "EditeDespesa";
            Text = "EditeDespesa";
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
        private Button btnExibirLista;
        private DateTimePicker dtpDataInicial;
        private DateTimePicker dtpDataFim;
        private Button btnExcluir;
        private Label lblListaDespesa;
    }
}