using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL.Models
{
    public abstract class StudyElement
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract DateTime PublishDay { get; set; }
    }
}
