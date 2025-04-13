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
using TicketManager.Domian;

namespace TicketManager.View
{
    public partial class EditEmployeesView : Form
    {
        private readonly ControllerEmployee controller = new();
        private readonly Domian.Employee @object;
        public EditEmployeesView(Domian.Employee @object)
        {
            InitializeComponent();
            this.@object = @object;

            Fill();

        }

        private void Fill()
        {
            nameEmployeeLabel.Text = @object.name;
            cpfLabel.Text = @object.cpf;
            if (@object.situation == 'A')
            {
                situacaoComboBox.SelectedIndex = 0;
            }
            else situacaoComboBox.SelectedIndex = 1;

        }

        private void ticketsNumberText_TextChanged(object sender, EventArgs e)
        {

        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            if (controller.Edit(@object, nameEmployeeLabel.Text, cpfLabel.Text, situation: situacaoComboBox.GetItemText(situacaoComboBox.SelectedIndex)[0]))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void canelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameEmployeeLabel_Click(object sender, EventArgs e)
        {
            nameEmployeeLabel.SelectAll();
        }

        private void cpfLabel_Click(object sender, EventArgs e)
        {
            cpfLabel.SelectAll();
        }
    }
}
