using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    public class BaiKiemTra : StudyElement
    {
        [DisplayName("Gioi thieu")]
        [Required(ErrorMessage = "Nhap noi dung gioi thieu.")]
        public string Description {  get; set; }

        [DisplayName("So luong tham gia")]
        public int Count {  get; set; }
    }
}
