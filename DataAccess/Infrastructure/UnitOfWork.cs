namespace DataAccess.Infrastructure
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly IDbFactory _dbFactory;
		private HTShopDbContext _dbContext;

		public UnitOfWork(IDbFactory dbFactory)
		{
			_dbFactory = dbFactory;
		}

		public HTShopDbContext DbContext
		{
			get { return _dbContext ?? (_dbContext = _dbFactory.Init()); }
		}

		public void Commit()
		{
			DbContext.SaveChanges();
		}
	}
}
