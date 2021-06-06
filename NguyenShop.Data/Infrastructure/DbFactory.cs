namespace NguyenShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private NguyenShopDbContext dbContext;

        public NguyenShopDbContext Init()
        {
            return dbContext ?? (dbContext = new NguyenShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}