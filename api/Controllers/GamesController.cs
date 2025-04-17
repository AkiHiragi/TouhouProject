using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("/api/[controller]")]
public class GamesController : ControllerBase {
    private readonly AppDbContext _db;

    public GamesController(AppDbContext db) {
        _db = db;
    }

    /// <summary>
    /// Получает список всех игр
    /// </summary>
    /// <response code="200">Возвращает список игр</response>
    [HttpGet]
    [ProducesResponseType(typeof(List<Game>), 200)]
    public async Task<IActionResult> GetAllGames() {
        return Ok(await _db.Games.Include(g => g.Characters)
                                 .ToListAsync());
    }
}
