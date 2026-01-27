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
        private readonly IMarkService _MarkService = MarkService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<MarkResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<MarkResponse>>> GetMarks()
        {
            var Marks = await _MarkService.GetAllMarksAsync();
            return Ok(Marks);
        }

        [HttpPost]
        [ProducesResponseType(typeof(MarkResponse), StatusCodes.Status201Created)]
        public async Task<ActionResult<MarkResponse>> CreateMark([FromBody] CreateMarkRequest request)
        {
            var Mark = await _MarkService.CreateMarkAsync(request);
            return CreatedAtAction(nameof(GetMarkByDisciplineAndGroup), new { id = Mark.Id }, Mark);
        }

        [HttpGet("by_dId_gId")]
        [ProducesResponseType(typeof(MarkResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(NotFoundResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MarkResponse>> GetMarkByDisciplineAndGroup([FromQuery] GetMarksByDisciplineAndGroupRequest request)
        {
            var Mark = await _MarkService.GetMarksByDisciplineAndGroupAsync(request);
            if (Mark == null)
                return NotFound(new {disciplineId = request.DisciplineId, groupId = request.GroupId});
            return Ok(Mark);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(NotFoundResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateMark([FromBody] UpdateMarkRequest request)
        {
            var success = await _MarkService.UpdateMarkAsync(request);
            if (!success)
                return NotFound(request.Id);

            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(NotFoundResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteMark([FromQuery] DeleteMarkByStudentAndWorkRequest request)
        {
            var success = await _MarkService.DeleteMarkByStudentAndWorkAsync(request);
            if (!success)
                return NotFound(request.WorkId);

            return NoContent();
        }
    }
}
