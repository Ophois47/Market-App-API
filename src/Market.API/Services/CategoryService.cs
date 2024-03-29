using System.Collections.Generic;
using System.Threading.Tasks;
using Market.API.Domain.Models;
using Market.API.Domain.Services;
using Market.API.Domain.Repositories;

namespace Market.API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        { 
            return await _categoryRepository.ListAsync();
        }
    }
}