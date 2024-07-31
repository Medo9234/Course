using Demo1.BLL;
using Demo1.Data;
using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Controllers
{
    public class StudentsController : Controller  //Dependent
    {
        IStudent studentBLL;// = new StudentBLL();   //Dependency
        DepartmentBLL departmentBLL = new DepartmentBLL();   //Dependency

        public StudentsController(IStudent _student)
        {
            studentBLL=_student;
        }
        public IActionResult Index()
        {
            
            var students = studentBLL.GetAll();
            return View(students);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return BadRequest();
            var model =studentBLL.Get_By_Id(id.Value);
            if (model == null)
                return NotFound();
            return View(model);
        }
        

        public IActionResult Create ()
        {
            var depts = departmentBLL.GetAll(); 
            ViewBag.Depts = new SelectList(depts, "Dept_Id" , "Dept_Name");
            return View("Create");  
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            
            if(ModelState.IsValid)
            {
               studentBLL.Add(std);
               return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Depts = new SelectList(departmentBLL.GetAll(), "Dept_Id", "Dept_Name");
                return View(std);
            }
            
           
           
        }
        public IActionResult Delete(int? id)
        {
            if(id == null)
                return BadRequest();
            studentBLL.Delete(id.Value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id==null)
                return BadRequest();
            Student std = studentBLL.Get_By_Id(id.Value);
            if(std == null)
                return NotFound();
            ViewBag.Dept_Num = new SelectList(departmentBLL.GetAll(), "Dept_Id", "Dept_Name",std.Dept_Num);

            return View(std);
        }
        [HttpPost]
        public IActionResult Update(Student std) //id
        {
            studentBLL.Edit(std);
            return RedirectToAction("Index");

        }

    }
}
