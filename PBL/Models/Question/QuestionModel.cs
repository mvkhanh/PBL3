using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    [Table("Question")]
    public class QuestionModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nhap cau hoi.")]
        public string Content {  get; set; }
        public byte[] Photo { get; set; }
        public int Id_Test { get; set; }
        [ForeignKey("Id_Test")]
        public virtual TestModel Test { get; set; }
        public virtual ICollection<AnswerModel> Answers { get; }

        //Constructor
        public QuestionModel()
        {
            Answers = new HashSet<AnswerModel>();
        }
    }
}
