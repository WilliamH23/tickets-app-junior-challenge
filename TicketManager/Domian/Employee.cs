using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManager.Domian
{
    public class Employee
    {
        [Key]
        public long id { get; set; }
        public string name { get; set; }
        public string cpf { get; set; }
        public char situation { get; set; }
        public DateTime DateEdit { get; set; }
        public Employee() { }
        public Employee(string name, string cpf)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Nome é obrigatório.");
            if (cpf.Length != 11) throw new ArgumentException("O CPF deve ter 11 caracteres.");
            this.name = name;
            this.cpf = cpf;
            situation = 'A';
            DateEdit = DateTime.Now;
        }
    }
}
