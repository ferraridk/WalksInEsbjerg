using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalksInEsbjerg.API.Data;
using WalksInEsbjerg.API.Models.Domain;

namespace WalksInEsbjerg.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly WalksInEsbjergDbContext dbContext;

        public RegionsController(WalksInEsbjergDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = dbContext.Regions.ToList();

            return Ok(regions);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var region = dbContext.Regions.FirstOrDefault(x => x.Id == id);

            if (region == null)
            {
                return NotFound();
            }
            return Ok(region);
        }
    }
}
