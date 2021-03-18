namespace ContasPagarXML
{
    partial class frCadXMLContasPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCadXMLContasPagar));
            this.ofdContasPagar = new System.Windows.Forms.OpenFileDialog();
            this.tbDocContasPagar = new System.Windows.Forms.TextBox();
            this.lbDocContasPagar = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgContasPagar = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnNovoDoc = new System.Windows.Forms.Button();
            this.fbdCaminhoArqContas = new System.Windows.Forms.FolderBrowserDialog();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgContasPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdContasPagar
            // 
            this.ofdContasPagar.DefaultExt = "xml";
            this.ofdContasPagar.FileName = "Contas";
            this.ofdContasPagar.Filter = "xml files (*.xml)|*.xml";
            this.ofdContasPagar.InitialDirectory = "C:\\";
            this.ofdContasPagar.Title = "Localizar Doc contas pagar";
            // 
            // tbDocContasPagar
            // 
            this.tbDocContasPagar.Location = new System.Drawing.Point(12, 27);
            this.tbDocContasPagar.Name = "tbDocContasPagar";
            this.tbDocContasPagar.ReadOnly = true;
            this.tbDocContasPagar.Size = new System.Drawing.Size(447, 20);
            this.tbDocContasPagar.TabIndex = 0;
            // 
            // lbDocContasPagar
            // 
            this.lbDocContasPagar.AutoSize = true;
            this.lbDocContasPagar.Location = new System.Drawing.Point(12, 9);
            this.lbDocContasPagar.Name = "lbDocContasPagar";
            this.lbDocContasPagar.Size = new System.Drawing.Size(95, 13);
            this.lbDocContasPagar.TabIndex = 1;
            this.lbDocContasPagar.Text = "Doc contas pagar:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(465, 27);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 20);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // dgContasPagar
            // 
            this.dgContasPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgContasPagar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgContasPagar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContasPagar.Location = new System.Drawing.Point(12, 53);
            this.dgContasPagar.Name = "dgContasPagar";
            this.dgContasPagar.ReadOnly = true;
            this.dgContasPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgContasPagar.Size = new System.Drawing.Size(603, 278);
            this.dgContasPagar.TabIndex = 3;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIncluir.Location = new System.Drawing.Point(15, 348);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 4;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(96, 348);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemover.Location = new System.Drawing.Point(177, 348);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // btnNovoDoc
            // 
            this.btnNovoDoc.Location = new System.Drawing.Point(541, 27);
            this.btnNovoDoc.Name = "btnNovoDoc";
            this.btnNovoDoc.Size = new System.Drawing.Size(75, 20);
            this.btnNovoDoc.TabIndex = 8;
            this.btnNovoDoc.Text = "Novo Doc";
            this.btnNovoDoc.UseVisualStyleBackColor = true;
            this.btnNovoDoc.Click += new System.EventHandler(this.BtnNovoDoc_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(452, 351);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(57, 13);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Text = "Valor total:";
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorTotal.Location = new System.Drawing.Point(515, 348);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.ReadOnly = true;
            this.tbValorTotal.Size = new System.Drawing.Size(100, 20);
            this.tbValorTotal.TabIndex = 10;
            // 
            // frCadXMLContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 383);
            this.Controls.Add(this.tbValorTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnNovoDoc);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgContasPagar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lbDocContasPagar);
            this.Controls.Add(this.tbDocContasPagar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(643, 422);
            this.Name = "frCadXMLContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de contas pagar";
            this.Shown += new System.EventHandler(this.FrCadXMLContasPagar_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgContasPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdContasPagar;
        private System.Windows.Forms.TextBox tbDocContasPagar;
        private System.Windows.Forms.Label lbDocContasPagar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgContasPagar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnNovoDoc;
        private System.Windows.Forms.FolderBrowserDialog fbdCaminhoArqContas;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tbValorTotal;
    }
}

