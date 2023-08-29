using System.Runtime.CompilerServices;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers;

public class ClienteController : BaseApiController
{
    private IUnitOfWork unitofwork;
    private readonly IMapper mapper;

    public ClienteController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitofwork = unitOfWork;
        this.mapper = mapper;
    }

    public IUnitOfWork UnitOfWork { get; }

    [HttpGet]
    //[MapToApiVersion("1.1")]//
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<ClienteDto>>> Get()
    {
        var clientes = await unitofwork.Clientes.GetAllAsync();
        return mapper.Map<List<ClienteDto>>(clientes);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ClienteDto>> Get(int id)
    {
        var cliente = await unitofwork.Clientes.GetByIdAsync(id);
        return mapper.Map<ClienteDto>(cliente);
    }

    
    //Post Normal que muestra todos los datos

    // [HttpPost]
    // [ProducesResponseType(StatusCodes.Status200OK)]
    // [ProducesResponseType(StatusCodes.Status400BadRequest)]
    // public async Task<ActionResult<Cliente>> Post(Cliente cliente)
    // {
    //     unitofwork.Clientes.Add(cliente);
    //     await unitofwork.SaveAsync();
    //     if (cliente == null){
    //         return BadRequest();
    //     }
    //     return CreatedAtAction(nameof(Post), new { id = cliente.Id }, cliente);
    // }



    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Cliente>> Post(ClienteDto clienteDto)
    {
        var cliente = this.mapper.Map<Cliente>(clienteDto);
        this.unitofwork.Clientes.Add(cliente);
        await UnitOfWork.SaveAsync();

        if (cliente == null){
            return BadRequest();
        }
        clienteDto.Id = cliente.Id;
        return CreatedAtAction(nameof(Post), new {id = clienteDto.Id}, clienteDto); 
    }


    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<ClienteDto>> Put(int id, [FromBody]ClienteDto clienteDto){
        if(clienteDto == null)
            return NotFound();

        var cliente = this.mapper.Map<Cliente>(clienteDto);
        unitofwork.Clientes.Update(cliente);
        await unitofwork.SaveAsync();
        return clienteDto;
    }


    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<IActionResult> Delete (int id){
        var cliente = await unitofwork.Clientes.GetByIdAsync(id);
        if(cliente == null)
            return NotFound();
        
        unitofwork.Clientes.Remove(cliente);
        await unitofwork.SaveAsync();
        return NoContent();    }

}
