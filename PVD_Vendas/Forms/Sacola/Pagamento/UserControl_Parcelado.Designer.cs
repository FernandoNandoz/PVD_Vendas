namespace PVD_Vendas.Forms.Sacola.Pagamento
{
    partial class UserControl_Parcelado
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
            this.textBoxNumeroParcela = new System.Windows.Forms.TextBox();
            this.buttonGerarParcela = new System.Windows.Forms.Button();
            this.flowLayoutPanel_ItemParcela = new System.Windows.Forms.FlowLayoutPanel();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumeroParcela
            // 
            this.textBoxNumeroParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroParcela.Location = new System.Drawing.Point(182, 25);
            this.textBoxNumeroParcela.Name = "textBoxNumeroParcela";
            this.textBoxNumeroParcela.Size = new System.Drawing.Size(154, 29);
            this.textBoxNumeroParcela.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(27, 27);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(153, 21);
            label4.TabIndex = 37;
            label4.Text = "Numero de parcelas:";
            // 
            // buttonGerarParcela
            // 
            this.buttonGerarParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerarParcela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            this.buttonGerarParcela.Location = new System.Drawing.Point(346, 24);
            this.buttonGerarParcela.Name = "buttonGerarParcela";
            this.buttonGerarParcela.Size = new System.Drawing.Size(91, 30);
            this.buttonGerarParcela.TabIndex = 39;
            this.buttonGerarParcela.Text = "Gerar";
            this.buttonGerarParcela.UseVisualStyleBackColor = true;
            this.buttonGerarParcela.Click += new System.EventHandler(this.buttonGerarParcela_Click);
            // 
            // flowLayoutPanel_ItemParcela
            // 
            this.flowLayoutPanel_ItemParcela.AutoScroll = true;
            this.flowLayoutPanel_ItemParcela.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel_ItemParcela.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanel_ItemParcela.Name = "flowLayoutPanel_ItemParcela";
            this.flowLayoutPanel_ItemParcela.Size = new System.Drawing.Size(490, 390);
            this.flowLayoutPanel_ItemParcela.TabIndex = 40;
            // 
            // UserControl_Parcelado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel_ItemParcela);
            this.Controls.Add(this.buttonGerarParcela);
            this.Controls.Add(this.textBoxNumeroParcela);
            this.Controls.Add(label4);
            this.Name = "UserControl_Parcelado";
            this.Size = new System.Drawing.Size(490, 460);
            this.Load += new System.EventHandler(this.UserControl_Parcelado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNumeroParcela;
        private System.Windows.Forms.Button buttonGerarParcela;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ItemParcela;
    }
}
