using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_test.Models;

namespace WebAPI_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : ControllerBase
    {
        public static List<HangHoa> hangHoas = new List<HangHoa>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(hangHoas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            try
            {
                var hanghoa = hangHoas.SingleOrDefault(hanghoa => hanghoa.MaHangHoa.ToString() == Guid.Parse(id).ToString());
                if (hanghoa == null)
                {
                    return NotFound();
                }
                return Ok(hanghoa);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Create(HangHoaVM hangHoaVM)
        {
            var hanghoa = new HangHoa
            {
                MaHangHoa = Guid.NewGuid(),
                TenHangHoa = hangHoaVM.TenHangHoa,
                DonGia = hangHoaVM.DonGia
            };
            hangHoas.Add(hanghoa);
            return Ok(new
            {
                Success = true,
                Data = hanghoa
            });
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, HangHoaVM hangHoaVM)
        {
            try
            {
                var hanghoa = hangHoas.SingleOrDefault(hanghoa => hanghoa.MaHangHoa.ToString() == Guid.Parse(id).ToString());
                if (hanghoa == null)
                {
                    return NotFound();
                }

                if (id != hanghoa.MaHangHoa.ToString())
                {
                    return BadRequest();
                }

                hanghoa.TenHangHoa = hangHoaVM.TenHangHoa;
                hanghoa.DonGia = hangHoaVM.DonGia;

                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                var hanghoa = hangHoas.SingleOrDefault(hanghoa => hanghoa.MaHangHoa.ToString() == Guid.Parse(id).ToString());
                if (hanghoa == null)
                {
                    return NotFound();
                }

                hangHoas.Remove(hanghoa);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
