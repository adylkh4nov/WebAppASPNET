using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApp.Models;

namespace WebApp.Services
{
	public class _DbContext :DbContext
	{
		private readonly IOptions<_DbContext> options;
		public _DbContext(DbContextOptions<_DbContext> options) : base(options)
		{
		}

		public DbSet<MessageASP> messages = null!;

		
	}
}
