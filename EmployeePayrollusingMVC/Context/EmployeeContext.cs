using EmployeePayrollusingMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeePayrollusingMVC.Context
{
    //Using code first approach
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {

        }
        //It will create ModelsEmployee tabel and it will have 13 columns,column names declare in employee model class
        public DbSet<EmployeeModel> ModelsEmployee { get; set; }
    }
}
