using Girilenler.Concrete;
using Idareetme.Abstract;
using Idareetme.Concrete;
using Melumatlar.Concrete.EfCarData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        IRentCarManager _irentCarManager;

        public CarsController(IRentCarManager irentCarManager)
        {
            _irentCarManager = irentCarManager;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _irentCarManager.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {

            var result = _irentCarManager.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getbybrandid")]
        public IActionResult GetByBrandId(int id)
        {

            var result = _irentCarManager.GetCarsByBrandID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getbycolorid")]
        public IActionResult GetByColorId(int id)
        {

            var result = _irentCarManager.GetCarsByColorID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {

            var result = _irentCarManager.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(Car car)
        {

            var result = _irentCarManager.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {

            var result = _irentCarManager.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }




    }
}
