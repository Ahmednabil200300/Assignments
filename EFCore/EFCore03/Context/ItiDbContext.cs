using C44_G03_EFCore03.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace C44_G03_EFCore03.Context
{
    public class itiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITIDatabase;Trusted_Connection=True;TrustServerCertificate=True;")
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region ApplyConfigurations
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            #endregion

            #region OneToOneRelationship
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithOne(d => d.HeadInstructor)
                .HasForeignKey<Instructor>(i => i.DepartmentId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region OneToManyRelationships
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Students)
                .WithOne(s => s.Department)
                .HasForeignKey(s => s.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.StudCourses)
                .WithOne(sc => sc.Course)
                .HasForeignKey(sc => sc.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Instructor>()
                .HasMany(i => i.Course_Insts)
                .WithOne(ci => ci.Instructor)
                .HasForeignKey(ci => ci.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Course_Insts)
                .WithOne(ci => ci.Course)
                .HasForeignKey(ci => ci.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region ManyToManyRelationship
            modelBuilder.Entity<StudCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });
            #endregion

            #region CompositeKeyForCourse_Inst
            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.InstructorId, ci.CourseId });
            #endregion

           
            modelBuilder.Entity<Department>()
                .HasIndex(d => d.DepartmentName)
                .IsUnique();

            modelBuilder.Entity<Course>()
                .HasIndex(c => c.CourseName)
                .IsUnique();

            modelBuilder.Entity<Topic>()
                .HasIndex(t => t.TopicName)
                .IsUnique();
         
        }

        #region DbSets
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudCourse> StudCourses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        #endregion
    }
}