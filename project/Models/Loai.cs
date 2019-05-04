using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models
{
    [Table("Loai")]
    public partial class Loai
    {
        public Loai()
        {
            HangHoa = new HashSet<HangHoa>();
        }

        [Display(Name="Ma Loai")]
        public int MaLoai { get; set; }
        
        [Required(ErrorMessage = "Chưa nhập tên hàng hóa")]
        [MaxLength(50, ErrorMessage = "Tối đa 50 kí tự")]
        [Display(Name="Ten Loai")]
        public string TenLoai { get; set; }
        
        [Display(Name="Mo Ta")]
        public string MoTa { get; set; }
        
        [Display(Name="Hinh")]
        public string Hinh { get; set; }

        public ICollection<HangHoa> HangHoa { get; set; }
    }
}
