using BgutuGrades.Models.Mark;
using BgutuGrades.Models.Student;
using BgutuGrades.Services;
using Microsoft.AspNetCore.Mvc;

namespace BgutuGrades.Controllers
{
    [Route("api/mark")]
    [ApiController]
    public class MarkController(IMarkService MarkService) : ControllerBase
    {
        private readonly IMarkService _markService = MarkService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<MarkResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<MarkResponse>>> GetMarks()
        {
            var marks = await _markService.GetAllMarksAsync();
            return Ok(marks);
        }

        [HttpPost]
        [ProducesResponseType(typeof(MarkResponse), StatusCodes.Status201Created)]
        public async Task<ActionResult<MarkResponse>> CreateMark([FromBody] CreateMarkRequest request)
        {
            var mark = await _markService.CreateMarkAsync(request);
            return CreatedAtAction(nameof(GetMarkByDisciplineAndGroup), new { id = mark.Id }, mark);
        }

        [HttpGet("by_dId_gId")]
        [ProducesResponseType(typeof(MarkResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(NotFoundResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MarkResponse>> GetMarkByDisciplineAndGroup([FromQuery] GetMarksByDisciplineAndGroupRequest request)
        {
            var marks = await _markService.GetMarksByDisciplineAndGroupAsync(request);
            if (marks == null)
                return NotFound(new {disciplineId = request.DisciplineId, groupId = request.GroupId});
            return Ok(marks);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(NotFoundResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateMark([FromBody] UpdateMarkRequest request)
        {
            var success = await _markService.UpdateMarkAsync(request);
            if (!success)
                return NotFound(request.Id);

            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(NotFoundResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteMark([FromQuery] DeleteMarkByStudentAndWorkRequest request)
        {
            var success = await _markService.DeleteMarkByStudentAndWorkAsync(request);
            if (!success)
                return NotFound(request.WorkId);

            return NoContent();
        }
    }
}
