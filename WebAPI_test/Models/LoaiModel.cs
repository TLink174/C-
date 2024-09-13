using System.ComponentModel.DataAnnotations;

namespace WebAPI_test.Models
{
    public class LoaiModel
    {
        [Required]
        [StringLength(50)]
        public string TenLoai { get; set; }
    }
}
