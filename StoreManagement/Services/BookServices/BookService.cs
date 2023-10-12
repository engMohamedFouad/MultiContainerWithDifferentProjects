using Newtonsoft.Json;
using StoreManagement.DTOs;
using StoreManagement.Enums;
using StoreManagement.Services.GeneralServices;

namespace StoreManagement.Services.BookServices
{
    public class BookService : IBookService
    {
        private readonly IBaseService _baseService;
        private readonly IConfiguration  _configuration;

        public BookService(IBaseService baseService,IConfiguration  configuration)
        {
            _baseService = baseService;
            _configuration=configuration;
        }

        public async Task<List<BookDTO>> GetBooks()
        {
            var RequestDTO = new RequestDTO();
            RequestDTO.apiMethods=ApiMethods.get;
            RequestDTO.URL=_configuration["ApiBaseUrl"]+ "WeatherForecast";
            var response = await _baseService.SendAsync(RequestDTO);
            return JsonConvert.DeserializeObject<List<BookDTO>>(response.Result.ToString());
        }
    }
}