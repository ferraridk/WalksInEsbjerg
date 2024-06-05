using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WalksInEsbjerg.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "James", "Gert", "Alba", "Mario", "Claus", "Julie" };
            return Ok(studentNames);

        }
    }
}
