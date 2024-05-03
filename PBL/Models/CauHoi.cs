using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    public class CauHoi
    {
        public int Id {  get; private set; }

        [Required(ErrorMessage = "Nhap cau hoi.")]
        public string Content {  get; set; }
        public int IdTest {  get; set; }
    }
}
