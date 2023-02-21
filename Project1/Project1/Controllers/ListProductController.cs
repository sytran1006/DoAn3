using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Interface;
using Project1.Models;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListProductController : ControllerBase
    {
        private readonly IListProductService _ilistproductservice;
        public ListProductController(IListProductService ilistproductservice)
        {
            _ilistproductservice = ilistproductservice;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                return Ok(await _ilistproductservice.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ListProduct>> GetItem(int id)
        {
            try
            {
                var result = await _ilistproductservice.GetItem(id);

                if (result == null) return NotFound();

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<ListProduct>> Update(int id, [FromForm] ListProduct listproduct)
        {
            try
            {
                if (id != listproduct.id)
                {
                    return BadRequest("Employee ID mismatch");
                }

                var result = await _ilistproductservice.GetItem(id);

                if (result == null)
                    return NotFound($"Employee with Id = {id} not found");
                return await _ilistproductservice.Update(listproduct);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }
        [HttpPost]
        public async Task<ActionResult<List<ListProduct>>> Add( [FromForm]ListProduct listproduct)
        {
            try
            {
                return Ok(await _ilistproductservice.Add(listproduct));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ListProduct>>> Delete(int id)
        {
            try
            {
                var result = await _ilistproductservice.Delete(id);
                if (result == null)
                    return BadRequest("Announ not found.");
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }
    }
}
