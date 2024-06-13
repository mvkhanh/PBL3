using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models.StudentTest
{
    [Table("StudentTest")]
    public class StudentTestModel
    {
        [Key]
        [Column(Order = 1)]
        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual StudentModel Student { get; set; }

        [Key]
        [Column(Order = 2)]
        public int TestId { get; set; }

        [ForeignKey("TestId")]
        public virtual TestModel Test { get; set; }

        public DateTime TestDate { get; set; }
        public int Scores {  get; set; }
        public int TestTime {  get; set; }
    }
}
