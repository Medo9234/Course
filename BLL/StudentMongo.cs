using Demo1.Models;

namespace Demo1.BLL
{
    public class StudentMongo : IStudent
    {
        public Student Add(Student student)
        {
            throw new NotImplementedException();
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
            return new List<Student>();
            //throw new NotImplementedException();
        }

        public Student Get_By_Id(int id)
        {
            throw new NotImplementedException();
        }
    }
}
