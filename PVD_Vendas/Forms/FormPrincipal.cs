using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        #region Dll Paint
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
        #endregion

        Banco banco = new Banco();

        Forms.Sacola.UserControlSacola sacola = new Forms.Sacola.UserControlSacola();


        int larguraPanel = 0, mediaPanel = 0;
        bool liberaSacola = false;


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

        private void limparControles()
        {
            liberaSacola = false;

            textBoxPesquisarProduto.Clear();
            textBoxQuantidade.Text = "1";
            textBoxValorUnitario.Text = decimal.Parse("0").ToString("N2");
            textBoxValorTotal.Text = decimal.Parse("0").ToString("N2");

            //
            textBoxPesquisarProduto.Focus();
        }

        private void pesquisaAutoCompleteProduto()
        {
            try
            {
                SqlCommand exePesquisa = new SqlCommand("SELECT nomeProduto, tipoUnitario, codigoProduto FROM Produtos", banco.connection);

                banco.conectar();
                SqlDataReader dr = exePesquisa.ExecuteReader();
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    lista.Add(dr.GetString(0) + "   ( " + dr.GetString(1) + " )      " + dr.GetString(2));
                }
                banco.desconectar();

                textBoxPesquisarProduto.AutoCompleteCustomSource = lista;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string[] dataProdutos()
        {
            string[] response = { };

            decimal quantidade = 0, valorUnitario = 0, valorTotal = 0;

            try
            {
                //Retorna os dados da tabela Produtos
                string query = ("SELECT idProduto, nomeProduto, tipoUnitario, codigoProduto, estoqueAtual, valorVenda FROM Produtos WHERE nomeProduto = @nome");
                SqlCommand exeVerificacao = new SqlCommand(query, banco.connection);
                banco.conectar();

                string textProduto = textBoxPesquisarProduto.Text;

                string[] produto = textProduto.Split('('); 

                exeVerificacao.Parameters.AddWithValue("@nome", produto[0]);

                SqlDataReader datareader = exeVerificacao.ExecuteReader();

                while (datareader.Read())
                {
                    //
                    quantidade = 1;
                    valorUnitario = datareader.GetDecimal(5);
                    valorTotal = valorUnitario * quantidade;

                    //
                    response = new string[5] { datareader[0].ToString(), datareader.GetString(1), quantidade.ToString(), valorUnitario.ToString(), valorTotal.ToString()};

                    //
                    textBoxPesquisarProduto.Text = datareader.GetString(1);
                    textBoxQuantidade.Text = "1";
                    textBoxValorUnitario.Text = valorUnitario.ToString("N2");
                    textBoxValorTotal.Text = valorTotal.ToString("N2");

                    //
                    liberaSacola = true;
                }

                banco.desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return response;

        }

        private decimal calcularValorTotal_Produto(int quantidade, decimal valorUnitario)
        {
            return 0;
        }

        private decimal calcularSubTotalTotal_Sacola(decimal Value)
        {
            return 0;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            textBoxPesquisarProduto.Focus();
        }

        private void FormPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            //Completo
            if (e.KeyCode == Keys.F1)
            {
                buttonAjuda_Click(sender, e);
            }

            //Completo
            if (e.KeyCode == Keys.F2)
            {
                Forms.FormReferenciarCliente window = new Forms.FormReferenciarCliente();
                window.ShowDialog();
                window.Dispose();
            }

            if (e.KeyCode == Keys.F3)
            {
                
            }

            //Completo
            if (e.KeyCode == Keys.F4)
            {
                Forms.FormVendasAguardadas window = new Forms.FormVendasAguardadas();
                window.ShowDialog();
                window.Dispose();
            }

            //Completo
            if (e.KeyCode == Keys.F5 && sacolaVenda._retornarValidacao() == true)
            {
                sacola.buttonConfirmar_Click(sender, e);
            }

            //Completo
            if (e.KeyCode == Keys.F7 && sacolaVenda._retornarValidacao() == true)
            {
                sacola.buttonAguardar_Click(sender, e);
            }

            //Completo
            if (e.KeyCode == Keys.F9 && sacolaVenda._retornarValidacao() == true)
            {
                limparControles();

                sacola.buttonCancelar_Click(sender, e);
                //
                sacolaVenda.receberDados(false);
            }

            if (e.KeyCode == Keys.F10)
            {
                
            }

            //Completo
            if (e.KeyCode == Keys.F12)
            {
                buttonConfiguracoes_Click(sender, e);
            }

            if (e.KeyCode == Keys.Delete)
            {
                
            }

            //Completo
            if (e.KeyCode == Keys.Escape)
            {
                buttonSair_Click(sender, e);
            }

            //Completo
            if (e.KeyCode == Keys.Insert)
            {
                limparControles();
                //
                textBoxPesquisarProduto.Focus();
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

        private void textBoxPesquisarProduto_Enter(object sender, EventArgs e)
        {
            pesquisaAutoCompleteProduto();
        }

        private void textBoxPesquisarProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (liberaSacola == true)
                {
                    buttonIncluirProduto_Click(sender, e);

                    liberaSacola = false;
                }
                else
                {
                    dataProdutos();
                }
            }
        }

        private void buttonIncluirProduto_Click(object sender, EventArgs e)
        {
            string[] data = { };

            if (sacolaVenda._retornarValidacao() == true)
            {
                data = dataProdutos();

                sacola.dataGridViewContent.Rows.Add(data[0], data[2], data[1], data[3], data[4]);

                //
                limparControles();
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
                data = dataProdutos();

                sacola.dataGridViewContent.Rows.Add(data[0], data[2], data[1], data[3], data[4]);

                //
                limparControles();
            }

        }

    }
}
