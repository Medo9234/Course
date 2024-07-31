using Demo1.Models;

namespace Demo1.BLL
{
    public interface IStudent
    {
        public List<Student> GetAll();
        public Student Get_By_Id(int id);
        public Student Add(Student student);
        public void Edit(Student student);
        public void Delete(int id);
    }
}
