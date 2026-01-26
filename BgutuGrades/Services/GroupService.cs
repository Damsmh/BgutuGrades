using BgutuGrades.Models.Group;

namespace BgutuGrades.Services
{
    public interface IGroupService
    {
        Task<IEnumerable<GroupResponse>> GetGroupsByDisciplineAsync(int disciplineId);
        Task<GroupResponse> CreateGroupAsync(CreateGroupRequest request);
        Task<GroupResponse?> GetGroupByIdAsync(int id);
        Task<bool> UpdateGroupAsync(UpdateGroupRequest request);
        Task<bool> DeleteGroupAsync(int id);
    }

    public class GroupService : IGroupService
    {
        public Task<GroupResponse> CreateGroupAsync(CreateGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteGroupAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GroupResponse?> GetGroupByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GroupResponse>> GetGroupsByDisciplineAsync(int disciplineId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateGroupAsync(UpdateGroupRequest request)
        {
            throw new NotImplementedException();
        }
    }
}