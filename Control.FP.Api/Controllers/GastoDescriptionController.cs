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
    public class GastoDescriptionController : ControllerBase
    {
        private readonly IGastoDescriptionRepository _gastoDescriptionRepository;

        public GastoDescriptionController(IGastoDescriptionRepository gastoDescriptionRepository)
        {
            _gastoDescriptionRepository = gastoDescriptionRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Response<List<GastoDescription>>>> GetAll()
        {
            var gastos = await _gastoDescriptionRepository.GetAllAsync();
            var response = new Response<List<GastoDescription>>();
            response.Data = gastos;

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<Response<GastoDescription>>> Post([FromBody] GastoDescription gasto)
        {
            
            gasto = await _gastoDescriptionRepository.SaveAsync(gasto);
            var response = new Response<GastoDescription>();
            response.Data = gasto;

            return Created($"/api/[controller]/{gasto.Id}", response);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Response<GastoDescription>>> GetByID(int id)
        {
            var gasto = await _gastoDescriptionRepository.GetById(id);
            var response = new Response<GastoDescription>();
            response.Data = gasto;

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<Response<GastoDescription>>> Update([FromBody] GastoDescription gasto)
        {
            var result = await _gastoDescriptionRepository.UpdateAsync(gasto);
            var response = new Response<GastoDescription>{Data = result};

            return Ok(response);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Response<bool>>> Delete(int id)
        {
            var deleted = await _gastoDescriptionRepository.DeleteAsync(id);

            return Ok(new Response<bool> {Data = deleted });
        }
    }
}
