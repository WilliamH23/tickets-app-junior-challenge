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
        //Controller do Ticket e criação objeto para armazenar o colaborador.
        private readonly ControllerTicket controllerTic = new();
        private Employee @object;
        //Construtor da View de inserção de tickets.
        //Recebe e armazena o colaborador .
        public InsertTicketView(Employee employee)
        {
            InitializeComponent();
            @object = employee;
        }
        //Ação de click em botão de concluir para inserir o ticket no colaborador passado como parametro
        //da View anterior(Tickets.View)
        private void concludeButton_Click(object sender, EventArgs e)
        {
            if (controllerTic.Insert(@object, quantLabel.Text)) ;
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        //Ação de botão de cancelar que fecha a View..
        private void canelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Ação de click do campo de texto gera a seleção completa dele para facilitar preenchimento.
        private void quantLabel_Click(object sender, EventArgs e)
        {
            quantLabel.SelectAll();
        }
    }
}
