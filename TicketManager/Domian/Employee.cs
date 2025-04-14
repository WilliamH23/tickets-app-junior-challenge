using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManager.Domian
{
    //Criação do objeto Employee e propriedades do objeto.
    public class Employee
    {
        [Key]
        public long id { get; set; }//Id do Colaborador que é Chave Primaria e tambem autoincrementada.
        public string name { get; set; }//Nome do colaborador.
        public string cpf { get; set; }//CPF do colaborador.
        public char situation { get; set; }//Situação do colaborador I - (Inativo) ou A - (Ativo).
        public DateTime DateEdit { get; set; }//Ultima data de alteração(Upgrade) do colaborador.
        //Contrutor do colaborador
        public Employee(string name, string cpf)
        {
            this.name = name;
            this.cpf = cpf;
            situation = 'A';//Situação sempre pré-estabelecida como A - (Ativo) na criação do Colaborador.
            DateEdit = DateTime.Now;
        }
    }
}
