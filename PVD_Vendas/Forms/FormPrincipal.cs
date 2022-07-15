using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
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
        bool liberaSacola = false, liberarDeleteSacola = false;

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
            liberarDeleteSacola = false;

            textBoxPesquisarProduto.Clear();
            textBoxQuantidade.Text = "1";
            textBoxValorUnitario.Text = string.Format("{0:#,##0.00}", 0d);
            textBoxValorTotal.Text = string.Format("{0:#,##0.00}", 0d);
            //
            sacola.dataGridViewContent.DefaultCellStyle.SelectionBackColor = Color.White;
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

        private void encontrarProdutos()
        {
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

                if (datareader.Read())
                {
                    Models.ProtudoItens.receberValidacao(true);
                    //
                    Models.ProtudoItens.receberProdutoItem(int.Parse(datareader[0].ToString()), datareader.GetString(1), 1, datareader.GetDecimal(5));
                }
                else
                {
                    Models.ProtudoItens.receberValidacao(false);
                }

                banco.desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private decimal calcularValorTotal_Produto()
        {
            int quantidade = 0;
            decimal valorUnitario = 0, ValorTotal = 0;

            if (textBoxQuantidade.Text != string.Empty && textBoxQuantidade.Text.All(Char.IsNumber)
                || textBoxValorUnitario.Text != string.Empty && textBoxValorUnitario.Text.All(Char.IsNumber))
            {
                quantidade = int.Parse(textBoxQuantidade.Text);
                valorUnitario = decimal.Parse(textBoxValorUnitario.Text);
            }

            ValorTotal = quantidade * valorUnitario;

            return ValorTotal;
        }

        private void calcularSubTotalTotal_Sacola(int operation, decimal Value)
        {
            //Tipos de Operção
            // 1 = ADIÇÃO
            // 2 = SUBTRAÇÃO

            decimal SubTotal_Atual = 0, SubTotal_Novo = 0;

            string subTotal_Label = sacola.labelSubotal_Value.Text;
            string[] subTotal_Value = subTotal_Label.Split(' ');

            SubTotal_Atual = decimal.Parse(subTotal_Value[1]);

            if (operation == 1)
            {
                SubTotal_Novo = SubTotal_Atual + Value;
            }
            else if (operation == 2)
            {
                SubTotal_Novo = SubTotal_Atual - Value;
            }

            sacola.labelSubotal_Value.Text = ("R$ " + SubTotal_Novo.ToString("N2"));
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            limparControles();

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

            //Completo
            if (e.KeyCode == Keys.F10)
            {
                sacola.dataGridViewContent.Focus();

                SendKeys.SendWait("{Tab}");
                SendKeys.Flush();

                sacola.dataGridViewContent.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 162, 211);

                liberarDeleteSacola = true;
            }

            //Completo
            if (e.KeyCode == Keys.F12)
            {
                buttonConfiguracoes_Click(sender, e);
            }

            
            if (e.KeyCode == Keys.Delete)
            {
                if(liberarDeleteSacola == true)
                {
                    sacola.removerItemSacola();
                }
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
            if(e.KeyCode == Keys.Delete)
            {
                textBoxPesquisarProduto.Clear();
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (liberaSacola == true)
                {
                    buttonIncluirProduto_Click(sender, e);

                    liberaSacola = false;
                }
                else
                {
                    encontrarProdutos();

                    if (Models.ProtudoItens._ItemEncontrado() == true)
                    {
                        //
                        textBoxPesquisarProduto.Text = Models.ProtudoItens._NomeProduto();
                        textBoxQuantidade.Text = Models.ProtudoItens._Quantidade().ToString();
                        textBoxValorUnitario.Text = Models.ProtudoItens._ValorUnitario().ToString("N2");
                        textBoxValorTotal.Text = calcularValorTotal_Produto().ToString("N2");

                        liberaSacola = true;
                    }
                }
            }
        }

        private void textBoxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita apenas números, tecla backspace.
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantidade_KeyUp(object sender, KeyEventArgs e)
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
                    //
                    textBoxValorTotal.Text = calcularValorTotal_Produto().ToString("N2");
                }
            }
            else
            {
                //
                textBoxValorTotal.Text = calcularValorTotal_Produto().ToString("N2");
            }
        }

        private void textBoxValorUnitario_KeyUp(object sender, KeyEventArgs e)
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
                    //
                    textBoxValorTotal.Text = calcularValorTotal_Produto().ToString("N2");
                }
            }
            else
            {
                //
                textBoxValorTotal.Text = calcularValorTotal_Produto().ToString("N2");
            }
        }

        private void textBoxValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Codigo que aceita apensa numeros e virgulas
            //if (e.KeyChar == '.')
            //{
            //    //troca o . pela virgula
            //    e.KeyChar = '.';

            //    //Verifica se já existe alguma vírgula na string
            //    if (textBoxValorUnitario.Text.Contains("."))
            //    {
            //        e.Handled = true; // Caso exista, aborte 
            //    }
            //}


            //else if (e.KeyChar == ',')
            //{
            //    //troca o . pela virgula
            //    e.KeyChar = ',';

            //    //Verifica se já existe alguma vírgula na string
            //    if (textBoxValorUnitario.Text.Contains(","))
            //    {
            //        e.Handled = true; // Caso exista, aborte 
            //    }
            //}

            ////aceita apenas números, tecla backspace.
            //else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            //{
            //    e.Handled = true;
            //}
            #endregion

            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox value = (TextBox)sender;
                string stringValue = Regex.Replace(value.Text, "[^0-9]", string.Empty);
                if (stringValue == string.Empty) stringValue = "00";

                if (e.KeyChar.Equals((char)Keys.Back))      //  If backspace
                    stringValue = stringValue.Substring(0, stringValue.Length - 1);      //      takes out the rightmost digit
                else
                    stringValue += e.KeyChar;

                value.Text = string.Format("{0:#,##0.00}", Double.Parse(stringValue) / 100);
                value.Select(value.Text.Length, 0);
            }

            e.Handled = true;
        }

        private void textBoxValorUnitario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //  Cast control
                TextBox t = (TextBox)sender;
                t.Text = string.Format("{0:#,##0.00}", 0d);
                t.Select(t.Text.Length, 0);
                e.Handled = true;
            }
        }

        private void textBoxValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buttonIncluirProduto_Click(object sender, EventArgs e)
        {
            int idProduto = Models.ProtudoItens._IdProduto();
            //
            string nomeProduto = Models.ProtudoItens._NomeProduto();
            //
            int quantidade = int.Parse(textBoxQuantidade.Text);
            //
            decimal valorUnitario = decimal.Parse(textBoxValorUnitario.Text);
            //
            decimal valorTotal = calcularValorTotal_Produto();


            if (sacolaVenda._retornarValidacao() == true)
            {
                sacola.dataGridViewContent.Rows.Add(idProduto, quantidade, nomeProduto, valorUnitario, valorTotal.ToString("N2"));

                calcularSubTotalTotal_Sacola(1, valorTotal);

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

                sacola.dataGridViewContent.Rows.Add(idProduto, quantidade, nomeProduto, valorUnitario, valorTotal.ToString("N2"));

                calcularSubTotalTotal_Sacola(1, valorTotal);

                //
                limparControles();
            }

        }

    }
}
