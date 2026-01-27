using BgutuGrades.Models.Class;

namespace BgutuGrades.Services
{
    public interface IClassService
    {
        Task<IEnumerable<ClassResponse>> GetClassesByDisciplineAndGroupAsync(GetClassesByDisciplineAndGroupRequest request);
        Task<ClassResponse> CreateClassAsync(CreateClassRequest request);
        Task<ClassResponse?> GetClassByIdAsync(int id);
        Task<bool> DeleteClassAsync(int id);
    }
    public class ClassService : IClassService
    {
        public Task<ClassResponse> CreateClassAsync(CreateClassRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteClassAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ClassResponse?> GetClassByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClassResponse>> GetClassesByDisciplineAndGroupAsync(GetClassesByDisciplineAndGroupRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
