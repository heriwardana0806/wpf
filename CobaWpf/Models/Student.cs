using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaWpf.Models
{
    [Table("Tb_M_Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public String Name { get; set; }
        public String Class { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }

    public interface InterfaceStu <TEntity>
    {
        void Add(TEntity entity);
    }

    public class Heri : Joshua<Student>
    {

    }
}
