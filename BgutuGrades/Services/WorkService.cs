using BgutuGrades.Models.Work;

namespace BgutuGrades.Services
{
    public interface IWorkService
    {
        Task<IEnumerable<WorkResponse>> GetAllWorksAsync();
        Task<WorkResponse> CreateWorkAsync(CreateWorkRequest request);
        Task<WorkResponse?> GetWorkByIdAsync(int id);
        Task<bool> UpdateWorkAsync(UpdateWorkRequest request);
        Task<bool> DeleteWorkAsync(int id);
    }
    public class WorkService : IWorkService
    {
        public Task<WorkResponse> CreateWorkAsync(CreateWorkRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteWorkAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WorkResponse>> GetAllWorksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<WorkResponse?> GetWorkByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateWorkAsync(UpdateWorkRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
