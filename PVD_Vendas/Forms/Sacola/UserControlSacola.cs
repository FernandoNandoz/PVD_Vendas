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
    public partial class UserControlSacola : UserControl
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


        public UserControlSacola()
        {
            InitializeComponent();

            Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        }

        #region Paint

        private void panelSubtotal_Paint(object sender, PaintEventArgs e)
        {
            panelSubtotal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelSubtotal.Width,
            panelSubtotal.Height, 5, 5));
        }

        private void buttonConfirmar_Paint(object sender, PaintEventArgs e)
        {
            buttonConfirmar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonConfirmar.Width,
            buttonConfirmar.Height, 5, 5));
        }

        private void buttonAguardar_Paint(object sender, PaintEventArgs e)
        {
            buttonAguardar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonAguardar.Width,
            buttonAguardar.Height, 5, 5));
        }

        private void buttonCancelar_Paint(object sender, PaintEventArgs e)
        {
            buttonCancelar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonCancelar.Width,
            buttonCancelar.Height, 5, 5));
        }

        #endregion

        #region Responsividade

        private void panelOpcoes_SizeChanged(object sender, EventArgs e)
        {
            larguraPanel = panelOpcoes.Width;
            mediaPanel = larguraPanel / 5;

            responsivePanelSubTotal();
            responsiveButtonConfirmar();
            responsiveButtonAguardar();
            responsiveButtonCancelar();
        }

        private void responsivePanelSubTotal()
        {
            int mediaMaior = 0;

            mediaMaior = ((mediaPanel * 2) + (mediaPanel - 84));

            panelSubtotal.Width = mediaMaior;

            panelSubtotal.Refresh();
        }

        private void responsiveButtonConfirmar()
        {
            int mediaMenor = 0, mediaLargura = 0;

            mediaLargura = mediaPanel / 3;

            mediaMenor = mediaPanel - mediaLargura + 16;

            //
            int X = 0, Y = 0;

            //
            Y = buttonConfirmar.Location.Y;

            X = (panelSubtotal.Width + 14);

            buttonConfirmar.Location = new Point(X, Y);

            buttonConfirmar.Width = mediaMenor;
        }


        private void responsiveButtonAguardar()
        {
            int mediaMenor = 0, mediaLargura = 0;

            mediaLargura = mediaPanel / 3;

            mediaMenor = mediaPanel - mediaLargura + 16;

            //
            int X = 0, Y = 0;

            //
            Y = buttonAguardar.Location.Y;

            X = (panelSubtotal.Width + buttonConfirmar.Width + 20);

            buttonAguardar.Location = new Point(X, Y);

            buttonAguardar.Width = mediaMenor;
        }

        private void responsiveButtonCancelar()
        {
            int mediaMenor = 0, mediaLargura = 0;

            mediaLargura = mediaPanel / 3;

            mediaMenor = mediaPanel - mediaLargura + 16;

            //
            int X = 0, Y = 0;

            //
            Y = buttonCancelar.Location.Y;

            X = (panelSubtotal.Width + buttonConfirmar.Width + buttonAguardar.Width + 25);

            buttonCancelar.Location = new Point(X, Y);

            buttonCancelar.Width = mediaMenor;
        }

        #endregion


        private void UserControlSacola_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewContent.Rows.Count != 0)
            {
                if(e.ColumnIndex == 5)
                {
                    dataGridViewContent.Rows.RemoveAt(dataGridViewContent.CurrentRow.Index);
                }
            }
        }

        public void buttonConfirmar_Click(object sender, EventArgs e)
        {
            Forms.Sacola.FormPagamentoVenda window = new FormPagamentoVenda();
            window.ShowDialog();
            window.Dispose();
        }

        public void buttonAguardar_Click(object sender, EventArgs e)
        {

        }

        public void buttonCancelar_Click(object sender, EventArgs e)
        {
            dataGridViewContent.Rows.Clear();

            this.Parent.Controls.Remove(this);

            sacolaVenda.receberDados(false);
        }
    }
}
