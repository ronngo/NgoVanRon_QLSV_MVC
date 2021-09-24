using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NgoVanRon_QLSV_MVC.Models
{
    public class NgoVanRon_Lop
    {
        public int Id { get; set; }
        [Required, DisplayName("Tên lớp")]
        public string TenLop { get; set; }
    }
}
