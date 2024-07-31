using Demo1.Models;
using Demo1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    public class StudentController : Controller
    {

        public ViewResult Display()
        {
            Student Std = new Student() { Id = 1, Name = "7ODa", Age = 21, Degree = 92 };
            Department Dept = new Department() { Dept_Id = 1, Dept_Name = "IS" };

            StuDepViewModel stu_dept_model = new StuDepViewModel();
            stu_dept_model.Student= Std;
            stu_dept_model.Department= Dept;
            //ViewData["Fmane"] = "7ODa_Sa33d";
            string Name = "7ODa";
            ViewBag.Fname = Name;
            ViewBag.Id = 10;
            ViewBag.Degree = 85; 
            ViewData["Friends"] =new string[]{ "Ahmed", "Ali", "Abdo", "Ghada", "Sama" };
            ViewBag.std1=Std;
            //new ViewResult() {ViewData=ViewData};

            return View(stu_dept_model);
        }

        // Action
        // Student/Show
        public string Show(string Name , int Id)
        {
            return $"Hello MVC + { Name}:{ Id}";
        }
        // Action
        // Student/Add
        public int Add(int Age)
        {
            return Age+10;
        }
        
    }
}
