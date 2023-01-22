using Contatos.Application.Commands.CreatePessoa;
using Contatos.Application.Commands.DeletePessoa;
using Contatos.Application.Commands.UpdatePessoa;
using Contatos.Application.Queries.GetAllPessoas;
using Contatos.Application.Queries.GetPessoaById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Contatos.Api.Controllers
{
  [Route("api/pessoa")]
  [ApiController]
  public class PessoaController : ControllerBase
  {
    private readonly IMediator _mediator;
    public PessoaController(IMediator mediator)
    {
      _mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var query = new GetAllPessoasQuery();
      var getAllPessoas = await _mediator.Send(query);

      return Ok(getAllPessoas);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById(int Id)
    {
      var query = new GetPessoaByIdQuery(Id);
      var pessoa = await _mediator.Send(query);
      if (pessoa == null)
      {
        return NotFound();
      }
      return Ok(pessoa);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreatePessoaCommand command)
    {
      var id = await _mediator.Send(command);
      return CreatedAtAction(nameof(GetById), new { id = id }, command);
    }
    [HttpPut]
    public async Task<IActionResult> Put(int id, [FromBody] UpdatePessoaCommand command)
    {
      await _mediator.Send(command);
      return NoContent();
    }
    [HttpDelete]
    public async Task<IActionResult> Delete(int Id)
    {
      var command = new DeletePessoaCommand(Id);
      await _mediator.Send(command);
      return NoContent();
    }
  }
}