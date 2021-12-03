using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        public void Add(Category category)
        {
            using (var context = new Context())
            {
                context.Add(category);
                context.SaveChanges();
            }
        }

        public void Delete(Category category)
        {
            using (var context = new Context())
            {
                context.Remove(category);
                context.SaveChanges();
            }
        }

        public List<Category> GetAll()
        {
            using (var context = new Context())
            {
                return context.Categories.ToList();
            }
        }

        public Category GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Categories.SingleOrDefault(c => c.Id == id);
            }
        }

        public void Update(Category category)
        {
            using (var context = new Context())
            {
                context.Update(category);
                context.SaveChanges();
            }
        }
    }
}
