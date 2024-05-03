using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace Hotel.ATR.Portal
{
    public class WebAppContext : DbContext
    {
        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
        { }

        public DbSet<Message> Messages { get; set; }
    }
}
