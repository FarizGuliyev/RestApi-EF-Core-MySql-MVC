using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudMVC.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeId { get; set; } 
        [Required(ErrorMessage ="This field is required!")]  
        [StringLength(50)]
        [DisplayName("Full Name")]
        public string FullName { get; set; }    
        [StringLength(10)]
        [DisplayName("Employee Code")]
        public string EmpCode { get; set; }
        [StringLength(100)]
        [DisplayName("Position")]
        public string Position { get; set; }
        [StringLength(100)]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }  
    }
}
