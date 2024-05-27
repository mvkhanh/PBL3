using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    [Table("Answer")]
    public class AnswerModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nhap dap an.")]
        public string Content { get; set; }
        public bool Right {  get; set; }
        public int Id_Question {  get; set; }

        [ForeignKey("Id_Question")]
        public virtual QuestionModel Question { get; set; }
    }
}
