using StoreManagement.DTOs;

namespace StoreManagement.Services.BookServices
{
    public interface IBookService
    {
        Task<List<BookDTO>> GetBooks();
    }
}