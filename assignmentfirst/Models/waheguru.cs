namespace assignmentfirst.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class waheguru : DbContext
    {
        public waheguru()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Table_1> Table_1 { get; set; }
        public virtual DbSet<Table_2> Table_2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table_1>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Table_1>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<Table_1>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Table_2>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Table_2>()
                .Property(e => e.Lastname)
                .IsUnicode(false);
        }
    }
}
