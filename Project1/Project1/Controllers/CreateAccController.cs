using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Interface;
using Project1.Models;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateAccController : ControllerBase
    {
        private readonly ICreateAccService _icreateaccservice;
        public CreateAccController(ICreateAccService icreateaccservice)
        {
            _icreateaccservice = icreateaccservice;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                return Ok(await _icreateaccservice.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<CreateAcc>> GetItem(int id)
        {
            try
            {
                var result = await _icreateaccservice.GetItem(id);

                if (result == null) return NotFound();

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        // PUT: api/News/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]

        // POST: api/News
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<List<CreateAcc>>> Add([FromForm] CreateAcc createacc)
        {
            try
            {
                return Ok(await _icreateaccservice.Add(createacc));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }
    }
}
