using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    public class BaiHoc : StudyElement
    {
        [Required(ErrorMessage = "Them noi dung.")]
        public string Content { get; set; }

        [DisplayName("Luot xem")]
        public int Views { get; set; }
    }
}
