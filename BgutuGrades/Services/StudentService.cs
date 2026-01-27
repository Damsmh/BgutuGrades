using BgutuGrades.Models.Student;

namespace BgutuGrades.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentResponse>> GetAllStudentsAsync();
        Task<IEnumerable<StudentResponse>> GetStudentsByGroupAsync(GetStudentsByGroupRequest request);
        Task<StudentResponse> CreateStudentAsync(CreateStudentRequest request);
        Task<StudentResponse?> GetStudentByIdAsync(int id);
        Task<bool> UpdateStudentAsync(UpdateStudentRequest request);
        Task<bool> DeleteStudentAsync(int id);
    }
    public class StudentService : IStudentService
    {
        public Task<StudentResponse> CreateStudentAsync(CreateStudentRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteStudentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StudentResponse>> GetAllStudentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StudentResponse?> GetStudentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StudentResponse>> GetStudentsByGroupAsync(GetStudentsByGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStudentAsync(UpdateStudentRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
