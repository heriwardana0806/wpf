using CobaWpf.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaWpf.Context
{
    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("DbConnectionString")
        {

        }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<User> Users { get; set; }
    }
}
