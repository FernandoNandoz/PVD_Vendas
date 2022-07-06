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

namespace PVD_Vendas.Forms.Configuracoes
{
    public partial class FormConfiguracoes : Form
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

        public FormConfiguracoes()
        {
            InitializeComponent();
        }

        private void FormConfiguracoes_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormConfiguracoes_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                buttonVoltar_Click(sender, e);
            }

            if(e.KeyCode == Keys.F5)
            {

            }
        }

        private void checkBoxImpressãoDireta_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxImpressãoDireta.Checked)
            {
                checkBoxImpressãoDireta.Text = "Impressão direta ativada";
            }
            else
            {
                checkBoxImpressãoDireta.Text = "Impressão direta desativada";
            }
        }

        private void buttonSalvar_Paint(object sender, PaintEventArgs e)
        {
            buttonSalvar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonSalvar.Width,
            buttonSalvar.Height, 3, 3));
        }

        private void buttonVoltar_Paint(object sender, PaintEventArgs e)
        {
            buttonVoltar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonVoltar.Width,
            buttonVoltar.Height, 3, 3));
        }
    }
}
