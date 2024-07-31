using Demo1.BLL;
using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo1.Controllers
{
    public class DepartmentController : Controller
    {
        StudentBLL studentBLL = new StudentBLL();
        DepartmentBLL departmentBLL = new DepartmentBLL();
        public IActionResult IndexDepartment ()
        {
            var departments = departmentBLL.GetAll();
            return View(departments);
        }

        

        public IActionResult CreateDepartment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDepartment (Department department)
        {
            if (ModelState.IsValid)
            {
                // Add code here to save the department to the database
                departmentBLL.Add(department);
                return RedirectToAction("IndexDepartment");
            }
            else
            {
                ViewBag.Depts = new SelectList(departmentBLL.GetAll(), "Dept_Id", "Dept_Name", "Dept_Description");

                return View(department);
            }
        }

     

        public IActionResult DetailsDepartment (int? id)
        {
            if (id == null)
                return BadRequest();
            var model = departmentBLL.Get_By_Id(id.Value);
            if (model == null)
                return NotFound();
            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            departmentBLL.Delete(id.Value);
            return RedirectToAction("IndexDepartment");
        }

        [HttpGet]
        public IActionResult UpdateDepartment (int? id)
        {
            if (id == null)
                return BadRequest();

            Department dept = departmentBLL.Get_By_Id(id.Value);

            if (dept == null)
                return NotFound();
            return View(dept);
        }

        [HttpPost]
        public IActionResult UpdateDepartment (Department dept)
        {
            
                departmentBLL.Edit(dept);
                return RedirectToAction("IndexDepartment");
           
        }
       


    }
}
