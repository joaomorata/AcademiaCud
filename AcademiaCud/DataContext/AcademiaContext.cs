using AcademiaCud.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademiaCud.DataContext
{
    public class AcademiaContext:DbContext
    {
        public AcademiaContext(DbContextOptions<AcademiaContext>options):base(options)
        {
            
        }

        public DbSet<instrutor> Instrutor { get; set; }
    }
}
