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
        //Controladores dos dois objetos do sistema.
        private readonly ControllerEmployee controllerEmp = new();
        private readonly ControllerTicket controllerTic = new();
        public InsertEmployeeView()//Inicializa a tela.
        {
            InitializeComponent();

        }
        //Ação de click em botão de cancellar a inserção de colaborador.
        private void canelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Ação de click em botão de concluir.
        //Se inserção foi bem sucedida fecha a tela.
        //Já passa a inserção de um primeiro Ticket do colaborador.
        private void concludeButton_Click(object sender, EventArgs e)
        {
            if (controllerEmp.Insert(nameEmployeeLabel.Text, cpfEmployeeLabel.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                if (controllerTic.Insert(controllerEmp.GetLastInsertedEmployee(), ticketsQuantLabel.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falha ao atribuir Ticket ao Colaborador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Falha ao inserir Colaborador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        //Seleção de todo o campo para acelerar o processo de inserção de dados,
        //durante a criação do colaborador.
        private void nameEmployeeLabel_Click(object sender, EventArgs e)
        {
            nameEmployeeLabel.SelectAll();
        }

        private void cpfLabel_Click(object sender, EventArgs e)
        {
            cpfEmployeeLabel.SelectAll();
        }

        private void ticketsQuantLabel_Click(object sender, EventArgs e)
        {
            ticketsQuantLabel.SelectAll();
        }

        private void canelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
