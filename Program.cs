using Entity4.SystemEntityCompletion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Entity4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //await EntityHasData.SetCompletionData();

            using (ApplicationContext context = new ApplicationContext())
            {
                var message = context.AddresSents.Include(t => t.Message)
                    .ThenInclude(t => t.Theme).Where(t => t.SenderId == 1 || t.RecipientId == 1).ToList();

                foreach(var list in message)
                {
                    Console.WriteLine(list.Message.MessageText);
                }
            }
        }
    }
}
