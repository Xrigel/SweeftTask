using System.ComponentModel.DataAnnotations;

namespace TeacherByStudentName.Models
{
    public class PupilAndTeacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PupilId { get; set; }
        public int TeacherId { get; set; }
        public Pupil Pupil { get; set; }
        public Teacher Teacher { get; set; }
    }
}
