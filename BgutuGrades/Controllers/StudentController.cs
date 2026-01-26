using BgutuGrades.Models.Student;
using BgutuGrades.Services;
using Microsoft.AspNetCore.Mvc;


namespace BgutuGrades.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController(IStudentService studentService) : ControllerBase
    {
        private readonly IStudentService _studentService = studentService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<StudentResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<StudentResponse>>> GetStudents()
        {
            var students = await _studentService.GetAllStudentsAsync();
            return Ok(students);
        }

        [HttpPost]
        [ProducesResponseType(typeof(StudentResponse), StatusCodes.Status201Created)]
        public async Task<ActionResult<StudentResponse>> CreateStudent([FromBody] CreateStudentRequest request)
        {
            var student = await _studentService.CreateStudentAsync(request);
            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(StudentResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(NotFoundResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<StudentResponse>> GetStudent([FromRoute] int id)
        {
            var student = await _studentService.GetStudentByIdAsync(id);
            if (student == null)
                return NotFound(id);
            return Ok(student);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(NotFoundResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateStudent([FromBody] UpdateStudentRequest request)
        {
            var success = await _studentService.UpdateStudentAsync(request);
            if (!success)
                return NotFound(request.Id);

            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(NotFoundResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteStudent([FromQuery] DeleteStudentRequest request)
        {
            var success = await _studentService.DeleteStudentAsync(request.Id);
            if (!success)
                return NotFound(request.Id);

            return NoContent();
        }
    }
}
