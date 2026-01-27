using BgutuGrades.Models.Discipline;

namespace BgutuGrades.Services
{
    public interface IDisciplineService
    {
        Task<IEnumerable<DisciplineResponse>> GetAllDisciplinesAsync();
        Task<DisciplineResponse> CreateDisciplineAsync(CreateDisciplineRequest request);
        Task<DisciplineResponse?> GetDisciplineByIdAsync(int id);
        Task<bool> UpdateDisciplineAsync(UpdateDisciplineRequest request);
        Task<bool> DeleteDisciplineAsync(int id);
    }
    public class DisciplineService : IDisciplineService
    {
        public Task<DisciplineResponse> CreateDisciplineAsync(CreateDisciplineRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDisciplineAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DisciplineResponse>> GetAllDisciplinesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DisciplineResponse?> GetDisciplineByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDisciplineAsync(UpdateDisciplineRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
