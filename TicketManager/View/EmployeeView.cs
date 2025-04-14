using System.Windows.Forms;
using TicketManager.Context;
using TicketManager.Controller;
using TicketManager.Domian;
using TicketManager.View;

namespace TicketManager
{
    public partial class EmployeeView : Form
    {
        private TicketManagerContext context;
        private List<Domian.Employee> fullList;

        public EmployeeView()
        {
            InitializeComponent();
            context = new TicketManagerContext();
            reTable();
        }
        //rotina para recarregar a tabela do Menu Colaboradores.
        private void reTable()
        {

            fullList = context.Employees.ToList();
            dataGridEmployees.DataSource = null;
            dataGridEmployees.DataSource = fullList;
        
            setColumn();

        }
        //Realiza configuração da Tabela.
        //(Como deve ser e quais propriedades de Colaboradores devem ser exibidos).
        public void setColumn()
        {
            dataGridEmployees.Columns["dateEdit"].Visible = false;


            dataGridEmployees.Columns["Id"].HeaderText = "Identificação:";
            dataGridEmployees.Columns["Name"].HeaderText = "Nome Completo:";
            dataGridEmployees.Columns["cpf"].HeaderText = "CPF:";
            dataGridEmployees.Columns["situation"].HeaderText = "Situação:";

            dataGridEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridEmployees.Columns["Id"].FillWeight = 14;
            dataGridEmployees.Columns["Name"].FillWeight = 40;
            dataGridEmployees.Columns["cpf"].FillWeight = 20;
            dataGridEmployees.Columns["situation"].FillWeight = 30;
            dataGridEmployees.DefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
        }
        //Ação de click do botão de Inserir colaborador novo na base de dados.
        //Confirma o sucesso e recarrega as informações do DB.
        private void insertButton_Click(object sender, EventArgs e)
        {
            InsertEmployeeView insertEmployeeView = new InsertEmployeeView();
            if (insertEmployeeView.ShowDialog() == DialogResult.OK)
            {
                reTable();
            }
        }
        //Ação de click do botão de Edição.
        //Verifica se algo foi selecionado e avisa o usuario se o colaborador esta com situação Inativo.
        //Confirma o sucesso da operação e recarrega a tabela.
        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridEmployees.SelectedRows.Count > 0)
            {
                Domian.Employee employeeSelected = (Domian.Employee)dataGridEmployees.SelectedRows[0].DataBoundItem;
                if (employeeSelected.situation == 'I')
                {
                    MessageBox.Show("O colaborador selecionado possui situação 'I'-Inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                EditEmployeesView editEmployees = new EditEmployeesView(employeeSelected);
                if (editEmployees.ShowDialog() == DialogResult.OK)
                {
                    reTable();
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado.");
            }
        }
        //TextBox utilizado como ferramenta de Busca no Sistema(Sempre que alterado uma nova varredura).
        private void findEmployeesTextBox_TextChanged(object sender, EventArgs employees)
        {
            var termo = findEmployeesTextBox.Text.ToLower();
            dataGridEmployees.DataSource = fullList
                .Where(employees =>
                    employees.name.ToLower().Contains(termo) ||
                    employees.cpf.ToLower().Contains(termo) ||
                    employees.situation.ToString().ToLower().Contains(termo))
                .ToList();
            setColumn();
        }
        //Se houver duplo click na tabela de Employees e algum colaborador estiver totalmente selecionado,
        //Exibe uma nova tela tela dos Tickets do colaborador em especifico(Passa o selecionado na tabela).
        private void dataGridEmployees_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridEmployees.SelectedRows.Count == 1)
            {
                Domian.Employee employeeSelected = (Domian.Employee)dataGridEmployees.SelectedRows[0].DataBoundItem;
                if (employeeSelected.situation == 'I')
                {
                    MessageBox.Show("O colaborador selecionado possui situação 'I'-Inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (employeeSelected != null)
                {
                    TicketsView ticketsView = new TicketsView(employeeSelected);
                    if (ticketsView.ShowDialog() == DialogResult.OK)
                    {
                        reTable();
                    }

                }
            }
        }
        //Ação de click em TextBox de procurar os employes,
        //Assim que o usuario digitar substitui o text informativo(Serve para limpar o campo). 
        private void findEmployeesTextBox_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
