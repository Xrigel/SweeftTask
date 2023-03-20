using Microsoft.EntityFrameworkCore;
using TeacherByStudentName.Models;

namespace TeacherByStudentName.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

        public DbSet<Pupil> Pupils => Set<Pupil>();
        public DbSet<Teacher> Teachers => Set<Teacher>();
        public DbSet<PupilAndTeacher> PupilAndTeachers => Set<PupilAndTeacher>();
    }
}
