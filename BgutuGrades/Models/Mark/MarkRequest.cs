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

    public class CreateMarkRequest
    {
        [Required]
        public DateOnly Date { get; set; }
        [Required]
        public string? Value { get; set; }
        [Required]
        public bool IsOverdue { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public int WorkId { get; set; }
    }

    public class DeleteMarkByStudentAndWorkRequest
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        public int WorkId { get; set; }
    }
}
