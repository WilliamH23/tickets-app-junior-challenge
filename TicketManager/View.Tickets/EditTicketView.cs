using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketManager.Controller;
using TicketManager.ControllerDomain;
using TicketManager.Domian;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketManager.View.Tickets
{
    public partial class EditTicketView : Form
    {
        //Controller do Ticket e criação objeto para armazenar o Ticket.
        private readonly ControllerTicket controller = new();
        private readonly Ticket @object;
        public EditTicketView(Ticket @object)
        {
            InitializeComponent();
            this.@object = @object;
            Fill();
        }
        //Rotina de carregamento de informações do objeto(Ticket) em questão.
        private void Fill()
        {
            quantAtualLabel.Text = @object.quantity.ToString();
            if (@object.situation == 'A')
            {
                situacaoComboBox.SelectedIndex = 0;
            }
            else situacaoComboBox.SelectedIndex = 1;
            operacaoComboBox.SelectedIndex = 1;
        }
        //Ação de click em botão de Editar Ticket
        //Utiliza controller de Ticket para editão o objeto
        //em questão passando as novas informações para edição, se sucesso fecha a View.
        private void concludeButton_Click(object sender, EventArgs e)
        {
            string oper = "";
            if (operacaoComboBox.SelectedIndex == 1)
            {
                oper = "SUM";
            }
            else
            {
                oper = "SUBTRACT";
            }
            if (controller.Edit(@object, quantLabel.Text, oper, situacaoComboBox.GetItemText(situacaoComboBox.SelectedIndex)[0]))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
        //Seleciona tudo no campo para facilitar preenchimento.
        private void quantLabel_Click(object sender, EventArgs e)
        {
            quantLabel.SelectAll();
        }
        //Ação de click em botão de cancelar que fecha a View.
        private void canelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
