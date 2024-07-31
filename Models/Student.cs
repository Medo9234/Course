using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo1.Models
{
    // ef core mapping entities to tables
    // l2e queries
    //naming convension , data annotation , fluient api
    //relations
    //relation in db unidirection
    //relation in code : navigation properties , bidirection
    public class Student
    {
        
        public int Id { get; set; }


        [StringLength(20 , MinimumLength =3,ErrorMessage ="*"),Required]
        [Display(Name ="Full Name")]
        public string Name { get; set; }



        [Range(10,60)]
        public int Age { get; set; }



        [Range(10, 100)]
        public int Degree { get; set; }




        [RegularExpression(@"[a-zA-Z0-9]+@[a-zA-Z]+.[a-zA-Z]{2,6}",ErrorMessage ="Email does't match Pattern")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }



        [Required(ErrorMessage ="*"),StringLength(20,MinimumLength =6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Display(Name ="Confirm Password")]
        [Compare("Password")]
        [NotMapped]
        [DataType(DataType.Password)]
        public string CPassword { get; set; }



        [Display(Name = "Department")]
        [ForeignKey("Department")]
        public int Dept_Num { get; set; }



        public virtual Department Department { get; set; }
        
    }
}
