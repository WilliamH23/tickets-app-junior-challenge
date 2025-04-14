using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManager.Domian
{
    //Criação do objeto Ticket e propriedades do objeto.
    public class Ticket
    {
        [Key]
        public int id { get; set; }//Chave primeira autoincrementada(Nunca é a mesma)
        public  long employeeId { get; set; }//Id do colaborador para identifica a qual dos cadastrados
                                             //o ticket pertence. 
        public int quantity { get; set; }//Quantidade do ticket
        public char situation { get; set; }//Um status de I ou A para diferenciar
        public DateTime dateEdit{ get; set; }//campo que registra a ultima alteração realizada.
        
        //Contrutores do objeto. 
        public Ticket() { 
        
        }
        public Ticket(Employee employee, int quantity)
        {
            this.employeeId = employee.id;
            this.quantity = quantity;
            situation = 'A';//Sempre A - (Ativo) é preestabelecido na sua criação
            dateEdit = DateTime.Now;//Registro da data de alteração.
        }
    }
}
