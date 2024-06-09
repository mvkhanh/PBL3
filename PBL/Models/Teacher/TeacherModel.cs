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

        [DisplayName("So dien thoai")]
        [RegularExpression(@"^\d{10}$",
        ErrorMessage = "So dien thoai phai co dung 10 chu so.")]
        public override string Phone { get; set; }

        [DisplayName("Ngay dang ky")]
        public override DateTime RegistDay { get; set; }

        public int Id_Account { get; set; }

        [ForeignKey("Id_Account")]
        public virtual AccountModel Account { get; set; }

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
