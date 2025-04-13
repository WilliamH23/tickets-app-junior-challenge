using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketManager.Context;
using TicketManager.Domian;
using TicketManager.View.Tickets;

namespace TicketManager.View
{
    public partial class TicketsView : Form
    {

        private TicketManagerContext context;
        private Domian.Employee @object;
        private List<Ticket> fullTicketsList;
        private List<Ticket> listaFiltrada;

        public TicketsView(Domian.Employee employee)
        {
            InitializeComponent();
            context = new TicketManagerContext();
            @object = employee;
            fill();
        }

        private void fill()
        {

            fullTicketsList = context.Tickets
                .Where(t => t.employeeId == @object.id)
                .ToList();

            dataGridTickets.DataSource = null;
            dataGridTickets.DataSource = fullTicketsList;
            listaFiltrada = fullTicketsList;
            employeeLabel.Text = @object.name;

            setColumn();
        }

        private void setColumn()
        {
            dataGridTickets.Columns["Id"].HeaderText = "Identificador(codigo do ticket):";
            dataGridTickets.Columns["Quantity"].HeaderText = "Quantidade:";
            dataGridTickets.Columns["Situation"].HeaderText = "Situação:";
            dataGridTickets.Columns["DateEdit"].HeaderText = "Data de Modificação";

            dataGridTickets.Columns["employeeId"].Visible = false;
            dataGridTickets.Columns["dateEdit"].Visible = false;


            dataGridTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridTickets.Columns["Id"].FillWeight = 30;
            dataGridTickets.Columns["Quantity"].FillWeight = 30;
            dataGridTickets.Columns["Situation"].FillWeight = 30;
            dataGridTickets.Columns["DateEdit"].FillWeight = 40;

            dataGridTickets.DefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
        }



        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddTickets_Load(object sender, EventArgs e)
        {

        }

        private void nomeEmployee_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (@object.situation == 'A')
            {
                InsertTicketView insertTicketView = new InsertTicketView(@object);
                if (insertTicketView.ShowDialog() == DialogResult.OK)
                {
                    fill();
                }
            }
            else
            {
                MessageBox.Show("Não é possivel inserir ticket em Colaborador com situação 'I'- Inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridTickets.SelectedRows.Count > 0)
            {
                if (@object.situation == 'I')
                {
                    MessageBox.Show("Você esta alterando um Ticket de colaborador com situação 'I'- Inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    EditTicketView editTicketView = new EditTicketView((Ticket)dataGridTickets.SelectedRows[0].DataBoundItem);
                    if (editTicketView.ShowDialog() == DialogResult.OK)
                    {
                        fill();
                    }
                }

            }
            else
            {
                MessageBox.Show("Nenhum item selecionado.");
            }
        }

        private void filtroDataCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filterDate();
        }
        private void filterDate()
        {
            if (filtroDataCheckBox.Checked)
            {

                DateTime inicio = inicioDateTimePicker.Value.Date;
                DateTime fim = fimDateTimePicker.Value.Date.AddDays(1).AddTicks(-1);

                listaFiltrada = fullTicketsList
                    .Where(t => t.dateEdit >= inicio && t.dateEdit <= fim)
                    .ToList();
            }
            dataGridTickets.DataSource = listaFiltrada;
            setColumn();
        }
        private void filtroDataCheckBox_Click(object sender, EventArgs e)
        {
            if (filtroDataCheckBox.Checked)
            {
                inicioDateTimePicker.Visible = true;
                fimDateTimePicker.Visible = true;
                inicioDateTimePicker.Enabled = true;
                fimDateTimePicker.Enabled = true;
                dataInicialLabel.Visible = true;
                dataInicialLabel.Enabled = true;
                dataFinalLabel.Visible = true;
                dataFinalLabel.Enabled = true;
            }
            else
            {
                inicioDateTimePicker.Visible = false;
                fimDateTimePicker.Visible = false;
                inicioDateTimePicker.Enabled = false;
                fimDateTimePicker.Enabled = false;

                dataInicialLabel.Visible = false;
                dataInicialLabel.Enabled = false;
                dataFinalLabel.Visible = false;
                dataFinalLabel.Enabled = false;

            }
            filterDate();
            fill();
        }

        private void inicioDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            filterDate();
        }

        private void inicioDateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            filterDate();
        }
    }
}
