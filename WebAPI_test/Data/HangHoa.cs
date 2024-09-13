using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_test.Data
{
    [Route("api/[controller]")]
    [ApiController]
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public int MaHh { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenHh { get; set; }

        public string Mota { get; set; }

        [Range(0, double.MaxValue)]
        public double DonGia { get; set; }

        public byte GiamGia { get; set; }
        [ForeignKey("MaLoai")]
        public int? MaLoai { get; set; }
        
        public Loai Loai { get; set; }

    }
}
