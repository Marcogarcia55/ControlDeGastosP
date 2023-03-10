using Microsoft.AspNetCore.Mvc;
using Control.FP.Core.Entities;
using Control.FP.Core.Http;
using Control.FP.Api.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Control.FP.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DireccionDescriptionController : ControllerBase
    {
        private readonly IDireccionDescriptionRepository _direccionDescriptionRepository;

        public DireccionDescriptionController(IDireccionDescriptionRepository direccionDescriptionRepository)
        {
            _direccionDescriptionRepository = direccionDescriptionRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Response<List<DireccionDescription>>>> GetAll()
        {
            var direccion = await _direccionDescriptionRepository.GetAllAsync();
            var response = new Response<List<DireccionDescription>>();
            response.Data = direccion;

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<Response<DireccionDescription>>> Post([FromBody] DireccionDescription direccion)
        {
            
            direccion = await _direccionDescriptionRepository.SaveAsync(direccion);
            var response = new Response<DireccionDescription>();
            response.Data = direccion;

            return Created($"/api/[controller]/{direccion.Id}", response);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Response<DireccionDescription>>> GetByID(int id)
        {
            var direccion = await _direccionDescriptionRepository.GetById(id);
            var response = new Response<DireccionDescription>();
            response.Data = direccion;

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<Response<DireccionDescription>>> Update([FromBody] DireccionDescription direccion)
        {
            var result = await _direccionDescriptionRepository.UpdateAsync(direccion);
            var response = new Response<DireccionDescription>{Data = result};

            return Ok(response);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Response<bool>>> Delete(int id)
        {
            var deleted = await _direccionDescriptionRepository.DeleteAsync(id);

            return Ok(new Response<bool> {Data = deleted });
        }
    }
}
