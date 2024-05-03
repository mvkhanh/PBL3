using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    public class StudyElement
    {
        [DisplayName("ID")]
        public int Id { get; private set; }

        [DisplayName("Ten")]
        [Required(ErrorMessage = "Nhap ten.")]
        [StringLength(50, ErrorMessage = "Ten phai co do dai toi da 50 ki tu.")]
        public string Name { get; set; }

        [DisplayName("Ngay dang")]
        public DateTime PublishDay { get; set; }
        public int IdGiangVien { get; set; }
    }
}
