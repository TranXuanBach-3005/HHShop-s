using HHShops.Application.Services.IServices;
using HHShops.Application.Unitofworks;
using HHShops.Model.Entities;

namespace HHShops.Application.Services.Services
{
    public class ErrorService : IErrorService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ErrorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Error> CreateAsync(Error error)
        {
            return await _unitOfWork.ErrorRepository.CreateAsync(error);
        }
    }
}
