using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketManager.ControllerDomain;
using TicketManager.Domian;

namespace TicketManager.View.Tickets
{
    public partial class InsertTicketView : Form
    {
        private readonly ControllerTicket controllerTic = new();
        private Domian.Employee @object;
        public InsertTicketView(Domian.Employee employee)
        {
            InitializeComponent();
            @object = employee;
        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            if (controllerTic.Insert(@object, quantLabel.Text)) ;
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void canelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quantLabel_Click(object sender, EventArgs e)
        {
            quantLabel.SelectAll();
        }
    }
}
