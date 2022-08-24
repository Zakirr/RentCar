using Business.Abstract;
using Girilenler.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IRentColorManager _irentColorManager;

        public ColorsController(IRentColorManager irentColorManager)
        {
            _irentColorManager = irentColorManager;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _irentColorManager.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {

            var result = _irentColorManager.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }



        [HttpPost("add")]
        public IActionResult Add(Color color)
        {

            var result = _irentColorManager.Add(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(Color color)
        {

            var result = _irentColorManager.Update(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Color color)
        {

            var result = _irentColorManager.Delete(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
