using Microsoft.EntityFrameworkCore;

namespace CrudMVC.Models
{
    public class EmployeeContext:DbContext 
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {
                
        }
        public DbSet<EmployeeModel> Employees { get; set; }  
    }
}
