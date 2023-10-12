using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using weatherapi.Data;
using weatherapi.Models;

namespace weatherapi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly AppDbContext _appDbContext;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,AppDbContext appDbContext)
    {
        _logger = logger;
        _appDbContext=appDbContext;
    }

    [HttpGet(Name = "GetData")]
    public async Task<IEnumerable<Book>> Get()
    {
        return await _appDbContext.books.ToListAsync();
    }
}
