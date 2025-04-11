using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManager.Context;
using TicketManager.Domian;

namespace TicketManager.ControllerDomain
{
    public class ControllerTicket
    {
        private readonly TicketManagerContext context;
        public ControllerTicket()
        {
            context = new TicketManagerContext();
        }
        public bool Insert(Domian.Employee employee, String quant )
        {
        if(!int.TryParse(quant,out int intQuant)){
            throw new ArgumentException("Preencha corretamente a quantidade!");
            }
            var @object = new Ticket(employee,intQuant);
            context.Tickets.Add(@object);
            context.SaveChanges();
            return true;
        }

        public int Contar()
        {
            return context.Employees.Count();
        }

        public bool Edit(Ticket @object, String quantOperation, string operation, char situation)
        {
            if (!int.TryParse(quantOperation, out int intQuantOparation))
            {
                throw new ArgumentException("Preencha corretamente a quantidade!");
            }
            if (operation == "SUM")
            {
                @object.quantity += intQuantOparation;
            }
            else {
                if (@object.quantity - intQuantOparation >= 0)
                {
                    @object.quantity -= intQuantOparation;
                }
            }
            if (situation == '0')
            {
                @object.situation = 'A';
            }
            if (situation == '1')
            {
                @object.situation = 'I';
            }
            @object.dateEdit =  DateTime.Now;
            try
            {
                context.Tickets.Update(@object);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar o Ticket!\n" + ex.Message);
                return false;
            }
        }
    }
}

