using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TieredArchitecture.Business.Model;
using TieredArchitecture.Database;

namespace TieredArchitecture.Business.LocationRepository
{
    internal interface ICategory
    {
        void Create(CategoryModel category);
        CategoryModel Read(int Id);
        void Update(CategoryModel category);
        void Delete(int Id);
    }
}
