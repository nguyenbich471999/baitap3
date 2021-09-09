using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace baitap3.Models
{
    public class LapTrinhQuanLyDbcontext : DbContext
    {

        public LapTrinhQuanLyDbcontext() : base("name=LTQLDbContext")
        { }
        public virtual DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Student>()
            .Property(e => e.StudentName)
            .IsUnicode(false);

        }
    }
}