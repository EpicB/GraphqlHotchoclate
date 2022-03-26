using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;
using Graphql.models;
using HotChocolate;
using HotChocolate.Types;

namespace Graphql.Mutations{
    public class subscription{
        [Subscribe]
        [Topic]
      /* public  platform onadd([EventMessage] platform platform){
         
           return platform;
        }
        */
        public IQueryable <platform> onadd([EventMessage] platform platform,[Service] AppDbContext context){
         
           return context.Platforms;
        }

    }

}