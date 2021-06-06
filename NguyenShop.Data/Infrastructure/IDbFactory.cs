using System;

namespace NguyenShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        NguyenShopDbContext Init();
    }
}