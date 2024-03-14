using Nest;
using WebApp.Services;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WebApp.Models
{
    public class RepoMessage : IRepoMessage
    {
        private readonly _DbContext dbContext;

        public RepoMessage(_DbContext context)
        {
            dbContext = context;
        }

        public async Task Add(MessageASP messageASP)
        {
            var MessageEntity = new MessageASP()
            {
                Email = messageASP.Email,
                Fullname = messageASP.Fullname,
                Company = messageASP.Company,
                Budget = messageASP.Budget,
                MessageText = messageASP.MessageText
            };

            await dbContext.AddAsync(MessageEntity);
            await dbContext.SaveChangesAsync();

        }

    }
}
