using System;

namespace DataAccess.Infrastructure
{
	public interface IDbFactory : IDisposable
	{
		HTShopDbContext Init();
	}
}
