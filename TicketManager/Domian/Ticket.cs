using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManager.Domian
{
    public class Ticket
    {
        [Key]
        public int id { get; set; }
        public  long employeeId { get; set; } 
        public int quantity { get; set; }
        public char situation { get; set; } 
        public DateTime dateEdit{ get; set; }

        public Ticket() { 
        
        }
        public Ticket(Employee employee, int quantity)
        {
            if (employee.situation == 'I')
                throw new InvalidOperationException("Não é possível " +
                    "adicionar tickets a um colaborador inativo.");
            this.employeeId = employee.id;
            this.quantity = quantity;
            situation = 'A';

            dateEdit = DateTime.Now;
        }
    }
}
