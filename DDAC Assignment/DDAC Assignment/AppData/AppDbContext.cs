using DDAC_Assignment.Controllers;
using DDAC_Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace DDAC_Assignment.AppData
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        
    }
}
