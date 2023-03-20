global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;

namespace TeacherByStudentName.Models
{
    public class Teacher
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }=String.Empty;
        public string LastName { get; set; }= String.Empty;
        public string Sex { get; set; } = String.Empty;
        public string Subject { get; set; } = String.Empty;
    }
}
