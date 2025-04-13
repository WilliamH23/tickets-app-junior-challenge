using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using TicketManager.Context;
using TicketManager.Domian;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TicketManager.Controller
{
    public class ControllerEmployee
    {
        private readonly TicketManagerContext context;
        public ControllerEmployee()
        {
            context = new TicketManagerContext();
        }
        public bool Insert(string name, string cpf)
        {
            if (IsCpfAlreadyRegistered(name))
            {
                MessageBox.Show("CPF já cadastrado!");
                return false;
            }
            if (name== "Nome do colaborador" || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Favor preencher o nome do Colaborador.");
                return false;
            }
            var @object = new Employee(name, cpf);
            context.Employees.Add(@object);
            context.SaveChanges();
            return true;
        }
        public bool IsCpfAlreadyRegistered(string cpf)
        {
            var existingEmployee = context.Employees.FirstOrDefault(e => e.cpf == cpf);
            return existingEmployee != null;
        }

        public Employee GetLastInsertedEmployee()
        {
            return context.Employees
                .OrderByDescending(e => e.id)
                .FirstOrDefault();
        }
        public bool Edit(Employee @object, string name, string cpf, char situation)
        {
            if (string.IsNullOrWhiteSpace(name)){
                MessageBox.Show("Favor preencher o nome do Colaborador.");
                return false;
            }
            @object.name = name;
            @object.cpf = cpf;
            if (situation == '0') {
                @object.situation = 'A';
            }
            if (situation == '1')
            {
                @object.situation = 'I';
            }
            @object.DateEdit = DateTime.Now;
            try
            {
                context.Employees.Update(@object);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar o Colaborador!\n" + ex.Message);
                return false;
            }
        }
    }
}
