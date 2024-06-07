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
    [Table("Test")]
    public class TestModel : StudyElement
    {
        [DisplayName("ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [DisplayName("Ten")]
        [Required(ErrorMessage = "Nhap ten.")]
        [StringLength(50, ErrorMessage = "Ten phai co do dai toi da 50 ki tu.")]
        public override string Name { get; set; }

        [DisplayName("Ngay dang")]
        public override DateTime PublishDay { get; set; }

        public int Id_Teacher { get; set; }

        [ForeignKey("Id_Teacher")]
        [DisplayName("Nguoi dang")]
        public virtual TeacherModel Teacher { get; set; }

        [DisplayName("Gioi thieu")]
        public string Description { get; set; }

        public byte[] Audio {  get; set; }

        [DisplayName("So luong tham gia")]
        public int Count {  get; set; }

        public virtual ICollection<QuestionModel> Questions { get; }

        //Constructor
        public TestModel()
        {
            Questions = new HashSet<QuestionModel>();
        }
        
    }
}
