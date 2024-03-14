using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Models
{
	public interface IRepoMessage
	{
		public Task Add(MessageASP messageASP);
	}
}
