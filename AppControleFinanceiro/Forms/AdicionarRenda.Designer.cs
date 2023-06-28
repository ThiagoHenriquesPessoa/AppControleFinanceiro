namespace AppControleFinanceiro.Forms
{
    partial class AdicionarRenda
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
            cbTipoRenda = new ComboBox();
            btnSalvar = new Button();
            btnCanelar = new Button();
            cldDataEntrada = new MonthCalendar();
            lblDataEntrada = new Label();
            lblTipoRenda = new Label();
            txtNovaRenda = new TextBox();
            lblNovaRenda = new Label();
            SuspendLayout();
            // 
            // cbTipoRenda
            // 
            cbTipoRenda.FormattingEnabled = true;
            cbTipoRenda.Items.AddRange(new object[] { "Salario", "Extra", "Emprestimo", "Pis", "Outros" });
            cbTipoRenda.Location = new Point(222, 128);
            cbTipoRenda.Name = "cbTipoRenda";
            cbTipoRenda.Size = new Size(171, 28);
            cbTipoRenda.TabIndex = 18;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(783, 547);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCanelar
            // 
            btnCanelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCanelar.Location = new Point(655, 547);
            btnCanelar.Name = "btnCanelar";
            btnCanelar.Size = new Size(94, 29);
            btnCanelar.TabIndex = 16;
            btnCanelar.Text = "Canelar";
            btnCanelar.UseVisualStyleBackColor = true;
            // 
            // cldDataEntrada
            // 
            cldDataEntrada.Location = new Point(222, 208);
            cldDataEntrada.Name = "cldDataEntrada";
            cldDataEntrada.TabIndex = 15;
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataEntrada.Location = new Point(67, 208);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(140, 23);
            lblDataEntrada.TabIndex = 14;
            lblDataEntrada.Text = "Data de Entrada";
            // 
            // lblTipoRenda
            // 
            lblTipoRenda.AutoSize = true;
            lblTipoRenda.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoRenda.Location = new Point(67, 133);
            lblTipoRenda.Name = "lblTipoRenda";
            lblTipoRenda.Size = new Size(126, 23);
            lblTipoRenda.TabIndex = 13;
            lblTipoRenda.Text = "Tipo de Renda";
            // 
            // txtNovaRenda
            // 
            txtNovaRenda.Location = new Point(222, 51);
            txtNovaRenda.Name = "txtNovaRenda";
            txtNovaRenda.Size = new Size(171, 27);
            txtNovaRenda.TabIndex = 12;
            // 
            // lblNovaRenda
            // 
            lblNovaRenda.AutoSize = true;
            lblNovaRenda.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNovaRenda.Location = new Point(67, 55);
            lblNovaRenda.Name = "lblNovaRenda";
            lblNovaRenda.Size = new Size(131, 23);
            lblNovaRenda.TabIndex = 11;
            lblNovaRenda.Text = "Valor da Renda";
            // 
            // AdicionarRenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(944, 626);
            Controls.Add(cbTipoRenda);
            Controls.Add(btnSalvar);
            Controls.Add(btnCanelar);
            Controls.Add(cldDataEntrada);
            Controls.Add(lblDataEntrada);
            Controls.Add(lblTipoRenda);
            Controls.Add(txtNovaRenda);
            Controls.Add(lblNovaRenda);
            Name = "AdicionarRenda";
            Text = "AdicionarRenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTipoRenda;
        private Button btnSalvar;
        private Button btnCanelar;
        private MonthCalendar cldDataEntrada;
        private Label lblDataEntrada;
        private Label lblTipoRenda;
        private TextBox txtNovaRenda;
        private Label lblNovaRenda;
    }
}