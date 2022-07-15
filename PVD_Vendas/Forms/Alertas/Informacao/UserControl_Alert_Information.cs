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

namespace PVD_Vendas.Forms.Alertas.Informacao
{
    public partial class UserControl_Alert_Information : UserControl
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

        public int OperacaoInterna = 0;

        public UserControl_Alert_Information()
        {
            InitializeComponent();
        }

        #region Paint

        private void buttonSim_Paint(object sender, PaintEventArgs e)
        {
            buttonSim.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonSim.Width,
            buttonSim.Height, 3, 3));
        }

        #endregion

        private void UserControl_Alert_Information_Load(object sender, EventArgs e)
        {
            if(OperacaoInterna == 1)
            {
                labelDescricao.Text = "Pedido finalizado com sucesso!";
            }

            if (OperacaoInterna == 2)
            {
                labelDescricao.Text = "Por favor preencher o valor recebido!";
            }

            if (OperacaoInterna == 3)
            {
                labelDescricao.Text = "O valor unitário deste produto é zero, favor corrigir antes de adicionar ao carrinho!";
            }
        }

        public void buttonSim_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
