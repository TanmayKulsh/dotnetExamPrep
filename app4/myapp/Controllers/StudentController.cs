using myapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace myapp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{

    private readonly DBTEST4Context _dbcontext;

    public StudentController(DBTEST4Context dbcontext)
    {
        _dbcontext = dbcontext;
    }

    [HttpGet]
    [Route("GetStudents")]
    public IActionResult Get()
    {
        List<Student> list = _dbcontext.Students.ToList();
        return StatusCode(StatusCodes.Status200OK,list);
    }
}
