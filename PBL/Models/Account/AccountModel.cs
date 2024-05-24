using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace PBL.Models
{
    public class AccountModel
    {
        [Key]
        public int Id {  get; set; }

        [DisplayName("Tai Khoan")]
        [Required(ErrorMessage = "Nhap tai khoan.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Tai khoan phai co do dai tu 6-50 ki tu.")]
        public string Account {  get; set; }

        [DisplayName("Mat Khau")]
        [Required(ErrorMessage = "Nhap mat khau.")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Mat khau phai co do dai tu 8-50 ki tu.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).*$",
        ErrorMessage = "Mat khau phai chua chu hoa, chu thuong, chu so va ki tu dac biet.")]
        public string Password { get; set; }
    }
}
