using StoreManagement.DTOs;

namespace StoreManagement.Services.GeneralServices{

    public interface IBaseService{
        Task<ResponseDTO> SendAsync(RequestDTO request);
    }
}