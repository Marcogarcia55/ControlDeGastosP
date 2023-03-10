using System.Collections.Immutable;
using Microsoft.AspNetCore.Mvc;
using Control.FP.Core.Entities;
using Control.FP.Core.Http;
using Control.FP.Api.Repositories.Interfaces;

namespace Control.FP.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class IngresoDescriptionController : ControllerBase
{
    private readonly IIngresoDescriptionRepository _ingresoDescriptionRepository;

    public IngresoDescriptionController(IIngresoDescriptionRepository ingresoDescriptionRepository)
    {
        _ingresoDescriptionRepository = ingresoDescriptionRepository;
    }
    
    

    [HttpGet]
    public async Task <ActionResult<Response<List<IngresosDescription>>>> GetAll()
    {
        var ingresos = await _ingresoDescriptionRepository.GetAllAsync();
        var response = new Response<List<IngresosDescription>>();
        response.Data = ingresos;

        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<Response<IngresosDescription>>> Post([FromBody] IngresosDescription ingreso)
    {
        ingreso = await _ingresoDescriptionRepository.SaveAsync(ingreso);
        var response = new Response<IngresosDescription>();
        response.Data = ingreso;
        
        return Created($"/api/[controller]/{ingreso.Id}", response);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<IngresosDescription>>> GetByID(int id)
    {
        var ingreso = await _ingresoDescriptionRepository.GetById(id);
        var response = new Response<IngresosDescription>();
        response.Data = ingreso;

        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<Response<IngresosDescription>>> Update([FromBody] IngresosDescription ingreso)
    {
        var result = await _ingresoDescriptionRepository.UpdateAsync(ingreso);
        var response = new Response<IngresosDescription>{Data = result};
        

        return Ok(response);
    }
    
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<bool>>> Delete(int id)
    {
        var ingreso = await _ingresoDescriptionRepository.DeleteAsync(id);
        
        return Ok(ingreso);
    }
}