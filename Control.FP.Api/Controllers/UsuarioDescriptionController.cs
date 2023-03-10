using System.Collections.Immutable;
using Microsoft.AspNetCore.Mvc;
using Control.FP.Core.Entities;
using Control.FP.Core.Http;
using Control.FP.Api.Repositories.Interfaces;

namespace Control.FP.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class UsuarioDescriptionController : ControllerBase
{
    private readonly IUsuarioDescriptionRepository _usuarioDescriptionRepository;

    public UsuarioDescriptionController(IUsuarioDescriptionRepository usuarioDescriptionRepository)
    {
        _usuarioDescriptionRepository = usuarioDescriptionRepository;
    }
    
    

    [HttpGet]
    public async Task <ActionResult<Response<List<UsuarioDescription>>>> GetAll()
    {
        var usuarios = await _usuarioDescriptionRepository.GetAllAsync();
        var response = new Response<List<UsuarioDescription>>();
        response.Data = usuarios;

        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<Response<UsuarioDescription>>> Post([FromBody] UsuarioDescription usuario)
    {
        usuario = await _usuarioDescriptionRepository.SaveAsync(usuario);
        var response = new Response<UsuarioDescription>();
        response.Data = usuario;
        
        return Created($"/api/[controller]/{usuario.Id}", response);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<UsuarioDescription>>> GetByID(int id)
    {
        var usuario = await _usuarioDescriptionRepository.GetById(id);
        var response = new Response<UsuarioDescription>();
        response.Data = usuario;

        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<Response<UsuarioDescription>>> Update([FromBody] UsuarioDescription usuario)
    {
        var result = await _usuarioDescriptionRepository.UpdateAsync(usuario);
        var response = new Response<UsuarioDescription>{Data = result};
        

        return Ok(response);
    }
    
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<bool>>> Delete(int id)
    {
        var usuario = await _usuarioDescriptionRepository.DeleteAsync(id);
        
        return Ok(usuario);
    }
}