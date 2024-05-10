using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    public abstract class UserModel
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Ten")]
        [Required(ErrorMessage = "Nhap ten.")]
        [StringLength(50, ErrorMessage = "Ten phai co do dai toi da 50 ki tu.")]
        public string Name { get; set; }
        //Check ngay sinh: Lon hon ngay hien tai?

        [Required(ErrorMessage = "Nhap ten.")]
        [DisplayName("Ngay sinh")]
        public DateTime Birth {  get; set; }

        [Required(ErrorMessage = "Nhap email.")]
        [EmailAddress(ErrorMessage = "Dia chi email khong hop le.")]
        public string Email {  get; set; }

        [Required(ErrorMessage = "Nhap so dien thoai.")]
        [DisplayName("So dien thoai")]
        [RegularExpression(@"^\d{10}$",
        ErrorMessage = "So dien thoai phai co dung 10 chu so.")]
        public string Phone { get; set; }

        [DisplayName("Ngay dang ky")]
        public DateTime RegistDay { get; set; }
    }
}
