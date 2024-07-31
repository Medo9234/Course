using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo1.Models
{
    
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Dept_Id { get; set; }
        [Required,StringLength(20)]
        public string Dept_Name { get; set; }
        [Required, StringLength(100)]
        public string Dept_Description { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public Department() 
        {
            Students = new HashSet<Student>();
        }

        internal static object ReferenceEquals(int id)
        {
            throw new NotImplementedException();
        }
    }
}
