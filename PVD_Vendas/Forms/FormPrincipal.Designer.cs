namespace PVD_Vendas
{
    partial class FormPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBoxIconOperador;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.label6 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.labelValorUnitario = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonConfiguracoes = new System.Windows.Forms.Button();
            this.buttonAjuda = new System.Windows.Forms.Button();
            this.panelPesquisar = new System.Windows.Forms.Panel();
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            this.textBoxValorUnitario = new System.Windows.Forms.TextBox();
            this.buttonIncluirProduto = new System.Windows.Forms.Button();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxPesquisarProduto = new System.Windows.Forms.TextBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.groupBoxCaixaVazio = new System.Windows.Forms.GroupBox();
            this.pictureBoxSacolaVazia = new System.Windows.Forms.PictureBox();
            pictureBoxIconOperador = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBoxIconOperador)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelPesquisar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.groupBoxCaixaVazio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSacolaVazia)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIconOperador
            // 
            pictureBoxIconOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            pictureBoxIconOperador.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconOperador.Image")));
            pictureBoxIconOperador.Location = new System.Drawing.Point(687, 24);
            pictureBoxIconOperador.Name = "pictureBoxIconOperador";
            pictureBoxIconOperador.Size = new System.Drawing.Size(38, 34);
            pictureBoxIconOperador.TabIndex = 39;
            pictureBoxIconOperador.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F);
            label3.ForeColor = System.Drawing.SystemColors.Window;
            label3.Location = new System.Drawing.Point(605, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(80, 18);
            label3.TabIndex = 38;
            label3.Text = "OPERADOR";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(17, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(230, 36);
            label1.TabIndex = 1;
            label1.Text = "Agropecuaria TX";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            label2.Location = new System.Drawing.Point(413, 251);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(240, 20);
            label2.TabIndex = 37;
            label2.Text = "Seu caixa está livre no momento!";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Produto (INSERT)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold);
            this.labelValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            this.labelValorTotal.Location = new System.Drawing.Point(726, 8);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(86, 20);
            this.labelValorTotal.TabIndex = 36;
            this.labelValorTotal.Text = "Valor Total";
            this.labelValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValorUnitario
            // 
            this.labelValorUnitario.AutoSize = true;
            this.labelValorUnitario.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold);
            this.labelValorUnitario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            this.labelValorUnitario.Location = new System.Drawing.Point(570, 8);
            this.labelValorUnitario.Name = "labelValorUnitario";
            this.labelValorUnitario.Size = new System.Drawing.Size(107, 20);
            this.labelValorUnitario.TabIndex = 35;
            this.labelValorUnitario.Text = "Valor Unitário";
            this.labelValorUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold);
            this.labelQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(83)))), ((int)(((byte)(119)))));
            this.labelQuantidade.Location = new System.Drawing.Point(414, 8);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(90, 20);
            this.labelQuantidade.TabIndex = 34;
            this.labelQuantidade.Text = "Quantidade";
            this.labelQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(134)))));
            this.panelHeader.Controls.Add(pictureBoxIconOperador);
            this.panelHeader.Controls.Add(this.labelUsuario);
            this.panelHeader.Controls.Add(label3);
            this.panelHeader.Controls.Add(this.buttonSair);
            this.panelHeader.Controls.Add(this.buttonConfiguracoes);
            this.panelHeader.Controls.Add(this.buttonAjuda);
            this.panelHeader.Controls.Add(label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1144, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // labelUsuario
            // 
            this.labelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUsuario.Location = new System.Drawing.Point(582, 40);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(103, 18);
            this.labelUsuario.TabIndex = 39;
            this.labelUsuario.Text = "nandonet1998";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSair.Location = new System.Drawing.Point(1008, 25);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(103, 33);
            this.buttonSair.TabIndex = 40;
            this.buttonSair.TabStop = false;
            this.buttonSair.Text = "SAIR (ESC)";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            this.buttonSair.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonSair_Paint);
            // 
            // buttonConfiguracoes
            // 
            this.buttonConfiguracoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.buttonConfiguracoes.FlatAppearance.BorderSize = 0;
            this.buttonConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguracoes.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfiguracoes.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonConfiguracoes.Location = new System.Drawing.Point(832, 25);
            this.buttonConfiguracoes.Name = "buttonConfiguracoes";
            this.buttonConfiguracoes.Size = new System.Drawing.Size(170, 33);
            this.buttonConfiguracoes.TabIndex = 30;
            this.buttonConfiguracoes.TabStop = false;
            this.buttonConfiguracoes.Text = "CONFIGURAÇÕES (F12)";
            this.buttonConfiguracoes.UseVisualStyleBackColor = false;
            this.buttonConfiguracoes.Click += new System.EventHandler(this.buttonConfiguracoes_Click);
            this.buttonConfiguracoes.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonConfiguracoes_Paint);
            // 
            // buttonAjuda
            // 
            this.buttonAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.buttonAjuda.FlatAppearance.BorderSize = 0;
            this.buttonAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjuda.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjuda.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAjuda.Location = new System.Drawing.Point(727, 25);
            this.buttonAjuda.Name = "buttonAjuda";
            this.buttonAjuda.Size = new System.Drawing.Size(99, 33);
            this.buttonAjuda.TabIndex = 20;
            this.buttonAjuda.TabStop = false;
            this.buttonAjuda.Text = "AJUDA (F1)";
            this.buttonAjuda.UseVisualStyleBackColor = false;
            this.buttonAjuda.Click += new System.EventHandler(this.buttonAjuda_Click);
            this.buttonAjuda.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonAjuda_Paint);
            // 
            // panelPesquisar
            // 
            this.panelPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPesquisar.BackColor = System.Drawing.SystemColors.Window;
            this.panelPesquisar.Controls.Add(this.labelValorTotal);
            this.panelPesquisar.Controls.Add(this.labelValorUnitario);
            this.panelPesquisar.Controls.Add(this.labelQuantidade);
            this.panelPesquisar.Controls.Add(this.textBoxValorTotal);
            this.panelPesquisar.Controls.Add(this.textBoxValorUnitario);
            this.panelPesquisar.Controls.Add(this.buttonIncluirProduto);
            this.panelPesquisar.Controls.Add(this.textBoxQuantidade);
            this.panelPesquisar.Controls.Add(this.label6);
            this.panelPesquisar.Controls.Add(this.textBoxPesquisarProduto);
            this.panelPesquisar.Location = new System.Drawing.Point(12, 89);
            this.panelPesquisar.Name = "panelPesquisar";
            this.panelPesquisar.Size = new System.Drawing.Size(1120, 92);
            this.panelPesquisar.TabIndex = 1;
            this.panelPesquisar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPesquisar_Paint);
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxValorTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxValorTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxValorTotal.Location = new System.Drawing.Point(730, 41);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.Size = new System.Drawing.Size(150, 32);
            this.textBoxValorTotal.TabIndex = 3;
            this.textBoxValorTotal.Text = "0,00";
            // 
            // textBoxValorUnitario
            // 
            this.textBoxValorUnitario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxValorUnitario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxValorUnitario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxValorUnitario.Location = new System.Drawing.Point(574, 41);
            this.textBoxValorUnitario.Name = "textBoxValorUnitario";
            this.textBoxValorUnitario.Size = new System.Drawing.Size(150, 32);
            this.textBoxValorUnitario.TabIndex = 2;
            this.textBoxValorUnitario.Text = "0,00";
            // 
            // buttonIncluirProduto
            // 
            this.buttonIncluirProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(211)))));
            this.buttonIncluirProduto.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonIncluirProduto.FlatAppearance.BorderSize = 0;
            this.buttonIncluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncluirProduto.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncluirProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonIncluirProduto.Location = new System.Drawing.Point(894, 0);
            this.buttonIncluirProduto.Name = "buttonIncluirProduto";
            this.buttonIncluirProduto.Size = new System.Drawing.Size(226, 92);
            this.buttonIncluirProduto.TabIndex = 4;
            this.buttonIncluirProduto.TabStop = false;
            this.buttonIncluirProduto.Text = "INCLUIR (ENTER)";
            this.buttonIncluirProduto.UseVisualStyleBackColor = false;
            this.buttonIncluirProduto.Click += new System.EventHandler(this.buttonIncluirProduto_Click);
            this.buttonIncluirProduto.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonIncluirProduto_Paint);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxQuantidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxQuantidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxQuantidade.Location = new System.Drawing.Point(418, 41);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(150, 32);
            this.textBoxQuantidade.TabIndex = 1;
            this.textBoxQuantidade.Text = "0";
            // 
            // textBoxPesquisarProduto
            // 
            this.textBoxPesquisarProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxPesquisarProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxPesquisarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxPesquisarProduto.Location = new System.Drawing.Point(16, 41);
            this.textBoxPesquisarProduto.Name = "textBoxPesquisarProduto";
            this.textBoxPesquisarProduto.Size = new System.Drawing.Size(396, 32);
            this.textBoxPesquisarProduto.TabIndex = 0;
            this.textBoxPesquisarProduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPesquisarProduto_KeyUp);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.SystemColors.Window;
            this.panelContent.Controls.Add(this.groupBoxCaixaVazio);
            this.panelContent.Location = new System.Drawing.Point(0, 190);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1144, 450);
            this.panelContent.TabIndex = 2;
            // 
            // groupBoxCaixaVazio
            // 
            this.groupBoxCaixaVazio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCaixaVazio.Controls.Add(this.pictureBoxSacolaVazia);
            this.groupBoxCaixaVazio.Controls.Add(label2);
            this.groupBoxCaixaVazio.Location = new System.Drawing.Point(35, 24);
            this.groupBoxCaixaVazio.Name = "groupBoxCaixaVazio";
            this.groupBoxCaixaVazio.Size = new System.Drawing.Size(1074, 402);
            this.groupBoxCaixaVazio.TabIndex = 3;
            this.groupBoxCaixaVazio.TabStop = false;
            // 
            // pictureBoxSacolaVazia
            // 
            this.pictureBoxSacolaVazia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxSacolaVazia.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSacolaVazia.Image")));
            this.pictureBoxSacolaVazia.Location = new System.Drawing.Point(433, 115);
            this.pictureBoxSacolaVazia.Name = "pictureBoxSacolaVazia";
            this.pictureBoxSacolaVazia.Size = new System.Drawing.Size(172, 129);
            this.pictureBoxSacolaVazia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSacolaVazia.TabIndex = 38;
            this.pictureBoxSacolaVazia.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1144, 641);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelPesquisar);
            this.Controls.Add(this.panelHeader);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1160, 680);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PVD VENDAS - AGROPECUARIA TX";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.SizeChanged += new System.EventHandler(this.FormPrincipal_SizeChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(pictureBoxIconOperador)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelPesquisar.ResumeLayout(false);
            this.panelPesquisar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.groupBoxCaixaVazio.ResumeLayout(false);
            this.groupBoxCaixaVazio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSacolaVazia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonConfiguracoes;
        private System.Windows.Forms.Button buttonAjuda;
        private System.Windows.Forms.Panel panelPesquisar;
        private System.Windows.Forms.TextBox textBoxValorTotal;
        private System.Windows.Forms.TextBox textBoxValorUnitario;
        private System.Windows.Forms.Button buttonIncluirProduto;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.TextBox textBoxPesquisarProduto;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.GroupBox groupBoxCaixaVazio;
        private System.Windows.Forms.PictureBox pictureBoxSacolaVazia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label labelValorUnitario;
        private System.Windows.Forms.Label labelQuantidade;
        public System.Windows.Forms.Panel panelContent;
    }
}

