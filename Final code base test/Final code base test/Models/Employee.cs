

using System.ComponentModel.DataAnnotations;

namespace Final_code_base_test.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LasttName { get; set; }
        public string EmpDept { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        
    }
}
