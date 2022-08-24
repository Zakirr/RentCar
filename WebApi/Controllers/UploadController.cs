using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {

        static IWebHostEnvironment _webHostEnvironment;
        ICarImagesService _cm;

        public UploadController(IWebHostEnvironment webHostEnvironment, ICarImagesService cm)
        {
            _webHostEnvironment = webHostEnvironment;
            _cm = cm;
        }

        //[HttpPost("upload")]
        //public IActionResult Upload([FromForm] CarImages obj)
        //{

        //    var result = _cm.Add(obj, @"C:\Users\Zakir\source\repos\RentCar\Melumatlar\Images\");
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
    }
}
