using BgutuGrades.Models.Mark;

namespace BgutuGrades.Services
{
    public interface IMarkService
    {
        Task<IEnumerable<MarkResponse>> GetAllMarksAsync();
        Task<MarkResponse> CreateMarkAsync(CreateMarkRequest request);
        Task<IEnumerable<MarkResponse>> GetMarksByDisciplineAndGroupAsync(GetMarksByDisciplineAndGroupRequest request);
        Task<bool> UpdateMarkAsync(UpdateMarkRequest request);
        Task<bool> DeleteMarkByStudentAndWorkAsync(DeleteMarkByStudentAndWorkRequest request);
    }
    public class MarkService : IMarkService
    {
        public Task<MarkResponse> CreateMarkAsync(CreateMarkRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMarkByStudentAndWorkAsync(DeleteMarkByStudentAndWorkRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MarkResponse>> GetAllMarksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MarkResponse>> GetMarksByDisciplineAndGroupAsync(GetMarksByDisciplineAndGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateMarkAsync(UpdateMarkRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
