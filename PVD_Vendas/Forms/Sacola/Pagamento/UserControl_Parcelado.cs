using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVD_Vendas.Forms.Sacola.Pagamento
{
    public partial class UserControl_Parcelado : UserControl
    {
        Forms.Sacola.Pagamento.UserControl_ItemParcela[] listaItem = new UserControl_ItemParcela[10];

        public UserControl_Parcelado()
        {
            InitializeComponent();
        }

        private void UserControl_Parcelado_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonGerarParcela_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_ItemParcela.Controls.Clear();

            for (int i = 0; i < int.Parse(textBoxNumeroParcela.Text); i++)
            {
                listaItem[i] = new UserControl_ItemParcela();

                flowLayoutPanel_ItemParcela.Controls.Add(listaItem[i]);
            }
        }
    }
}
