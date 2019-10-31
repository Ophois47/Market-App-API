using System.Collections.Generic;
using System.Threading.Tasks;
using Market.API.Domain.Models;

namespace Market.API.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}