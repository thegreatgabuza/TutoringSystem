using Microsoft.EntityFrameworkCore;
using TutoringSystem.Models;

namespace TutoringSystem.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Student)
                .WithMany(s => s.Bookings)
                .HasForeignKey(b => b.StudentId)
                .OnDelete(DeleteBehavior.Restrict); // Set restrict delete for Student

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Tutor)
                .WithMany(t => t.Bookings)
                .HasForeignKey(b => b.TutorId)
                .OnDelete(DeleteBehavior.NoAction); // Set no action delete for Tutor

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Module)
                .WithMany(m => m.Bookings)
                .HasForeignKey(b => b.ModuleId)
                .OnDelete(DeleteBehavior.NoAction); // Set no action delete for Module
        }
    }
}
