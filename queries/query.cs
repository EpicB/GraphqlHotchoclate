using System.Linq;
using Graphql.models;
using HotChocolate;

namespace Graphql.queries{
    public class Query{
        public IQueryable<platform> GetPlatforms([Service] AppDbContext context){
           
           return context.Platforms;
        }
    }
}