using Cadastro.Command.Contracts;
using Cadastro.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AlunoController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public void CadastrarAluno([FromBody]CadastrarAlunoCommand request)
        {
            string mensagem = _mediator.Send(request).Result;
            Console.WriteLine(mensagem);
        }
        [HttpGet]
        public async Task<ActionResult> RetornarAlunos()
        {
            return Ok( await _mediator.Send(new RetornarAlunosResponse()));
        }
    }
}
