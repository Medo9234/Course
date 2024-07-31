using Demo1.Models;

namespace Demo1.BLL
{
    public class StudentMoc:IStudent
    {
        List<Student> students = new List<Student>()
        {
            new Student() {Id=1,Name="7ODa",Age=21,Degree=95, Department=new Department(){ Dept_Id=1,Dept_Name="IS"},Dept_Num=1}
        };

        public Student Add(Student student)
        {
            students.Add(student);
            return student;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public Student Get_By_Id(int id)
        {
            return students.FirstOrDefault(a => a.Id == id);
        }
    }
}
