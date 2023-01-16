using Microsoft.AspNetCore.Mvc;
using myapp.Models;
namespace myapp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayerController : ControllerBase
{
    private readonly DBTEST3Context _dbContext;

    public PlayerController(DBTEST3Context dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    [Route("GetPlayers")]
    public IActionResult Get()
    {
        List<Player> list = _dbContext.Players.ToList();
        return StatusCode(StatusCodes.Status200OK,list);
    }
}
