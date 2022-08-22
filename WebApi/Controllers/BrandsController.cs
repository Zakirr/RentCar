using Business.Abstract;
using Girilenler.Concrete;
using Idareetme.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IRentBrandManager _irentBrandManager;

        public BrandsController(IRentBrandManager irentBrandManager)
        {
            _irentBrandManager = irentBrandManager;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _irentBrandManager.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {

            var result = _irentBrandManager.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
     
      
        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {

            var result = _irentBrandManager.Add(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(Brand brand)
        {

            var result = _irentBrandManager.Update(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Brand brand)
        {

            var result = _irentBrandManager.Delete(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
