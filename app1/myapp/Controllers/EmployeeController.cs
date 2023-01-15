using Microsoft.AspNetCore.Mvc;
using myapp.Models;

namespace myapp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly DBTESTContext _dbContext;
//dependency injection
    public EmployeeController(DBTESTContext dbContext)
    {
        _dbContext=dbContext;
    }
   
    [HttpGet]
    [Route("GetEmployess")]
    public IActionResult Get()
    {
        List<Employee> list = _dbContext.Employees.ToList();
        return StatusCode(StatusCodes.Status200OK,list);
    }
}