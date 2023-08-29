using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers;

public class ClienteController : BaseApiController
{
    private IUnitOfWork unitofwork;

    public ClienteController(IUnitOfWork unitOfWork)
    {
        this.unitofwork = unitOfWork;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Cliente>>> Get()
    {
        var clientes = await unitofwork.Clientes.GetAllAsync();
        return Ok(clientes);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Cliente>> Get(int id)
    {
        var cliente = await unitofwork.Clientes.GetByIdAsync(id);
        return Ok(cliente);
    }

    

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Cliente>> Post(Cliente cliente)
    {
        unitofwork.Clientes.Add(cliente);
        await unitofwork.SaveAsync();
        if (cliente == null){
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new { id = cliente.Id }, cliente);
    }

}
