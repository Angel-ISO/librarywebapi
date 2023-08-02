using Aplicacion.Paises;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DinoApi.Controllers;
public class PaisController : BaseApiController
{
    private readonly IMediator mediator;

    public PaisController(IMediator _mediator){
        mediator = _mediator;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<Pais>>> Get()
    {
        return await mediator.Send(new Consultas.ListaPais());
    }
}