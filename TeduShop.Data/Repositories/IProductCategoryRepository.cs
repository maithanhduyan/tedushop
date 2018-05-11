using System.Collections.Generic;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    internal interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
}