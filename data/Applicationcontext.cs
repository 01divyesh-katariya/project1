using Microsoft.EntityFrameworkCore;
using project1.Models;


namespace project1.data
{
    public class Applicationcontext : DbContext
    {
        public Applicationcontext(DbContextOptions<Applicationcontext> option) : base(option)
        {

        }
        public DbSet<Employee> Employees
        {
            get; set;
        }
    }
}
