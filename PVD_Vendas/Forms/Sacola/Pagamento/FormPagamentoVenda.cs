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

namespace PVD_Vendas.Forms.Sacola
{
    public partial class FormPagamentoVenda : Form
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

        Forms.Sacola.Pagamento.UserControl_Avista Avista = new Pagamento.UserControl_Avista();
        Forms.Sacola.Pagamento.UserControl_Parcelado parcelado = new Pagamento.UserControl_Parcelado();


        public FormPagamentoVenda()
        {
            InitializeComponent();
        }

        #region Paint

        private void buttonEmitirRecibo_Paint(object sender, PaintEventArgs e)
        {
            buttonEmitirRecibo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonEmitirRecibo.Width,
            buttonEmitirRecibo.Height, 5, 5));
        }

        private void buttonFinalizar_Paint(object sender, PaintEventArgs e)
        {
            buttonFinalizar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonFinalizar.Width,
            buttonFinalizar.Height, 5, 5));
        }

        private void buttonVoltar_Paint(object sender, PaintEventArgs e)
        {
            buttonVoltar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonVoltar.Width,
            buttonVoltar.Height, 5, 5));
        }

        #endregion

        private void FormPagamentoVenda_Load(object sender, EventArgs e)
        {
            radioButton_Avista_CheckedChanged(sender, e);
        }

        private void FormPagamentoVenda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonVoltar_Click(sender, e);
            }

            if (e.KeyCode == Keys.F2)
            {

            }

            if (e.KeyCode == Keys.F3)
            {

            }

            if (e.KeyCode == Keys.F4)
            {

            }


            if (e.KeyCode == Keys.F5)
            {

            }

            if (e.KeyCode == Keys.F7)
            {

            }
        }

        private void radioButton_Avista_CheckedChanged(object sender, EventArgs e)
        {
            panelPagemento.Controls.Clear();
            panelPagemento.Controls.Add(Avista);
        }

        private void radioButtonParcelado_CheckedChanged(object sender, EventArgs e)
        {
            panelPagemento.Controls.Clear();
            panelPagemento.Controls.Add(parcelado);
        }

        private void buttonEmitirRecibo_Click(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
