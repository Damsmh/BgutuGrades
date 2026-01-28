using AutoMapper;
using BgutuGrades.Models.Presence;
using BgutuGrades.Repositories;
using Grades.Entities;

namespace BgutuGrades.Services
{
    public interface IPresenceService
    {
        Task<IEnumerable<PresenceResponse>> GetAllPresencesAsync();
        Task<PresenceResponse> CreatePresenceAsync(CreatePresenceRequest request);
        Task<IEnumerable<PresenceResponse>> GetPresencesByDisciplineAndGroupAsync(GetPresenceByDisciplineAndGroupRequest request);
        Task<bool> DeletePresenceByStudentAndDateAsync(DeletePresenceByStudentAndDateRequest request);
        Task<bool> UpdatePresenceAsync(UpdatePresenceRequest request);
    }
    public class PresenceService(IPresenceRepository presenceRepository, IMapper mapper) : IPresenceService
    {
        private readonly IPresenceRepository _presenceRepository = presenceRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<PresenceResponse> CreatePresenceAsync(CreatePresenceRequest request)
        {
            var entity = _mapper.Map<Presence>(request);
            var createdEntity = await _presenceRepository.CreatePresenceAsync(entity);
            return _mapper.Map<PresenceResponse>(createdEntity);
        }

        public async Task<IEnumerable<PresenceResponse>> GetAllPresencesAsync()
        {
            var entities = await _presenceRepository.GetAllPresencesAsync();
            return _mapper.Map<IEnumerable<PresenceResponse>>(entities);
        }

        public async Task<IEnumerable<PresenceResponse>> GetPresencesByDisciplineAndGroupAsync(GetPresenceByDisciplineAndGroupRequest request)
        {
            var entities = await _presenceRepository.GetPresencesByDisciplineAndGroupAsync(request.DisciplineId, request.GroupId);
            return _mapper.Map<IEnumerable<PresenceResponse>>(entities);
        }

        public async Task<bool> DeletePresenceByStudentAndDateAsync(DeletePresenceByStudentAndDateRequest request)
        {
            return await _presenceRepository.DeletePresenceByStudentAndDateAsync(request.StudentId, request.Date);
        }

        public async Task<bool> UpdatePresenceAsync(UpdatePresenceRequest request)
        {
            var entity = _mapper.Map<Presence>(request);
            return await _presenceRepository.UpdatePresenceAsync(entity);
        }
    }

}
