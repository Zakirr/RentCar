//using Business.Concrete;
//using DataAcces.Concrete.EfData;
//using Entities.Concrete;
//using Melumatlar.Abstract;
//using Melumatlar.Concrete.EfCarData;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace WebApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CarImagesController : ControllerBase
//    {
//        CarImagesManager _carImagesManager =new CarImagesManager(new EfCarImagesData());



//        [HttpPost]

//        public IActionResult Upload(CarImages carimages, [FromForm] IFormFile file)
//        {
//            var result = _carImagesManager.Add(carimages,file);
//            {
//                if (result.Success)
//                {
//                    return Ok(result);
//                }
//                return BadRequest(result);
//            }
//        }
//    }
//}
