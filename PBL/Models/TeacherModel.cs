using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    public class TeacherModel : User
    {
        [DisplayName("So luong bai hoc da dang")]
        public int Lessons { get; set; }
        [DisplayName("So luong bai kiem tra da dang")]
        public int Tests {  get; set; }
    }
}
