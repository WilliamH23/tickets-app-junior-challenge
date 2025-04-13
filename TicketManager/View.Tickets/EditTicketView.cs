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
        private readonly ControllerTicket controller = new();
        private readonly Ticket @object;
        public EditTicketView(Ticket @object)
        {
            InitializeComponent();
            this.@object = @object;
            Fill();
        }
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
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        private void quantLabel_Click(object sender, EventArgs e)
        {
            quantLabel.SelectAll();
        }
    }
}
