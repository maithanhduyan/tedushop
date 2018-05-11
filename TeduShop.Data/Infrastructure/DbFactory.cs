namespace TeduShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TeduShopDbContext dbConText;

        public TeduShopDbContext Init()
        {
            return dbConText ?? (dbConText = new TeduShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbConText != null)
            {
                dbConText.Dispose();
            }
        }
    }
}