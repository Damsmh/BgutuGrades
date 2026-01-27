using BgutuGrades.Models.Transfer;

namespace BgutuGrades.Services
{
    public interface ITransferService
    {
        Task<IEnumerable<TransferResponse>> GetAllTransfersAsync();
        Task<TransferResponse> CreateTransferAsync(CreateTransferRequest request);
        Task<TransferResponse?> GetTransferByIdAsync(int id);
        Task<bool> UpdateTransferAsync(UpdateTransferRequest request);
        Task<bool> DeleteTransferAsync(int id);
    }
    public class TransferService : ITransferService
    {
        public Task<TransferResponse> CreateTransferAsync(CreateTransferRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTransferAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TransferResponse>> GetAllTransfersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TransferResponse?> GetTransferByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTransferAsync(UpdateTransferRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
