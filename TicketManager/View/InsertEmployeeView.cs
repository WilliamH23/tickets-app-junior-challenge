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
using TicketManager.View;
using static System.Net.Mime.MediaTypeNames;


namespace TicketManager.View
{
    public partial class InsertEmployeeView : Form
    {
        private readonly ControllerEmployee controllerEmp = new();
        private readonly ControllerTicket controllerTic = new();
        public InsertEmployeeView()
        {
            InitializeComponent();

        }

        private void canelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void concludeButton_Click_1(object sender, EventArgs e)
        {
            if (controllerEmp.Insert(nameEmployeeLabel.Text, cpfLabel.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                if (controllerTic.Insert(controllerEmp.GetLastInsertedEmployee(), ticketsQuantLabel.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

        }

        private void nameEmployeeLabel_Click(object sender, EventArgs e)
        {
            nameEmployeeLabel.SelectAll();
        }

        private void cpfLabel_Click(object sender, EventArgs e)
        {
            cpfLabel.SelectAll();
        }

        private void ticketsQuantLabel_Click(object sender, EventArgs e)
        {
            ticketsQuantLabel.SelectAll();
        }
    }
}
