using System.ComponentModel.DataAnnotations;

namespace BgutuGrades.Models.Class
{
    public class GetClassesByDisciplineAndGroupRequest
    {
        [Required]
        public int DisciplineId { get; set; }
        [Required]
        public int GroupId { get; set; }
    }
}
