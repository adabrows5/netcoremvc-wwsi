using Microsoft.EntityFrameworkCore;
using Z510.Models;

namespace Z510
{
    public class FilmContext : DbContext
    {
        public DbSet<FilmModel> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            var cs = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FilmDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            dbContextOptions.UseSqlServer(cs);

        }

    }
}
