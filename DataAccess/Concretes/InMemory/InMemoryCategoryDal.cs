using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public InMemoryCategoryDal()
        {
            
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete = _categories.SingleOrDefault(c => c.Id == category.Id);
            _categories.Remove(categoryToDelete);
            

        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>>? predicate = null, Func<IQueryable<Category>, IIncludableQueryable<Category, object>>? include = null, bool enableTracking = true)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        { // => lambda
            Category categoryToUpdate = _categories.SingleOrDefault(c => c.Id == category.Id);
            categoryToUpdate.Id = category.Id;
            categoryToUpdate.Name = category.Name;
           
        }

        List<Category> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
