using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Graphql.models;
using HotChocolate;
using HotChocolate.Subscriptions;

namespace Graphql.Mutations{
    public class Mutation{
        public async Task<platform> AddtPlatforms([Service] AppDbContext context,platform s ,[Service] ITopicEventSender eventSender,CancellationToken token){
          await context.AddAsync(s);
          await context.SaveChangesAsync(token);
          await eventSender.SendAsync(nameof(subscription.onadd),s,token);

           return s;
        }
        /*    
            mutation{

                addtPlatforms(s: {
                id : 5
                name: "hi"
                licencekey:"aaa"
            })
            {
                id
                licencekey
            }
            
            }

            mutation{
                    addtPlatforms(s: {id : 7, name: "hi", licencekey:"aaa"})
                        {
                            id
                            licencekey
                        }
                }
        */
    }
}