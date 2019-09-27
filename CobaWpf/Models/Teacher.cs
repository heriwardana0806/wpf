using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaWpf.Models
{
    [Table("TB_M_Teacher")]
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public String TeacherName { get; set; }
        public String Address { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
