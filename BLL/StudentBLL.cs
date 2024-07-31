using Demo1.Data;
using Demo1.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo1.BLL
{
    public class StudentBLL:IStudent
    {
        //Repository Design Pattern
        SchoolDb db = new SchoolDb();
        public List<Student> GetAll()
        {
            return db.Students.Include(a => a.Department).ToList();
        }
        public Student Get_By_Id(int id)
        {
            return db.Students.Include(d => d.Department).SingleOrDefault(a => a.Id == id);
        }
        public Student Add(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return student;
        }
        //Update
        //Delete

        public void Edit(Student student)
        {
           //var s = Get_By_Id(student.Id);
           // s.Name= student.Name;

            db.Students.Update(student);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
           Student std = Get_By_Id(id);
            if (std != null)
            {
                db.Students.Remove(std);
                db.SaveChanges();
            }
        }
    }

}
