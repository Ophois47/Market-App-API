using System.Collections.Generic;
using System.Threading.Tasks;
using Market.API.Domain.Models;

namespace Market.API.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}