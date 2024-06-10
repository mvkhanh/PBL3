using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    public abstract class UserModel
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime Birth {  get; set; }
        public virtual string Email {  get; set; }
        public virtual string Phone { get; set; }
        public virtual DateTime RegistDay { get; set; }
        public virtual string Account {  get; set; }
        public virtual string Password { get; set; }
    }
}
