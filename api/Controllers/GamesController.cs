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

    [HttpGet]
    public async Task<IActionResult> GetAllGames() {
        return Ok(await _db.Games.Include(g => g.Characters)
                                 .ToListAsync());
    }
}
