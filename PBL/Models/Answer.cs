using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    public class Answer
    {
        public int Id {  get; private set; }
        [Required(ErrorMessage = "Nhap dap an.")]
        public string Content { get; set; }
        public bool Right {  get; set; }
        public int IdQues {  get; set; }
    }
}
