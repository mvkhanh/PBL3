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
    [Table("Teacher")]
    public class TeacherModel : UserModel
    {
        //Properties
        [DisplayName("ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        [DisplayName("Tai Khoan")]
        [Required(ErrorMessage = "Nhap tai khoan.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Tai khoan phai co do dai tu 6-50 ki tu.")]
        public override string Account { get; set; }

        [DisplayName("Mat Khau")]
        [Required(ErrorMessage = "Nhap mat khau.")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Mat khau phai co do dai tu 8-50 ki tu.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).*$",
        ErrorMessage = "Mat khau phai chua chu hoa, chu thuong, chu so va ki tu dac biet.")]
        public override string Password { get; set; }

        public virtual ICollection<LessonModel> Lessons { get; }
        public virtual ICollection<TestModel> Tests {  get; }

        //Constructor
        public TeacherModel()
        {
            Lessons = new HashSet<LessonModel>();
            Tests = new HashSet<TestModel>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
