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
        public bool Insert(Employee employee, String quantity )
        {

            if (!int.TryParse(quantity,out int intQuantity)){
                MessageBox.Show("Preencha corretamente a quantidade!");
                return false;
            }
            var @object = new Ticket(employee,intQuantity);
            context.Tickets.Add(@object);
            context.SaveChanges();
            return true;
        }
        public bool Edit(Ticket @object, String quantityOperation, string operation, char situation)
        {
            if (@object.situation == 'I')
            {
                MessageBox.Show("Erro ao editar o Ticket!\nColaborador com situação I - Inativo");
                return false;
            }
            if (!int.TryParse(quantityOperation, out int intQuantOparation))
            {
                throw new ArgumentException("Preencha corretamente a quantidade!");
            }
            if (operation == "SUM")
            {
                @object.quantity += intQuantOparation;
            }else {
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

