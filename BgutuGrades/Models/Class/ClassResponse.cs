using Grades.Entities;

namespace BgutuGrades.Models.Class
{
    public class ClassResponse
    {
        public int Id { get; set; }
        public int WeekDay { get; set; }
        public int Weeknumber { get; set; }
        public ClassType Type { get; set; }
        public int DisciplineId { get; set; }
        public int GroupId { get; set; }
    }
}
