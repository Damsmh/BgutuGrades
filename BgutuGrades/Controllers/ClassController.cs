using BgutuGrades.Models.Class;
using BgutuGrades.Models.Student;
using BgutuGrades.Services;
using Microsoft.AspNetCore.Mvc;

namespace BgutuGrades.Controllers
{
    [Route("api/class")]
    [ApiController]
    public class ClassController(IClassService ClassService) : ControllerBase
    {
        private readonly IClassService _ClassService = ClassService;

        [HttpGet("by_dId_gId")]
        [ProducesResponseType(typeof(IEnumerable<ClassResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ClassResponse>>> GetClasss(
            [FromQuery] GetClassesByDisciplineAndGroupRequest request)
        {
            var classs = await _ClassService.GetClassesByDisciplineAndGroupAsync(request);
            return Ok(classs);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ClassResponse), StatusCodes.Status201Created)]
        public async Task<ActionResult<ClassResponse>> CreateClass([FromBody] CreateClassRequest request)
        {
            var _class = await _ClassService.CreateClassAsync(request);
            return CreatedAtAction(nameof(GetClass), new { id = _class.Id }, _class);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ClassResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(NotFoundResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ClassResponse>> GetClass([FromRoute] int id)
        {
            var _class = await _ClassService.GetClassByIdAsync(id);
            if (_class == null)
                return NotFound(id);
            return Ok(_class);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(NotFoundResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteClass([FromQuery] int id)
        {
            var success = await _ClassService.DeleteClassAsync(id);
            if (!success)
                return NotFound(id);

            return NoContent();
        }
    }
}
