using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bulkybook.Models;

namespace Bulkybook.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepositroy<Category>
    {
        void Update(Category category);
    }
}
