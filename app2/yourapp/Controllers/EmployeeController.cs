using Microsoft.AspNetCore.Mvc;
using yourapp.Models;

namespace yourapp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly DBTESTContext _dbContext;
    //depedency injection
    public EmployeeController(DBTESTContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    [Route("GetEmployees")]
    public IActionResult Get()
    {
        List<Employee> list = _dbContext.Employees.ToList();
        return StatusCode(StatusCodes.Status200OK,list);
    }
}
