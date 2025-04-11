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
        private void reTable()
        {

            fullList = context.Employees.ToList();
            dataGridEmployees.DataSource = null;
            dataGridEmployees.DataSource = fullList;
        
            setColumn();

        }
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
            dataGridEmployees.Columns["cpf"].DefaultCellStyle.Format = "@\"000\\.000\\.000\\-00\"";
            dataGridEmployees.DefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
        }
        private void insertButton_Click(object sender, EventArgs e)
        {
            InsertEmployeeView insertEmployeeView = new InsertEmployeeView();
            if (insertEmployeeView.ShowDialog() == DialogResult.OK)
            {
                reTable();
            }
        }

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

        private void findEmployeesTextBox_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }
    }
}
