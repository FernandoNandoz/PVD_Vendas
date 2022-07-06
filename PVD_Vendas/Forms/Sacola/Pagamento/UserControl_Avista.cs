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
    public partial class UserControl_Avista : UserControl
    {
        public UserControl_Avista()
        {
            InitializeComponent();
        }

        private void UserControl_Avista_Load(object sender, EventArgs e)
        {
            comboBoxFormaPagamento.SelectedIndex = 0;
            comboBoxContaCaixa.SelectedIndex = 0;

            textBoxValorRecebido.Text = Convert.ToDecimal(0).ToString("C2");
        }
    }
}
