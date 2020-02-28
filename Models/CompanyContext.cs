using Microsoft.EntityFrameworkCore;

namespace newwebapi.Models
{

    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions options):base(options)
        {

        }
       public  DbSet<Company> CompanyNames {get;set;}

    }

}