using System.Collections.Generic;
using TYH.Domain.Entities;

namespace TYH.Data.Repositories
{
    public interface ICategoryRepository: IRepository<Category,int>
    {
        List<Category> GetByAlias(string alias);
    }
}
