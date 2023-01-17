using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myapp.Models;

namespace myapp.Controllers;

public class EmployeeController : Controller
{
    private readonly DBTESTContext _DBTESTContext;

    public EmployeeController(DBTESTContext DBTESTContext)
    {
        _DBTESTContext = DBTESTContext;
    }

    public IActionResult GetEmployees()
    {
        List<Employee> list = _DBTESTContext.Employees.ToList();
        ViewData["empdata"] = list;

        return View();
    }

[HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Employee employeeadd){
        _DBTESTContext.Employees.Add(employeeadd);
        _DBTESTContext.SaveChanges();

        return RedirectToAction("GetEmployees");
    }

    [HttpGet]
    public IActionResult Delete(Employee employeedel){
        _DBTESTContext.Employees.Remove(employeedel);
        _DBTESTContext.SaveChanges();
        return RedirectToAction("GetEmployees");
    }



    [HttpGet]
    public IActionResult Login(){
        return View();
    }
    
    [HttpPost]
    public IActionResult Login(Employee employeelog){
        List<Employee> list = _DBTESTContext.Employees.ToList();
        foreach(Employee item in list){
            if(item.Email == employeelog.Email && employeelog.Id == item.Id){  
                return RedirectToAction("GetEmployees");
            }
        }
        return RedirectToAction("Login");
    }

    [HttpGet]
    public IActionResult Edit(){
        return View();
    }
}
