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

namespace PVD_Vendas.Forms
{
    public partial class FormReferenciarCliente : Form
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

        public FormReferenciarCliente()
        {
            InitializeComponent();
        }

        #region Paint

        private void buttonReferenciar_Paint(object sender, PaintEventArgs e)
        {
            buttonReferenciar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonReferenciar.Width,
            buttonReferenciar.Height, 3, 3));
        }

        private void buttonVoltar_Paint(object sender, PaintEventArgs e)
        {
            buttonVoltar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonVoltar.Width,
            buttonVoltar.Height, 3, 3));
        }

        private void buttonCadastrarCliente_Paint(object sender, PaintEventArgs e)
        {
            buttonCadastrarCliente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonCadastrarCliente.Width,
            buttonCadastrarCliente.Height, 3, 3));
        }

        #endregion

        private void FormReferenciarCliente_Load(object sender, EventArgs e)
        {

        }

        private void FormReferenciarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F7)
            {
                buttonCadastrarCliente_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                buttonVoltar_Click(sender, e);
            }

            if(e.KeyCode == Keys.Enter)
            {
                buttonReferenciar_Click(sender, e);
            }
        }

        private void buttonCadastrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void buttonReferenciar_Click(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
