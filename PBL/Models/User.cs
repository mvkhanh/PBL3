using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    public abstract class User
    {
        [DisplayName("ID")]
        public int Id { get; private set; }
        [DisplayName("Ho")]
        [Required(ErrorMessage = "Nhap ho.")]
        [StringLength(50, ErrorMessage = "Ho phai co do dai toi da 50 ki tu.")]
        public string FirstName { get; set; }
        [DisplayName("Ten")]
        [Required(ErrorMessage = "Nhap ten.")]
        [StringLength(50, ErrorMessage = "Ten phai co do dai toi da 50 ki tu.")]
        public string LastName { get; set; }
        //Check ngay sinh: Lon hon ngay hien tai?
        [DisplayName("Ngay sinh")]
        public DateTime Birth {  get; set; }

        [EmailAddress(ErrorMessage = "Dia chi email khong hop le.")]
        public string Email {  get; set; }

        [DisplayName("So dien thoai")]
        [RegularExpression(@"^\d{10}$",
        ErrorMessage = "So dien thoai phai co dung 10 chu so.")]
        public string Phone { get; set; }

        [DisplayName("Ngay dang ky")]
        public DateTime RegistDay { get; private set; }
        public int IdAccount {  get; set; }
    }
}
