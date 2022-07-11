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
    public partial class FormVendasAguardadas : Form
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

        public FormVendasAguardadas()
        {
            InitializeComponent();
        }

        private void FormVendasAguardadas_Load(object sender, EventArgs e)
        {

        }

        private void FormVendasAguardadas_KeyUp(object sender, KeyEventArgs e)
        {          
            if (e.KeyCode == Keys.F5)
            {

            }

            if (e.KeyCode == Keys.F10)
            {

            }

            if (e.KeyCode == Keys.Escape)
            {
                buttonSair_Click(sender, e);
            }


            if (e.KeyCode == Keys.Delete)
            {

            }      
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSair_Paint(object sender, PaintEventArgs e)
        {
            buttonSair.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonSair.Width,
            buttonSair.Height, 3, 3));
        }

        private void panelDescricao_Paint(object sender, PaintEventArgs e)
        {
            panelDescricao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelDescricao.Width,
            panelDescricao.Height, 25, 25));
        }
    }
}
