using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myapp.Models;

namespace myapp.Controllers;

public class StudentController : Controller
{
    private readonly MVC1Context _MVC1Context;

    public StudentController(MVC1Context MVC1Context)
    {
        _MVC1Context = MVC1Context;
    }
    public IActionResult GetStudents()
    {
        List<Student> list = _MVC1Context.Students.ToList();
        ViewData["allstuds"] = list;
        return View();
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Add(Student student)
    {
        _MVC1Context.Students.Add(student);
        _MVC1Context.SaveChanges();

        return RedirectToAction("GetStudents");
    }

    [HttpGet]
    public IActionResult Delete(Student studentdel){
        _MVC1Context.Students.Remove(studentdel);
        _MVC1Context.SaveChanges();
        return RedirectToAction("GetStudents");
    }
}