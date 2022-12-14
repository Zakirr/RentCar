using Business.Abstract;
using Castle.Core;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {

        static IWebHostEnvironment _webHostEnvironment;
        ICarImagesService _cm;

        public CarImagesController(IWebHostEnvironment webHostEnvironment, ICarImagesService cm)
        {
            _webHostEnvironment = webHostEnvironment;
            _cm = cm;
        }

        [HttpPost("upload")]
        public IActionResult Upload([FromForm] CarImages obj)
        {

            var result = _cm.Add(obj, @"C:\Users\Zakir\source\repos\RentCar\Melumatlar\Images\");

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete([FromForm] CarImages images)
        {

            var result = _cm.Delete(images);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update([FromForm] CarImages images)
        {
            var result = _cm.Update(images, @"C:\Users\Zakir\source\repos\RentCar\Melumatlar\Images\");

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
