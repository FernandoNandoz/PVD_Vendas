namespace PVD_Vendas.Forms
{
    partial class FormReferenciarCliente
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
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label1;
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.buttonReferenciar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.Location = new System.Drawing.Point(39, 49);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(430, 29);
            this.textBoxCliente.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            label9.Location = new System.Drawing.Point(103, 21);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(302, 25);
            label9.TabIndex = 47;
            label9.Text = "Referenciar CPF/CNPJ do Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(87, 81);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(334, 17);
            label1.TabIndex = 48;
            label1.Text = "Digite o CPF / CNPJ ou Nome do cliente cadastrado";
            // 
            // buttonReferenciar
            // 
            this.buttonReferenciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReferenciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(63)))));
            this.buttonReferenciar.FlatAppearance.BorderSize = 0;
            this.buttonReferenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReferenciar.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReferenciar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReferenciar.Location = new System.Drawing.Point(39, 118);
            this.buttonReferenciar.Name = "buttonReferenciar";
            this.buttonReferenciar.Size = new System.Drawing.Size(178, 35);
            this.buttonReferenciar.TabIndex = 72;
            this.buttonReferenciar.Text = "Referenciar (ENTER)";
            this.buttonReferenciar.UseVisualStyleBackColor = false;
            this.buttonReferenciar.Click += new System.EventHandler(this.buttonReferenciar_Click);
            this.buttonReferenciar.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonReferenciar_Paint);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(85)))), ((int)(((byte)(87)))));
            this.buttonVoltar.FlatAppearance.BorderSize = 0;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVoltar.Location = new System.Drawing.Point(347, 118);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(122, 35);
            this.buttonVoltar.TabIndex = 71;
            this.buttonVoltar.Text = "Voltar (ESC)";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            this.buttonVoltar.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonVoltar_Paint);
            // 
            // FormReferenciarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(509, 173);
            this.Controls.Add(this.buttonReferenciar);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(label1);
            this.Controls.Add(label9);
            this.Controls.Add(this.textBoxCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReferenciarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Referenciar Cliente";
            this.Load += new System.EventHandler(this.FormReferenciarCliente_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormReferenciarCliente_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Button buttonReferenciar;
        private System.Windows.Forms.Button buttonVoltar;
    }
}