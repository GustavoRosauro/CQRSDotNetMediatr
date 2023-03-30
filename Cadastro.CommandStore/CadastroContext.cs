using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.CommandStore
{
    public class CadastroContext:DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext> options) : base(options) { }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
    }
}
