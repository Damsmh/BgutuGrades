using Grades.Entities;
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

    public class CreateClassRequest
    {
        [Required]
        public int WeekDay { get; set; }
        [Required]
        public int Weeknumber { get; set; }
        [Required]
        public ClassType Type { get; set; }
        [Required]
        public int DisciplineId { get; set; }
        [Required]
        public int GroupId { get; set; }
    }
}
