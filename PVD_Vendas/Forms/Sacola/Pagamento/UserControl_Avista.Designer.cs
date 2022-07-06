namespace PVD_Vendas.Forms.Sacola.Pagamento
{
    partial class UserControl_Avista
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label7;
            this.textBoxValorRecebido = new System.Windows.Forms.TextBox();
            this.comboBoxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.labelValueTroco = new System.Windows.Forms.Label();
            this.comboBoxContaCaixa = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(42, 49);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(162, 21);
            label4.TabIndex = 39;
            label4.Text = "Forma de pagamento:";
            // 
            // textBoxValorRecebido
            // 
            this.textBoxValorRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorRecebido.Location = new System.Drawing.Point(210, 115);
            this.textBoxValorRecebido.Name = "textBoxValorRecebido";
            this.textBoxValorRecebido.Size = new System.Drawing.Size(183, 29);
            this.textBoxValorRecebido.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(90, 119);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 21);
            label1.TabIndex = 41;
            label1.Text = "Valor recebido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(112, 192);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 21);
            label2.TabIndex = 43;
            label2.Text = "Conta caixa:";
            // 
            // comboBoxFormaPagamento
            // 
            this.comboBoxFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormaPagamento.FormattingEnabled = true;
            this.comboBoxFormaPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Crédito",
            "Débito",
            "Cheque",
            "Crédito Loja",
            "Outro"});
            this.comboBoxFormaPagamento.Location = new System.Drawing.Point(210, 48);
            this.comboBoxFormaPagamento.Name = "comboBoxFormaPagamento";
            this.comboBoxFormaPagamento.Size = new System.Drawing.Size(183, 28);
            this.comboBoxFormaPagamento.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label3.Location = new System.Drawing.Point(15, 258);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(457, 13);
            label3.TabIndex = 47;
            label3.Text = "___________________________________________________________________________";
            // 
            // labelValueTroco
            // 
            this.labelValueTroco.AutoSize = true;
            this.labelValueTroco.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueTroco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            this.labelValueTroco.Location = new System.Drawing.Point(219, 295);
            this.labelValueTroco.Name = "labelValueTroco";
            this.labelValueTroco.Size = new System.Drawing.Size(114, 32);
            this.labelValueTroco.TabIndex = 49;
            this.labelValueTroco.Text = "R$ 20,00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            label7.Location = new System.Drawing.Point(148, 297);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(78, 29);
            label7.TabIndex = 48;
            label7.Text = "Troco:";
            // 
            // comboBoxContaCaixa
            // 
            this.comboBoxContaCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContaCaixa.FormattingEnabled = true;
            this.comboBoxContaCaixa.Items.AddRange(new object[] {
            "DINHEIRO",
            "CAIXA ECONOMICA",
            "BRADESCO",
            "BANCO DO BRAZIL"});
            this.comboBoxContaCaixa.Location = new System.Drawing.Point(210, 190);
            this.comboBoxContaCaixa.Name = "comboBoxContaCaixa";
            this.comboBoxContaCaixa.Size = new System.Drawing.Size(183, 28);
            this.comboBoxContaCaixa.TabIndex = 50;
            // 
            // UserControl_Avista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.comboBoxContaCaixa);
            this.Controls.Add(this.labelValueTroco);
            this.Controls.Add(label7);
            this.Controls.Add(label3);
            this.Controls.Add(this.comboBoxFormaPagamento);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBoxValorRecebido);
            this.Controls.Add(label1);
            this.Controls.Add(label4);
            this.Name = "UserControl_Avista";
            this.Size = new System.Drawing.Size(488, 359);
            this.Load += new System.EventHandler(this.UserControl_Avista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValorRecebido;
        private System.Windows.Forms.ComboBox comboBoxFormaPagamento;
        private System.Windows.Forms.Label labelValueTroco;
        private System.Windows.Forms.ComboBox comboBoxContaCaixa;
    }
}
