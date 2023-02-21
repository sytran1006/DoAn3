using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Interface;
using Project1.Models;
using Project1.Service;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductPopularController : ControllerBase
    {
        private readonly IProductPopularService _iproductpopularservice;
        private static IWebHostEnvironment _webHostEnvironment;
        public ProductPopularController(IProductPopularService iproductpopularservice, IWebHostEnvironment webHostEnvironment)
        {
            _iproductpopularservice = iproductpopularservice;
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                return Ok(await _iproductpopularservice.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductPopular>> GetItem(int id)
        {
            try
            {
                var result = await _iproductpopularservice.GetItem(id);

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
        public async Task<ActionResult<ProductPopular>> Update(int id, [FromForm] ProductPopular productpopular)
        {
            try
            {
                if (id != productpopular.id)
                {
                    return BadRequest("Employee ID mismatch");
                }

                var result = await _iproductpopularservice.GetItem(id);

                if (result == null)
                    return NotFound($"Employee with Id = {id} not found");
                return await _iproductpopularservice.Update(productpopular);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

        // POST: api/News
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<List<ProductPopular>>> Add([FromForm] int id, [FromForm] string title, [FromForm] ProductPopularImg img,
            [FromForm] string color, [FromForm] string size, [FromForm] string createdAt)
        {
            try
            {
                if(img.files.Length> 0)
                {
                    string path= _webHostEnvironment.WebRootPath+ "//img//";
                    if(Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream filestream= System.IO.File.Create(path + img.files.FileName)) {
                        img.files.CopyTo(filestream);
                        filestream.Flush();
                    }
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                       "false");
                }
                ProductPopular result = new ProductPopular();
                result.id = id;
                result.title = title;
                result.img = img.files.FileName;
                result.color = color;
                result.size = size;
                result.createdAt = createdAt;
                try
                {
                    return Ok(await _iproductpopularservice.Add(result));
                }
                catch (Exception)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        "hcl");
                }
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error creating new employee record");
            }
        }

        // DELETE: api/News/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ProductPopular>>> Delete(int id)
        {
            try
            {
                var result = await _iproductpopularservice.Delete(id);
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
