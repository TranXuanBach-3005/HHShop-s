using HHShops.Model.Entities;

namespace HHShops.Application.Services.IServices
{
    public interface IErrorService
    {
        Task<Error> CreateAsync(Error error);
    }
}
