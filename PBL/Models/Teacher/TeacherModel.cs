using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    public class TeacherModel : UserModel
    {
        [DisplayName("ID")]
        [Key]
        public override int Id { get; set; }

        [DisplayName("Ten")]
        [Required(ErrorMessage = "Nhap ten.")]
        [StringLength(50, ErrorMessage = "Ten phai co do dai toi da 50 ki tu.")]
        public override string Name { get; set; }

        [DisplayName("Ngay sinh")]
        public override DateTime Birth { get; set; }

        [Required(ErrorMessage = "Nhap email.")]
        [EmailAddress(ErrorMessage = "Dia chi email khong hop le.")]
        public override string Email { get; set; }

        [Required(ErrorMessage = "Nhap so dien thoai.")]
        [DisplayName("So dien thoai")]
        [RegularExpression(@"^\d{10}$",
        ErrorMessage = "So dien thoai phai co dung 10 chu so.")]
        public override string Phone { get; set; }

        [DisplayName("Ngay dang ky")]
        public override DateTime RegistDay { get; set; }

        [DisplayName("So luong bai hoc da dang")]
        public int Lessons { get; set; }

        [DisplayName("So luong bai kiem tra da dang")]
        public int Tests {  get; set; }

        public override int Id_TaiKhoan { get => base.Id_TaiKhoan; set => base.Id_TaiKhoan = value; }

        [ForeignKey("Id_TaiKhoan")]
        public virtual AccountModel AccountModel { get; set; }
    }
}
