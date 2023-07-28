using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using ZstdSharp.Unsafe;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateController : ControllerBase
    {
        private readonly IEstateService _stateService;

        public EstateController(IEstateService stateService)
        {
            _stateService = stateService;
        }

        [HttpGet("getEstateList")]
        public async Task<IActionResult> Index()
        {
            var estates=await _stateService.GetAllAsync();
            return Ok(estates);

         }

        [HttpPost("addEstate")]
        public async Task<IActionResult> AddEstate(Estate estate)
        {
            await _stateService.CreateAsync(estate);
            return Ok();
        }

        [HttpDelete("deleteEstate/{id}")]
        public async Task<IActionResult> DeleteEstate(string id)
        {
            await _stateService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("updateEstate")]
        public async Task<IActionResult> UpdateEstate(Estate estate,string id)
        {
            estate.Id = new ObjectId(id);
            await _stateService.UpdateAsync(estate,estate.Id.ToString());
            return Ok();
        }





    }
}
