namespace PVD_Vendas.Forms.Sacola
{
    partial class FormPagamentoVenda
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            this.radioButton_Avista = new System.Windows.Forms.RadioButton();
            this.radioButtonParcelado = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxObservacao = new System.Windows.Forms.TextBox();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.buttonEmitirRecibo = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.panelPagemento = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            label6.Location = new System.Drawing.Point(16, 14);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(260, 25);
            label6.TabIndex = 31;
            label6.Text = "Confirmação de Pagemento";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label1.Location = new System.Drawing.Point(12, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(871, 13);
            label1.TabIndex = 32;
            label1.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(18, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(125, 21);
            label2.TabIndex = 33;
            label2.Text = "Total da compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(65, 115);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(78, 21);
            label4.TabIndex = 35;
            label4.Text = "Desconto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            label7.Location = new System.Drawing.Point(18, 182);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(134, 25);
            label7.TabIndex = 37;
            label7.Text = "Total a pagar:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label8.Location = new System.Drawing.Point(12, 153);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(373, 13);
            label8.TabIndex = 39;
            label8.Text = "_____________________________________________________________";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            label9.Location = new System.Drawing.Point(27, 30);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(173, 21);
            label9.TabIndex = 40;
            label9.Text = "Forma de pagamento";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            groupBox1.Controls.Add(this.radioButton_Avista);
            groupBox1.Controls.Add(this.radioButtonParcelado);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new System.Drawing.Point(-5, 221);
            groupBox1.Margin = new System.Windows.Forms.Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(0);
            groupBox1.Size = new System.Drawing.Size(394, 83);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            // 
            // radioButton_Avista
            // 
            this.radioButton_Avista.AutoSize = true;
            this.radioButton_Avista.Checked = true;
            this.radioButton_Avista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Avista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            this.radioButton_Avista.Location = new System.Drawing.Point(206, 31);
            this.radioButton_Avista.Name = "radioButton_Avista";
            this.radioButton_Avista.Size = new System.Drawing.Size(69, 22);
            this.radioButton_Avista.TabIndex = 41;
            this.radioButton_Avista.TabStop = true;
            this.radioButton_Avista.Text = "À vista";
            this.radioButton_Avista.UseVisualStyleBackColor = true;
            this.radioButton_Avista.CheckedChanged += new System.EventHandler(this.radioButton_Avista_CheckedChanged);
            // 
            // radioButtonParcelado
            // 
            this.radioButtonParcelado.AutoSize = true;
            this.radioButtonParcelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonParcelado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            this.radioButtonParcelado.Location = new System.Drawing.Point(281, 31);
            this.radioButtonParcelado.Name = "radioButtonParcelado";
            this.radioButtonParcelado.Size = new System.Drawing.Size(93, 22);
            this.radioButtonParcelado.TabIndex = 42;
            this.radioButtonParcelado.TabStop = true;
            this.radioButtonParcelado.Text = "Parcelado";
            this.radioButtonParcelado.UseVisualStyleBackColor = true;
            this.radioButtonParcelado.CheckedChanged += new System.EventHandler(this.radioButtonParcelado_CheckedChanged);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            label10.Location = new System.Drawing.Point(22, 332);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(97, 21);
            label10.TabIndex = 44;
            label10.Text = "Cliente (F2)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            label11.Location = new System.Drawing.Point(22, 433);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(132, 21);
            label11.TabIndex = 46;
            label11.Text = "Observação (F3)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label12.Location = new System.Drawing.Point(24, 388);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(279, 18);
            label12.TabIndex = 48;
            label12.Text = "Para cadastrar um cliente presioone (F4)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "R$ 130,00";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(146, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 29);
            this.textBox1.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            this.label5.Location = new System.Drawing.Point(149, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "R$ 130,00";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.Location = new System.Drawing.Point(26, 358);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(343, 29);
            this.textBoxCliente.TabIndex = 45;
            // 
            // textBoxObservacao
            // 
            this.textBoxObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservacao.Location = new System.Drawing.Point(26, 464);
            this.textBoxObservacao.Name = "textBoxObservacao";
            this.textBoxObservacao.Size = new System.Drawing.Size(343, 29);
            this.textBoxObservacao.TabIndex = 47;
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(63)))));
            this.buttonFinalizar.FlatAppearance.BorderSize = 0;
            this.buttonFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinalizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFinalizar.Location = new System.Drawing.Point(669, 599);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(200, 45);
            this.buttonFinalizar.TabIndex = 52;
            this.buttonFinalizar.Text = "Finalizar e sair (F5)";
            this.buttonFinalizar.UseVisualStyleBackColor = false;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            this.buttonFinalizar.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonFinalizar_Paint);
            // 
            // buttonEmitirRecibo
            // 
            this.buttonEmitirRecibo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEmitirRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(211)))));
            this.buttonEmitirRecibo.FlatAppearance.BorderSize = 0;
            this.buttonEmitirRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmitirRecibo.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmitirRecibo.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEmitirRecibo.Location = new System.Drawing.Point(669, 548);
            this.buttonEmitirRecibo.Name = "buttonEmitirRecibo";
            this.buttonEmitirRecibo.Size = new System.Drawing.Size(200, 45);
            this.buttonEmitirRecibo.TabIndex = 51;
            this.buttonEmitirRecibo.Text = "Emitir recibo (F7)";
            this.buttonEmitirRecibo.UseVisualStyleBackColor = false;
            this.buttonEmitirRecibo.Click += new System.EventHandler(this.buttonEmitirRecibo_Click);
            this.buttonEmitirRecibo.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonEmitirRecibo_Paint);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(85)))), ((int)(((byte)(87)))));
            this.buttonVoltar.FlatAppearance.BorderSize = 0;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVoltar.Location = new System.Drawing.Point(463, 599);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(200, 45);
            this.buttonVoltar.TabIndex = 50;
            this.buttonVoltar.Text = "Voltar (ESC)";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            this.buttonVoltar.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonVoltar_Paint);
            // 
            // panelPagemento
            // 
            this.panelPagemento.BackColor = System.Drawing.SystemColors.Window;
            this.panelPagemento.Location = new System.Drawing.Point(391, 68);
            this.panelPagemento.Name = "panelPagemento";
            this.panelPagemento.Size = new System.Drawing.Size(490, 460);
            this.panelPagemento.TabIndex = 49;
            // 
            // FormPagamentoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(892, 657);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.buttonEmitirRecibo);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.panelPagemento);
            this.Controls.Add(label12);
            this.Controls.Add(this.textBoxObservacao);
            this.Controls.Add(label11);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(label10);
            this.Controls.Add(groupBox1);
            this.Controls.Add(label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(label6);
            this.Controls.Add(label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPagamentoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmação de pagamento";
            this.Load += new System.EventHandler(this.FormPagamentoVenda_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormPagamentoVenda_KeyUp);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_Avista;
        private System.Windows.Forms.RadioButton radioButtonParcelado;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxObservacao;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.Button buttonEmitirRecibo;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Panel panelPagemento;
    }
}