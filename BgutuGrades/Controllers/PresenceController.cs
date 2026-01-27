using BgutuGrades.Models.Presence;
using BgutuGrades.Models.Student;
using BgutuGrades.Services;
using Microsoft.AspNetCore.Mvc;

namespace BgutuGrades.Controllers
{
    [Route("api/presence")]
    [ApiController]
    public class PresenceController(IPresenceService PresenceService) : ControllerBase
    {
        private readonly IPresenceService _PresenceService = PresenceService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PresenceResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PresenceResponse>>> GetPresences()
        {
            var Presences = await _PresenceService.GetAllPresencesAsync();
            return Ok(Presences);
        }

        [HttpPost]
        [ProducesResponseType(typeof(PresenceResponse), StatusCodes.Status201Created)]
        public async Task<ActionResult<PresenceResponse>> CreatePresence([FromBody] CreatePresenceRequest request)
        {
            var Presence = await _PresenceService.CreatePresenceAsync(request);
            return CreatedAtAction(nameof(GetPresence), new { id = Presence.Id }, Presence);
        }

        [HttpGet("by_dId_gId")]
        [ProducesResponseType(typeof(PresenceResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(NotFoundResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PresenceResponse>> GetPresence([FromQuery] GetPresenceByDisciplineAndGroupRequest request)
        {
            var Presence = await _PresenceService.GetPresencesByDisciplineAndGroupAsync(request);
            if (Presence == null)
                return NotFound(new { disciplineId = request.DisciplineId, groupId = request.GroupId });
            return Ok(Presence);
        }

        //[HttpPut]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(typeof(NotFoundResponse), StatusCodes.Status404NotFound)]
        //public async Task<IActionResult> UpdatePresence([FromBody] UpdatePresenceRequest request)
        //{
        //    var success = await _PresenceService.UpdatePresenceAsync(request);
        //    if (!success)
        //        return NotFound(request.Id);

        //    return NoContent();
        //}

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(NotFoundResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeletePresence([FromQuery] DeletePresenceByStudentAndDateRequest request)
        {
            var success = await _PresenceService.DeletePresenceByStudentAndDateAsync(request);
            if (!success)
                return NotFound(new { studentId = request.StudentId, date = request.Date});

            return NoContent();
        }
    }
}
