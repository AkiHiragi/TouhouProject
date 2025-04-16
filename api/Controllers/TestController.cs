using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase {

    [HttpGet]
    public IActionResult GetTestMessage() {
        return Ok(new { Message = "API работает! 🚀" });
    }
}
