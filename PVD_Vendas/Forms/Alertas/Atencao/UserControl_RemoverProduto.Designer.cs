namespace PVD_Vendas.Forms.Alertas.Atencao
{
    partial class UserControl_RemoverProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_RemoverProduto));
            System.Windows.Forms.Label label9;
            this.buttonSim = new System.Windows.Forms.Button();
            this.buttonNao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSim
            // 
            this.buttonSim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(63)))));
            this.buttonSim.FlatAppearance.BorderSize = 0;
            this.buttonSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSim.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSim.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSim.Location = new System.Drawing.Point(221, 72);
            this.buttonSim.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSim.Name = "buttonSim";
            this.buttonSim.Size = new System.Drawing.Size(100, 30);
            this.buttonSim.TabIndex = 0;
            this.buttonSim.Text = "Sim (ENTER)";
            this.buttonSim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSim.UseVisualStyleBackColor = false;
            this.buttonSim.Click += new System.EventHandler(this.buttonSim_Click);
            this.buttonSim.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonSim_Paint);
            // 
            // buttonNao
            // 
            this.buttonNao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(85)))), ((int)(((byte)(87)))));
            this.buttonNao.FlatAppearance.BorderSize = 0;
            this.buttonNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNao.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.buttonNao.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonNao.Location = new System.Drawing.Point(332, 72);
            this.buttonNao.Name = "buttonNao";
            this.buttonNao.Size = new System.Drawing.Size(100, 30);
            this.buttonNao.TabIndex = 1;
            this.buttonNao.Text = "Não (ESC)";
            this.buttonNao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNao.UseVisualStyleBackColor = false;
            this.buttonNao.Click += new System.EventHandler(this.buttonNao_Click);
            this.buttonNao.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonNao_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            label9.Location = new System.Drawing.Point(74, 23);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(345, 20);
            label9.TabIndex = 45;
            label9.Text = "Você tem certeza que deseja cancelar esse item?";
            // 
            // UserControl_RemoverProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.buttonSim);
            this.Controls.Add(this.buttonNao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label9);
            this.Name = "UserControl_RemoverProduto";
            this.Size = new System.Drawing.Size(444, 111);
            this.Load += new System.EventHandler(this.UserControl_RemoverProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button buttonSim;
        public System.Windows.Forms.Button buttonNao;
    }
}
