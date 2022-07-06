using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVD_Vendas
{
    public partial class FormPrincipal : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        int larguraPanel = 0, mediaPanel = 0;

        Forms.Sacola.UserControlSacola sacola = new Forms.Sacola.UserControlSacola();


        public FormPrincipal()
        {
            InitializeComponent();
        }

        #region Paint

        private void buttonAjuda_Paint(object sender, PaintEventArgs e)
        {
            buttonAjuda.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonAjuda.Width,
            buttonAjuda.Height, 3, 3));
        }

        private void buttonConfiguracoes_Paint(object sender, PaintEventArgs e)
        {
            buttonConfiguracoes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonConfiguracoes.Width,
            buttonConfiguracoes.Height, 3, 3));
        }

        private void buttonSair_Paint(object sender, PaintEventArgs e)
        {
            buttonSair.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonSair.Width,
            buttonSair.Height, 3, 3));
        }

        private void panelPesquisar_Paint(object sender, PaintEventArgs e)
        {
            panelPesquisar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelPesquisar.Width,
            panelPesquisar.Height, 5, 5));
        }

        private void buttonIncluirProduto_Paint(object sender, PaintEventArgs e)
        {
            buttonIncluirProduto.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonIncluirProduto.Width,
            buttonIncluirProduto.Height, 5, 5));
        }

        #endregion

        #region Responsividade

        private void FormPrincipal_SizeChanged(object sender, EventArgs e)
        {
            panelPesquisar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelPesquisar.Width,
            panelPesquisar.Height, 5, 5));

            larguraPanel = panelPesquisar.Width;
            mediaPanel = larguraPanel / 5;

            responsiveProdutos();
            responsiveQuantidade();
            responsiveValorUnitario();
            responsiveValorTotal();

            buttonIncluirProduto.Width = mediaPanel;

            if (sacolaVenda._retornarValidacao() == true)
            {
                panelContent.Controls.Add(sacola);
                groupBoxCaixaVazio.SendToBack();
            }
        }

        private void responsiveProdutos()
        {
            int mediaMaior = 0, mediaMenor = 0, mediaLargura = 0;

            mediaLargura = mediaPanel / 5;

            mediaMenor = mediaPanel - mediaLargura;

            mediaMaior = mediaPanel + mediaMenor;

            textBoxPesquisarProduto.Width = mediaMaior;
        }

        private void responsiveQuantidade()
        {
            int mediaMenor = 0, mediaLargura = 0;

            mediaLargura = mediaPanel / 3;

            mediaMenor = mediaPanel - mediaLargura;

            //
            int X = 0, Y = 0;

            //
            Y = textBoxQuantidade.Location.Y;

            X = (textBoxPesquisarProduto.Width + 21);

            textBoxQuantidade.Location = new Point(X, Y);

            labelQuantidade.Location = new Point((X - 4), labelQuantidade.Location.Y);

            textBoxQuantidade.Width = mediaMenor;
        }

        private void responsiveValorUnitario()
        {
            int mediaMenor = 0, mediaLargura = 0;

            mediaLargura = mediaPanel / 3;

            mediaMenor = mediaPanel - mediaLargura;

            //
            int X = 0, Y = 0;

            //
            Y = textBoxValorUnitario.Location.Y;

            X = (textBoxPesquisarProduto.Width + textBoxQuantidade.Width + 26);

            textBoxValorUnitario.Location = new Point(X, Y);

            labelValorUnitario.Location = new Point((X - 4), labelValorUnitario.Location.Y);

            textBoxValorUnitario.Width = mediaMenor;
        }

        private void responsiveValorTotal()
        {
            int mediaMenor = 0, mediaLargura = 0;

            mediaLargura = mediaPanel / 3;

            mediaMenor = mediaPanel - mediaLargura;

            //
            int X = 0, Y = 0;

            //
            Y = textBoxValorTotal.Location.Y;

            X = (textBoxPesquisarProduto.Width + textBoxQuantidade.Width + textBoxValorUnitario.Width + 30);

            textBoxValorTotal.Location = new Point(X, Y);

            labelValorTotal.Location = new Point((X - 4), labelValorTotal.Location.Y);

            textBoxValorTotal.Width = mediaMenor;
        }

        #endregion

        private void dataProdutos()
        {
            sacola.dataGridViewContent.Rows.Add(0, "1", "teste", "20,00", "40,00");
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            textBoxPesquisarProduto.Focus();
        }

        private void FormPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonSair_Click(sender, e);
            }

            if (e.KeyCode == Keys.F1)
            {
                buttonAjuda_Click(sender, e);
            }

            if (e.KeyCode == Keys.F12)
            {
                buttonConfiguracoes_Click(sender, e);
            }

            if (e.KeyCode == Keys.Insert)
            {
                textBoxPesquisarProduto.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                buttonIncluirProduto_Click(sender, e);
            }

            if (e.KeyCode == Keys.F5)
            {
                if(sacolaVenda._retornarValidacao() == true)
                {
                    sacola.buttonConfirmar_Click(sender, e);
                }
            }

            if (e.KeyCode == Keys.F7)
            {
                if(sacolaVenda._retornarValidacao() == true)
                {
                    sacola.buttonAguardar_Click(sender, e);
                }

            }

            if (e.KeyCode == Keys.F9)
            {
                if (sacolaVenda._retornarValidacao() == true)
                {
                    sacola.buttonCancelar_Click(sender, e);
                    //
                    sacolaVenda.receberDados(false);
                }
            }
        }

        private void buttonConfiguracoes_Click(object sender, EventArgs e)
        {
            Forms.Configuracoes.FormConfiguracoes window = new Forms.Configuracoes.FormConfiguracoes();
            window.ShowDialog();
            window.Dispose();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjuda_Click(object sender, EventArgs e)
        {
            Forms.FormAjuda window = new Forms.FormAjuda();
            window.ShowDialog();
            window.Dispose();
        }

        private void textBoxPesquisarProduto_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void buttonIncluirProduto_Click(object sender, EventArgs e)
        {
            if (sacolaVenda._retornarValidacao() == true)
            {
                dataProdutos();

            }
            else
            {
                sacolaVenda.receberDados(true);
                //
                sacola.Width = panelContent.Width;
                sacola.Height = panelContent.Height;

                panelContent.Controls.Add(sacola);
                groupBoxCaixaVazio.SendToBack();

                //
                dataProdutos();
            }

        }

    }
}
