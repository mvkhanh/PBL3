using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models.Comment
{
    [Table("TestComment")]
    public class TestCommentModel : CommentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [ForeignKey("StudentId")]
        public virtual StudentModel Student { get; set; }

        public int TestId { get; set; }
        [ForeignKey("TestId")]
        public virtual TestModel Test { get; set; }
    }
}
