using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    [Table("StudentLesson")]
    public class StudentLessonModel
    {
        [Key]
        [Column(Order = 1)]
        public int StudentId {  get; set; }

        [ForeignKey("StudentId")]
        public virtual StudentModel Student { get; set; }

        [Key]
        [Column(Order = 2)]
        public int LessonId {  get; set; }

        [ForeignKey("LessonId")]
        public virtual LessonModel Lesson { get; set; }
    }
}
