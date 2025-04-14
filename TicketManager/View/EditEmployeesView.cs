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
        //Controller dos colaboradores e declaração de uma variavel tipo employee,
        //para armazenar o colaborador selecionado na Tabela de Employee.View.
        private readonly ControllerEmployee controller = new();
        private readonly Employee @object;
        //Inicializa a tela, armazena o Colaborador a manipulado e chama uma função que preenche
        //as informações do mesmo.
        public EditEmployeesView(Employee @object)
        {
            InitializeComponent();
            this.@object = @object;
            Fill();
        }
        //Rotina de carregamento de informações do objeto(Employee) em questão.
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
        //Solicita ao controller do Colaborador a edição do Objeto
        //em questao, passando como parametros ele e as novas propriedaes para atualizacao. 

        private void concludeButton_Click(object sender, EventArgs e)
        {
            if (controller.Edit(@object, nameEmployeeLabel.Text, cpfLabel.Text, situation: situacaoComboBox.GetItemText(situacaoComboBox.SelectedIndex)[0]))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        //Ação de click de botão de cancelar(Fecha a tela).
        private void canelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Seleção de todo o campo para acelerar o processo de inserção de dados,
        //durante a criação do colaborador.
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
