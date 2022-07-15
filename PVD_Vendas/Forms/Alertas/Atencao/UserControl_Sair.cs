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

namespace PVD_Vendas.Forms.Alertas.Atencao
{
    public partial class UserControl_Sair : UserControl
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

        public UserControl_Sair()
        {
            InitializeComponent();
        }

        #region Paint

        private void buttonSim_Paint(object sender, PaintEventArgs e)
        {
            buttonSim.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonSim.Width,
            buttonSim.Height, 3, 3));
        }

        private void buttonNao_Paint(object sender, PaintEventArgs e)
        {
            buttonNao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonNao.Width,
            buttonNao.Height, 3, 3));
        }

        #endregion

        private void UserControl_Sair_Load(object sender, EventArgs e)
        {

        }

        public void buttonSim_Click(object sender, EventArgs e)
        {
            alertValidation.receberDados(true);

            this.ParentForm.Close();
        }

        public void buttonNao_Click(object sender, EventArgs e)
        {
            alertValidation.receberDados(false);

            this.ParentForm.Close();
        }
    }
}
