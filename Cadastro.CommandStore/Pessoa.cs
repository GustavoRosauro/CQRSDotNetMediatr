using System.ComponentModel.DataAnnotations;

namespace Cadastro.CommandStore
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public int Idade { get; set; }
    }
}