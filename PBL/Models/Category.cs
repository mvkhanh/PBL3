using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    public class Category
    {
        public int Id { get; private set; }

        [Required(ErrorMessage = "Nhap danh muc.")]
        [StringLength(50, ErrorMessage = "Danh muc phai co do dai toi da 50 ki tu.")]
        public string Name { get; set; }
    }
}
