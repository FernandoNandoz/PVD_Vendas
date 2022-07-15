using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVD_Vendas.Forms.Alertas
{
    public partial class FormAlerta : Form
    {
        //Alert
        Atencao.UserControl_Sair sair = new Atencao.UserControl_Sair();
        Atencao.UserControl_RemoverProduto removerProduto = new Atencao.UserControl_RemoverProduto();
        Atencao.UserControl_Alert_Pedidos alertPedido = new Atencao.UserControl_Alert_Pedidos();

        //Information
        Informacao.UserControl_Alert_Information information = new Informacao.UserControl_Alert_Information();


        //CODIGO DAS OPERAÇÕES
        // 1 - Sair/fechar programa
        // 2 - Remover produto/item
        // 3 - Cancelar pedido
        // 4 - Aguardar pedido
        // 5 - Finalizar pedido


        public FormAlerta()
        {
            InitializeComponent();
        }

        private void FormAlerta_Load(object sender, EventArgs e)
        {
            if (alertValidation._retornarOperacao() == 1)
            {
                panelContent.Controls.Add(sair);
            }

            if (alertValidation._retornarOperacao() == 2)
            {
                panelContent.Controls.Add(removerProduto);
            }

            if (alertValidation._retornarOperacao() == 3)
            {
                alertPedido.OperacaoInterna = 2; // 2 = Cancelar Pedido
                //
                panelContent.Controls.Add(alertPedido);
            }

            if (alertValidation._retornarOperacao() == 4)
            {
                alertPedido.OperacaoInterna = 1; // 1 = Aguardar Pedido
                //
                panelContent.Controls.Add(alertPedido);
            }

            if (alertValidation._retornarOperacao() == 5)
            {
                alertPedido.OperacaoInterna = 3; // 3 = Finalizar Pedido
                //
                panelContent.Controls.Add(alertPedido);
            }

            //Information

            if (alertValidation._retornarOperacao() == 10)
            {
                information.OperacaoInterna = 1; // 1 = Pedido Finalizado
                //
                panelContent.Controls.Add(information);
            }

            if (alertValidation._retornarOperacao() == 11)
            {
                information.OperacaoInterna = 2; // 2 = Preencher valor recebido
                //
                panelContent.Controls.Add(information);
            }

            if (alertValidation._retornarOperacao() == 12)
            {
                information.OperacaoInterna = 3; // 3 = Valor unitário é igual a zero
                //
                panelContent.Controls.Add(information);
            }
        }

        private void FormAlerta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (alertValidation._retornarOperacao() == 1)
                {
                    sair.buttonNao_Click(sender, e);
                }

                if (alertValidation._retornarOperacao() == 2)
                {
                    removerProduto.buttonNao_Click(sender, e);
                }

                if (alertValidation._retornarOperacao() == 3)
                {
                    alertPedido.buttonNao_Click(sender, e);
                }

                if (alertValidation._retornarOperacao() == 4)
                {
                    alertPedido.buttonNao_Click(sender, e);
                }

                if (alertValidation._retornarOperacao() == 5)
                {
                    alertPedido.buttonNao_Click(sender, e);
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (alertValidation._retornarOperacao() == 1)
                {
                    sair.buttonSim_Click(sender, e);
                }

                if (alertValidation._retornarOperacao() == 2)
                {
                    removerProduto.buttonSim_Click(sender, e);
                }

                if (alertValidation._retornarOperacao() == 3)
                {
                    alertPedido.buttonSim_Click(sender, e);
                }

                if (alertValidation._retornarOperacao() == 4)
                {
                    alertPedido.buttonSim_Click(sender, e);
                }

                if (alertValidation._retornarOperacao() == 5)
                {
                    alertPedido.buttonSim_Click(sender, e);
                }


                //Information

                if (alertValidation._retornarOperacao() == 10)
                {
                    information.buttonSim_Click(sender, e);
                }

                if (alertValidation._retornarOperacao() == 11)
                {
                    information.buttonSim_Click(sender, e);
                }

                if (alertValidation._retornarOperacao() == 12)
                {
                    information.buttonSim_Click(sender, e);
                }
            }
        }
    }
}
