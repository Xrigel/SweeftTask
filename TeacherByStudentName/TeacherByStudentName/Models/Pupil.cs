namespace TeacherByStudentName.Models
{
    public class Pupil
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string Name { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Sex { get; set; } = String.Empty;
        public string Class { get; set; } = String.Empty;
    }
}
