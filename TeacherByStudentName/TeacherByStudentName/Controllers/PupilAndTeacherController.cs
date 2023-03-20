using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeacherByStudentName.Data;
using TeacherByStudentName.Models;


namespace TeacherByStudentName.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PupilAndTeacherController : ControllerBase
    {
        private readonly DataContext _dbContext;

        public PupilAndTeacherController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetAllTeachersByStudent(string pupilName)
        {
            var pupils = await _dbContext.Pupils.Where(p => p.Name == pupilName).ToListAsync();
            if (pupils == null || pupils.Count() == 0)
            {
                return NotFound();
            }

            var pupilIds = pupils.Select(p => p.Id);
            var pupilAndTeachers = await _dbContext.PupilAndTeachers
                .Include(pt => pt.Teacher)
                .Where(pt => pupilIds.Contains(pt.PupilId))
                .ToListAsync();

            if (pupilAndTeachers == null || pupilAndTeachers.Count() == 0)
            {
                return NotFound();
            }

            var teachers = pupilAndTeachers.Select(pt => pt.Teacher);
            return teachers.Distinct().ToList();
            //თუ გვინდა,რომ მასწავლებელი რამდენიმეჯერ მეორდებოდეს წავშლით ამ Distinct ფუნქციას.

        }
    }
}
