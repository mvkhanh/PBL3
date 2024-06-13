using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models.Comment
{
    public abstract class CommentModel
    {
        public virtual int Id { get; set; }
        public virtual int StudentId {  get; set; }
        public virtual string Content {  get; set; }
        public virtual DateTime CreateDay { get; set; }
    }
}
