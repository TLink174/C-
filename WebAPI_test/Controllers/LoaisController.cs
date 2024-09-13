using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_test.Data;
using WebAPI_test.Models;

namespace WebAPI_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaisController : ControllerBase
    {
        private readonly MyDbContext _context;

        public LoaisController(MyDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var dsloai = _context.Loais.ToList();
            return Ok(dsloai);
        }

        [HttpGet("id")]
        public IActionResult GetById(int id) 
        {
            var loai = _context.Loais.SingleOrDefault(x => x.MaLoai == id);

            if (loai == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(loai);
            }
        }

        [HttpPost]
        public IActionResult CreateLoai(LoaiModel model)
        {
            try
            {
            var loai = new Loai
                {
                    TenLoai = model.TenLoai
                };
            _context.Add(loai);
            _context.SaveChanges();
            return Ok(loai);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("id")]
        public IActionResult UpdateLoaiById(int id, LoaiModel model)
        {
            var loai = _context.Loais.SingleOrDefault(x => x.MaLoai == id);

            if (loai == null)
            {
                return NotFound();
            }
            else
            {
                loai.TenLoai = model.TenLoai;
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
