using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/api/[controller]")]
public class GamesController : ControllerBase {
    private static readonly List<Game> Games = new() {
        new Game{Id=1,Title="Touhou 6: Embodiment of Scarlet Devil", ReleaseOrder=6, CoverImageUrl=""},
        new Game{Id=2,Title="Touhou 7: Perfect Cherry Blossom", ReleaseOrder=7, CoverImageUrl=""},
    };

    [HttpGet]
    public IActionResult GetAllGames() {
        return Ok(Games);
    }
}
