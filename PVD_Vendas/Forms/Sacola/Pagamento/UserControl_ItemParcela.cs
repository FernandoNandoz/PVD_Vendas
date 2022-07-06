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
    public partial class UserControl_ItemParcela : UserControl
    {
        public UserControl_ItemParcela()
        {
            InitializeComponent();
        }

        private void UserControl_ItemParcela_Load(object sender, EventArgs e)
        {
            textBoxValor.Text = "90,00";
            comboBoxFormaPagamento.SelectedIndex = 0;
            comboBoxSituacao.SelectedIndex = 0;
        }
    }
}
