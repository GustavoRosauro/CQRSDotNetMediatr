using Cadastro.Command.Contracts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PessoaController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public void CadastrarPessoa([FromBody]CadastrarCommand request)
        {
            string mensagem = _mediator.Send(request).Result;
            Console.WriteLine(mensagem);
        }
    }
}
