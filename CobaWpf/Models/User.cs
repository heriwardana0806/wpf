using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaWpf.Models
{
    [Table("Tb_M_User")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Contact { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

    }
}
