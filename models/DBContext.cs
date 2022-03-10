using Microsoft.EntityFrameworkCore;

namespace Graphql.models{
    public class AppDbContext:DbContext{
         public AppDbContext(DbContextOptions options):base(options){

         }
         public DbSet<platform> Platforms {get;set;}
    }
}