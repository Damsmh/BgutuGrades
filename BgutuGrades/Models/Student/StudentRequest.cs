using System.ComponentModel.DataAnnotations;

namespace BgutuGrades.Models.Student
{
    public class GetStudentsByGroupRequest
    {
        [Required]
        public int GroupId { get; set; }
    }
}
