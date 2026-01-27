using BgutuGrades.Models.Presence;

namespace BgutuGrades.Services
{
    public interface IPresenceService
    {
        Task<IEnumerable<PresenceResponse>> GetAllPresencesAsync();
        Task<PresenceResponse> CreatePresenceAsync(CreatePresenceRequest request);
        Task<IEnumerable<PresenceResponse>> GetPresencesByDisciplineAndGroupAsync(GetPresenceByDisciplineAndGroupRequest request);
        Task<bool> DeletePresenceByStudentAndDateAsync(DeletePresenceByStudentAndDateRequest request);
    }
    public class PresenceService : IPresenceService
    {
        public Task<PresenceResponse> CreatePresenceAsync(CreatePresenceRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePresenceByStudentAndDateAsync(DeletePresenceByStudentAndDateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PresenceResponse>> GetAllPresencesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PresenceResponse>> GetPresencesByDisciplineAndGroupAsync(GetPresenceByDisciplineAndGroupRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
