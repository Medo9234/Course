using Demo1.Data;
using Demo1.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo1.BLL
{
    public class DepartmentBLL
    {
        SchoolDb dp=new SchoolDb();


        public List<Department> GetAll()
        {
            return dp.Departments.ToList();
        }

        public Department Get_By_Id(int id)
        {
            return dp.Departments.Include(d => d.Students).SingleOrDefault(a => a.Dept_Id == id);
        }

        public Department Add(Department department)
        {
            dp.Departments.Add(department);
            dp.SaveChanges();
            return department;
        }

        //Update
        //Delete

        public void Edit(Department dept)
        {
          
            dp.Departments.Update(dept);
            dp.SaveChanges();
        }
        public void Delete(int id)
        {
            Department depts = Get_By_Id(id);
            if (depts != null)
            {
                dp.Departments.Remove(depts);
                dp.SaveChanges();
            }
        }

    }
}
