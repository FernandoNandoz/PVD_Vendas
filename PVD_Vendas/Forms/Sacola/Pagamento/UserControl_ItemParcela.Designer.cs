namespace PVD_Vendas.Forms.Sacola.Pagamento
{
    partial class UserControl_ItemParcela
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNumero = new System.Windows.Forms.Label();
            this.dateTimeVencimento = new System.Windows.Forms.DateTimePicker();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.comboBoxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.comboBoxSituacao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.Location = new System.Drawing.Point(6, 4);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(27, 24);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "0";
            this.labelNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeVencimento
            // 
            this.dateTimeVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeVencimento.Location = new System.Drawing.Point(39, 5);
            this.dateTimeVencimento.Name = "dateTimeVencimento";
            this.dateTimeVencimento.Size = new System.Drawing.Size(105, 23);
            this.dateTimeVencimento.TabIndex = 1;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor.Location = new System.Drawing.Point(152, 5);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(91, 23);
            this.textBoxValor.TabIndex = 2;
            // 
            // comboBoxFormaPagamento
            // 
            this.comboBoxFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormaPagamento.FormattingEnabled = true;
            this.comboBoxFormaPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Crédito",
            "Débito",
            "Cheque",
            "Crédito Loja",
            "Outro"});
            this.comboBoxFormaPagamento.Location = new System.Drawing.Point(249, 5);
            this.comboBoxFormaPagamento.Name = "comboBoxFormaPagamento";
            this.comboBoxFormaPagamento.Size = new System.Drawing.Size(118, 23);
            this.comboBoxFormaPagamento.TabIndex = 3;
            // 
            // comboBoxSituacao
            // 
            this.comboBoxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSituacao.FormattingEnabled = true;
            this.comboBoxSituacao.Items.AddRange(new object[] {
            "ABERTO",
            "PAGO"});
            this.comboBoxSituacao.Location = new System.Drawing.Point(373, 5);
            this.comboBoxSituacao.Name = "comboBoxSituacao";
            this.comboBoxSituacao.Size = new System.Drawing.Size(84, 23);
            this.comboBoxSituacao.TabIndex = 4;
            // 
            // UserControl_ItemParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.comboBoxSituacao);
            this.Controls.Add(this.comboBoxFormaPagamento);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.dateTimeVencimento);
            this.Controls.Add(this.labelNumero);
            this.Name = "UserControl_ItemParcela";
            this.Size = new System.Drawing.Size(460, 34);
            this.Load += new System.EventHandler(this.UserControl_ItemParcela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.DateTimePicker dateTimeVencimento;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.ComboBox comboBoxFormaPagamento;
        private System.Windows.Forms.ComboBox comboBoxSituacao;
    }
}
