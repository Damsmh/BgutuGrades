using System.ComponentModel.DataAnnotations;

namespace BgutuGrades.Models.Mark
{
    public class GetMarksByDisciplineAndGroupRequest
    {
        [Required]
        public int DisciplineId { get; set; }
        [Required]
        public int GroupId { get; set; }
    }
}
