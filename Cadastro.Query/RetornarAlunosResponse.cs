using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Query
{
    public class RetornarAlunosResponse:IRequest<IEnumerable<RetornarAlunosResponse>> 
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
