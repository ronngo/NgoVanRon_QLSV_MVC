using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NgoVanRon_QLSV_MVC.Models
{
    public class NgoVanRon_Sinhvien
    {
        [Key]
        public int id { get; set; }
        [Required, DisplayName("Tên sinh viên ")]
        public string TenSinhVien { get; set; }

        [Required, DisplayName("Địa chỉ ")]
        public string DiaChi { get; set; }
        public int IdLop { get; set; }
    }
}
