using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models.Comment
{
    [Table("LessonComment")]
    public class LessonCommentModel : CommentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [ForeignKey("StudentId")]
        public virtual StudentModel Student { get; set; }

        public int LessonId { get; set; }
        [ForeignKey("LessonId")]
        public virtual LessonModel Lesson { get; set; }
    }
}
