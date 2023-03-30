using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.CommandStore
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        public string Matricula { get; set; } = "";
        public Pessoa Pessoa { get; set; } = new Pessoa();
    }
}
