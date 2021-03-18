namespace ContasPagarXML
{
    partial class frInserirNovaConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frInserirNovaConta));
            this.fbdAvancado = new System.Windows.Forms.FolderBrowserDialog();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbFormaPagamento = new System.Windows.Forms.Label();
            this.lbDataCompra = new System.Windows.Forms.Label();
            this.mtbDataCompra = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.lbDataVencimento = new System.Windows.Forms.Label();
            this.mtbDataPagamento = new System.Windows.Forms.MaskedTextBox();
            this.lbDataPagamento = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // fbdAvancado
            // 
            this.fbdAvancado.Description = "Local padrão para salvamento";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(7, 10);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(34, 13);
            this.lbValor.TabIndex = 4;
            this.lbValor.Text = "Valor:";
            // 
            // lbFormaPagamento
            // 
            this.lbFormaPagamento.AutoSize = true;
            this.lbFormaPagamento.Location = new System.Drawing.Point(154, 10);
            this.lbFormaPagamento.Name = "lbFormaPagamento";
            this.lbFormaPagamento.Size = new System.Drawing.Size(95, 13);
            this.lbFormaPagamento.TabIndex = 7;
            this.lbFormaPagamento.Text = "Forma pagamento:";
            // 
            // lbDataCompra
            // 
            this.lbDataCompra.AutoSize = true;
            this.lbDataCompra.Location = new System.Drawing.Point(7, 61);
            this.lbDataCompra.Name = "lbDataCompra";
            this.lbDataCompra.Size = new System.Drawing.Size(71, 13);
            this.lbDataCompra.TabIndex = 9;
            this.lbDataCompra.Text = "Data compra:";
            // 
            // mtbDataCompra
            // 
            this.mtbDataCompra.Location = new System.Drawing.Point(10, 77);
            this.mtbDataCompra.Mask = "00/00/0000";
            this.mtbDataCompra.Name = "mtbDataCompra";
            this.mtbDataCompra.Size = new System.Drawing.Size(100, 20);
            this.mtbDataCompra.TabIndex = 5;
            this.mtbDataCompra.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDataVencimento
            // 
            this.mtbDataVencimento.Location = new System.Drawing.Point(157, 77);
            this.mtbDataVencimento.Mask = "00/00/0000";
            this.mtbDataVencimento.Name = "mtbDataVencimento";
            this.mtbDataVencimento.Size = new System.Drawing.Size(100, 20);
            this.mtbDataVencimento.TabIndex = 6;
            this.mtbDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // lbDataVencimento
            // 
            this.lbDataVencimento.AutoSize = true;
            this.lbDataVencimento.Location = new System.Drawing.Point(154, 61);
            this.lbDataVencimento.Name = "lbDataVencimento";
            this.lbDataVencimento.Size = new System.Drawing.Size(91, 13);
            this.lbDataVencimento.TabIndex = 11;
            this.lbDataVencimento.Text = "Data vencimento:";
            // 
            // mtbDataPagamento
            // 
            this.mtbDataPagamento.Location = new System.Drawing.Point(306, 77);
            this.mtbDataPagamento.Mask = "00/00/0000";
            this.mtbDataPagamento.Name = "mtbDataPagamento";
            this.mtbDataPagamento.Size = new System.Drawing.Size(100, 20);
            this.mtbDataPagamento.TabIndex = 7;
            this.mtbDataPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // lbDataPagamento
            // 
            this.lbDataPagamento.AutoSize = true;
            this.lbDataPagamento.Location = new System.Drawing.Point(303, 61);
            this.lbDataPagamento.Name = "lbDataPagamento";
            this.lbDataPagamento.Size = new System.Drawing.Size(89, 13);
            this.lbDataPagamento.TabIndex = 13;
            this.lbDataPagamento.Text = "Data pagamento:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(91, 116);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(10, 116);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(10, 26);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 2;
            this.tbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbValor_KeyPress);
            this.tbValor.Leave += new System.EventHandler(this.TbValor_Leave);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(303, 10);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(58, 13);
            this.lbDescricao.TabIndex = 14;
            this.lbDescricao.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(306, 26);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(100, 20);
            this.tbDescricao.TabIndex = 4;
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão"});
            this.cbFormaPagamento.Location = new System.Drawing.Point(157, 26);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(100, 21);
            this.cbFormaPagamento.TabIndex = 3;
            // 
            // frInserirNovaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 151);
            this.Controls.Add(this.cbFormaPagamento);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.mtbDataPagamento);
            this.Controls.Add(this.lbDataPagamento);
            this.Controls.Add(this.mtbDataVencimento);
            this.Controls.Add(this.lbDataVencimento);
            this.Controls.Add(this.mtbDataCompra);
            this.Controls.Add(this.lbDataCompra);
            this.Controls.Add(this.lbFormaPagamento);
            this.Controls.Add(this.lbValor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(442, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(442, 190);
            this.Name = "frInserirNovaConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir nova conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdAvancado;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbFormaPagamento;
        private System.Windows.Forms.Label lbDataCompra;
        private System.Windows.Forms.MaskedTextBox mtbDataCompra;
        private System.Windows.Forms.MaskedTextBox mtbDataVencimento;
        private System.Windows.Forms.Label lbDataVencimento;
        private System.Windows.Forms.MaskedTextBox mtbDataPagamento;
        private System.Windows.Forms.Label lbDataPagamento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
    }
}