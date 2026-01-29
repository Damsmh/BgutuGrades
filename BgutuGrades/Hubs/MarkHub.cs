using AutoMapper;
using BgutuGrades.Models.Mark;
using BgutuGrades.Services;
using Microsoft.AspNetCore.SignalR;

namespace BgutuGrades.Hubs
{
    public class MarkHub(IMarkService markService, IMapper mapper) : Hub
    {
        private readonly IMapper _mapper = mapper;
        private readonly IMarkService _markService = markService;

        public async Task GetAll()
        {
            var marks = await _markService.GetAllMarksAsync();
            await Clients.Caller.SendAsync("Receive", marks);
        }

        public async Task Create(CreateMarkRequest request)
        {
            var mark = await _markService.CreateMarkAsync(request);
            await Clients.All.SendAsync("Created", mark);
        }

        public async Task GetByDidAndGid(GetMarksByDisciplineAndGroupRequest request)
        {
            var marks = await _markService.GetMarksByDisciplineAndGroupAsync(request);
            await Clients.Caller.SendAsync("Receive", marks);
        }

        public async Task Update(UpdateMarkRequest request)
        {
            var success = await _markService.UpdateMarkAsync(request);
            if (!success)
            {
                await Clients.Caller.SendAsync("NotFound", request.Id);
            }
            var response = _mapper.Map<MarkResponse>(request);
            await Clients.All.SendAsync("Updated", response);
        }

        public async Task Delete(DeleteMarkByStudentAndWorkRequest request)
        {
            var success = await _markService.DeleteMarkByStudentAndWorkAsync(request);
            if (!success)
            {
                await Clients.Caller.SendAsync("NotFound", request);
            }
            await Clients.All.SendAsync("Deleted");
        }
    }
}
