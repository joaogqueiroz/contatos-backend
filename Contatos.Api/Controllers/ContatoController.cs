using Contatos.Application.Commands.CreateContato;
using Contatos.Application.Commands.DeleteContato;
using Contatos.Application.Commands.UpdateContato;
using Contatos.Application.Queries.GetAllContatos;
using Contatos.Application.Queries.GetContatoById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Contatos.Api.Controllers
{
  [Route("api/contato")]
  [ApiController]
  public class ContatoController : ControllerBase
  {
    private readonly IMediator _mediator;
    public ContatoController(IMediator mediator)
    {
      _mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var query = new GetAllContatosQuery();
      var getAllContatos = await _mediator.Send(query);

      return Ok(getAllContatos);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById(int Id)
    {
      var query = new GetContatoByIdQuery(Id);
      var contato = await _mediator.Send(query);
      if (contato == null)
      {
        return NotFound();
      }
      return Ok(contato);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateContatoCommand command)
    {
      var id = await _mediator.Send(command);
      return CreatedAtAction(nameof(GetById), new { id = id }, command);
    }
    [HttpPut]
    public async Task<IActionResult> Put(int id, [FromBody] UpdateContatoCommand command)
    {
      await _mediator.Send(command);
      return NoContent();
    }
    [HttpDelete]
    public async Task<IActionResult> Delete(int Id)
    {
      var command = new DeleteContatoCommand(Id);
      await _mediator.Send(command);
      return NoContent();
    }
  }
}